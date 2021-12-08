using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using PracticeSession.Core;
using PracticeSession.Core.Enums;
using PracticeSession.Core.Events;
using PracticeSession.Core.Interfaces;
using PracticeSession.Properties;
using Microsoft.Extensions.Logging;
using PracticeSession.Core.Models;

namespace PracticeSession
{
    public partial class MainForm : Form
    {
        private readonly int _markerWidth = 5;
        private readonly int _markerHeight = 10;
        private string _currentFilename = "";

        private readonly int _maxRecentDisplayLength = 60;

        // msec
        private readonly int _maskOutInterval = 450;

        private readonly int _jumpSeconds = 2;

        // 96 ticks are 12 semitones => each 8 ticks is one semitone
        private readonly int _ticksPerSemitone = 8;

        private readonly IAudioPlaybackService _audioPlaybackService;
        private readonly ILogger _logger;
        private string _appDataFolder;
        private object _timerLock = new object();
        private bool _isUpdatePlayTimeNeeded;

        private bool _ignorePlayTimeUIEvents = false;
        private bool _playTimeTrackBarIsChanging = false;
        private bool _jumpMode = false;
        private DateTime _playTimeTrackBarMaskOutTime = DateTime.Now;
        private DateTime _currentControlsMaskOutTime = DateTime.Now;

        private MostRecentlyUsedList _recentFilesList;
        private readonly List<ToolStripMenuItem> _recentFilesMenuItems = new List<ToolStripMenuItem>();

        public MainForm(ILogger<MainForm> logger, IAudioPlaybackService audioPlaybackService)
        {
            _logger = logger;
            _audioPlaybackService = audioPlaybackService;
            InitializeComponent();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void menuItemFile_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "menuItemExit":
                    Application.Exit();
                    break;
            }
            
        }

        private void menuItemFile_DropDownOpening(object sender, EventArgs e)
        {
            List<string> mruItems = _recentFilesList.Items;

            for (int menuItemIndex = 0; menuItemIndex < _recentFilesMenuItems.Count; menuItemIndex++)
            {
                ToolStripMenuItem menuItem = _recentFilesMenuItems[menuItemIndex];

                menuItem.Visible = menuItemIndex < mruItems.Count;
                if (menuItemIndex < mruItems.Count)
                {
                    string recentFilename = mruItems[menuItemIndex];
                    menuItem.Visible = true;
                    int rightIndex = 0;
                    string recentFilenameDisplay = string.Empty;
                    if (recentFilename.Length > _maxRecentDisplayLength)
                    {
                        rightIndex = recentFilename.Length - _maxRecentDisplayLength;
                        recentFilenameDisplay = recentFilename.Substring(0, 3) + " ... " + recentFilename.Substring(rightIndex, _maxRecentDisplayLength);
                    }
                    else
                    {
                        recentFilenameDisplay = recentFilename;
                    }

                    menuItem.Text = recentFilenameDisplay;
                    menuItem.Tag = recentFilename;

                    // Disable current file in recent MRU items - its already open
                    if (recentFilename == _currentFilename)
                    {
                        menuItem.Enabled = false;
                    }
                    else
                    {
                        menuItem.Enabled = true;
                    }
                }
                else
                {
                    menuItem.Visible = false;
                }

            }
        }

