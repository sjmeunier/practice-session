using System;
using System.IO;
using System.Threading;
using PracticeSession.Core.Enums;
using PracticeSession.Core.Events;
using PracticeSession.Core.Interfaces;
using PracticeSession.SoundTouchSharp;
using BigMansStuff.NAudio.Ogg;
using Microsoft.Extensions.Logging;
using NAudio.Wave;
using PracticeSession.Core.Models;

namespace PracticeSession.Core.Services
{
    public class AudioPlaybackService : IAudioPlaybackService, IDisposable
    {
        #region variables

        private static ILogger _logger;
        private PlaybackStatus _playbackStatus = PlaybackStatus.None;
        private Thread _audioProcessingThread;
        private string _filename;
        private int _latency = 125; // msec

        private SoundTouchSharpWrapper _soundTouchSharp;
        private IWavePlayer _waveOutDevice;
        private AdvancedBufferedWaveProvider _inputProvider;

        private WaveStream _blockAlignedStream = null;
        private WaveStream _waveReader = null;
        private WaveChannel32 _waveChannel = null;

        private float _tempo = 1f;
        private float _pitch = 0f;
        private bool _loop;
        private float _volume;
        private volatile bool _volumeChanged = false;
        private float _eqLo;
        private float _eqMed;
        private float _eqHi;
        private InputChannelMode _inputChannelMode;
        private bool _swapLeftRightSpeakers;
        private volatile bool _eqParamsChanged;
        private EqualizerEffect _eqEffect;

        private TimeStretchProfile _timeStretchProfile;
        private volatile bool _timeStretchProfileChanged;

        private volatile bool _stopWorker = false;

        private TimeSpan _filePlayDuration;

        private TimeSpan _startMarker;
        private TimeSpan _endMarker;
        private TimeSpan _cue;
        private bool _suppressVocals;
        private TimeSpan _currentPlayTime;
        private TimeSpan _newPlayTime;
        private volatile bool _newPlayTimeRequested; // Double checked locking - http://www.cs.colorado.edu/~kena/classes/5828/s12/presentation-materials/goldbergdrew.pdf
        private volatile bool _tempoChanged = true;
        private volatile bool _pitchChanged = true;

        // Thread Locks
        private readonly object _currentPlayTimeLock = new object();
        private readonly object _newPlayTimeLock = new object();
        private readonly object _initializedLock = new object();
        private readonly object _firstPlayLock = new object();
        private readonly object _tempoLock = new object();
        private readonly object _loopLock = new object();
        private readonly object _propertiesLock = new object();
        #endregion

        #region Events

        public event EventHandler PlayTimeChanged;
        public event EventHandler<PlaybackStatusChangedEventArgs> PlaybackStatusChanged;
        public event EventHandler CueWaitPulsed;

        #endregion

        #region Properties

        /// <summary>
        /// Getter of the file play duration - the length of the file playing time
        /// </summary>
        public TimeSpan FilePlayDuration
        {
            get
            {
                return _filePlayDuration;
            }
        }

        /// <summary>
        /// Property for controlling the play back Tempo (Speed)
        /// Domain values - A non-negative floating number (normally 0.1 - 3.0)
        /// 1.0 = Regular speed
        /// greater than 1.0 = Faster (e.g. 2.0 runs two times faster)
        /// less than 1.0 = Slower (e.g. 0.5 runs two times slower)
        /// </summary>
        /// <remarks>
        /// To be used from the controlling component (i.e. the GUI)
        /// </remarks>
        public float Tempo
        {
            get { lock (_tempoLock) return _tempo; }
            set { lock (_tempoLock) { _tempo = value; _tempoChanged = true; } }
        }

        /// <summary>
        /// Property for controlling the play back Pitch
        /// Domain values - Semi-Tones (-12.0 to +12.0, -12 is one octave down/+12 is one octave up)
        /// 0.0 = Regular Pitch
        /// </summary>
        /// <remarks>
        /// To be used from the controlling component (i.e. the GUI)
        /// </remarks>
        public float Pitch
        {
            get { lock (_propertiesLock) return _pitch; }
            set { lock (_propertiesLock) { _pitch = value; _pitchChanged = true; } }
        }

        /// <summary>
        /// Play back Volume in percent - 0%..100%
        /// </summary>
        public float Volume
        {
            get
            {
                lock (_propertiesLock) { return _volume; }
            }
            set
            {
                lock (_propertiesLock)
                {
                    _volume = value;
                    _volumeChanged = true;
                }
            }
        }

        public float EqualizerLoBand
        {
            get
            {
                lock (_propertiesLock) { return _eqLo; }
            }
            set
            {
                lock (_propertiesLock)
                {
                    _eqLo = value;
                    _eqParamsChanged = true;
                }
            }
        }

        public float EqualizerMedBand
        {
            get
            {
                lock (_propertiesLock) { return _eqMed; }
            }
            set
            {
                lock (_propertiesLock)
                {
                    _eqMed = value;
                    _eqParamsChanged = true;
                }
            }
        }

