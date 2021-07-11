
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
            this.trackBarTempo = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX20 = new System.Windows.Forms.Label();
            this.labelX10 = new System.Windows.Forms.Label();
            this.labelX01 = new System.Windows.Forms.Label();
            this.labelX05 = new System.Windows.Forms.Label();
            this.labelX15 = new System.Windows.Forms.Label();
            this.labelPitch8vb = new System.Windows.Forms.Label();
            this.labelPitch0 = new System.Windows.Forms.Label();
            this.labelPitch8va = new System.Windows.Forms.Label();
            this.labelPitch = new System.Windows.Forms.Label();
            this.trackBarPitch = new System.Windows.Forms.TrackBar();
            this.labelVolume0pc = new System.Windows.Forms.Label();
            this.labelVolume50pc = new System.Windows.Forms.Label();
            this.labelVolume100pc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.labelVolume75pc = new System.Windows.Forms.Label();
            this.labelVolume25pc = new System.Windows.Forms.Label();
            this.labelEQMin100pc = new System.Windows.Forms.Label();
            this.labelEQ0pc = new System.Windows.Forms.Label();
            this.labelEQ100pc = new System.Windows.Forms.Label();
            this.labelEqualizer = new System.Windows.Forms.Label();
            this.trackBarEQLow = new System.Windows.Forms.TrackBar();
            this.labelEQLow = new System.Windows.Forms.Label();
            this.labelEQHi = new System.Windows.Forms.Label();
            this.trackBarEQMid = new System.Windows.Forms.TrackBar();
            this.labelEQMid = new System.Windows.Forms.Label();
            this.trackBarEQHi = new System.Windows.Forms.TrackBar();
            this.trackBarPlayTime = new System.Windows.Forms.TrackBar();
            this.labelPosition = new System.Windows.Forms.Label();
            this.toolStripChannels = new System.Windows.Forms.ToolStrip();
            this.buttonChannelBoth = new System.Windows.Forms.ToolStripButton();
            this.buttonChannelLeft = new System.Windows.Forms.ToolStripButton();
            this.buttonChannelRight = new System.Windows.Forms.ToolStripButton();
            this.buttonChannelDualMono = new System.Windows.Forms.ToolStripButton();
            this.labelChannel = new System.Windows.Forms.Label();
            this.checkBoxSwapLR = new System.Windows.Forms.CheckBox();
            this.checkBoxSuppressVocals = new System.Windows.Forms.CheckBox();
            this.labelTempoValue = new System.Windows.Forms.Label();
            this.labelPitchValue = new System.Windows.Forms.Label();
            this.labelSemitones = new System.Windows.Forms.Label();
            this.labelVolumeValue = new System.Windows.Forms.Label();
            this.labelEQLowValue = new System.Windows.Forms.Label();
            this.labelEQMidValue = new System.Windows.Forms.Label();
            this.labelEQHiValue = new System.Windows.Forms.Label();
            this.labelPlayDuration0Q = new System.Windows.Forms.Label();
            this.labelPlayDuration1Q = new System.Windows.Forms.Label();
            this.labelPlayDuration2Q = new System.Windows.Forms.Label();
            this.labelPlayDuration3Q = new System.Windows.Forms.Label();
            this.labelPlayDuration = new System.Windows.Forms.Label();
            this.labelPositionValue = new System.Windows.Forms.Label();
            this.PlayTimeUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.labelTimeStretchProfile = new System.Windows.Forms.Label();
            this.comboBoxTimeStretchProfile = new System.Windows.Forms.ComboBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEQLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEQMid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEQHi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlayTime)).BeginInit();
            this.toolStripChannels.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1204, 40);
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
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "All Music Files|*.mp3;*.wav;*.ogg;*.flac;*.wma;*.aiff;*.m4a|MP3 files|*.mp3|WAV f" +
    "iles|*.wav|Ogg Vorbis files|*.ogg|FLAC files|*.flac|WMA files|*.wma|AIFF files|*" +
    ".aiff|M4A files|*.m4a";
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(306, 70);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(198, 32);
            this.labelFilename.TabIndex = 2;
            this.labelFilename.Text = "<No file loaded>";
            // 
            // labelCurrentlyPlaying
            // 
            this.labelCurrentlyPlaying.AutoSize = true;
            this.labelCurrentlyPlaying.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentlyPlaying.Location = new System.Drawing.Point(80, 70);
            this.labelCurrentlyPlaying.Name = "labelCurrentlyPlaying";
            this.labelCurrentlyPlaying.Size = new System.Drawing.Size(220, 32);
            this.labelCurrentlyPlaying.TabIndex = 3;
            this.labelCurrentlyPlaying.Text = "Currently playing:";
            // 
            // trackBarTempo
            // 
            this.trackBarTempo.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.trackBarTempo.LargeChange = 0;
            this.trackBarTempo.Location = new System.Drawing.Point(96, 400);
            this.trackBarTempo.Maximum = 200;
            this.trackBarTempo.Minimum = 10;
            this.trackBarTempo.Name = "trackBarTempo";
            this.trackBarTempo.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTempo.Size = new System.Drawing.Size(90, 538);
            this.trackBarTempo.SmallChange = 2;
            this.trackBarTempo.TabIndex = 4;
            this.trackBarTempo.TickFrequency = 10;
            this.trackBarTempo.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarTempo.Value = 100;
            this.trackBarTempo.ValueChanged += new System.EventHandler(this.trackBarTempo_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(84, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tempo";
            // 
            // labelX20
            // 
            this.labelX20.AutoSize = true;
            this.labelX20.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX20.Location = new System.Drawing.Point(55, 412);
            this.labelX20.Name = "labelX20";
            this.labelX20.Size = new System.Drawing.Size(44, 25);
            this.labelX20.TabIndex = 6;
            this.labelX20.Text = "x2.0";
            this.labelX20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            this.labelX10.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX10.Location = new System.Drawing.Point(55, 667);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(44, 25);
            this.labelX10.TabIndex = 7;
            this.labelX10.Text = "x1.0";
            this.labelX10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelX01
            // 
            this.labelX01.AutoSize = true;
            this.labelX01.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX01.Location = new System.Drawing.Point(55, 900);
            this.labelX01.Name = "labelX01";
            this.labelX01.Size = new System.Drawing.Size(44, 25);
            this.labelX01.TabIndex = 8;
            this.labelX01.Text = "x0.1";
            this.labelX01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelX05
            // 
            this.labelX05.AutoSize = true;
            this.labelX05.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX05.Location = new System.Drawing.Point(55, 784);
            this.labelX05.Name = "labelX05";
            this.labelX05.Size = new System.Drawing.Size(44, 25);
            this.labelX05.TabIndex = 9;
            this.labelX05.Text = "x0.5";
            this.labelX05.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelX15
            // 
            this.labelX15.AutoSize = true;
            this.labelX15.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelX15.Location = new System.Drawing.Point(55, 528);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(44, 25);
            this.labelX15.TabIndex = 10;
            this.labelX15.Text = "x1.5";
            this.labelX15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPitch8vb
            // 
            this.labelPitch8vb.AutoSize = true;
            this.labelPitch8vb.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPitch8vb.Location = new System.Drawing.Point(219, 900);
            this.labelPitch8vb.Name = "labelPitch8vb";
            this.labelPitch8vb.Size = new System.Drawing.Size(42, 25);
            this.labelPitch8vb.TabIndex = 15;
            this.labelPitch8vb.Text = "8vb";
            this.labelPitch8vb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPitch0
            // 
            this.labelPitch0.AutoSize = true;
            this.labelPitch0.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPitch0.Location = new System.Drawing.Point(219, 655);
            this.labelPitch0.Name = "labelPitch0";
            this.labelPitch0.Size = new System.Drawing.Size(22, 25);
            this.labelPitch0.TabIndex = 14;
            this.labelPitch0.Text = "0";
            this.labelPitch0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPitch8va
            // 
            this.labelPitch8va.AutoSize = true;
            this.labelPitch8va.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPitch8va.Location = new System.Drawing.Point(219, 412);
            this.labelPitch8va.Name = "labelPitch8va";
            this.labelPitch8va.Size = new System.Drawing.Size(40, 25);
            this.labelPitch8va.TabIndex = 13;
            this.labelPitch8va.Text = "8va";
            this.labelPitch8va.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPitch
            // 
            this.labelPitch.AutoSize = true;
            this.labelPitch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPitch.Location = new System.Drawing.Point(260, 365);
            this.labelPitch.Name = "labelPitch";
            this.labelPitch.Size = new System.Drawing.Size(71, 32);
            this.labelPitch.TabIndex = 12;
            this.labelPitch.Text = "Pitch";
            // 
            // trackBarPitch
            // 
            this.trackBarPitch.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.trackBarPitch.LargeChange = 0;
            this.trackBarPitch.Location = new System.Drawing.Point(260, 400);
            this.trackBarPitch.Maximum = 96;
            this.trackBarPitch.Minimum = -96;
            this.trackBarPitch.Name = "trackBarPitch";
            this.trackBarPitch.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarPitch.Size = new System.Drawing.Size(90, 538);
            this.trackBarPitch.SmallChange = 2;
            this.trackBarPitch.TabIndex = 11;
            this.trackBarPitch.TickFrequency = 8;
            this.trackBarPitch.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarPitch.ValueChanged += new System.EventHandler(this.trackBarPitch_ValueChanged);
            // 
            // labelVolume0pc
            // 
            this.labelVolume0pc.AutoSize = true;
            this.labelVolume0pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolume0pc.Location = new System.Drawing.Point(451, 900);
            this.labelVolume0pc.Name = "labelVolume0pc";
            this.labelVolume0pc.Size = new System.Drawing.Size(37, 25);
            this.labelVolume0pc.TabIndex = 20;
            this.labelVolume0pc.Text = "0%";
            this.labelVolume0pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVolume50pc
            // 
            this.labelVolume50pc.AutoSize = true;
            this.labelVolume50pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolume50pc.Location = new System.Drawing.Point(441, 655);
            this.labelVolume50pc.Name = "labelVolume50pc";
            this.labelVolume50pc.Size = new System.Drawing.Size(47, 25);
            this.labelVolume50pc.TabIndex = 19;
            this.labelVolume50pc.Text = "50%";
            this.labelVolume50pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVolume100pc
            // 
            this.labelVolume100pc.AutoSize = true;
            this.labelVolume100pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolume100pc.Location = new System.Drawing.Point(431, 412);
            this.labelVolume100pc.Name = "labelVolume100pc";
            this.labelVolume100pc.Size = new System.Drawing.Size(57, 25);
            this.labelVolume100pc.TabIndex = 18;
            this.labelVolume100pc.Text = "100%";
            this.labelVolume100pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(461, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Volume";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.trackBarVolume.Location = new System.Drawing.Point(482, 400);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.Size = new System.Drawing.Size(90, 538);
            this.trackBarVolume.TabIndex = 16;
            this.trackBarVolume.TickFrequency = 10;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarVolume.Value = 75;
            this.trackBarVolume.ValueChanged += new System.EventHandler(this.trackBarVolume_ValueChanged);
            // 
            // labelVolume75pc
            // 
            this.labelVolume75pc.AutoSize = true;
            this.labelVolume75pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolume75pc.Location = new System.Drawing.Point(441, 528);
            this.labelVolume75pc.Name = "labelVolume75pc";
            this.labelVolume75pc.Size = new System.Drawing.Size(47, 25);
            this.labelVolume75pc.TabIndex = 21;
            this.labelVolume75pc.Text = "75%";
            this.labelVolume75pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVolume25pc
            // 
            this.labelVolume25pc.AutoSize = true;
            this.labelVolume25pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolume25pc.Location = new System.Drawing.Point(441, 775);
            this.labelVolume25pc.Name = "labelVolume25pc";
            this.labelVolume25pc.Size = new System.Drawing.Size(47, 25);
            this.labelVolume25pc.TabIndex = 22;
            this.labelVolume25pc.Text = "25%";
            this.labelVolume25pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEQMin100pc
            // 
            this.labelEQMin100pc.AutoSize = true;
            this.labelEQMin100pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEQMin100pc.Location = new System.Drawing.Point(630, 900);
            this.labelEQMin100pc.Name = "labelEQMin100pc";
            this.labelEQMin100pc.Size = new System.Drawing.Size(64, 25);
            this.labelEQMin100pc.TabIndex = 27;
            this.labelEQMin100pc.Text = "-100%";
            this.labelEQMin100pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEQ0pc
            // 
            this.labelEQ0pc.AutoSize = true;
            this.labelEQ0pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEQ0pc.Location = new System.Drawing.Point(657, 655);
            this.labelEQ0pc.Name = "labelEQ0pc";
            this.labelEQ0pc.Size = new System.Drawing.Size(37, 25);
            this.labelEQ0pc.TabIndex = 26;
            this.labelEQ0pc.Text = "0%";
            this.labelEQ0pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEQ100pc
            // 
            this.labelEQ100pc.AutoSize = true;
            this.labelEQ100pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEQ100pc.Location = new System.Drawing.Point(637, 412);
            this.labelEQ100pc.Name = "labelEQ100pc";
            this.labelEQ100pc.Size = new System.Drawing.Size(57, 25);
            this.labelEQ100pc.TabIndex = 25;
            this.labelEQ100pc.Text = "100%";
            this.labelEQ100pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEqualizer
            // 
            this.labelEqualizer.AutoSize = true;
            this.labelEqualizer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEqualizer.Location = new System.Drawing.Point(729, 333);
            this.labelEqualizer.Name = "labelEqualizer";
            this.labelEqualizer.Size = new System.Drawing.Size(119, 32);
            this.labelEqualizer.TabIndex = 24;
            this.labelEqualizer.Text = "Equalizer";
            // 
            // trackBarEQLow
            // 
            this.trackBarEQLow.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.trackBarEQLow.LargeChange = 10;
            this.trackBarEQLow.Location = new System.Drawing.Point(688, 400);
            this.trackBarEQLow.Maximum = 100;
            this.trackBarEQLow.Minimum = -100;
            this.trackBarEQLow.Name = "trackBarEQLow";
            this.trackBarEQLow.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEQLow.Size = new System.Drawing.Size(90, 538);
            this.trackBarEQLow.SmallChange = 5;
            this.trackBarEQLow.TabIndex = 23;
            this.trackBarEQLow.TickFrequency = 20;
            this.trackBarEQLow.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEQLow.ValueChanged += new System.EventHandler(this.trackBarEQLow_ValueChanged);
            // 
            // labelEQLow
            // 
            this.labelEQLow.AutoSize = true;
            this.labelEQLow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEQLow.Location = new System.Drawing.Point(688, 365);
            this.labelEQLow.Name = "labelEQLow";
            this.labelEQLow.Size = new System.Drawing.Size(60, 32);
            this.labelEQLow.TabIndex = 30;
            this.labelEQLow.Text = "Low";
            // 
            // labelEQHi
            // 
            this.labelEQHi.AutoSize = true;
            this.labelEQHi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEQHi.Location = new System.Drawing.Point(840, 365);
            this.labelEQHi.Name = "labelEQHi";
            this.labelEQHi.Size = new System.Drawing.Size(39, 32);
            this.labelEQHi.TabIndex = 32;
            this.labelEQHi.Text = "Hi";
            // 
            // trackBarEQMid
            // 
            this.trackBarEQMid.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.trackBarEQMid.LargeChange = 10;
            this.trackBarEQMid.Location = new System.Drawing.Point(758, 400);
            this.trackBarEQMid.Maximum = 100;
            this.trackBarEQMid.Minimum = -100;
            this.trackBarEQMid.Name = "trackBarEQMid";
            this.trackBarEQMid.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEQMid.Size = new System.Drawing.Size(90, 538);
            this.trackBarEQMid.SmallChange = 5;
            this.trackBarEQMid.TabIndex = 31;
            this.trackBarEQMid.TickFrequency = 20;
            this.trackBarEQMid.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEQMid.ValueChanged += new System.EventHandler(this.trackBarEQMid_ValueChanged);
            // 
            // labelEQMid
            // 
            this.labelEQMid.AutoSize = true;
            this.labelEQMid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEQMid.Location = new System.Drawing.Point(763, 365);
            this.labelEQMid.Name = "labelEQMid";
            this.labelEQMid.Size = new System.Drawing.Size(59, 32);
            this.labelEQMid.TabIndex = 34;
            this.labelEQMid.Text = "Mid";
            // 
            // trackBarEQHi
            // 
            this.trackBarEQHi.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.trackBarEQHi.LargeChange = 10;
            this.trackBarEQHi.Location = new System.Drawing.Point(829, 400);
            this.trackBarEQHi.Maximum = 100;
            this.trackBarEQHi.Minimum = -100;
            this.trackBarEQHi.Name = "trackBarEQHi";
            this.trackBarEQHi.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarEQHi.Size = new System.Drawing.Size(90, 538);
            this.trackBarEQHi.SmallChange = 5;
            this.trackBarEQHi.TabIndex = 33;
            this.trackBarEQHi.TickFrequency = 20;
            this.trackBarEQHi.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarEQHi.ValueChanged += new System.EventHandler(this.trackBarEQHi_ValueChanged);
            // 
            // trackBarPlayTime
            // 
            this.trackBarPlayTime.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trackBarPlayTime.LargeChange = 0;
            this.trackBarPlayTime.Location = new System.Drawing.Point(12, 240);
            this.trackBarPlayTime.Maximum = 100;
            this.trackBarPlayTime.Name = "trackBarPlayTime";
            this.trackBarPlayTime.Size = new System.Drawing.Size(1168, 90);
            this.trackBarPlayTime.SmallChange = 5;
            this.trackBarPlayTime.TabIndex = 35;
            this.trackBarPlayTime.TickFrequency = 5;
            this.trackBarPlayTime.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarPlayTime.ValueChanged += new System.EventHandler(this.trackBarPlayTime_ValueChanged);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPosition.Location = new System.Drawing.Point(80, 145);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(114, 32);
            this.labelPosition.TabIndex = 36;
            this.labelPosition.Text = "Position:";
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
            this.toolStripChannels.Location = new System.Drawing.Point(965, 412);
            this.toolStripChannels.Name = "toolStripChannels";
            this.toolStripChannels.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripChannels.Size = new System.Drawing.Size(96, 170);
            this.toolStripChannels.TabIndex = 37;
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
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelChannel.Location = new System.Drawing.Point(955, 365);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(106, 32);
            this.labelChannel.TabIndex = 38;
            this.labelChannel.Text = "Channel";
            // 
            // checkBoxSwapLR
            // 
            this.checkBoxSwapLR.AutoSize = true;
            this.checkBoxSwapLR.Location = new System.Drawing.Point(965, 847);
            this.checkBoxSwapLR.Name = "checkBoxSwapLR";
            this.checkBoxSwapLR.Size = new System.Drawing.Size(143, 36);
            this.checkBoxSwapLR.TabIndex = 39;
            this.checkBoxSwapLR.Text = "Swap L/R";
            this.checkBoxSwapLR.UseVisualStyleBackColor = true;
            this.checkBoxSwapLR.CheckedChanged += new System.EventHandler(this.checkBoxSwapLR_CheckedChanged);
            // 
            // checkBoxSuppressVocals
            // 
            this.checkBoxSuppressVocals.AutoSize = true;
            this.checkBoxSuppressVocals.Location = new System.Drawing.Point(965, 889);
            this.checkBoxSuppressVocals.Name = "checkBoxSuppressVocals";
            this.checkBoxSuppressVocals.Size = new System.Drawing.Size(215, 36);
            this.checkBoxSuppressVocals.TabIndex = 40;
            this.checkBoxSuppressVocals.Text = "Suppress Vocals";
            this.checkBoxSuppressVocals.UseVisualStyleBackColor = true;
            this.checkBoxSuppressVocals.CheckedChanged += new System.EventHandler(this.checkBoxSuppressVocals_CheckedChanged);
            // 
            // labelTempoValue
            // 
            this.labelTempoValue.Location = new System.Drawing.Point(96, 925);
            this.labelTempoValue.Name = "labelTempoValue";
            this.labelTempoValue.Size = new System.Drawing.Size(70, 32);
            this.labelTempoValue.TabIndex = 41;
            this.labelTempoValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPitchValue
            // 
            this.labelPitchValue.Location = new System.Drawing.Point(260, 925);
            this.labelPitchValue.Name = "labelPitchValue";
            this.labelPitchValue.Size = new System.Drawing.Size(70, 32);
            this.labelPitchValue.TabIndex = 42;
            this.labelPitchValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSemitones
            // 
            this.labelSemitones.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSemitones.Location = new System.Drawing.Point(243, 957);
            this.labelSemitones.Name = "labelSemitones";
            this.labelSemitones.Size = new System.Drawing.Size(107, 32);
            this.labelSemitones.TabIndex = 43;
            this.labelSemitones.Text = "Semi-tones";
            this.labelSemitones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelVolumeValue
            // 
            this.labelVolumeValue.Location = new System.Drawing.Point(482, 925);
            this.labelVolumeValue.Name = "labelVolumeValue";
            this.labelVolumeValue.Size = new System.Drawing.Size(70, 32);
            this.labelVolumeValue.TabIndex = 44;
            this.labelVolumeValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelEQLowValue
            // 
            this.labelEQLowValue.Location = new System.Drawing.Point(688, 925);
            this.labelEQLowValue.Name = "labelEQLowValue";
            this.labelEQLowValue.Size = new System.Drawing.Size(70, 32);
            this.labelEQLowValue.TabIndex = 45;
            this.labelEQLowValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelEQMidValue
            // 
            this.labelEQMidValue.Location = new System.Drawing.Point(753, 925);
            this.labelEQMidValue.Name = "labelEQMidValue";
            this.labelEQMidValue.Size = new System.Drawing.Size(70, 32);
            this.labelEQMidValue.TabIndex = 46;
            this.labelEQMidValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelEQHiValue
            // 
            this.labelEQHiValue.Location = new System.Drawing.Point(829, 925);
            this.labelEQHiValue.Name = "labelEQHiValue";
            this.labelEQHiValue.Size = new System.Drawing.Size(70, 32);
            this.labelEQHiValue.TabIndex = 47;
            this.labelEQHiValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPlayDuration0Q
            // 
            this.labelPlayDuration0Q.AutoSize = true;
            this.labelPlayDuration0Q.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayDuration0Q.Location = new System.Drawing.Point(12, 212);
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
            this.labelPlayDuration1Q.Location = new System.Drawing.Point(294, 212);
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
            this.labelPlayDuration2Q.Location = new System.Drawing.Point(575, 212);
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
            this.labelPlayDuration3Q.Location = new System.Drawing.Point(853, 212);
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
            this.labelPlayDuration.Location = new System.Drawing.Point(1134, 212);
            this.labelPlayDuration.Name = "labelPlayDuration";
            this.labelPlayDuration.Size = new System.Drawing.Size(56, 25);
            this.labelPlayDuration.TabIndex = 52;
            this.labelPlayDuration.Text = "00:00";
            this.labelPlayDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPositionValue
            // 
            this.labelPositionValue.AutoSize = true;
            this.labelPositionValue.Location = new System.Drawing.Point(220, 145);
            this.labelPositionValue.Name = "labelPositionValue";
            this.labelPositionValue.Size = new System.Drawing.Size(125, 32);
            this.labelPositionValue.TabIndex = 53;
            this.labelPositionValue.Text = "0:00 / 0:00";
            this.labelPositionValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlayTimeUpdateTimer
            // 
            this.PlayTimeUpdateTimer.Interval = 50;
            this.PlayTimeUpdateTimer.Tick += new System.EventHandler(this.PlayTimeUpdateTimer_Tick);
            // 
            // labelTimeStretchProfile
            // 
            this.labelTimeStretchProfile.AutoSize = true;
            this.labelTimeStretchProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTimeStretchProfile.Location = new System.Drawing.Point(21, 1005);
            this.labelTimeStretchProfile.Name = "labelTimeStretchProfile";
            this.labelTimeStretchProfile.Size = new System.Drawing.Size(97, 32);
            this.labelTimeStretchProfile.TabIndex = 54;
            this.labelTimeStretchProfile.Text = "Profile:";
            // 
            // comboBoxTimeStretchProfile
            // 
            this.comboBoxTimeStretchProfile.FormattingEnabled = true;
            this.comboBoxTimeStretchProfile.Location = new System.Drawing.Point(135, 1005);
            this.comboBoxTimeStretchProfile.Name = "comboBoxTimeStretchProfile";
            this.comboBoxTimeStretchProfile.Size = new System.Drawing.Size(404, 40);
            this.comboBoxTimeStretchProfile.TabIndex = 55;
            this.comboBoxTimeStretchProfile.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeStretchProfile_SelectedIndexChanged);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.Image")));
            this.buttonOpenFile.Location = new System.Drawing.Point(11, 58);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(57, 57);
            this.buttonOpenFile.TabIndex = 56;
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.Location = new System.Drawing.Point(10, 133);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(57, 57);
            this.buttonPlay.TabIndex = 57;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 1090);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.comboBoxTimeStretchProfile);
            this.Controls.Add(this.labelTimeStretchProfile);
            this.Controls.Add(this.labelPositionValue);
            this.Controls.Add(this.labelPlayDuration);
            this.Controls.Add(this.labelPlayDuration3Q);
            this.Controls.Add(this.labelPlayDuration2Q);
            this.Controls.Add(this.labelPlayDuration1Q);
            this.Controls.Add(this.labelPlayDuration0Q);
            this.Controls.Add(this.labelEQHiValue);
            this.Controls.Add(this.labelEQMidValue);
            this.Controls.Add(this.labelEQLowValue);
            this.Controls.Add(this.labelVolumeValue);
            this.Controls.Add(this.labelSemitones);
            this.Controls.Add(this.labelPitchValue);
            this.Controls.Add(this.labelTempoValue);
            this.Controls.Add(this.checkBoxSuppressVocals);
            this.Controls.Add(this.checkBoxSwapLR);
            this.Controls.Add(this.labelChannel);
            this.Controls.Add(this.toolStripChannels);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.trackBarPlayTime);
            this.Controls.Add(this.labelEQMid);
            this.Controls.Add(this.trackBarEQHi);
            this.Controls.Add(this.labelEQHi);
            this.Controls.Add(this.trackBarEQMid);
            this.Controls.Add(this.labelEQLow);
            this.Controls.Add(this.labelEQMin100pc);
            this.Controls.Add(this.labelEQ0pc);
            this.Controls.Add(this.labelEQ100pc);
            this.Controls.Add(this.labelEqualizer);
            this.Controls.Add(this.trackBarEQLow);
            this.Controls.Add(this.labelVolume25pc);
            this.Controls.Add(this.labelVolume75pc);
            this.Controls.Add(this.labelVolume0pc);
            this.Controls.Add(this.labelVolume50pc);
            this.Controls.Add(this.labelVolume100pc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.labelPitch8vb);
            this.Controls.Add(this.labelPitch0);
            this.Controls.Add(this.labelPitch8va);
            this.Controls.Add(this.labelPitch);
            this.Controls.Add(this.trackBarPitch);
            this.Controls.Add(this.labelX15);
            this.Controls.Add(this.labelX05);
            this.Controls.Add(this.labelX01);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX20);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarTempo);
            this.Controls.Add(this.labelCurrentlyPlaying);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Practice Session";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEQLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEQMid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEQHi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlayTime)).EndInit();
            this.toolStripChannels.ResumeLayout(false);
            this.toolStripChannels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Label labelCurrentlyPlaying;
        private System.Windows.Forms.TrackBar trackBarTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX20;
        private System.Windows.Forms.Label labelX10;
        private System.Windows.Forms.Label labelX01;
        private System.Windows.Forms.Label labelX05;
        private System.Windows.Forms.Label labelX15;
        private System.Windows.Forms.Label labelPitch8vb;
        private System.Windows.Forms.Label labelPitch0;
        private System.Windows.Forms.Label labelPitch8va;
        private System.Windows.Forms.Label labelPitch;
        private System.Windows.Forms.TrackBar trackBarPitch;
        private System.Windows.Forms.Label labelVolume0pc;
        private System.Windows.Forms.Label labelVolume50pc;
        private System.Windows.Forms.Label labelVolume100pc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label labelVolume75pc;
        private System.Windows.Forms.Label labelVolume25pc;
        private System.Windows.Forms.Label labelEQMin100pc;
        private System.Windows.Forms.Label labelEQ0pc;
        private System.Windows.Forms.Label labelEQ100pc;
        private System.Windows.Forms.Label labelEqualizer;
        private System.Windows.Forms.TrackBar trackBarEQLow;
        private System.Windows.Forms.Label labelEQLow;
        private System.Windows.Forms.Label labelEQHi;
        private System.Windows.Forms.TrackBar trackBarEQMid;
        private System.Windows.Forms.Label labelEQMid;
        private System.Windows.Forms.TrackBar trackBarEQHi;
        private System.Windows.Forms.TrackBar trackBarPlayTime;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ToolStrip toolStripChannels;
        private System.Windows.Forms.ToolStripButton buttonChannelBoth;
        private System.Windows.Forms.ToolStripButton buttonChannelLeft;
        private System.Windows.Forms.ToolStripButton buttonChannelRight;
        private System.Windows.Forms.ToolStripButton buttonChannelDualMono;
        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.CheckBox checkBoxSwapLR;
        private System.Windows.Forms.CheckBox checkBoxSuppressVocals;
        private System.Windows.Forms.Label labelTempoValue;
        private System.Windows.Forms.Label labelPitchValue;
        private System.Windows.Forms.Label labelSemitones;
        private System.Windows.Forms.Label labelVolumeValue;
        private System.Windows.Forms.Label labelEQLowValue;
        private System.Windows.Forms.Label labelEQMidValue;
        private System.Windows.Forms.Label labelEQHiValue;
        private System.Windows.Forms.Label labelPlayDuration0Q;
        private System.Windows.Forms.Label labelPlayDuration1Q;
        private System.Windows.Forms.Label labelPlayDuration2Q;
        private System.Windows.Forms.Label labelPlayDuration3Q;
        private System.Windows.Forms.Label labelPlayDuration;
        private System.Windows.Forms.Label labelPositionValue;
        private System.Windows.Forms.Timer PlayTimeUpdateTimer;
        private System.Windows.Forms.Label labelTimeStretchProfile;
        private System.Windows.Forms.ComboBox comboBoxTimeStretchProfile;
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
    }
}