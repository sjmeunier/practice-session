
using System;

namespace PracticeSession
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecent1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecent2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecent3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecent4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecent5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecent6 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecent7 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecent8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelFilename = new System.Windows.Forms.Label();
            this.labelCurrentlyPlaying = new System.Windows.Forms.Label();
            this.trackBarPlayTime = new System.Windows.Forms.TrackBar();
            this.labelPlayDuration0Q = new System.Windows.Forms.Label();
            this.labelPlayDuration1Q = new System.Windows.Forms.Label();
            this.labelPlayDuration2Q = new System.Windows.Forms.Label();
            this.labelPlayDuration3Q = new System.Windows.Forms.Label();
            this.labelPlayDuration = new System.Windows.Forms.Label();
            this.PlayTimeUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelControls = new System.Windows.Forms.Panel();
            this.labelEQMidValue = new System.Windows.Forms.Label();
            this.labelEQLowValue = new System.Windows.Forms.Label();
            this.labelCueSeconds = new System.Windows.Forms.Label();
            this.labelCue = new System.Windows.Forms.Label();
            this.upDownCue = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTimeStretchProfile = new System.Windows.Forms.ComboBox();
            this.labelTimeStretchProfile = new System.Windows.Forms.Label();
            this.labelEQHiValue = new System.Windows.Forms.Label();
            this.labelVolumeValue = new System.Windows.Forms.Label();
            this.labelSemitones = new System.Windows.Forms.Label();
            this.labelPitchValue = new System.Windows.Forms.Label();
            this.labelTempoValue = new System.Windows.Forms.Label();
            this.checkBoxSuppressVocals = new System.Windows.Forms.CheckBox();
            this.checkBoxSwapLR = new System.Windows.Forms.CheckBox();
            this.labelChannel = new System.Windows.Forms.Label();
            this.toolStripChannels = new System.Windows.Forms.ToolStrip();
            this.buttonChannelBoth = new System.Windows.Forms.ToolStripButton();
            this.buttonChannelLeft = new System.Windows.Forms.ToolStripButton();
            this.buttonChannelRight = new System.Windows.Forms.ToolStripButton();
            this.buttonChannelDualMono = new System.Windows.Forms.ToolStripButton();
            this.labelEQMid = new System.Windows.Forms.Label();
            this.trackBarEQHi = new System.Windows.Forms.TrackBar();
            this.labelEQHi = new System.Windows.Forms.Label();
            this.trackBarEQMid = new System.Windows.Forms.TrackBar();
            this.labelEQLow = new System.Windows.Forms.Label();
            this.labelEQMin100pc = new System.Windows.Forms.Label();
            this.labelEQ0pc = new System.Windows.Forms.Label();
            this.labelEQ100pc = new System.Windows.Forms.Label();
            this.labelEqualizer = new System.Windows.Forms.Label();
            this.trackBarEQLow = new System.Windows.Forms.TrackBar();
            this.labelVolume25pc = new System.Windows.Forms.Label();
            this.labelVolume75pc = new System.Windows.Forms.Label();
            this.labelVolume0pc = new System.Windows.Forms.Label();
            this.labelVolume50pc = new System.Windows.Forms.Label();
            this.labelVolume100pc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.labelPitch8vb = new System.Windows.Forms.Label();
            this.labelPitch0 = new System.Windows.Forms.Label();
            this.labelPitch8va = new System.Windows.Forms.Label();
            this.labelPitch = new System.Windows.Forms.Label();
            this.trackBarPitch = new System.Windows.Forms.TrackBar();
            this.labelX15 = new System.Windows.Forms.Label();
            this.labelX05 = new System.Windows.Forms.Label();
            this.labelX01 = new System.Windows.Forms.Label();
            this.labelX10 = new System.Windows.Forms.Label();
            this.labelX20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarTempo = new System.Windows.Forms.TrackBar();
            this.panelLoop = new System.Windows.Forms.Panel();
            this.labelPositionValue = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.upDownCurrentMilliseconds = new System.Windows.Forms.NumericUpDown();
            this.upDownCurrentSeconds = new System.Windows.Forms.NumericUpDown();
            this.upDownCurrentMinutes = new System.Windows.Forms.NumericUpDown();
            this.buttonEndLoopNow = new System.Windows.Forms.Button();
            this.upDownEndLoopMilliseconds = new System.Windows.Forms.NumericUpDown();
            this.upDownEndLoopSeconds = new System.Windows.Forms.NumericUpDown();
            this.upDownEndLoopMinutes = new System.Windows.Forms.NumericUpDown();
            this.labelLoopEnd = new System.Windows.Forms.Label();
            this.buttonStartLoopNow = new System.Windows.Forms.Button();
            this.upDownStartLoopMilliseconds = new System.Windows.Forms.NumericUpDown();
            this.upDownStartLoopSeconds = new System.Windows.Forms.NumericUpDown();
            this.upDownStartLoopMinutes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxLoop = new System.Windows.Forms.CheckBox();
            this.panelPresets = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSavePreset = new System.Windows.Forms.Button();
            this.labelPreset4 = new System.Windows.Forms.Label();
            this.labelPreset8 = new System.Windows.Forms.Label();
            this.buttonPreset8 = new System.Windows.Forms.Button();
            this.buttonPreset4 = new System.Windows.Forms.Button();
            this.labelPreset3 = new System.Windows.Forms.Label();
            this.labelPreset7 = new System.Windows.Forms.Label();
            this.buttonPreset7 = new System.Windows.Forms.Button();
            this.buttonPreset3 = new System.Windows.Forms.Button();
            this.labelPreset2 = new System.Windows.Forms.Label();
            this.labelPreset6 = new System.Windows.Forms.Label();
            this.buttonPreset6 = new System.Windows.Forms.Button();
            this.buttonPreset2 = new System.Windows.Forms.Button();
            this.labelPreset1 = new System.Windows.Forms.Label();
            this.labelPreset5 = new System.Windows.Forms.Label();
            this.buttonPreset5 = new System.Windows.Forms.Button();
            this.buttonPreset1 = new System.Windows.Forms.Button();
            this.pictureBoxRenderer = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlayTime)).BeginInit();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCue)).BeginInit();
            this.toolStripChannels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEQHi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEQMid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEQLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTempo)).BeginInit();
            this.panelLoop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCurrentMilliseconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCurrentSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCurrentMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownEndLoopMilliseconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownEndLoopSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownEndLoopMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownStartLoopMilliseconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownStartLoopSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownStartLoopMinutes)).BeginInit();
            this.panelPresets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRenderer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1668, 40);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRecent1,
            this.menuItemRecent2,
            this.menuItemRecent3,
            this.menuItemRecent4,
            this.menuItemRecent5,
            this.menuItemRecent6,
            this.menuItemRecent7,
            this.menuItemRecent8,
            this.toolStripSeparator2,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(71, 36);
            this.menuItemFile.Text = "&File";
            this.menuItemFile.DropDownOpening += new System.EventHandler(this.menuItemFile_DropDownOpening);
            this.menuItemFile.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuItemFile_Clicked);
            // 
            // menuItemRecent1
            // 
            this.menuItemRecent1.Name = "menuItemRecent1";
            this.menuItemRecent1.Size = new System.Drawing.Size(342, 44);
            this.menuItemRecent1.Text = "menuItemRecent1";
            // 
            // menuItemRecent2
            // 
            this.menuItemRecent2.Name = "menuItemRecent2";
            this.menuItemRecent2.Size = new System.Drawing.Size(342, 44);
            this.menuItemRecent2.Text = "menuItemRecent2";
            // 
            // menuItemRecent3
            // 
            this.menuItemRecent3.Name = "menuItemRecent3";
            this.menuItemRecent3.Size = new System.Drawing.Size(342, 44);
            this.menuItemRecent3.Text = "menuItemRecent3";
            // 
            // menuItemRecent4
            // 
            this.menuItemRecent4.Name = "menuItemRecent4";
            this.menuItemRecent4.Size = new System.Drawing.Size(342, 44);
            this.menuItemRecent4.Text = "menuItemRecent4";
            // 
            // menuItemRecent5
            // 
            this.menuItemRecent5.Name = "menuItemRecent5";
            this.menuItemRecent5.Size = new System.Drawing.Size(342, 44);
            this.menuItemRecent5.Text = "menuItemRecent5";
            // 
            // menuItemRecent6
            // 
            this.menuItemRecent6.Name = "menuItemRecent6";
            this.menuItemRecent6.Size = new System.Drawing.Size(342, 44);
            this.menuItemRecent6.Text = "menuItemRecent7";
            // 
            // menuItemRecent7
            // 
            this.menuItemRecent7.Name = "menuItemRecent7";
            this.menuItemRecent7.Size = new System.Drawing.Size(342, 44);
            this.menuItemRecent7.Text = "menuItemRecent7";
            // 
            // menuItemRecent8
            // 
            this.menuItemRecent8.Name = "menuItemRecent8";
            this.menuItemRecent8.Size = new System.Drawing.Size(342, 44);
            this.menuItemRecent8.Text = "menuItemRecent8";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(339, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(342, 44);
            this.menuItemExit.Text = "E&xit";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Music Files|*.mp3;*.wav;*.ogg;*.flac;*.wma;*.aiff;*.m4a|MP3 files|*.mp3|WAV f" +
    "iles|*.wav|Ogg Vorbis files|*.ogg|FLAC files|*.flac|WMA files|*.wma|AIFF files|*" +
    ".aiff|M4A files|*.m4a";
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(364, 70);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(198, 32);
            this.labelFilename.TabIndex = 2;
            this.labelFilename.Text = "<No file loaded>";
            this.labelFilename.Click += new System.EventHandler(this.labelFilename_Click);
            // 
            // labelCurrentlyPlaying
            // 
            this.labelCurrentlyPlaying.AutoSize = true;
            this.labelCurrentlyPlaying.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentlyPlaying.Location = new System.Drawing.Point(138, 70);
            this.labelCurrentlyPlaying.Name = "labelCurrentlyPlaying";
            this.labelCurrentlyPlaying.Size = new System.Drawing.Size(220, 32);
            this.labelCurrentlyPlaying.TabIndex = 3;
            this.labelCurrentlyPlaying.Text = "Currently playing:";
            this.labelCurrentlyPlaying.Click += new System.EventHandler(this.labelCurrentlyPlaying_Click);
            // 
            // trackBarPlayTime
            // 
            this.trackBarPlayTime.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trackBarPlayTime.LargeChange = 0;
            this.trackBarPlayTime.Location = new System.Drawing.Point(-6, 442);
            this.trackBarPlayTime.Maximum = 100;
            this.trackBarPlayTime.Name = "trackBarPlayTime";
            this.trackBarPlayTime.Size = new System.Drawing.Size(1682, 90);
            this.trackBarPlayTime.SmallChange = 5;
            this.trackBarPlayTime.TabIndex = 35;
            this.trackBarPlayTime.TickFrequency = 5;
            this.trackBarPlayTime.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarPlayTime.ValueChanged += new System.EventHandler(this.trackBarPlayTime_ValueChanged);
            // 
            // labelPlayDuration0Q
            // 
            this.labelPlayDuration0Q.AutoSize = true;
            this.labelPlayDuration0Q.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayDuration0Q.Location = new System.Drawing.Point(7, 497);
            this.labelPlayDuration0Q.Name = "labelPlayDuration0Q";
            this.labelPlayDuration0Q.Size = new System.Drawing.Size(56, 25);
            this.labelPlayDuration0Q.TabIndex = 48;
            this.labelPlayDuration0Q.Text = "00:00";
            this.labelPlayDuration0Q.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPlayDuration1Q
            // 
            this.labelPlayDuration1Q.AutoSize = true;
            this.labelPlayDuration1Q.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayDuration1Q.Location = new System.Drawing.Point(403, 497);
            this.labelPlayDuration1Q.Name = "labelPlayDuration1Q";
            this.labelPlayDuration1Q.Size = new System.Drawing.Size(56, 25);
            this.labelPlayDuration1Q.TabIndex = 49;
            this.labelPlayDuration1Q.Text = "00:00";
            this.labelPlayDuration1Q.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPlayDuration2Q
            // 
            this.labelPlayDuration2Q.AutoSize = true;
            this.labelPlayDuration2Q.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayDuration2Q.Location = new System.Drawing.Point(807, 497);
            this.labelPlayDuration2Q.Name = "labelPlayDuration2Q";
            this.labelPlayDuration2Q.Size = new System.Drawing.Size(56, 25);
            this.labelPlayDuration2Q.TabIndex = 50;
            this.labelPlayDuration2Q.Text = "00:00";
            this.labelPlayDuration2Q.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPlayDuration3Q
            // 
            this.labelPlayDuration3Q.AutoSize = true;
            this.labelPlayDuration3Q.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayDuration3Q.Location = new System.Drawing.Point(1208, 497);
            this.labelPlayDuration3Q.Name = "labelPlayDuration3Q";
            this.labelPlayDuration3Q.Size = new System.Drawing.Size(56, 25);
            this.labelPlayDuration3Q.TabIndex = 51;
            this.labelPlayDuration3Q.Text = "00:00";
            this.labelPlayDuration3Q.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPlayDuration
            // 
            this.labelPlayDuration.AutoSize = true;
            this.labelPlayDuration.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayDuration.Location = new System.Drawing.Point(1612, 497);
            this.labelPlayDuration.Name = "labelPlayDuration";
            this.labelPlayDuration.Size = new System.Drawing.Size(56, 25);
            this.labelPlayDuration.TabIndex = 52;
            this.labelPlayDuration.Text = "00:00";
            this.labelPlayDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlayTimeUpdateTimer
            // 
            this.PlayTimeUpdateTimer.Interval = 50;
            this.PlayTimeUpdateTimer.Tick += new System.EventHandler(this.PlayTimeUpdateTimer_Tick);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.Image")));
            this.buttonOpenFile.Location = new System.Drawing.Point(15, 62);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(48, 48);
            this.buttonOpenFile.TabIndex = 56;
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.Location = new System.Drawing.Point(74, 62);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(48, 48);
            this.buttonPlay.TabIndex = 57;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Location = new System.Drawing.Point(0, 1344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1668, 22);
            this.statusStrip1.TabIndex = 58;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelControls
            // 
            this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControls.Controls.Add(this.labelEQMidValue);
            this.panelControls.Controls.Add(this.labelEQLowValue);
            this.panelControls.Controls.Add(this.labelCueSeconds);
            this.panelControls.Controls.Add(this.labelCue);
            this.panelControls.Controls.Add(this.upDownCue);
            this.panelControls.Controls.Add(this.comboBoxTimeStretchProfile);
            this.panelControls.Controls.Add(this.labelTimeStretchProfile);
            this.panelControls.Controls.Add(this.labelEQHiValue);
            this.panelControls.Controls.Add(this.labelVolumeValue);
            this.panelControls.Controls.Add(this.labelSemitones);
            this.panelControls.Controls.Add(this.labelPitchValue);
            this.panelControls.Controls.Add(this.labelTempoValue);
            this.panelControls.Controls.Add(this.checkBoxSuppressVocals);
            this.panelControls.Controls.Add(this.checkBoxSwapLR);
            this.panelControls.Controls.Add(this.labelChannel);
            this.panelControls.Controls.Add(this.toolStripChannels);
            this.panelControls.Controls.Add(this.labelEQMid);
            this.panelControls.Controls.Add(this.trackBarEQHi);
            this.panelControls.Controls.Add(this.labelEQHi);
            this.panelControls.Controls.Add(this.trackBarEQMid);
            this.panelControls.Controls.Add(this.labelEQLow);
            this.panelControls.Controls.Add(this.labelEQMin100pc);
            this.panelControls.Controls.Add(this.labelEQ0pc);
            this.panelControls.Controls.Add(this.labelEQ100pc);
            this.panelControls.Controls.Add(this.labelEqualizer);
            this.panelControls.Controls.Add(this.trackBarEQLow);
            this.panelControls.Controls.Add(this.labelVolume25pc);
            this.panelControls.Controls.Add(this.labelVolume75pc);
            this.panelControls.Controls.Add(this.labelVolume0pc);
            this.panelControls.Controls.Add(this.labelVolume50pc);
            this.panelControls.Controls.Add(this.labelVolume100pc);
            this.panelControls.Controls.Add(this.label5);
            this.panelControls.Controls.Add(this.trackBarVolume);
            this.panelControls.Controls.Add(this.labelPitch8vb);
            this.panelControls.Controls.Add(this.labelPitch0);
            this.panelControls.Controls.Add(this.labelPitch8va);
            this.panelControls.Controls.Add(this.labelPitch);
            this.panelControls.Controls.Add(this.trackBarPitch);
            this.panelControls.Controls.Add(this.labelX15);
            this.panelControls.Controls.Add(this.labelX05);
            this.panelControls.Controls.Add(this.labelX01);
            this.panelControls.Controls.Add(this.labelX10);
            this.panelControls.Controls.Add(this.labelX20);
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Controls.Add(this.trackBarTempo);
            this.panelControls.Location = new System.Drawing.Point(15, 550);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1197, 776);
            this.panelControls.TabIndex = 62;
            // 
            // labelEQMidValue
            // 
            this.labelEQMidValue.Location = new System.Drawing.Point(749, 620);
            this.labelEQMidValue.Name = "labelEQMidValue";
            this.labelEQMidValue.Size = new System.Drawing.Size(70, 32);
            this.labelEQMidValue.TabIndex = 106;
            this.labelEQMidValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelEQLowValue
            // 
            this.labelEQLowValue.Location = new System.Drawing.Point(673, 620);
            this.labelEQLowValue.Name = "labelEQLowValue";
            this.labelEQLowValue.Size = new System.Drawing.Size(70, 32);
            this.labelEQLowValue.TabIndex = 105;
            this.labelEQLowValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCueSeconds
            // 
            this.labelCueSeconds.AutoSize = true;
            this.labelCueSeconds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCueSeconds.Location = new System.Drawing.Point(765, 703);
            this.labelCueSeconds.Name = "labelCueSeconds";
            this.labelCueSeconds.Size = new System.Drawing.Size(58, 32);
            this.labelCueSeconds.TabIndex = 104;
            this.labelCueSeconds.Text = "secs";
            // 
            // labelCue
            // 
            this.labelCue.AutoSize = true;
            this.labelCue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCue.Location = new System.Drawing.Point(628, 703);
            this.labelCue.Name = "labelCue";
            this.labelCue.Size = new System.Drawing.Size(57, 32);
            this.labelCue.TabIndex = 103;
            this.labelCue.Text = "Cue";
            // 
            // upDownCue
            // 
            this.upDownCue.Location = new System.Drawing.Point(691, 701);
            this.upDownCue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upDownCue.Name = "upDownCue";
            this.upDownCue.Size = new System.Drawing.Size(68, 39);
            this.upDownCue.TabIndex = 102;
            this.upDownCue.ValueChanged += new System.EventHandler(this.upDownCue_ValueChanged);
            // 
            // comboBoxTimeStretchProfile
            // 
            this.comboBoxTimeStretchProfile.FormattingEnabled = true;
            this.comboBoxTimeStretchProfile.Location = new System.Drawing.Point(126, 700);
            this.comboBoxTimeStretchProfile.Name = "comboBoxTimeStretchProfile";
            this.comboBoxTimeStretchProfile.Size = new System.Drawing.Size(404, 40);
            this.comboBoxTimeStretchProfile.TabIndex = 101;
            this.comboBoxTimeStretchProfile.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeStretchProfile_SelectedIndexChanged);
            // 
            // labelTimeStretchProfile
            // 
            this.labelTimeStretchProfile.AutoSize = true;
            this.labelTimeStretchProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTimeStretchProfile.Location = new System.Drawing.Point(12, 700);
            this.labelTimeStretchProfile.Name = "labelTimeStretchProfile";
            this.labelTimeStretchProfile.Size = new System.Drawing.Size(97, 32);
            this.labelTimeStretchProfile.TabIndex = 100;
            this.labelTimeStretchProfile.Text = "Profile:";
            // 
            // labelEQHiValue
            // 
            this.labelEQHiValue.Location = new System.Drawing.Point(820, 620);
            this.labelEQHiValue.Name = "labelEQHiValue";
            this.labelEQHiValue.Size = new System.Drawing.Size(70, 32);
            this.labelEQHiValue.TabIndex = 99;
            this.labelEQHiValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelVolumeValue
            // 
            this.labelVolumeValue.Location = new System.Drawing.Point(473, 620);
            this.labelVolumeValue.Name = "labelVolumeValue";
            this.labelVolumeValue.Size = new System.Drawing.Size(70, 32);
            this.labelVolumeValue.TabIndex = 98;
            this.labelVolumeValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSemitones
            // 
            this.labelSemitones.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSemitones.Location = new System.Drawing.Point(234, 652);
            this.labelSemitones.Name = "labelSemitones";
            this.labelSemitones.Size = new System.Drawing.Size(107, 32);
            this.labelSemitones.TabIndex = 97;
            this.labelSemitones.Text = "Semi-tones";
            this.labelSemitones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPitchValue
            // 
            this.labelPitchValue.Location = new System.Drawing.Point(251, 620);
            this.labelPitchValue.Name = "labelPitchValue";
            this.labelPitchValue.Size = new System.Drawing.Size(70, 32);
            this.labelPitchValue.TabIndex = 96;
            this.labelPitchValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTempoValue
            // 
            this.labelTempoValue.Location = new System.Drawing.Point(87, 620);
            this.labelTempoValue.Name = "labelTempoValue";
            this.labelTempoValue.Size = new System.Drawing.Size(70, 32);
            this.labelTempoValue.TabIndex = 95;
            this.labelTempoValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxSuppressVocals
            // 
            this.checkBoxSuppressVocals.AutoSize = true;
            this.checkBoxSuppressVocals.Location = new System.Drawing.Point(956, 584);
            this.checkBoxSuppressVocals.Name = "checkBoxSuppressVocals";
            this.checkBoxSuppressVocals.Size = new System.Drawing.Size(215, 36);
            this.checkBoxSuppressVocals.TabIndex = 94;
            this.checkBoxSuppressVocals.Text = "Suppress Vocals";
            this.checkBoxSuppressVocals.UseVisualStyleBackColor = true;
            this.checkBoxSuppressVocals.CheckedChanged += new System.EventHandler(this.checkBoxSuppressVocals_CheckedChanged);
            // 
            // checkBoxSwapLR
            // 
            this.checkBoxSwapLR.AutoSize = true;
            this.checkBoxSwapLR.Location = new System.Drawing.Point(956, 542);
            this.checkBoxSwapLR.Name = "checkBoxSwapLR";
            this.checkBoxSwapLR.Size = new System.Drawing.Size(143, 36);
            this.checkBoxSwapLR.TabIndex = 93;
            this.checkBoxSwapLR.Text = "Swap L/R";
            this.checkBoxSwapLR.UseVisualStyleBackColor = true;
            this.checkBoxSwapLR.CheckedChanged += new System.EventHandler(this.checkBoxSwapLR_CheckedChanged);
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelChannel.Location = new System.Drawing.Point(946, 60);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(106, 32);
            this.labelChannel.TabIndex = 92;
            this.labelChannel.Text = "Channel";
            // 
            // toolStripChannels
            // 
            this.toolStripChannels.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStripChannels.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripChannels.CanOverflow = false;
            this.toolStripChannels.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripChannels.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripChannels.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripChannels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonChannelBoth,
            this.buttonChannelLeft,
            this.buttonChannelRight,
            this.buttonChannelDualMono});
            this.toolStripChannels.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStripChannels.Location = new System.Drawing.Point(964, 94);
            this.toolStripChannels.Name = "toolStripChannels";
            this.toolStripChannels.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripChannels.Size = new System.Drawing.Size(96, 170);
            this.toolStripChannels.TabIndex = 91;
            this.toolStripChannels.Text = "toolStripChannels";
            this.toolStripChannels.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripChannels_ItemClicked);
            // 
            // buttonChannelBoth
            // 
            this.buttonChannelBoth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonChannelBoth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonChannelBoth.Image = ((System.Drawing.Image)(resources.GetObject("buttonChannelBoth.Image")));
            this.buttonChannelBoth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChannelBoth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonChannelBoth.Name = "buttonChannelBoth";
            this.buttonChannelBoth.Size = new System.Drawing.Size(93, 36);
            this.buttonChannelBoth.Text = "BOTH";
            this.buttonChannelBoth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChannelBoth.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // buttonChannelLeft
            // 
            this.buttonChannelLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonChannelLeft.Image = ((System.Drawing.Image)(resources.GetObject("buttonChannelLeft.Image")));
            this.buttonChannelLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonChannelLeft.Name = "buttonChannelLeft";
            this.buttonChannelLeft.Size = new System.Drawing.Size(93, 36);
            this.buttonChannelLeft.Text = "LEFT";
            this.buttonChannelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonChannelRight
            // 
            this.buttonChannelRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonChannelRight.Image = ((System.Drawing.Image)(resources.GetObject("buttonChannelRight.Image")));
            this.buttonChannelRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonChannelRight.Name = "buttonChannelRight";
            this.buttonChannelRight.Size = new System.Drawing.Size(93, 36);
            this.buttonChannelRight.Text = "RIGHT";
            this.buttonChannelRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonChannelDualMono
            // 
            this.buttonChannelDualMono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonChannelDualMono.Image = ((System.Drawing.Image)(resources.GetObject("buttonChannelDualMono.Image")));
            this.buttonChannelDualMono.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonChannelDualMono.Name = "buttonChannelDualMono";
            this.buttonChannelDualMono.Size = new System.Drawing.Size(93, 36);
            this.buttonChannelDualMono.Text = "MONO";
            this.buttonChannelDualMono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEQMid
            // 
            this.labelEQMid.AutoSize = true;
            this.labelEQMid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEQMid.Location = new System.Drawing.Point(754, 60);
            this.labelEQMid.Name = "labelEQMid";
            this.labelEQMid.Size = new System.Drawing.Size(59, 32);
            this.labelEQMid.TabIndex = 90;
            this.labelEQMid.Text = "Mid";
            // 
            // trackBarEQHi
            // 
            this.trackBarEQHi.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.trackBarEQHi.LargeChange = 10;
            this.trackBarEQHi.Location = new System.Drawing.Point(820, 95);
            this.trackBarEQHi.Maximum = 100;
            this.trackBarEQHi.Minimum = -100;
            this.trackBarEQHi.Name = "trackBarEQHi";
            this.trackBarEQHi.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEQHi.Size = new System.Drawing.Size(90, 538);
            this.trackBarEQHi.SmallChange = 5;
            this.trackBarEQHi.TabIndex = 89;
            this.trackBarEQHi.TickFrequency = 20;
            this.trackBarEQHi.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEQHi.ValueChanged += new System.EventHandler(this.trackBarEQHi_ValueChanged);
            // 
            // labelEQHi
            // 
            this.labelEQHi.AutoSize = true;
            this.labelEQHi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEQHi.Location = new System.Drawing.Point(831, 60);
            this.labelEQHi.Name = "labelEQHi";
            this.labelEQHi.Size = new System.Drawing.Size(39, 32);
            this.labelEQHi.TabIndex = 88;
            this.labelEQHi.Text = "Hi";
            // 
            // trackBarEQMid
            // 
            this.trackBarEQMid.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.trackBarEQMid.LargeChange = 10;
            this.trackBarEQMid.Location = new System.Drawing.Point(749, 95);
            this.trackBarEQMid.Maximum = 100;
            this.trackBarEQMid.Minimum = -100;
            this.trackBarEQMid.Name = "trackBarEQMid";
            this.trackBarEQMid.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEQMid.Size = new System.Drawing.Size(90, 538);
            this.trackBarEQMid.SmallChange = 5;
            this.trackBarEQMid.TabIndex = 87;
            this.trackBarEQMid.TickFrequency = 20;
            this.trackBarEQMid.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEQMid.ValueChanged += new System.EventHandler(this.trackBarEQMid_ValueChanged);
            // 
            // labelEQLow
            // 
            this.labelEQLow.AutoSize = true;
            this.labelEQLow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEQLow.Location = new System.Drawing.Point(679, 60);
            this.labelEQLow.Name = "labelEQLow";
            this.labelEQLow.Size = new System.Drawing.Size(60, 32);
            this.labelEQLow.TabIndex = 86;
            this.labelEQLow.Text = "Low";
            // 
            // labelEQMin100pc
            // 
            this.labelEQMin100pc.AutoSize = true;
            this.labelEQMin100pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEQMin100pc.Location = new System.Drawing.Point(621, 595);
            this.labelEQMin100pc.Name = "labelEQMin100pc";
            this.labelEQMin100pc.Size = new System.Drawing.Size(64, 25);
            this.labelEQMin100pc.TabIndex = 85;
            this.labelEQMin100pc.Text = "-100%";
            this.labelEQMin100pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEQ0pc
            // 
            this.labelEQ0pc.AutoSize = true;
            this.labelEQ0pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEQ0pc.Location = new System.Drawing.Point(648, 350);
            this.labelEQ0pc.Name = "labelEQ0pc";
            this.labelEQ0pc.Size = new System.Drawing.Size(37, 25);
            this.labelEQ0pc.TabIndex = 84;
            this.labelEQ0pc.Text = "0%";
            this.labelEQ0pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEQ100pc
            // 
            this.labelEQ100pc.AutoSize = true;
            this.labelEQ100pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEQ100pc.Location = new System.Drawing.Point(628, 107);
            this.labelEQ100pc.Name = "labelEQ100pc";
            this.labelEQ100pc.Size = new System.Drawing.Size(57, 25);
            this.labelEQ100pc.TabIndex = 83;
            this.labelEQ100pc.Text = "100%";
            this.labelEQ100pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEqualizer
            // 
            this.labelEqualizer.AutoSize = true;
            this.labelEqualizer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEqualizer.Location = new System.Drawing.Point(720, 28);
            this.labelEqualizer.Name = "labelEqualizer";
            this.labelEqualizer.Size = new System.Drawing.Size(119, 32);
            this.labelEqualizer.TabIndex = 82;
            this.labelEqualizer.Text = "Equalizer";
            // 
            // trackBarEQLow
            // 
            this.trackBarEQLow.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.trackBarEQLow.LargeChange = 10;
            this.trackBarEQLow.Location = new System.Drawing.Point(679, 95);
            this.trackBarEQLow.Maximum = 100;
            this.trackBarEQLow.Minimum = -100;
            this.trackBarEQLow.Name = "trackBarEQLow";
            this.trackBarEQLow.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEQLow.Size = new System.Drawing.Size(90, 538);
            this.trackBarEQLow.SmallChange = 5;
            this.trackBarEQLow.TabIndex = 81;
            this.trackBarEQLow.TickFrequency = 20;
            this.trackBarEQLow.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEQLow.ValueChanged += new System.EventHandler(this.trackBarEQLow_ValueChanged);
            // 
            // labelVolume25pc
            // 
            this.labelVolume25pc.AutoSize = true;
            this.labelVolume25pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolume25pc.Location = new System.Drawing.Point(432, 470);
            this.labelVolume25pc.Name = "labelVolume25pc";
            this.labelVolume25pc.Size = new System.Drawing.Size(47, 25);
            this.labelVolume25pc.TabIndex = 80;
            this.labelVolume25pc.Text = "25%";
            this.labelVolume25pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVolume75pc
            // 
            this.labelVolume75pc.AutoSize = true;
            this.labelVolume75pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolume75pc.Location = new System.Drawing.Point(432, 223);
            this.labelVolume75pc.Name = "labelVolume75pc";
            this.labelVolume75pc.Size = new System.Drawing.Size(47, 25);
            this.labelVolume75pc.TabIndex = 79;
            this.labelVolume75pc.Text = "75%";
            this.labelVolume75pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVolume0pc
            // 
            this.labelVolume0pc.AutoSize = true;
            this.labelVolume0pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolume0pc.Location = new System.Drawing.Point(442, 595);
            this.labelVolume0pc.Name = "labelVolume0pc";
            this.labelVolume0pc.Size = new System.Drawing.Size(37, 25);
            this.labelVolume0pc.TabIndex = 78;
            this.labelVolume0pc.Text = "0%";
            this.labelVolume0pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVolume50pc
            // 
            this.labelVolume50pc.AutoSize = true;
            this.labelVolume50pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolume50pc.Location = new System.Drawing.Point(432, 350);
            this.labelVolume50pc.Name = "labelVolume50pc";
            this.labelVolume50pc.Size = new System.Drawing.Size(47, 25);
            this.labelVolume50pc.TabIndex = 77;
            this.labelVolume50pc.Text = "50%";
            this.labelVolume50pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVolume100pc
            // 
            this.labelVolume100pc.AutoSize = true;
            this.labelVolume100pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolume100pc.Location = new System.Drawing.Point(422, 107);
            this.labelVolume100pc.Name = "labelVolume100pc";
            this.labelVolume100pc.Size = new System.Drawing.Size(57, 25);
            this.labelVolume100pc.TabIndex = 76;
            this.labelVolume100pc.Text = "100%";
            this.labelVolume100pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(452, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 75;
            this.label5.Text = "Volume";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.trackBarVolume.Location = new System.Drawing.Point(473, 95);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.Size = new System.Drawing.Size(90, 538);
            this.trackBarVolume.TabIndex = 74;
            this.trackBarVolume.TickFrequency = 10;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarVolume.Value = 75;
            this.trackBarVolume.ValueChanged += new System.EventHandler(this.trackBarVolume_ValueChanged);
            // 
            // labelPitch8vb
            // 
            this.labelPitch8vb.AutoSize = true;
            this.labelPitch8vb.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPitch8vb.Location = new System.Drawing.Point(210, 595);
            this.labelPitch8vb.Name = "labelPitch8vb";
            this.labelPitch8vb.Size = new System.Drawing.Size(42, 25);
            this.labelPitch8vb.TabIndex = 73;
            this.labelPitch8vb.Text = "8vb";
            this.labelPitch8vb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPitch0
            // 
            this.labelPitch0.AutoSize = true;
            this.labelPitch0.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPitch0.Location = new System.Drawing.Point(210, 350);
            this.labelPitch0.Name = "labelPitch0";
            this.labelPitch0.Size = new System.Drawing.Size(22, 25);
            this.labelPitch0.TabIndex = 72;
            this.labelPitch0.Text = "0";
            this.labelPitch0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPitch8va
            // 
            this.labelPitch8va.AutoSize = true;
            this.labelPitch8va.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPitch8va.Location = new System.Drawing.Point(210, 107);
            this.labelPitch8va.Name = "labelPitch8va";
            this.labelPitch8va.Size = new System.Drawing.Size(40, 25);
            this.labelPitch8va.TabIndex = 71;
            this.labelPitch8va.Text = "8va";
            this.labelPitch8va.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPitch
            // 
            this.labelPitch.AutoSize = true;
            this.labelPitch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPitch.Location = new System.Drawing.Point(251, 60);
            this.labelPitch.Name = "labelPitch";
            this.labelPitch.Size = new System.Drawing.Size(71, 32);
            this.labelPitch.TabIndex = 70;
            this.labelPitch.Text = "Pitch";
            // 
            // trackBarPitch
            // 
            this.trackBarPitch.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.trackBarPitch.LargeChange = 0;
            this.trackBarPitch.Location = new System.Drawing.Point(251, 95);
            this.trackBarPitch.Maximum = 96;
            this.trackBarPitch.Minimum = -96;
            this.trackBarPitch.Name = "trackBarPitch";
            this.trackBarPitch.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarPitch.Size = new System.Drawing.Size(90, 538);
            this.trackBarPitch.SmallChange = 2;
            this.trackBarPitch.TabIndex = 69;
            this.trackBarPitch.TickFrequency = 8;
            this.trackBarPitch.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarPitch.ValueChanged += new System.EventHandler(this.trackBarPitch_ValueChanged);
            // 
            // labelX15
            // 
            this.labelX15.AutoSize = true;
            this.labelX15.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX15.Location = new System.Drawing.Point(46, 223);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(44, 25);
            this.labelX15.TabIndex = 68;
            this.labelX15.Text = "x1.5";
            this.labelX15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelX05
            // 
            this.labelX05.AutoSize = true;
            this.labelX05.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX05.Location = new System.Drawing.Point(46, 479);
            this.labelX05.Name = "labelX05";
            this.labelX05.Size = new System.Drawing.Size(44, 25);
            this.labelX05.TabIndex = 67;
            this.labelX05.Text = "x0.5";
            this.labelX05.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelX01
            // 
            this.labelX01.AutoSize = true;
            this.labelX01.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX01.Location = new System.Drawing.Point(46, 595);
            this.labelX01.Name = "labelX01";
            this.labelX01.Size = new System.Drawing.Size(44, 25);
            this.labelX01.TabIndex = 66;
            this.labelX01.Text = "x0.1";
            this.labelX01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            this.labelX10.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX10.Location = new System.Drawing.Point(46, 362);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(44, 25);
            this.labelX10.TabIndex = 65;
            this.labelX10.Text = "x1.0";
            this.labelX10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelX20
            // 
            this.labelX20.AutoSize = true;
            this.labelX20.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX20.Location = new System.Drawing.Point(46, 107);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(44, 25);
            this.labelX20.TabIndex = 64;
            this.labelX20.Text = "x2.0";
            this.labelX20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 63;
            this.label1.Text = "Tempo";
            // 
            // trackBarTempo
            // 
            this.trackBarTempo.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.trackBarTempo.LargeChange = 0;
            this.trackBarTempo.Location = new System.Drawing.Point(87, 95);
            this.trackBarTempo.Maximum = 200;
            this.trackBarTempo.Minimum = 10;
            this.trackBarTempo.Name = "trackBarTempo";
            this.trackBarTempo.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTempo.Size = new System.Drawing.Size(90, 538);
            this.trackBarTempo.SmallChange = 2;
            this.trackBarTempo.TabIndex = 62;
            this.trackBarTempo.TickFrequency = 10;
            this.trackBarTempo.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarTempo.Value = 100;
            this.trackBarTempo.ValueChanged += new System.EventHandler(this.trackBarTempo_ValueChanged);
            // 
            // panelLoop
            // 
            this.panelLoop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLoop.Controls.Add(this.labelPositionValue);
            this.panelLoop.Controls.Add(this.labelPosition);
            this.panelLoop.Controls.Add(this.upDownCurrentMilliseconds);
            this.panelLoop.Controls.Add(this.upDownCurrentSeconds);
            this.panelLoop.Controls.Add(this.upDownCurrentMinutes);
            this.panelLoop.Controls.Add(this.buttonEndLoopNow);
            this.panelLoop.Controls.Add(this.upDownEndLoopMilliseconds);
            this.panelLoop.Controls.Add(this.upDownEndLoopSeconds);
            this.panelLoop.Controls.Add(this.upDownEndLoopMinutes);
            this.panelLoop.Controls.Add(this.labelLoopEnd);
            this.panelLoop.Controls.Add(this.buttonStartLoopNow);
            this.panelLoop.Controls.Add(this.upDownStartLoopMilliseconds);
            this.panelLoop.Controls.Add(this.upDownStartLoopSeconds);
            this.panelLoop.Controls.Add(this.upDownStartLoopMinutes);
            this.panelLoop.Controls.Add(this.label2);
            this.panelLoop.Controls.Add(this.checkBoxLoop);
            this.panelLoop.Location = new System.Drawing.Point(1218, 550);
            this.panelLoop.Name = "panelLoop";
            this.panelLoop.Size = new System.Drawing.Size(435, 292);
            this.panelLoop.TabIndex = 63;
            // 
            // labelPositionValue
            // 
            this.labelPositionValue.AutoSize = true;
            this.labelPositionValue.Location = new System.Drawing.Point(81, 16);
            this.labelPositionValue.Name = "labelPositionValue";
            this.labelPositionValue.Size = new System.Drawing.Size(125, 32);
            this.labelPositionValue.TabIndex = 119;
            this.labelPositionValue.Text = "0:00 / 0:00";
            this.labelPositionValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPosition.Location = new System.Drawing.Point(10, 16);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(61, 32);
            this.labelPosition.TabIndex = 118;
            this.labelPosition.Text = "Pos:";
            // 
            // upDownCurrentMilliseconds
            // 
            this.upDownCurrentMilliseconds.Location = new System.Drawing.Point(259, 60);
            this.upDownCurrentMilliseconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.upDownCurrentMilliseconds.Name = "upDownCurrentMilliseconds";
            this.upDownCurrentMilliseconds.Size = new System.Drawing.Size(83, 39);
            this.upDownCurrentMilliseconds.TabIndex = 117;
            this.upDownCurrentMilliseconds.ValueChanged += new System.EventHandler(this.upDownCurrent_ValueChanged);
            // 
            // upDownCurrentSeconds
            // 
            this.upDownCurrentSeconds.Location = new System.Drawing.Point(170, 60);
            this.upDownCurrentSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.upDownCurrentSeconds.Name = "upDownCurrentSeconds";
            this.upDownCurrentSeconds.Size = new System.Drawing.Size(83, 39);
            this.upDownCurrentSeconds.TabIndex = 116;
            this.upDownCurrentSeconds.ValueChanged += new System.EventHandler(this.upDownCurrent_ValueChanged);
            // 
            // upDownCurrentMinutes
            // 
            this.upDownCurrentMinutes.Location = new System.Drawing.Point(81, 60);
            this.upDownCurrentMinutes.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.upDownCurrentMinutes.Name = "upDownCurrentMinutes";
            this.upDownCurrentMinutes.Size = new System.Drawing.Size(83, 39);
            this.upDownCurrentMinutes.TabIndex = 115;
            this.upDownCurrentMinutes.ValueChanged += new System.EventHandler(this.upDownCurrent_ValueChanged);
            // 
            // buttonEndLoopNow
            // 
            this.buttonEndLoopNow.Location = new System.Drawing.Point(348, 234);
            this.buttonEndLoopNow.Name = "buttonEndLoopNow";
            this.buttonEndLoopNow.Size = new System.Drawing.Size(71, 41);
            this.buttonEndLoopNow.TabIndex = 114;
            this.buttonEndLoopNow.Text = "Now";
            this.buttonEndLoopNow.UseVisualStyleBackColor = true;
            this.buttonEndLoopNow.Click += new System.EventHandler(this.buttonEndLoopNow_Click);
            // 
            // upDownEndLoopMilliseconds
            // 
            this.upDownEndLoopMilliseconds.Location = new System.Drawing.Point(259, 234);
            this.upDownEndLoopMilliseconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.upDownEndLoopMilliseconds.Name = "upDownEndLoopMilliseconds";
            this.upDownEndLoopMilliseconds.Size = new System.Drawing.Size(83, 39);
            this.upDownEndLoopMilliseconds.TabIndex = 113;
            this.upDownEndLoopMilliseconds.ValueChanged += new System.EventHandler(this.upDownEndLoopMilliseconds_ValueChanged);
            // 
            // upDownEndLoopSeconds
            // 
            this.upDownEndLoopSeconds.Location = new System.Drawing.Point(170, 234);
            this.upDownEndLoopSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.upDownEndLoopSeconds.Name = "upDownEndLoopSeconds";
            this.upDownEndLoopSeconds.Size = new System.Drawing.Size(83, 39);
            this.upDownEndLoopSeconds.TabIndex = 112;
            this.upDownEndLoopSeconds.ValueChanged += new System.EventHandler(this.upDownEndLoopSeconds_ValueChanged);
            // 
            // upDownEndLoopMinutes
            // 
            this.upDownEndLoopMinutes.Location = new System.Drawing.Point(81, 234);
            this.upDownEndLoopMinutes.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.upDownEndLoopMinutes.Name = "upDownEndLoopMinutes";
            this.upDownEndLoopMinutes.Size = new System.Drawing.Size(83, 39);
            this.upDownEndLoopMinutes.TabIndex = 111;
            this.upDownEndLoopMinutes.ValueChanged += new System.EventHandler(this.upDownEndLoopMinutes_ValueChanged);
            // 
            // labelLoopEnd
            // 
            this.labelLoopEnd.AutoSize = true;
            this.labelLoopEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoopEnd.Location = new System.Drawing.Point(8, 236);
            this.labelLoopEnd.Name = "labelLoopEnd";
            this.labelLoopEnd.Size = new System.Drawing.Size(59, 32);
            this.labelLoopEnd.TabIndex = 110;
            this.labelLoopEnd.Text = "End:";
            // 
            // buttonStartLoopNow
            // 
            this.buttonStartLoopNow.Location = new System.Drawing.Point(348, 187);
            this.buttonStartLoopNow.Name = "buttonStartLoopNow";
            this.buttonStartLoopNow.Size = new System.Drawing.Size(71, 41);
            this.buttonStartLoopNow.TabIndex = 109;
            this.buttonStartLoopNow.Text = "Now";
            this.buttonStartLoopNow.UseVisualStyleBackColor = true;
            this.buttonStartLoopNow.Click += new System.EventHandler(this.buttonStartLoopNow_Click);
            // 
            // upDownStartLoopMilliseconds
            // 
            this.upDownStartLoopMilliseconds.Location = new System.Drawing.Point(259, 187);
            this.upDownStartLoopMilliseconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.upDownStartLoopMilliseconds.Name = "upDownStartLoopMilliseconds";
            this.upDownStartLoopMilliseconds.Size = new System.Drawing.Size(83, 39);
            this.upDownStartLoopMilliseconds.TabIndex = 108;
            this.upDownStartLoopMilliseconds.ValueChanged += new System.EventHandler(this.upDownStartLoopMilliseconds_ValueChanged);
            // 
            // upDownStartLoopSeconds
            // 
            this.upDownStartLoopSeconds.Location = new System.Drawing.Point(170, 187);
            this.upDownStartLoopSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.upDownStartLoopSeconds.Name = "upDownStartLoopSeconds";
            this.upDownStartLoopSeconds.Size = new System.Drawing.Size(83, 39);
            this.upDownStartLoopSeconds.TabIndex = 107;
            this.upDownStartLoopSeconds.ValueChanged += new System.EventHandler(this.upDownStartLoopSeconds_ValueChanged);
            // 
            // upDownStartLoopMinutes
            // 
            this.upDownStartLoopMinutes.Location = new System.Drawing.Point(81, 187);
            this.upDownStartLoopMinutes.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.upDownStartLoopMinutes.Name = "upDownStartLoopMinutes";
            this.upDownStartLoopMinutes.Size = new System.Drawing.Size(83, 39);
            this.upDownStartLoopMinutes.TabIndex = 106;
            this.upDownStartLoopMinutes.ValueChanged += new System.EventHandler(this.upDownStartLoopMinutes_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 32);
            this.label2.TabIndex = 105;
            this.label2.Text = "Start:";
            // 
            // checkBoxLoop
            // 
            this.checkBoxLoop.AutoSize = true;
            this.checkBoxLoop.Location = new System.Drawing.Point(81, 140);
            this.checkBoxLoop.Name = "checkBoxLoop";
            this.checkBoxLoop.Size = new System.Drawing.Size(99, 36);
            this.checkBoxLoop.TabIndex = 0;
            this.checkBoxLoop.Text = "Loop";
            this.checkBoxLoop.UseVisualStyleBackColor = true;
            this.checkBoxLoop.CheckedChanged += new System.EventHandler(this.checkBoxLoop_CheckedChanged);
            // 
            // panelPresets
            // 
            this.panelPresets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPresets.Controls.Add(this.buttonReset);
            this.panelPresets.Controls.Add(this.buttonSavePreset);
            this.panelPresets.Controls.Add(this.labelPreset4);
            this.panelPresets.Controls.Add(this.labelPreset8);
            this.panelPresets.Controls.Add(this.buttonPreset8);
            this.panelPresets.Controls.Add(this.buttonPreset4);
            this.panelPresets.Controls.Add(this.labelPreset3);
            this.panelPresets.Controls.Add(this.labelPreset7);
            this.panelPresets.Controls.Add(this.buttonPreset7);
            this.panelPresets.Controls.Add(this.buttonPreset3);
            this.panelPresets.Controls.Add(this.labelPreset2);
            this.panelPresets.Controls.Add(this.labelPreset6);
            this.panelPresets.Controls.Add(this.buttonPreset6);
            this.panelPresets.Controls.Add(this.buttonPreset2);
            this.panelPresets.Controls.Add(this.labelPreset1);
            this.panelPresets.Controls.Add(this.labelPreset5);
            this.panelPresets.Controls.Add(this.buttonPreset5);
            this.panelPresets.Controls.Add(this.buttonPreset1);
            this.panelPresets.Location = new System.Drawing.Point(1218, 848);
            this.panelPresets.Name = "panelPresets";
            this.panelPresets.Size = new System.Drawing.Size(435, 478);
            this.panelPresets.TabIndex = 64;
            // 
            // buttonReset
            // 
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Image = ((System.Drawing.Image)(resources.GetObject("buttonReset.Image")));
            this.buttonReset.Location = new System.Drawing.Point(64, 11);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(48, 48);
            this.buttonReset.TabIndex = 126;
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSavePreset
            // 
            this.buttonSavePreset.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSavePreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSavePreset.Image = ((System.Drawing.Image)(resources.GetObject("buttonSavePreset.Image")));
            this.buttonSavePreset.Location = new System.Drawing.Point(10, 11);
            this.buttonSavePreset.Name = "buttonSavePreset";
            this.buttonSavePreset.Size = new System.Drawing.Size(48, 48);
            this.buttonSavePreset.TabIndex = 65;
            this.buttonSavePreset.UseVisualStyleBackColor = false;
            this.buttonSavePreset.Click += new System.EventHandler(this.buttonSavePreset_Click);
            // 
            // labelPreset4
            // 
            this.labelPreset4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPreset4.Location = new System.Drawing.Point(10, 233);
            this.labelPreset4.Margin = new System.Windows.Forms.Padding(0);
            this.labelPreset4.Name = "labelPreset4";
            this.labelPreset4.Size = new System.Drawing.Size(35, 32);
            this.labelPreset4.TabIndex = 125;
            this.labelPreset4.Text = "4:";
            this.labelPreset4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPreset8
            // 
            this.labelPreset8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPreset8.Location = new System.Drawing.Point(10, 426);
            this.labelPreset8.Margin = new System.Windows.Forms.Padding(0);
            this.labelPreset8.Name = "labelPreset8";
            this.labelPreset8.Size = new System.Drawing.Size(35, 32);
            this.labelPreset8.TabIndex = 124;
            this.labelPreset8.Text = "8:";
            this.labelPreset8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonPreset8
            // 
            this.buttonPreset8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreset8.Location = new System.Drawing.Point(48, 422);
            this.buttonPreset8.Name = "buttonPreset8";
            this.buttonPreset8.Size = new System.Drawing.Size(371, 41);
            this.buttonPreset8.TabIndex = 123;
            this.buttonPreset8.Text = "<Preset not defined>";
            this.buttonPreset8.UseVisualStyleBackColor = true;
            this.buttonPreset8.Click += new System.EventHandler(this.buttonPreset8_Click);
            // 
            // buttonPreset4
            // 
            this.buttonPreset4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreset4.Location = new System.Drawing.Point(48, 230);
            this.buttonPreset4.Name = "buttonPreset4";
            this.buttonPreset4.Size = new System.Drawing.Size(371, 41);
            this.buttonPreset4.TabIndex = 122;
            this.buttonPreset4.Text = "<Preset not defined>";
            this.buttonPreset4.UseVisualStyleBackColor = true;
            this.buttonPreset4.Click += new System.EventHandler(this.buttonPreset4_Click);
            // 
            // labelPreset3
            // 
            this.labelPreset3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPreset3.Location = new System.Drawing.Point(10, 186);
            this.labelPreset3.Margin = new System.Windows.Forms.Padding(0);
            this.labelPreset3.Name = "labelPreset3";
            this.labelPreset3.Size = new System.Drawing.Size(35, 32);
            this.labelPreset3.TabIndex = 121;
            this.labelPreset3.Text = "3:";
            this.labelPreset3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPreset7
            // 
            this.labelPreset7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPreset7.Location = new System.Drawing.Point(10, 379);
            this.labelPreset7.Margin = new System.Windows.Forms.Padding(0);
            this.labelPreset7.Name = "labelPreset7";
            this.labelPreset7.Size = new System.Drawing.Size(35, 32);
            this.labelPreset7.TabIndex = 120;
            this.labelPreset7.Text = "7:";
            this.labelPreset7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonPreset7
            // 
            this.buttonPreset7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreset7.Location = new System.Drawing.Point(48, 375);
            this.buttonPreset7.Name = "buttonPreset7";
            this.buttonPreset7.Size = new System.Drawing.Size(371, 41);
            this.buttonPreset7.TabIndex = 119;
            this.buttonPreset7.Text = "<Preset not defined>";
            this.buttonPreset7.UseVisualStyleBackColor = true;
            this.buttonPreset7.Click += new System.EventHandler(this.buttonPreset7_Click);
            // 
            // buttonPreset3
            // 
            this.buttonPreset3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreset3.Location = new System.Drawing.Point(48, 183);
            this.buttonPreset3.Name = "buttonPreset3";
            this.buttonPreset3.Size = new System.Drawing.Size(371, 41);
            this.buttonPreset3.TabIndex = 118;
            this.buttonPreset3.Text = "<Preset not defined>";
            this.buttonPreset3.UseVisualStyleBackColor = true;
            this.buttonPreset3.Click += new System.EventHandler(this.buttonPreset3_Click);
            // 
            // labelPreset2
            // 
            this.labelPreset2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPreset2.Location = new System.Drawing.Point(10, 139);
            this.labelPreset2.Margin = new System.Windows.Forms.Padding(0);
            this.labelPreset2.Name = "labelPreset2";
            this.labelPreset2.Size = new System.Drawing.Size(35, 32);
            this.labelPreset2.TabIndex = 117;
            this.labelPreset2.Text = "2:";
            this.labelPreset2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPreset6
            // 
            this.labelPreset6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPreset6.Location = new System.Drawing.Point(10, 332);
            this.labelPreset6.Margin = new System.Windows.Forms.Padding(0);
            this.labelPreset6.Name = "labelPreset6";
            this.labelPreset6.Size = new System.Drawing.Size(35, 32);
            this.labelPreset6.TabIndex = 116;
            this.labelPreset6.Text = "6:";
            this.labelPreset6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonPreset6
            // 
            this.buttonPreset6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreset6.Location = new System.Drawing.Point(48, 328);
            this.buttonPreset6.Name = "buttonPreset6";
            this.buttonPreset6.Size = new System.Drawing.Size(371, 41);
            this.buttonPreset6.TabIndex = 115;
            this.buttonPreset6.Text = "<Preset not defined>";
            this.buttonPreset6.UseVisualStyleBackColor = true;
            this.buttonPreset6.Click += new System.EventHandler(this.buttonPreset6_Click);
            // 
            // buttonPreset2
            // 
            this.buttonPreset2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreset2.Location = new System.Drawing.Point(48, 136);
            this.buttonPreset2.Name = "buttonPreset2";
            this.buttonPreset2.Size = new System.Drawing.Size(371, 41);
            this.buttonPreset2.TabIndex = 114;
            this.buttonPreset2.Text = "<Preset not defined>";
            this.buttonPreset2.UseVisualStyleBackColor = true;
            this.buttonPreset2.Click += new System.EventHandler(this.buttonPreset2_Click);
            // 
            // labelPreset1
            // 
            this.labelPreset1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPreset1.Location = new System.Drawing.Point(10, 91);
            this.labelPreset1.Margin = new System.Windows.Forms.Padding(0);
            this.labelPreset1.Name = "labelPreset1";
            this.labelPreset1.Size = new System.Drawing.Size(35, 32);
            this.labelPreset1.TabIndex = 113;
            this.labelPreset1.Text = "1:";
            this.labelPreset1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPreset5
            // 
            this.labelPreset5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPreset5.Location = new System.Drawing.Point(10, 284);
            this.labelPreset5.Margin = new System.Windows.Forms.Padding(0);
            this.labelPreset5.Name = "labelPreset5";
            this.labelPreset5.Size = new System.Drawing.Size(35, 32);
            this.labelPreset5.TabIndex = 112;
            this.labelPreset5.Text = "5:";
            this.labelPreset5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonPreset5
            // 
            this.buttonPreset5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreset5.Location = new System.Drawing.Point(48, 280);
            this.buttonPreset5.Name = "buttonPreset5";
            this.buttonPreset5.Size = new System.Drawing.Size(371, 41);
            this.buttonPreset5.TabIndex = 111;
            this.buttonPreset5.Text = "<Preset not defined>";
            this.buttonPreset5.UseVisualStyleBackColor = true;
            this.buttonPreset5.Click += new System.EventHandler(this.buttonPreset5_Click);
            // 
            // buttonPreset1
            // 
            this.buttonPreset1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreset1.Location = new System.Drawing.Point(48, 88);
            this.buttonPreset1.Name = "buttonPreset1";
            this.buttonPreset1.Size = new System.Drawing.Size(371, 41);
            this.buttonPreset1.TabIndex = 110;
            this.buttonPreset1.Text = "<Preset not defined>";
            this.buttonPreset1.UseVisualStyleBackColor = true;
            this.buttonPreset1.Click += new System.EventHandler(this.buttonPreset1_Click);
            // 
            // pictureBoxRenderer
            // 
            this.pictureBoxRenderer.BackColor = System.Drawing.Color.White;
            this.pictureBoxRenderer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRenderer.Location = new System.Drawing.Point(15, 126);
            this.pictureBoxRenderer.Name = "pictureBoxRenderer";
            this.pictureBoxRenderer.Size = new System.Drawing.Size(1638, 319);
            this.pictureBoxRenderer.TabIndex = 65;
            this.pictureBoxRenderer.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 1366);
            this.Controls.Add(this.pictureBoxRenderer);
            this.Controls.Add(this.panelPresets);
            this.Controls.Add(this.panelLoop);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.labelPlayDuration);
            this.Controls.Add(this.labelPlayDuration3Q);
            this.Controls.Add(this.labelPlayDuration2Q);
            this.Controls.Add(this.labelPlayDuration1Q);
            this.Controls.Add(this.labelPlayDuration0Q);
            this.Controls.Add(this.trackBarPlayTime);
            this.Controls.Add(this.labelCurrentlyPlaying);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Practice Session";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlayTime)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCue)).EndInit();
            this.toolStripChannels.ResumeLayout(false);
            this.toolStripChannels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEQHi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEQMid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEQLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTempo)).EndInit();
            this.panelLoop.ResumeLayout(false);
            this.panelLoop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCurrentMilliseconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCurrentSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCurrentMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownEndLoopMilliseconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownEndLoopSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownEndLoopMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownStartLoopMilliseconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownStartLoopSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownStartLoopMinutes)).EndInit();
            this.panelPresets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRenderer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Label labelCurrentlyPlaying;
        private System.Windows.Forms.TrackBar trackBarPlayTime;
        private System.Windows.Forms.Label labelPlayDuration0Q;
        private System.Windows.Forms.Label labelPlayDuration1Q;
        private System.Windows.Forms.Label labelPlayDuration2Q;
        private System.Windows.Forms.Label labelPlayDuration3Q;
        private System.Windows.Forms.Label labelPlayDuration;
        private System.Windows.Forms.Timer PlayTimeUpdateTimer;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecent1;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecent2;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecent3;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecent4;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecent5;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecent6;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecent7;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecent8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label labelCueSeconds;
        private System.Windows.Forms.Label labelCue;
        private System.Windows.Forms.NumericUpDown upDownCue;
        private System.Windows.Forms.ComboBox comboBoxTimeStretchProfile;
        private System.Windows.Forms.Label labelTimeStretchProfile;
        private System.Windows.Forms.Label labelEQHiValue;
        private System.Windows.Forms.Label labelVolumeValue;
        private System.Windows.Forms.Label labelSemitones;
        private System.Windows.Forms.Label labelPitchValue;
        private System.Windows.Forms.Label labelTempoValue;
        private System.Windows.Forms.CheckBox checkBoxSuppressVocals;
        private System.Windows.Forms.CheckBox checkBoxSwapLR;
        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.ToolStrip toolStripChannels;
        private System.Windows.Forms.ToolStripButton buttonChannelBoth;
        private System.Windows.Forms.ToolStripButton buttonChannelLeft;
        private System.Windows.Forms.ToolStripButton buttonChannelRight;
        private System.Windows.Forms.ToolStripButton buttonChannelDualMono;
        private System.Windows.Forms.Label labelEQMid;
        private System.Windows.Forms.TrackBar trackBarEQHi;
        private System.Windows.Forms.Label labelEQHi;
        private System.Windows.Forms.TrackBar trackBarEQMid;
        private System.Windows.Forms.Label labelEQLow;
        private System.Windows.Forms.Label labelEQMin100pc;
        private System.Windows.Forms.Label labelEQ0pc;
        private System.Windows.Forms.Label labelEQ100pc;
        private System.Windows.Forms.Label labelEqualizer;
        private System.Windows.Forms.TrackBar trackBarEQLow;
        private System.Windows.Forms.Label labelVolume25pc;
        private System.Windows.Forms.Label labelVolume75pc;
        private System.Windows.Forms.Label labelVolume0pc;
        private System.Windows.Forms.Label labelVolume50pc;
        private System.Windows.Forms.Label labelVolume100pc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label labelPitch8vb;
        private System.Windows.Forms.Label labelPitch0;
        private System.Windows.Forms.Label labelPitch8va;
        private System.Windows.Forms.Label labelPitch;
        private System.Windows.Forms.TrackBar trackBarPitch;
        private System.Windows.Forms.Label labelX15;
        private System.Windows.Forms.Label labelX05;
        private System.Windows.Forms.Label labelX01;
        private System.Windows.Forms.Label labelX10;
        private System.Windows.Forms.Label labelX20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarTempo;
        private System.Windows.Forms.Panel panelLoop;
        private System.Windows.Forms.CheckBox checkBoxLoop;
        private System.Windows.Forms.Button buttonEndLoopNow;
        private System.Windows.Forms.NumericUpDown upDownEndLoopMilliseconds;
        private System.Windows.Forms.NumericUpDown upDownEndLoopSeconds;
        private System.Windows.Forms.NumericUpDown upDownEndLoopMinutes;
        private System.Windows.Forms.Label labelLoopEnd;
        private System.Windows.Forms.Button buttonStartLoopNow;
        private System.Windows.Forms.NumericUpDown upDownStartLoopMilliseconds;
        private System.Windows.Forms.NumericUpDown upDownStartLoopSeconds;
        private System.Windows.Forms.NumericUpDown upDownStartLoopMinutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPresets;
        private System.Windows.Forms.Label labelPreset2;
        private System.Windows.Forms.Label labelPreset6;
        private System.Windows.Forms.Button buttonPreset6;
        private System.Windows.Forms.Button buttonPreset2;
        private System.Windows.Forms.Label labelPreset1;
        private System.Windows.Forms.Label labelPreset5;
        private System.Windows.Forms.Button buttonPreset5;
        private System.Windows.Forms.Button buttonPreset1;
        private System.Windows.Forms.Label labelPreset4;
        private System.Windows.Forms.Label labelPreset8;
        private System.Windows.Forms.Button buttonPreset8;
        private System.Windows.Forms.Button buttonPreset4;
        private System.Windows.Forms.Label labelPreset3;
        private System.Windows.Forms.Label labelPreset7;
        private System.Windows.Forms.Button buttonPreset7;
        private System.Windows.Forms.Button buttonPreset3;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSavePreset;
        private System.Windows.Forms.NumericUpDown upDownCurrentMilliseconds;
        private System.Windows.Forms.NumericUpDown upDownCurrentSeconds;
        private System.Windows.Forms.NumericUpDown upDownCurrentMinutes;
        private System.Windows.Forms.Label labelEQMidValue;
        private System.Windows.Forms.Label labelEQLowValue;
        private System.Windows.Forms.PictureBox pictureBoxRenderer;
        private System.Windows.Forms.Label labelPositionValue;
        private System.Windows.Forms.Label labelPosition;
    }
}