        public float EqualizerHiBand
        {
            get
            {
                lock (_propertiesLock) { return _eqHi; }
            }
            set
            {
                lock (_propertiesLock)
                {
                    _eqHi = value;
                    _eqParamsChanged = true;
                }
            }
        }


        public InputChannelMode InputChannelMode
        {
            get
            {
                lock (_propertiesLock) { return _inputChannelMode; }
            }
            set
            {
                lock (_propertiesLock)
                {
                    _inputChannelMode = value;
                }
            }
        }

        /// <summary>
        /// Sets the Swap Speakers (Left<->Right) mode on or off
        /// </summary>
        public bool SwapLeftRightSpeakers
        {
            get
            {
                lock (_propertiesLock) { return _swapLeftRightSpeakers; }
            }
            set
            {
                lock (_propertiesLock)
                {
                    _swapLeftRightSpeakers = value;
                }
            }
        }


        public TimeStretchProfile TimeStretchProfile
        {
            get
            {
                lock (_propertiesLock) { return _timeStretchProfile; }
            }
            set
            {
                lock (_propertiesLock)
                {
                    _timeStretchProfile = value;
                    _timeStretchProfileChanged = true;
                }
            }
        }

        /// <summary>
        /// Current status
        /// </summary>
        public PlaybackStatus PlaybackStatus { get { return _playbackStatus; } }

        /// <summary>
        /// The current real play time - taking into account the tempo value
        /// </summary>
        public TimeSpan CurrentPlayTime
        {
            get
            {
                if (_inputProvider == null)
                    return TimeSpan.Zero;

                lock (_currentPlayTimeLock)
                {
                    return _currentPlayTime;
                }
            }
            set
            {
                TimeSpan newPlayTime = value;
                lock (_newPlayTimeLock)
                {
                    // Limit minimum and maximum
                    if (newPlayTime < TimeSpan.Zero)
                        newPlayTime = TimeSpan.Zero;
                    else if (newPlayTime > _filePlayDuration)
                        newPlayTime = _filePlayDuration;
                    _newPlayTimeRequested = true;
                    _newPlayTime = newPlayTime;
                }

                // For normal non-playing statuses update the current playing time immediately
                if (_playbackStatus == PlaybackStatus.Pausing || _playbackStatus == PlaybackStatus.Ready || _playbackStatus == PlaybackStatus.Stopped)
                {
                    lock (_currentPlayTimeLock)
                    {
                        _currentPlayTime = newPlayTime;
                    }
                }
            }
        }

        /// <summary>
        /// Boolean flag for playing the selected region (or whole file) in a loop
        ///     True - play on loop
        ///     False - play once and stop
        /// </summary>
        public bool Loop
        {
            get
            {
                lock (_loopLock)
                {
                    return _loop;
                }
            }
            set
            {
                lock (_loopLock)
                {
                    _loop = value;
                }
            }
        }

        public TimeSpan StartMarker
        {
            get
            {
                if (_inputProvider == null)
                    return TimeSpan.Zero;

                lock (_propertiesLock)
                {
                    return _startMarker;
                }
            }
            set
            {
                lock (_propertiesLock)
                {
                    _startMarker = value;
                }
            }
        }

        public TimeSpan EndMarker
        {
            get
            {
                if (_inputProvider == null)
                    return TimeSpan.Zero;

                lock (_propertiesLock)
                {
                    return _endMarker;
                }
            }
            set
            {
                lock (_propertiesLock)
                {
                    _endMarker = value;
                }
            }
        }

        public TimeSpan Cue
        {
            get
            {
                if (_inputProvider == null)
                    return TimeSpan.Zero;

                lock (_propertiesLock)
                {
                    return _cue;
                }
            }
            set
            {
                lock (_propertiesLock)
                {
                    _cue = value;
                }
            }
        }

        /// <summary>
        /// Supresses the vocals part of the song
        /// </summary>
        public bool SuppressVocals
        {
            get
            {
                lock (_propertiesLock) { return _suppressVocals; }
            }
            set
            {
                lock (_propertiesLock) { _suppressVocals = value; }
            }
        }

        #endregion

        public AudioPlaybackService(ILogger<AudioPlaybackService> logger)
        {
            _logger = logger;
            Initialize();
        }

        public void Initialize()
        {
            ChangePlaybackStatus(PlaybackStatus.Initializing);
            _startMarker = TimeSpan.Zero;
            _endMarker = TimeSpan.Zero;
            _cue = TimeSpan.Zero;
            _suppressVocals = false;
            _inputChannelMode = InputChannelMode.Both;
            _swapLeftRightSpeakers = false;

            InitializeSoundTouchSharp();
        }

