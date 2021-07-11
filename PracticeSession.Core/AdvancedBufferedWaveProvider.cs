using System;
using System.Collections.Generic;
using NAudio.Wave;
using PracticeSession.Core.Events;

namespace PracticeSession.Core
{
    /// <summary>
    /// Provides a buffered store of samples
    /// Read method will return queued samples or fill buffer with zeroes
    /// </summary>
    public class AdvancedBufferedWaveProvider : IWaveProvider
    {

        private Queue<AudioBuffer> _queue;
        private WaveFormat _waveFormat;

        /// <summary>
        /// Constructor - Creates a new buffered WaveProvider
        /// </summary>
        /// <param name="waveFormat">WaveFormat</param>
        public AdvancedBufferedWaveProvider(WaveFormat waveFormat)
        {
            _waveFormat = waveFormat;
            _queue = new Queue<AudioBuffer>();
            MaxQueuedBuffers = 100;
        }


        public event EventHandler PlayPositionChanged;


        /// <summary>
        /// Maximum number of queued buffers
        /// </summary>
        public int MaxQueuedBuffers { get; set; }

        /// <summary>
        /// Gets the WaveFormat
        /// </summary>
        public WaveFormat WaveFormat
        {
            get { return _waveFormat; }
        }

        /// <summary>
        /// Adds samples. Takes a copy of buffer, so that buffer can be reused if necessary
        /// </summary>
        public void AddSamples(byte[] buffer, int offset, int count, TimeSpan currentTime)
        {
            byte[] nBuffer = new byte[count];
            Buffer.BlockCopy(buffer, offset, nBuffer, 0, count);
            lock (_queue)
            {
                if (_queue.Count >= this.MaxQueuedBuffers)
                {
                    throw new InvalidOperationException("Too many queued buffers");
                }
                _queue.Enqueue(new AudioBuffer(nBuffer, currentTime));
            }
        }

        /// <summary>
        /// IWaveProvider.Read implementation - Reads from the next queued audioBuffer into the internal NAudio buffer
        /// Will always return count bytes, since we will zero-fill the buffer if not enough available
        /// </summary>
        public int Read(byte[] buffer, int offset, int count)
        {
            int read = 0;
            while (read < count)
            {
                int required = count - read;
                AudioBuffer audioBuffer = null;
                lock (_queue)
                {
                    if (_queue.Count > 0)
                    {
                        audioBuffer = _queue.Peek();
                    }
                }

                if (audioBuffer == null)
                {
                    // Return a zero filled buffer
                    for (int n = 0; n < required; n++)
                        buffer[offset + n] = 0;
                    read += required;
                }
                else // There is an audio buffer - let's play it
                {
                    int nRead = audioBuffer.Buffer.Length - audioBuffer.Position;

                    // Fire PlayPositionChanged event
                    if (PlayPositionChanged != null)
                    {
                        PlayPositionChanged(this, new BufferedPlayEventArgs(audioBuffer.CurrentTime));
                    }

                    // If this buffer must be read in it's entirety
                    if (nRead <= required)
                    {
                        // Read entire buffer
                        Buffer.BlockCopy(audioBuffer.Buffer, audioBuffer.Position, buffer, offset + read, nRead);
                        read += nRead;

                        lock (_queue)
                        {
                            if (_queue.Count > 0)
                            {
                                _queue.Dequeue();
                            }
                        }
                    }
                    else // the number of bytes that can be read is greater than that required
                    {
                        Buffer.BlockCopy(audioBuffer.Buffer, audioBuffer.Position, buffer, offset + read, required);
                        audioBuffer.Position += required;
                        read += required;
                    }
                }
            }
            return read;
        }

        /// <summary>
        /// Flushes the queue of any remaining audio buffers
        /// </summary>
        public void Flush()
        {
            lock (_queue)
            {
                _queue.Clear();
            }
        }

        /// <summary>
        /// Gets the current number of buffers in the queue
        /// </summary>
        public int GetQueueCount()
        {
            int queueCount = 0;
            lock (_queue)
            {
                queueCount = _queue.Count;
            }

            return queueCount;
        }
    }

    /// <summary>
    /// Internal helper class for a stored audio buffer
    /// </summary>
    internal class AudioBuffer
    {
        /// <summary>
        /// Constructs a new AudioBuffer
        /// </summary>
        public AudioBuffer(byte[] buffer, TimeSpan currentTime)
        {
            this.Buffer = buffer;
            this.CurrentTime = currentTime;
        }

        /// <summary>
        /// Gets the Buffer
        /// </summary>
        public byte[] Buffer { get; private set; }

        /// <summary>
        /// Gets or sets the position within the buffer we have read up to so far
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// CurrentTime of original file - used for calculating actual position within played buffer
        /// </summary>
        public TimeSpan CurrentTime { get; set; }
    }

}