        private void ShowFileDialog()
        {
            var pausedPlaying = false;
            if (_audioPlaybackService.PlaybackStatus == PlaybackStatus.Playing)
            {
                pausedPlaying = true;
                _audioPlaybackService.Pause();
            }
            try
            {
                // Show the open file dialog
                openFileDialog.InitialDirectory = Properties.Settings.Default.LastOpenedFolder;
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    pausedPlaying = false;

                    var fileInfo = new FileInfo(openFileDialog.FileName);
                    Properties.Settings.Default.LastOpenedFolder = fileInfo?.Directory?.FullName;
                    Properties.Settings.Default.LastFilterIndex = openFileDialog.FilterIndex;
                    Properties.Settings.Default.Save();

                    OpenFile(openFileDialog.FileName, true);
                }
            }
            finally
            {
                if (pausedPlaying)
                {
                    _audioPlaybackService.Play();
                }
            }
        }

        private void PlayButtonPressed()
        {
            if (_audioPlaybackService.PlaybackStatus == PlaybackStatus.Playing)
            {
                buttonPlay.Image = Resources.Play;
                _audioPlaybackService.Pause();
            }
            else if ((_audioPlaybackService.PlaybackStatus == PlaybackStatus.Pausing) ||
                     (_audioPlaybackService.PlaybackStatus == PlaybackStatus.Ready))
            {
                buttonPlay.Image = Resources.Pause;

                // Mask the track bar & current controls updates - to remove jumps due to old play time positions
                TempMaskOutPlayTimeTrackBar();
                TempMaskOutCurrentControls();

                _audioPlaybackService.Play();
            }
            else if (_audioPlaybackService.PlaybackStatus == PlaybackStatus.Stopped)
            {
                // Playing has stopped, need to reload the file
                if (trackBarPlayTime.Value == trackBarPlayTime.Maximum)
                    trackBarPlayTime.Value = trackBarPlayTime.Minimum;

                buttonPlay.Image = Resources.Play;
                OpenFile(_currentFilename, false);
                _audioPlaybackService.Play();
            }
        }
        private bool OpenFile(string filename, bool autoPlay)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (!File.Exists(filename))
                {
                    MessageBox.Show($"Could not find file {filename}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _audioPlaybackService.Stop();

                _recentFilesList.Add(filename);
                _currentFilename = filename;

                Properties.Settings.Default.LastUsedFilename = filename;
                Properties.Settings.Default.Save();
                labelFilename.Text = Path.GetFileName(filename);
                _audioPlaybackService.LoadFile(filename);

                ToggleControls(true);

                labelPlayDuration.Text =
                    $"{_audioPlaybackService.FilePlayDuration.Minutes:00}:{_audioPlaybackService.FilePlayDuration.Seconds:00)}";
                labelPlayDuration1Q.Text =
                    $"{(_audioPlaybackService.FilePlayDuration.TotalSeconds / 4 / 60):00}:{(_audioPlaybackService.FilePlayDuration.Seconds / 4):00}";
                labelPlayDuration2Q.Text =
                    $"{(_audioPlaybackService.FilePlayDuration.Minutes / 2):00}:{(_audioPlaybackService.FilePlayDuration.Seconds / 2):00}";
                labelPlayDuration3Q.Text =
                    $"{(_audioPlaybackService.FilePlayDuration.TotalSeconds * 3 / 4 / 60):00}:{(_audioPlaybackService.FilePlayDuration.Seconds * 3 / 4):00}";

                if (autoPlay)
                {
                    buttonPlay.Image = Properties.Resources.Pause;
                    _audioPlaybackService.Play();
                }
            }
            finally
            {
                //playTimeUpdateTimer.Enabled = true;
                Cursor.Current = Cursors.Default;
            }

            return true;
        }

        private void ToggleControls(bool enable)
        {
            buttonPlay.Enabled = enable;
            trackBarPlayTime.Enabled = enable;
            trackBarPitch.Enabled = enable;
            trackBarVolume.Enabled = enable;
            trackBarEQLow.Enabled = enable;
            trackBarEQMid.Enabled = enable;
            trackBarEQHi.Enabled = enable;
            upDownCue.Enabled = enable;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.Name = "MainFormThread";

            InitializeApplicationFolders();

            _logger.LogInformation("Application started");

            try
            {
                InitializeApplication();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed initialize the audio playback service - {ex}");
            }

            AutoLoadLastFile();


        }
        private void InitializeApplication()
        {
            // Set process priority to high - to minimize playback hiccups
            Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.High;

            InitializeMRUFiles();

            _audioPlaybackService.PlaybackStatusChanged += new EventHandler<PlaybackStatusChangedEventArgs>(AudioPlaybackService_StatusChanged);
            _audioPlaybackService.PlayTimeChanged += new EventHandler(AudioPlaybackService_PlayTimeChanged);

            ToggleControls(false);

            openFileDialog.InitialDirectory = Properties.Settings.Default.LastOpenedFolder;
            openFileDialog.FilterIndex = Properties.Settings.Default.LastFilterIndex;

            buttonPlay.Image = Resources.Play;
            buttonChannelBoth.Checked = true;
            _audioPlaybackService.InputChannelMode = InputChannelMode.Both;

            //cueComboBox.SelectedIndex = 0;

            // Set defaults
            trackBarTempo_ValueChanged(this, new EventArgs());
            trackBarPitch_ValueChanged(this, new EventArgs());
            trackBarVolume_ValueChanged(this, new EventArgs());
            trackBarPlayTime_ValueChanged(this, new EventArgs());

            InitializeTimeStretchProfiles();
        }
        private void AudioPlaybackService_StatusChanged(object sender, PlaybackStatusChangedEventArgs e)
        {
            if (_jumpMode || _audioPlaybackService == null || _audioPlaybackService.PlaybackStatus == PlaybackStatus.Terminating || _audioPlaybackService.PlaybackStatus == PlaybackStatus.Terminated)
                return;

            this.BeginInvoke(new MethodInvoker(delegate ()
            {
                if (_audioPlaybackService == null || _audioPlaybackService.PlaybackStatus == PlaybackStatus.Terminating || _audioPlaybackService.PlaybackStatus == PlaybackStatus.Terminated)
                    return;

                //appStatusLabel.Text = e.PlaybackStatus.ToString();

                if ((e.PlaybackStatus == PlaybackStatus.Stopped)
                   || (e.PlaybackStatus == PlaybackStatus.Pausing)
                   || (e.PlaybackStatus == PlaybackStatus.Error))
                {
                    buttonPlay.Image = Resources.Play;
                    PlayTimeUpdateTimer.Enabled = false;

                    // Force a last refresh of play time controls
                    UpdateCurrentPlaytime(_audioPlaybackService.CurrentPlayTime, _audioPlaybackService.FilePlayDuration);
                    int currentPlayTimeValue = 0;
                    if (_audioPlaybackService.FilePlayDuration.TotalSeconds > 0)
                    {
                        currentPlayTimeValue = Convert.ToInt32(100.0f * _audioPlaybackService.CurrentPlayTime.TotalSeconds / _audioPlaybackService.FilePlayDuration.TotalSeconds);
                        if (currentPlayTimeValue > trackBarPlayTime.Maximum)
                            currentPlayTimeValue = trackBarPlayTime.Maximum;
                    }
                    trackBarPlayTime.Value = currentPlayTimeValue;
                    //positionMarkersPanel.Refresh();
                }
                else if (e.PlaybackStatus == PlaybackStatus.Playing)
                {
                    buttonPlay.Image = Resources.Pause;
                    PlayTimeUpdateTimer.Enabled = true;
                }
            })
            );
        }

        private void AudioPlaybackService_PlayTimeChanged(object sender, EventArgs e)
        {
            if (_audioPlaybackService == null || _audioPlaybackService.PlaybackStatus == PlaybackStatus.Terminating || _audioPlaybackService.PlaybackStatus == PlaybackStatus.Terminated)
                return;

            this.Invoke(
                new MethodInvoker(delegate ()
                {
                    _isUpdatePlayTimeNeeded = true;
                }));
        }


        /// <summary>
        /// Initialize time stretch profiles and their UI controls
        /// </summary>
        private void InitializeTimeStretchProfiles()
        {
            int defaultProfileIndex = 0;
            foreach (TimeStretchProfile timeStretchProfile in TimeStretchProfiles.Profiles.Values)
            {
                int itemIndex = comboBoxTimeStretchProfile.Items.Add(timeStretchProfile);
                if (timeStretchProfile.Id == TimeStretchProfiles.DefaultProfile)
                {
                    defaultProfileIndex = itemIndex;
                }
            }

            comboBoxTimeStretchProfile.SelectedIndex = defaultProfileIndex;
        }

        /// <summary>
        /// Initializes the Most-Recently-Used files
        /// </summary>
        private void InitializeMRUFiles()
        {
            _recentFilesMenuItems.AddRange(new ToolStripMenuItem[] {
                    menuItemRecent1,  menuItemRecent2, menuItemRecent3, menuItemRecent4, menuItemRecent5,
                    menuItemRecent6, menuItemRecent7, menuItemRecent8 });
            foreach (ToolStripMenuItem recentMenuItem in _recentFilesMenuItems)
            {
                recentMenuItem.Click += new EventHandler(RecentMenuItem_Click);
            }
            
            _recentFilesList = new MostRecentlyUsedList(_recentFilesMenuItems.Count, $"{_appDataFolder}\\practicesession_mru.txt");
        }

        /// <summary>
        /// Initializes the application folders (Data & Log)
        /// </summary>
        private void InitializeApplicationFolders()
        {
            // Initialize Application Data Folder - used for storing Preset Bank files
            _appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\PracticeSession";
            if (!Directory.Exists(_appDataFolder))
            {
                Directory.CreateDirectory(_appDataFolder);
            }

            // Workaround for older Windows (XP or less) that don't have  LOCALAPPDATA environment variable
            // This environment variable is used by NLog layout renderer (NLog.config)
            Environment.SetEnvironmentVariable("PracticeSession", _appDataFolder);
        }

        private void AutoLoadLastFile()
        {
            string lastFilename = Properties.Settings.Default.LastUsedFilename;

            if (File.Exists(lastFilename))
            {
                // Open file but don't start playing automatically
                OpenFile(lastFilename, false);
            }
        }

        private void trackBarTempo_ValueChanged(object sender, EventArgs e)
        {
            if (_audioPlaybackService == null)
                return;

            float newTempo = trackBarTempo.Value / 100.0f;
            _audioPlaybackService.Tempo = newTempo;

            labelTempoValue.ForeColor = (newTempo != 1.0f) ? Color.Blue : Color.Black;
            labelTempoValue.Text = $"x{newTempo}";
        }

        private void trackBarPitch_ValueChanged(object sender, EventArgs e)
        {
            if (_audioPlaybackService == null)
                return;

            float newPitchSemiTones = trackBarPitch.Value / (float)_ticksPerSemitone;
            _audioPlaybackService.Pitch = newPitchSemiTones;


            // Update Pitch value label
            string pitchValue;
            if (newPitchSemiTones == 0)
                pitchValue = "==";
            else
            {
                pitchValue = (newPitchSemiTones > 0) ? "+" : "-";

                double intPart = Math.Abs(Math.Truncate(newPitchSemiTones));
                float remainder = Math.Abs(newPitchSemiTones - (int)newPitchSemiTones);

                // Add integer part
                if (intPart > 0)
                {
                    pitchValue += intPart.ToString();
                }

                if (remainder == 0.25f)
                {
                    pitchValue += "¼";
                }
                else if (remainder == 0.5f)
                {
                    pitchValue += "½";
                }
                else if (remainder == 0.75f)
                {
                    pitchValue += "¾";
                }
            }

            labelPitchValue.ForeColor = (newPitchSemiTones != 0) ? Color.Blue : Color.Black;
            labelPitchValue.Text = pitchValue;
        }

        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {
            if (_audioPlaybackService == null)
                return;

            float newVolume = trackBarVolume.Value / 100.0f;
            _audioPlaybackService.Volume = newVolume;

            labelVolumeValue.Text = $"{trackBarVolume.Value}%";
        }

        private void trackBarEQLow_ValueChanged(object sender, EventArgs e)
        {
            if (_audioPlaybackService == null)
                return;

            float newEqLow = trackBarEQLow.Value / 100.0f;
            _audioPlaybackService.EqualizerLoBand = newEqLow;

            labelEQLowValue.Text = $"{trackBarEQLow.Value}%";
        }

        private void trackBarEQMid_ValueChanged(object sender, EventArgs e)
        {
            if (_audioPlaybackService == null)
                return;

            float newEqMid= trackBarEQMid.Value / 100.0f;
            _audioPlaybackService.EqualizerMedBand = newEqMid;

            labelEQMidValue.Text = $"{trackBarEQMid.Value}%";
        }

        private void trackBarEQHi_ValueChanged(object sender, EventArgs e)
        {
            if (_audioPlaybackService == null)
                return;

            float newEqHi = trackBarEQHi.Value / 100.0f;
            _audioPlaybackService.EqualizerHiBand = newEqHi;

            labelEQHiValue.Text = $"{trackBarEQHi.Value}%";
        }

        private void trackBarPlayTime_ValueChanged(object sender, EventArgs e)
        {
            if (_ignorePlayTimeUIEvents)
                return;
            if (_audioPlaybackService == null)
                return;

            float playPosSeconds = (float)(trackBarPlayTime.Value / 100.0f * _audioPlaybackService.FilePlayDuration.TotalSeconds);
            TimeSpan newPlayTime = new TimeSpan(0, 0, 0, (int)playPosSeconds,
                (int)(100 * (playPosSeconds - Math.Truncate(playPosSeconds))));

            _audioPlaybackService.CurrentPlayTime = newPlayTime;
            if (_audioPlaybackService.PlaybackStatus != PlaybackStatus.Playing)
            {
                UpdateCurrentPlaytime(newPlayTime, _audioPlaybackService.FilePlayDuration);
            }
        }

        private void UpdateCurrentPlaytime(TimeSpan playTime, TimeSpan filePlayDuration)
        {
            labelPositionValue.Text =
                $"{playTime.Minutes:00}:{playTime.Seconds:00} / {filePlayDuration.Minutes:00}:{filePlayDuration.Seconds:00}";

            upDownCurrentMinutes.ValueChanged -= upDownCurrent_ValueChanged;
            upDownCurrentSeconds.ValueChanged -= upDownCurrent_ValueChanged;
            upDownCurrentMilliseconds.ValueChanged -= upDownCurrent_ValueChanged;
            try
            {
                // Update current play time controls
                upDownCurrentMinutes.Value = playTime.Minutes;
                upDownCurrentSeconds.Value = playTime.Seconds;
                upDownCurrentMilliseconds.Value = playTime.Milliseconds;
            }
            finally
            {
                upDownCurrentMinutes.ValueChanged += upDownCurrent_ValueChanged;
                upDownCurrentSeconds.ValueChanged += upDownCurrent_ValueChanged;
                upDownCurrentMilliseconds.ValueChanged += upDownCurrent_ValueChanged;
            }
        }

        private void PlayTimeUpdateTimer_Tick(object sender, EventArgs e)
        {
            lock (_timerLock)
            {
                if (!_isUpdatePlayTimeNeeded)
                    return;
            }

            // Only update when file is playing
            if (_audioPlaybackService.PlaybackStatus != PlaybackStatus.Playing)
                return;

            _isUpdatePlayTimeNeeded = false;

            _ignorePlayTimeUIEvents = true;
            try
            {
                if (DateTime.Now > _currentControlsMaskOutTime)
                {
                    UpdateCurrentPlaytime(_audioPlaybackService.CurrentPlayTime, _audioPlaybackService.FilePlayDuration);
                }

                if (!_playTimeTrackBarIsChanging && DateTime.Now > _playTimeTrackBarMaskOutTime)
                {
                    UpdatePlayTimeTrackBarCurrentValue();
                }

               // positionMarkersPanel.Refresh();
            }
            finally
            {
                _ignorePlayTimeUIEvents = false;
            }
        }

        private void UpdatePlayTimeTrackBarCurrentValue()
        {
            int currentPlayTimeValue = Convert.ToInt32(100.0f * _audioPlaybackService.CurrentPlayTime.TotalSeconds / _audioPlaybackService.FilePlayDuration.TotalSeconds);
            if (currentPlayTimeValue > trackBarPlayTime.Maximum)
            {
                currentPlayTimeValue = trackBarPlayTime.Maximum;
            }

            trackBarPlayTime.Value = currentPlayTimeValue;
        }

        private void RecentMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            string selectedRecentFilename = (string)menuItem.Tag;

            // Open Recent file and start playing it
            if (!OpenFile(selectedRecentFilename, true))
            {
                _recentFilesList.Remove(selectedRecentFilename);
            }
        }

        private void toolStripChannels_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "buttonChannelBoth":
                    buttonChannelBoth.Checked = true;
                    buttonChannelLeft.Checked = false;
                    buttonChannelRight.Checked = false;
                    buttonChannelDualMono.Checked = false;
                    _audioPlaybackService.InputChannelMode = InputChannelMode.Both;
                    break;
                case "buttonChannelLeft":
                    buttonChannelBoth.Checked = false;
                    buttonChannelLeft.Checked = true;
                    buttonChannelRight.Checked = false;
                    buttonChannelDualMono.Checked = false;
                    _audioPlaybackService.InputChannelMode = InputChannelMode.Left;
                    break;
                case "buttonChannelRight":
                    buttonChannelBoth.Checked = false;
                    buttonChannelLeft.Checked = false;
                    buttonChannelRight.Checked = true;
                    buttonChannelDualMono.Checked = false;
                    _audioPlaybackService.InputChannelMode = InputChannelMode.Right;
                    break;
                case "buttonChannelDualMono":
                    buttonChannelBoth.Checked = false;
                    buttonChannelLeft.Checked = false;
                    buttonChannelRight.Checked = false;
                    buttonChannelDualMono.Checked = true;
                    _audioPlaybackService.InputChannelMode = InputChannelMode.DualMono;
                    break;
            }
        }

        private void checkBoxSwapLR_CheckedChanged(object sender, EventArgs e)
        {
            _audioPlaybackService.SwapLeftRightSpeakers = checkBoxSwapLR.Checked;
        }

        private void checkBoxSuppressVocals_CheckedChanged(object sender, EventArgs e)
        {
            _audioPlaybackService.SuppressVocals = checkBoxSuppressVocals.Checked;
        }

        /// <summary>
        /// Mask out playtime TrackBar update messages for some time to avoid trackbar jumps 
        /// </summary>
        private void TempMaskOutPlayTimeTrackBar()
        {
            _playTimeTrackBarMaskOutTime = DateTime.Now.AddMilliseconds(_maskOutInterval);
        }

        /// <summary>
        /// Mask out updates of current up-down controls to avoid jumps
        /// </summary>
        private void TempMaskOutCurrentControls()
        {
            _currentControlsMaskOutTime = DateTime.Now.AddMilliseconds(_maskOutInterval);
        }

        private void comboBoxTimeStretchProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_audioPlaybackService != null)
            {
                _audioPlaybackService.TimeStretchProfile = comboBoxTimeStretchProfile.Items[comboBoxTimeStretchProfile.SelectedIndex] as TimeStretchProfile;
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            ShowFileDialog();
        }


        private void buttonPlay_Click(object sender, EventArgs e)
        {
            PlayButtonPressed();
        }

        private void upDownCue_ValueChanged(object sender, EventArgs e)
        {
            if (_audioPlaybackService != null)
            {
                _audioPlaybackService.Cue = new TimeSpan(0, 0, Convert.ToInt32(upDownCue.Value));
            }
        }

        private void checkBoxLoop_CheckedChanged(object sender, EventArgs e)
        {
            if (_audioPlaybackService != null)
            {
                _audioPlaybackService.Loop = checkBoxLoop.Checked;
            }
        }

        private void buttonStartLoopNow_Click(object sender, EventArgs e)
        {
            if (_audioPlaybackService == null)
            {
                return;
            }

            if (_audioPlaybackService.CurrentPlayTime > _audioPlaybackService.EndMarker)
            {
                upDownEndLoopMinutes.Value = upDownCurrentMinutes.Value;
                upDownEndLoopSeconds.Value = upDownCurrentSeconds.Value;
                upDownEndLoopMilliseconds.Value = upDownCurrentMilliseconds.Value;
            }

            upDownStartLoopMinutes.Value = upDownCurrentMinutes.Value;
            upDownStartLoopSeconds.Value = upDownCurrentSeconds.Value;
            upDownStartLoopMilliseconds.Value = upDownCurrentMilliseconds.Value;
        }

        private void buttonEndLoopNow_Click(object sender, EventArgs e)
        {
            upDownEndLoopMinutes.Value = upDownCurrentMinutes.Value;
            upDownEndLoopSeconds.Value = upDownCurrentSeconds.Value;
            upDownEndLoopMilliseconds.Value = upDownCurrentMilliseconds.Value;
        }

        private void upDownStartLoopMinutes_ValueChanged(object sender, EventArgs e)
        {
            if (_audioPlaybackService == null)
                return;

            TimeSpan startMarker = _audioPlaybackService.StartMarker;

            if (upDownStartLoopMinutes.Value < 0)
            {
                startMarker = startMarker.Subtract(new TimeSpan(0, 0, 1, 0, 0));
            }
            else if (upDownStartLoopMinutes.Value > 99)
            {
                startMarker = startMarker.Add(new TimeSpan(0, 0, 1, 0, 0));
            }
            else
            {
                startMarker = new TimeSpan(0, 0, Convert.ToInt32(upDownStartLoopMinutes.Value), startMarker.Seconds, startMarker.Milliseconds);
            }

            UpdateStartMarker(startMarker);
        }

        private void upDownStartLoopSeconds_ValueChanged(object sender, EventArgs e)
        {
            if (_audioPlaybackService == null)
                return;

            TimeSpan startMarker = _audioPlaybackService.StartMarker;

            if (upDownStartLoopSeconds.Value < 0)
            {
                startMarker = startMarker.Subtract(new TimeSpan(0, 0, 1));
            }
            else if (upDownStartLoopSeconds.Value > 59)
            {
                startMarker = startMarker.Add(new TimeSpan(0, 0, 1));
            }
            else
            {
                startMarker = new TimeSpan(0, 0, startMarker.Minutes, Convert.ToInt32(upDownStartLoopSeconds.Value), startMarker.Milliseconds);
            }

            UpdateStartMarker(startMarker);
        }

        private void upDownStartLoopMilliseconds_ValueChanged(object sender, EventArgs e)
        {
            if (_audioPlaybackService == null)
                return;

            TimeSpan startMarker = _audioPlaybackService.StartMarker;

            if (upDownStartLoopMilliseconds.Value < 0)
            {
                startMarker = startMarker.Subtract(new TimeSpan(0, 0, 0, 0, 1));
            }
            else if (upDownStartLoopMilliseconds.Value > 999)
            {
                startMarker = startMarker.Add(new TimeSpan(0, 0, 0, 0, 1));
            }
            else
            {
                startMarker = new TimeSpan(0, 0, startMarker.Minutes, startMarker.Seconds, Convert.ToInt32(upDownStartLoopMilliseconds.Value));
            }

            UpdateStartMarker(startMarker);
        }

        private void upDownEndLoopMinutes_ValueChanged(object sender, EventArgs e)
        {
            if (_audioPlaybackService == null)
                return;

            TimeSpan endMarker = _audioPlaybackService.EndMarker;

            if (upDownEndLoopMinutes.Value < 0)
            {
                endMarker = endMarker.Subtract(new TimeSpan(0, 0, 1, 0, 0));
            }
            else if (upDownEndLoopMinutes.Value > 99)
            {
                endMarker = endMarker.Add(new TimeSpan(0, 0, 1, 0, 0));
            }
            else
            {
                endMarker = new TimeSpan(0, 0, Convert.ToInt32(upDownEndLoopMinutes.Value), endMarker.Seconds, endMarker.Milliseconds);
            }

            UpdateEndMarker(endMarker);
        }

        private void upDownEndLoopSeconds_ValueChanged(object sender, EventArgs e)
        {
            if (_audioPlaybackService == null)
                return;

            TimeSpan endMarker = _audioPlaybackService.EndMarker;

            if (upDownEndLoopSeconds.Value < 0)
            {
                endMarker = endMarker.Subtract(new TimeSpan(0, 0, 1));
            }
            else if (upDownEndLoopSeconds.Value > 59)
            {
                endMarker = endMarker.Add(new TimeSpan(0, 0, 1));
            }
            else
            {
                endMarker = new TimeSpan(0, 0, endMarker.Minutes, Convert.ToInt32(upDownEndLoopSeconds.Value), endMarker.Milliseconds);
            }

            UpdateEndMarker(endMarker);
        }

        private void upDownEndLoopMilliseconds_ValueChanged(object sender, EventArgs e)
        {
            if (_audioPlaybackService == null)
                return;

            TimeSpan endMarker = _audioPlaybackService.EndMarker;

            if (upDownEndLoopMilliseconds.Value < 0)
            {
                endMarker = endMarker.Subtract(new TimeSpan(0, 0, 0, 0, 1));
            }
            else if (upDownEndLoopMilliseconds.Value > 999)
            {
                endMarker = endMarker.Add(new TimeSpan(0, 0, 0, 0, 1));
            }
            else
            {
                endMarker = new TimeSpan(0, 0, endMarker.Minutes, endMarker.Seconds, Convert.ToInt32(upDownEndLoopMilliseconds.Value));
            }

            UpdateEndMarker(endMarker);
        }

        private void UpdateStartMarker(TimeSpan startMarker)
        {
            if (startMarker > _audioPlaybackService.EndMarker)
            {
                startMarker = _audioPlaybackService.EndMarker;
            }
            else if (startMarker < TimeSpan.Zero)
            {
                startMarker = TimeSpan.Zero;
            }

            _audioPlaybackService.StartMarker = startMarker;

            ApplyLoopStartMarkerUI(startMarker);
        }

        private void UpdateEndMarker(TimeSpan endMarker)
        {
            if (endMarker < _audioPlaybackService.StartMarker)
            {
                endMarker = _audioPlaybackService.StartMarker;
            }
            else if (endMarker > _audioPlaybackService.FilePlayDuration)
            {
                endMarker = _audioPlaybackService.FilePlayDuration;
            }

            _audioPlaybackService.EndMarker = endMarker;

            ApplyLoopEndMarkerUI(endMarker);
        }

        private void ApplyLoopStartMarkerUI(TimeSpan startMarker)
        {
            upDownStartLoopMinutes.ValueChanged -= upDownStartLoopMinutes_ValueChanged;
            upDownStartLoopSeconds.ValueChanged -= upDownStartLoopSeconds_ValueChanged;
            upDownStartLoopMilliseconds.ValueChanged -= upDownStartLoopMilliseconds_ValueChanged;
            try
            {
                upDownStartLoopMinutes.Value = startMarker.Minutes;
                upDownStartLoopSeconds.Value = startMarker.Seconds;
                upDownStartLoopMilliseconds.Value = startMarker.Milliseconds;
            }
            finally
            {
                upDownStartLoopMinutes.ValueChanged += upDownStartLoopMinutes_ValueChanged;
                upDownStartLoopSeconds.ValueChanged += upDownStartLoopSeconds_ValueChanged;
                upDownStartLoopMilliseconds.ValueChanged += upDownStartLoopMilliseconds_ValueChanged;
            }
        }

        private void ApplyLoopEndMarkerUI(TimeSpan endMarker)
        {
            upDownEndLoopMinutes.ValueChanged -= upDownEndLoopMinutes_ValueChanged;
            upDownEndLoopSeconds.ValueChanged -= upDownEndLoopSeconds_ValueChanged;
            upDownEndLoopMilliseconds.ValueChanged -= upDownEndLoopMilliseconds_ValueChanged;
            try
            {
                upDownEndLoopMinutes.Value = endMarker.Minutes;
                upDownEndLoopSeconds.Value = endMarker.Seconds;
                upDownEndLoopMilliseconds.Value = endMarker.Milliseconds;
            }
            finally
            {
                upDownEndLoopMinutes.ValueChanged += upDownEndLoopMinutes_ValueChanged;
                upDownEndLoopSeconds.ValueChanged += upDownEndLoopSeconds_ValueChanged;
                upDownEndLoopMilliseconds.ValueChanged += upDownEndLoopMilliseconds_ValueChanged;
            }
        }

        private void upDownCurrent_ValueChanged(object sender, EventArgs e)
        {
            if (_ignorePlayTimeUIEvents)
                return;

            TimeSpan currentPlayTime = new TimeSpan(0, 0, Convert.ToInt32(upDownCurrentMinutes.Value), Convert.ToInt32(upDownCurrentSeconds.Value), Convert.ToInt32(upDownCurrentMilliseconds.Value));
            // Mask out events to eliminate 'Racing' between GUI and  over current playtime
            TempMaskOutCurrentControls();

            UpdateCoreCurrentPlayTime(ref currentPlayTime);

            if (_audioPlaybackService.PlaybackStatus != PlaybackStatus.Playing)
            {
                trackBarPlayTime.Value = Convert.ToInt32(100.0f * currentPlayTime.TotalSeconds / _audioPlaybackService.FilePlayDuration.TotalSeconds);
            }
        }

        private void UpdateCoreCurrentPlayTime(ref TimeSpan currentPlayTime)
        {
            // Clip to actual file duration limits (0..FilePlayDuration)
            if (currentPlayTime > _audioPlaybackService.FilePlayDuration)
                currentPlayTime = _audioPlaybackService.FilePlayDuration;
            else if (currentPlayTime < TimeSpan.Zero)
                currentPlayTime = TimeSpan.Zero;

            _audioPlaybackService.CurrentPlayTime = currentPlayTime;

            UpdateCurrentPlaytime(currentPlayTime, _audioPlaybackService.FilePlayDuration);
        }
    }
}