        public void Stop()
        {
            // Already stopped? Nothing to do
            if (_playbackStatus == PlaybackStatus.Stopped)
                return;

            // Stop the audio processing thread
            _stopWorker = true;

            // Release lock, if current thread has not started playback
            lock (_firstPlayLock)
            {
                _logger.LogDebug("Stop: Pulse FirstPlayLock");
                Monitor.PulseAll(_firstPlayLock);
            }

            // Wait for audio thread to stop (Up to 2000 msec), if not just give up
            int counter = 100;
            while (_audioProcessingThread != null && counter > 0)
            {
                Thread.Sleep(20);
                counter--;
            }
        }

        public void Pause()
        {
            // Playback status changed to -> Pausing
            _waveOutDevice.Pause();
            Thread.Sleep(20); // Allow the audio to pause and settle
            ChangePlaybackStatus(PlaybackStatus.Pausing);
        }

        public void Play()
        {
            _logger.LogDebug($"Play - {_playbackStatus}");
            // Not playing now - Start the audio processing thread
            if (_playbackStatus == PlaybackStatus.Ready)
            {
                lock (_firstPlayLock)
                {
                    _logger.LogDebug("Monitor: Play(), Pulse FirstPlayLock");
                    Monitor.PulseAll(_firstPlayLock);
                }
            }
            else if (_playbackStatus == PlaybackStatus.Pausing)
            {
                if (_newPlayTimeRequested)
                {
                    // Flush existing buffers
                    _soundTouchSharp.Clear();
                    _waveChannel.Flush();
                    _inputProvider.Flush();
                }

                _waveOutDevice.Play();
                ChangePlaybackStatus(PlaybackStatus.Playing);
            }
        }

        public void ResetCurrentPlayTime()
        {
            // Reset current play time so it starts from the beginning
            CurrentPlayTime = StartMarker;

            // Signal the UI about the cue
            RaiseEventCueWaitPulsed();
        }

        public static bool IsAudioFile(string filename)
        {
            filename = filename.ToLower();
            bool result = filename.EndsWith(Constants.MP3Extension) ||
                          filename.EndsWith(Constants.M4AExtension) ||
                          filename.EndsWith(Constants.WAVExtension) ||
                          filename.EndsWith(Constants.OGGVExtension) ||
                          filename.EndsWith(Constants.AIFFExtension);

            return result;
        }

        public void LoadFile(string filename)
        {
            if (_audioProcessingThread != null)
            {
                Stop();
            }

            _filename = filename;
            _playbackStatus = PlaybackStatus.Loading;

            StartAudioThread(filename);

            // Wait for thread for finish initialization
            lock (_initializedLock)
            {
                if (!Monitor.Wait(_initializedLock, 5000))
                {
                    _logger.LogError("Initialization lock timeout");
                }
            }
        }

        private void StartAudioThread(string filename)
        {
            // Create the Audio Processing Worker (Thread)
            _audioProcessingThread = new Thread(new ThreadStart(AudioProcessingWorker_DoWork))
            {
                Name = "AudioProcessingThread-" + filename,
                IsBackground = true,
                Priority = ThreadPriority.Highest
            };
            // Important: MTA is needed for WMFSDK to function properly (for WMA support)
            // All WMA (COM) related actions MUST be done within the Thread's MTA otherwise there is a COM exception
            _audioProcessingThread.SetApartmentState(ApartmentState.MTA);

            // Allow initialization to start >>Inside<< the thread, the thread will stop and wait for a pulse
            _audioProcessingThread.Start();
        }

        /// <summary>
        /// Audio processing thread procedure
        /// </summary>
        private void AudioProcessingWorker_DoWork()
        {
            _stopWorker = false;
            try
            {
                // Initialize audio playback
                try
                {
                    InitializeFileAudio();

                    InitializeEqualizerEffect();

                    bool newPlayTimeRequested;
                    lock (_newPlayTimeLock)
                    {
                        newPlayTimeRequested = _newPlayTimeRequested;
                    }

                    lock (_currentPlayTimeLock)
                    {
                        // Special case handling for re-playing after last playing stopped in non-loop mode: 
                        //   Reset current play time to beginning of file in case the previous play has reached the end of file
                        if (!newPlayTimeRequested && _currentPlayTime >= _waveChannel.TotalTime)
                        {
                            _currentPlayTime = TimeSpan.Zero;
                        }
                    }

                    // Playback status changed to -> Initialized
                    ChangePlaybackStatus(PlaybackStatus.Ready);
                }
                finally
                {
                    // Pulse the initialized lock to release the client (UI) that is waiting for initialization to finish
                    lock (_initializedLock)
                    {
                        _logger.LogDebug("Monitor: Pulse InitializedLock");
                        Monitor.PulseAll(_initializedLock);
                    }
                }

                // Wait for first Play to pulse and free lock
                lock (_firstPlayLock)
                {
                    _logger.LogDebug("Monitor: Wait for FirstPlayLock");
                    Monitor.Wait(_firstPlayLock);
                }
                _logger.LogDebug("Monitor: FirstPlayLock got pulsed");

                // Safety guard - if thread never really started playing but PracticeSharpLogic was terminated ore started terminating
                if (_waveOutDevice == null || _playbackStatus == PlaybackStatus.Terminating || _playbackStatus == PlaybackStatus.Terminated)
                {
                    _logger.LogWarning("SHOULD NOT GET HERE - Terminated before play started");
                    return;
                }

                try
                {
                    if (_stopWorker)
                    {
                        _logger.LogDebug("Stopped before playing ever started");
                        return;
                    }

                    _logger.LogDebug("waveOutDevice.Play()");
                    // Command NAudio to start playing
                    _waveOutDevice.Play();
                    // Playback status changed to -> Playing
                    ChangePlaybackStatus(PlaybackStatus.Playing);

                    // ==============================================
                    // ====  Perform the actual audio processing ====
                    ProcessAudio();
                    // ==============================================
                }
                finally
                {
                    // Dispose of NAudio in context of thread (for WMF it must be disposed in the same thread)
                    TerminateNAudio();

                    _audioProcessingThread = null;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception in audioProcessingWorker_DoWork, ");
                ChangePlaybackStatus(PlaybackStatus.Error);
            }

        }

        /// <summary>
        /// The heart of audio processing:
        /// 1. Reads chunks of uncompressed samples from the input file
        /// 2. Processes the samples using SoundTouch 
        /// 3. Receive process samples from SoundTouch
        /// 4. Play the processed samples with NAudio
        /// 
        /// Also handles logic required for dynamically changing values on-the-fly of: Volume, Loop, Cue, Current Play Position.
        /// </summary>
        private void ProcessAudio()
        {
            _logger.LogDebug("ProcessAudio() started");

            #region Setup
            WaveFormat format = _waveChannel.WaveFormat;
            int bufferSecondLength = format.SampleRate * format.Channels;
            byte[] inputBuffer = new byte[Constants.BufferSamples * sizeof(float)];
            byte[] soundTouchOutBuffer = new byte[Constants.BufferSamples * sizeof(float)];

            ByteAndFloatsConverter convertInputBuffer = new ByteAndFloatsConverter { Bytes = inputBuffer };
            ByteAndFloatsConverter convertOutputBuffer = new ByteAndFloatsConverter { Bytes = soundTouchOutBuffer };
            uint outBufferSizeFloats = (uint)convertOutputBuffer.Bytes.Length / (uint)(sizeof(float) * format.Channels);

            int bytesRead;
            int floatsRead;
            uint samplesProcessed = 0;
            int bufferIndex = 0;
            TimeSpan actualEndMarker = TimeSpan.Zero;
            bool loop;

            #endregion

            bool isWaitForCue = (Cue.TotalSeconds > 0);

            while (!_stopWorker && _waveChannel.Position < _waveChannel.Length)
            {
                if (_volumeChanged) // Double checked locking
                {
                    lock (_propertiesLock)
                    {
                        if (_volumeChanged)
                        {
                            _waveChannel.Volume = _volume;
                            _volumeChanged = false;
                        }
                    }
                }

                TimeSpan newPlayTime = TimeSpan.MinValue;
                if (_newPlayTimeRequested) // Double checked locking
                {
                    lock (_newPlayTimeLock)
                    {
                        if (_newPlayTimeRequested)
                        {
                            _logger.LogDebug("newPlayTimeRequested: " + _newPlayTime);
                            if (_newPlayTime == _startMarker)
                            {
                                isWaitForCue = true;
                            }

                            newPlayTime = _newPlayTime;
                            _newPlayTimeRequested = false;
                        }
                    }
                }


                if (isWaitForCue)
                {
                    isWaitForCue = false;
                    WaitForCue();
                }

                if (newPlayTime != TimeSpan.MinValue)
                {
                    // Perform the change of play position outside of the lock() block, to avoid dead locks
                    _waveOutDevice.Pause();
                    _waveChannel.CurrentTime = newPlayTime;
                    _soundTouchSharp.Clear();
                    _waveChannel.Flush();
                    _inputProvider.Flush();
                    _waveOutDevice.Play();
                    continue;
                }

                // *** Read one chunk from input file ***
                bytesRead = _waveChannel.Read(convertInputBuffer.Bytes, 0, convertInputBuffer.Bytes.Length);
                // **************************************

                floatsRead = bytesRead / ((sizeof(float)) * format.Channels);

                ApplyDSPEffects(convertInputBuffer.Floats, floatsRead);

                // Double checked locking
                if (_timeStretchProfileChanged)
                {
                    lock (_propertiesLock)
                    {
                        if (_timeStretchProfileChanged)
                        {
                            ApplySoundTouchTimeStretchProfile();

                            _timeStretchProfileChanged = false;
                        }
                    }
                }

                actualEndMarker = this.EndMarker;
                loop = this.Loop;

                if (!loop || actualEndMarker == TimeSpan.Zero)
                    actualEndMarker = _waveChannel.TotalTime;

                if (_waveChannel.CurrentTime > actualEndMarker)
                {

                    // ** End marker reached **
                    // Now the input buffer is processed, 'flush' some last samples that are
                    // hiding in the SoundTouch's internal processing pipeline.
                    _soundTouchSharp.Clear();
                    _inputProvider.Flush();
                    _waveChannel.Flush();

                    if (!_stopWorker)
                    {
                        while (!_stopWorker && samplesProcessed != 0)
                        {
                            samplesProcessed = _soundTouchSharp.ReceiveSamples(convertOutputBuffer.Floats, outBufferSizeFloats);

                            if (samplesProcessed > 0)
                            {
                                TimeSpan currentBufferTime = _waveChannel.CurrentTime;
                                _inputProvider.AddSamples(convertOutputBuffer.Bytes, 0, (int)samplesProcessed * sizeof(float) * format.Channels, currentBufferTime);
                            }
                        }
                    }

                    loop = this.Loop;
                    if (loop)
                    {
                        _soundTouchSharp.Clear();
                        _waveChannel.Flush();
                        _waveChannel.CurrentTime = this.StartMarker;
                        isWaitForCue = (Cue.TotalSeconds > 0);
                        continue;
                    }
                    else
                    {
                        // Exit playback gracefully
                        break;
                    }

                }

                SetSoundSharpValues();

                // ***                    Put samples in SoundTouch                   ***
                _soundTouchSharp.PutSamples(convertInputBuffer.Floats, (uint)floatsRead);
                // **********************************************************************

                // Receive samples from SoundTouch
                do
                {
                    // ***                Receive samples back from SoundTouch            ***
                    // *** This is where Time Stretching and Pitch Changing are actually done *********
                    samplesProcessed = _soundTouchSharp.ReceiveSamples(convertOutputBuffer.Floats, outBufferSizeFloats);
                    // **********************************************************************

                    if (samplesProcessed > 0)
                    {
                        TimeSpan currentBufferTime = _waveChannel.CurrentTime;

                        // ** Play samples that came out of SoundTouch by adding them to AdvancedBufferedWaveProvider - the buffered player 
                        _inputProvider.AddSamples(convertOutputBuffer.Bytes, 0, (int)samplesProcessed * sizeof(float) * format.Channels, currentBufferTime);
                        // **********************************************************************

                        // Wait for queue to free up - only then add continue reading from the file
                        // >> Note: when paused, loop runs infinitely
                        while (!_stopWorker && _inputProvider.GetQueueCount() > Constants.BusyQueuedBuffersThreshold)
                        {
                            Thread.Sleep(10);
                        }
                        bufferIndex++;
                    }
                } while (!_stopWorker && samplesProcessed != 0);
            } // while


            _logger.LogDebug("ProcessAudio() finished - stop playback");
            _waveOutDevice.Stop();
            // Stop listening to PlayPositionChanged events
            _inputProvider.PlayPositionChanged -= new EventHandler(InputProvider_PlayPositionChanged);

            // Fix to current play time not finishing up at end marker (Wave channel uses positions)
            if (!_stopWorker && CurrentPlayTime < actualEndMarker)
            {
                lock (_currentPlayTimeLock)
                {
                    _currentPlayTime = actualEndMarker;
                }
            }

            // Clear left over buffers
            _soundTouchSharp.Clear();

            // Playback status changed to -> Stopped
            ChangePlaybackStatus(PlaybackStatus.Stopped);
        }


        /// <summary>
        /// Applies the DSP Effects in the effects chain
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="count"></param>
        private void ApplyDSPEffects(float[] buffer, int count)
        {
            int samples = count * 2;

            bool suppressVocals;
            // Apply Equalizer parameters (if they were changed)
            lock (_propertiesLock)
            {
                suppressVocals = _suppressVocals;

                if (_eqParamsChanged)
                {
                    _eqEffect.LoGainFactor.Value = _eqEffect.LoGainFactor.Maximum * _eqLo;
                    //m_eqEffect.LoDriveFactor.Value = (m_eqLo + 1.0f) / 2 * 100.0f;
                    _eqEffect.MedGainFactor.Value = _eqEffect.MedGainFactor.Maximum * _eqMed;
                    // m_eqEffect.MedDriveFactor.Value = (m_eqMed + 1.0f) / 2 * 100.0f;
                    _eqEffect.HiGainFactor.Value = _eqEffect.HiGainFactor.Maximum * _eqHi;
                    //m_eqEffect.HiDriveFactor.Value = (m_eqHi + 1.0f) / 2 * 100.0f;

                    _eqEffect.OnFactorChanges();

                    _eqParamsChanged = false;
                }

            }

            // Run each sample in the buffer through the equalizer effect
            for (int sample = 0; sample < samples; sample += 2)
            {
                // Get the samples, per audio channel
                float sampleLeft = buffer[sample];
                float sampleRight = buffer[sample + 1];

                // Apply the equalizer effect to the samples
                _eqEffect.Sample(ref sampleLeft, ref sampleRight);

                if (suppressVocals)
                {
                    // Suppression of vocals assumes vocals are recorded in the 'Center'
                    // The suppression results in two mono channels (instead of the original Stereo)
                    float suppressedVocalChannel = (sampleLeft - sampleRight) * 0.7f;
                    sampleLeft = suppressedVocalChannel;
                    sampleRight = suppressedVocalChannel;
                }

                // Put the modified samples back into the buffer, with input channel selection mode
                float finalRightSample;
                float finalLeftSample;
                if (_inputChannelMode == InputChannelMode.DualMono)
                {
                    finalRightSample = (sampleRight + sampleLeft) * 0.7f;
                    finalLeftSample = finalRightSample;
                }
                else
                {
                    finalRightSample = _inputChannelMode == InputChannelMode.Right ? sampleRight : sampleLeft;
                    finalLeftSample = _inputChannelMode == InputChannelMode.Left ? sampleLeft : sampleRight;
                }

                if (_swapLeftRightSpeakers)
                {
                    var temp = finalRightSample;
                    finalRightSample = finalLeftSample;
                    finalLeftSample = temp;
                }

                buffer[sample] = finalRightSample;
                buffer[sample + 1] = finalLeftSample;
            }
        }

        /// <summary>
        /// Waits for the loop cue - basically waits a few seconds before the loop starts again, this allows the musician to rest a bit and prepare
        /// </summary>
        private void WaitForCue()
        {
            TimeSpan cue = this.Cue;
            if (cue.TotalSeconds > 0)
            {
                // Wait Cue - 1 seconds in a slow pulse (one per second) busy-loop
                int pulseCount = 0;
                while (!_stopWorker && pulseCount < cue.TotalSeconds - 1)
                {
                    RaiseEventCueWaitPulsed();

                    Thread.Sleep(1000);
                    pulseCount++;
                }

                // Wait 1 seconds in a fast pulse (4 per second) busy-loop
                pulseCount = 0;
                while (!_stopWorker && pulseCount < 4)
                {
                    RaiseEventCueWaitPulsed();

                    Thread.Sleep(250);
                    pulseCount++;
                }
            }
        }

        /// <summary>
        /// Raises the CueWaitPulsed event in an asynchronous way
        /// </summary>
        private void RaiseEventCueWaitPulsed()
        {
            if (CueWaitPulsed != null)
            {
                CueWaitPulsed(this, EventArgs.Empty);
            }
        }

        private void ChangePlaybackStatus(PlaybackStatus status)
        {
            _playbackStatus = status;

            // Raise StatusChanged Event
            if (PlaybackStatusChanged != null)
            {
                PlaybackStatusChanged(this, new PlaybackStatusChangedEventArgs(status));
            }
        }

        private void InitializeFileAudio()
        {
            InitializeNAudioLibrary();

            CreateSoundTouchInputProvider(_filename);

            try
            {
                _waveOutDevice.Init(_inputProvider);
            }
            catch (Exception initException)
            {
                _logger.LogError(initException, "Exception in InitializeFileAudio - _waveOutDevice.Init");

                throw;
            }

            _filePlayDuration = _waveChannel.TotalTime;
        }

        /// <summary>
        /// Creates an input WaveChannel (Audio file reader for MP3/WAV/OGG/FLAC/WMA/AIFF/Other formats in the future)
        /// </summary>
        /// <param name="filename"></param>
        private void CreateInputWaveChannel(string filename)
        {
            string fileExt = Path.GetExtension(filename.ToLower());
            if (fileExt == Constants.MP3Extension)
            {
                _waveReader = new Mp3FileReader(filename);
                _blockAlignedStream = new BlockAlignReductionStream(_waveReader);
                // Wave channel - reads from file and returns raw wave blocks
                _waveChannel = new WaveChannel32(_blockAlignedStream);
            }
            else if (fileExt == Constants.M4AExtension)
            {
                _waveReader = new MediaFoundationReader(filename);
                _blockAlignedStream = new BlockAlignReductionStream(_waveReader);
                // Wave channel - reads from file and returns raw wave blocks
                _waveChannel = new WaveChannel32(_blockAlignedStream);
            }
            else if (fileExt == Constants.WAVExtension)
            {
                _waveReader = new WaveFileReader(filename);
                if (_waveReader.WaveFormat.Encoding != WaveFormatEncoding.Pcm)
                {
                    _waveReader = WaveFormatConversionStream.CreatePcmStream(_waveReader);
                    _waveReader = new BlockAlignReductionStream(_waveReader);
                }
                if (_waveReader.WaveFormat.BitsPerSample != 16)
                {
                    var format = new WaveFormat(_waveReader.WaveFormat.SampleRate,
                       16, _waveReader.WaveFormat.Channels);
                    _waveReader = new WaveFormatConversionStream(format, _waveReader);
                }

                _waveChannel = new WaveChannel32(_waveReader);
            }
            else if (fileExt == Constants.OGGVExtension)
            {
                _waveReader = new OggVorbisFileReader(filename);
                if (_waveReader.WaveFormat.Encoding != WaveFormatEncoding.Pcm)
                {
                    _waveReader = WaveFormatConversionStream.CreatePcmStream(_waveReader);
                    _waveReader = new BlockAlignReductionStream(_waveReader);
                }
                if (_waveReader.WaveFormat.BitsPerSample != 16)
                {
                    var format = new WaveFormat(_waveReader.WaveFormat.SampleRate,
                       16, _waveReader.WaveFormat.Channels);
                    _waveReader = new WaveFormatConversionStream(format, _waveReader);
                }

                _waveChannel = new WaveChannel32(_waveReader);
            }
            else if (fileExt == Constants.AIFFExtension)
            {
                _waveReader = new AiffFileReader(filename);
                _waveChannel = new WaveChannel32(_waveReader);
            }
            else
            {
                throw new ApplicationException("Cannot create Input WaveChannel - Unknown file type: " + fileExt);
            }
        }

        /// <summary>
        /// Creates input provider needed for reading an audio file into the SoundTouch library
        /// </summary>
        /// <param name="filename"></param>
        private void CreateSoundTouchInputProvider(string filename)
        {
            CreateInputWaveChannel(filename);

            WaveFormat format = _waveChannel.WaveFormat;
            _inputProvider = new AdvancedBufferedWaveProvider(format);
            _inputProvider.PlayPositionChanged += new EventHandler(InputProvider_PlayPositionChanged);
            _inputProvider.MaxQueuedBuffers = 100;

            _soundTouchSharp.SetSampleRate(format.SampleRate);
            _soundTouchSharp.SetChannels(format.Channels);

            _soundTouchSharp.SetTempoChange(0);
            _soundTouchSharp.SetPitchSemiTones(0);
            _soundTouchSharp.SetRateChange(0);

            _soundTouchSharp.SetTempo(_tempo);

            // Apply default SoundTouch settings
            _soundTouchSharp.SetSetting(SoundTouchSettings.SETTING_USE_QUICKSEEK, 0);

            ApplySoundTouchTimeStretchProfile();
        }

        private void ApplySoundTouchTimeStretchProfile()
        {
            // "Disable" sound touch AA and revert to Automatic settings at regular tempo (to remove side effects)
            if (Math.Abs(_tempo - 1) < 0.001)
            {
                _soundTouchSharp.SetSetting(SoundTouchSettings.SETTING_USE_AA_FILTER, 0);
                _soundTouchSharp.SetSetting(SoundTouchSettings.SETTING_AA_FILTER_LENGTH, 0);
                _soundTouchSharp.SetSetting(SoundTouchSettings.SETTING_OVERLAP_MS, 0);
                _soundTouchSharp.SetSetting(SoundTouchSettings.SETTING_SEQUENCE_MS, 0);
                _soundTouchSharp.SetSetting(SoundTouchSettings.SETTING_SEEKWINDOW_MS, 0);
            }
            else
            {
                _soundTouchSharp.SetSetting(SoundTouchSettings.SETTING_USE_AA_FILTER, _timeStretchProfile.UseAAFilter ? 1 : 0);
                _soundTouchSharp.SetSetting(SoundTouchSettings.SETTING_AA_FILTER_LENGTH, _timeStretchProfile.AAFilterLength);
                _soundTouchSharp.SetSetting(SoundTouchSettings.SETTING_OVERLAP_MS, _timeStretchProfile.Overlap);
                _soundTouchSharp.SetSetting(SoundTouchSettings.SETTING_SEQUENCE_MS, _timeStretchProfile.Sequence);
                _soundTouchSharp.SetSetting(SoundTouchSettings.SETTING_SEEKWINDOW_MS, _timeStretchProfile.SeekWindow);
            }
        }

        /// <summary>
        /// Sets the SoundSharp values - tempo & pitch
        /// </summary>
        /// <param name="tempo"></param>
        /// <param name="pitch"></param>
        private void SetSoundSharpValues()
        {
            if (_tempoChanged)
            {
                lock (_propertiesLock)
                {
                    if (_tempoChanged) // Double Check Locking
                    {
                        float tempo = this.Tempo;
                        // Assign updated tempo
                        _soundTouchSharp.SetTempo(tempo);
                        _tempoChanged = false;

                        ApplySoundTouchTimeStretchProfile();
                    }
                }
            }

            if (_pitchChanged)
            {
                lock (_propertiesLock)
                {
                    if (_pitchChanged) // Double Check Locking
                    {
                        float pitch = this.Pitch;
                        // Assign updated pitch
                        // m_soundTouchSharp.SetPitchOctaves(pitch);
                        _soundTouchSharp.SetPitchSemiTones(pitch);
                        _pitchChanged = false;
                    }
                }
            }
        }

        /// <summary>
        /// NAudio Event handler - Fired every time the play position has changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputProvider_PlayPositionChanged(object sender, EventArgs e)
        {
            lock (_currentPlayTimeLock)
            {
                _currentPlayTime = (e as BufferedPlayEventArgs).PlayTime;
            }

            RaiseEventPlayTimeChanged();
        }

        /// <summary>
        /// Raises the PlayTimeChanged event in an asynchronous way
        /// </summary>
        private void RaiseEventPlayTimeChanged()
        {
            if (PlayTimeChanged != null)
            {
                PlayTimeChanged(this, new EventArgs());
            }
        }

        void WaveOutDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (e == null || e.Exception == null)
                return;

            _logger.LogError(e.Exception, "waveOutDevice_PlaybackStopped");
        }

        /// <summary>
        /// Initialize the sound touch library (using the SoundTouchSharp wrapper)
        /// </summary>
        private void InitializeSoundTouchSharp()
        {
            _soundTouchSharp = new SoundTouchSharpWrapper();
            _soundTouchSharp.CreateInstance();
            _logger.LogInformation($"SoundTouch Initialized - Version: {_soundTouchSharp.SoundTouchVersionId}, {_soundTouchSharp.SoundTouchVersionString}");
        }

        /// <summary>
        /// Initialize the Equalizer DSP Effect
        /// </summary>
        private void InitializeEqualizerEffect()
        {
            // Initialize Equalizer
            _eqEffect = new EqualizerEffect
            {
                SampleRate = _waveChannel.WaveFormat.SampleRate
            };

            _eqEffect.LoDriveFactor.Value = 75;
            _eqEffect.LoGainFactor.Value = 0;
            _eqEffect.MedDriveFactor.Value = 40;
            _eqEffect.MedGainFactor.Value = 0;
            _eqEffect.HiDriveFactor.Value = 30;
            _eqEffect.HiGainFactor.Value = 0;
            _eqEffect.Init();
            _eqEffect.OnFactorChanges();
        }

        /// <summary>
        /// Initialize the NAudio framework
        /// </summary>
        private void InitializeNAudioLibrary()
        {
            try
            {

                _logger.LogInformation("OS Info: " + Environment.OSVersion.ToString());

                // string soundOutput = "WasapiOut";
                string soundOutput = "WaveOut";

                // Set the wave output device based on the configuration setting
                switch (soundOutput)
                {
                    case "WasapiOut":
                        _waveOutDevice = new WasapiOut(global::NAudio.CoreAudioApi.AudioClientShareMode.Shared, _latency);
                        break;

                    case "DirectSound":
                        _waveOutDevice = new DirectSoundOut(_latency);
                        break;

                    default:
                    case "WaveOut":
                        _waveOutDevice = new WaveOut();
                        break;
                }

                _waveOutDevice.PlaybackStopped += WaveOutDevice_PlaybackStopped;
                _logger.LogInformation("Wave Output Device that is actually being used: {0}", _waveOutDevice.GetType().ToString());
            }
            catch (Exception driverCreateException)
            {
                _logger.LogError(driverCreateException, "NAudio Driver Creation Failed");
                throw;
            }
        }

        /// <summary>
        /// Disposes of the current allocated resources
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "m_waveReader"),
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "m_blockAlignedStream"),
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "m_waveChannel"),
        System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "m_waveOutDevice")]
        public void Dispose()
        {
            if (_playbackStatus != PlaybackStatus.Terminated)
            {
                Terminate();
            }

            GC.SuppressFinalize(this);
        }


        /// <summary>
        /// Terminates all current play back and resources
        /// </summary>
        public void Terminate()
        {
            ChangePlaybackStatus(PlaybackStatus.Terminating);

            Stop();

            // Dispose of SoundTouchSharp
            TerminateSoundTouchSharp();

            ChangePlaybackStatus(PlaybackStatus.Terminated);
        }

        /// <summary>
        /// Terminates the NAudio library resources and connection
        /// </summary>
        private void TerminateNAudio()
        {
            if (_inputProvider != null)
            {
                if (_inputProvider is IDisposable)
                {
                    (_inputProvider as IDisposable).Dispose();
                }
                _inputProvider = null;
            }

            if (_waveChannel != null)
            {
                _waveChannel.Dispose();
                _waveChannel = null;
            }

            if (_blockAlignedStream != null)
            {
                _blockAlignedStream.Dispose();
                _blockAlignedStream = null;
            }

            if (_waveReader != null)
            {
                _waveReader.Dispose();
                _waveReader = null;
            }

            if (_waveOutDevice != null)
            {
                _waveOutDevice.Dispose();
                _waveOutDevice = null;
            }

            _logger.LogDebug("NAudio terminated");
        }

        /// <summary>
        /// Terminates the SoundTouch resources and connection
        /// </summary>
        private void TerminateSoundTouchSharp()
        {
            if (_soundTouchSharp != null)
            {
                _soundTouchSharp.Clear();
                _soundTouchSharp.Dispose();
                _soundTouchSharp = null;
                _logger.LogDebug("SoundTouch terminated");
            }
        }
    }
}
