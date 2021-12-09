
using System;
using System.Windows.Forms;

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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelFilename = new System.Windows.Forms.Label();
            this.labelCurrentlyPlaying = new System.Windows.Forms.Label();
            this.labelPlayDuration0Q = new System.Windows.Forms.Label();
            this.labelPlayDuration1Q = new System.Windows.Forms.Label();
            this.labelPlayDuration2Q = new System.Windows.Forms.Label();
            this.labelPlayDuration3Q = new System.Windows.Forms.Label();
            this.labelPlayDuration = new System.Windows.Forms.Label();
            this.PlayTimeUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.Panel();
            this.labelChannel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripChannels = new DarkUI.Controls.DarkToolStrip();
            this.buttonChannelBoth = new System.Windows.Forms.ToolStripButton();
            this.buttonChannelLeft = new System.Windows.Forms.ToolStripButton();
            this.buttonChannelRight = new System.Windows.Forms.ToolStripButton();
            this.buttonChannelDualMono = new System.Windows.Forms.ToolStripButton();
            this.comboBoxTimeStretchProfile = new DarkUI.Controls.DarkComboBox();
            this.upDownCue = new DarkUI.Controls.DarkNumericUpDown();
            this.sliderEQHi = new MediaSlider.MediaSlider();
            this.sliderEQMid = new MediaSlider.MediaSlider();
            this.sliderEQLow = new MediaSlider.MediaSlider();
            this.sliderVolume = new MediaSlider.MediaSlider();
            this.sliderPitch = new MediaSlider.MediaSlider();
            this.sliderTempo = new MediaSlider.MediaSlider();
            this.labelEQMidValue = new System.Windows.Forms.Label();
            this.labelEQLowValue = new System.Windows.Forms.Label();
            this.labelCueSeconds = new System.Windows.Forms.Label();
            this.labelCue = new System.Windows.Forms.Label();
            this.labelTimeStretchProfile = new System.Windows.Forms.Label();
            this.labelEQHiValue = new System.Windows.Forms.Label();
            this.labelVolumeValue = new System.Windows.Forms.Label();
            this.labelSemitones = new System.Windows.Forms.Label();
            this.labelPitchValue = new System.Windows.Forms.Label();
            this.labelTempoValue = new System.Windows.Forms.Label();
            this.checkBoxSuppressVocals = new System.Windows.Forms.CheckBox();
            this.checkBoxSwapLR = new System.Windows.Forms.CheckBox();
            this.labelEQMid = new System.Windows.Forms.Label();
            this.labelEQHi = new System.Windows.Forms.Label();
            this.labelEQLow = new System.Windows.Forms.Label();
            this.labelEQMin100pc = new System.Windows.Forms.Label();
            this.labelEQ0pc = new System.Windows.Forms.Label();
            this.labelEQ100pc = new System.Windows.Forms.Label();
            this.labelEqualizer = new System.Windows.Forms.Label();
            this.labelVolume25pc = new System.Windows.Forms.Label();
            this.labelVolume75pc = new System.Windows.Forms.Label();
            this.labelVolume0pc = new System.Windows.Forms.Label();
            this.labelVolume50pc = new System.Windows.Forms.Label();
            this.labelVolume100pc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPitch8vb = new System.Windows.Forms.Label();
            this.labelPitch0 = new System.Windows.Forms.Label();
            this.labelPitch8va = new System.Windows.Forms.Label();
            this.labelPitch = new System.Windows.Forms.Label();
            this.labelX15 = new System.Windows.Forms.Label();
            this.labelX05 = new System.Windows.Forms.Label();
            this.labelX01 = new System.Windows.Forms.Label();
            this.labelX10 = new System.Windows.Forms.Label();
            this.labelX20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.overlayPosition = new System.Windows.Forms.Label();
            this.panelLoop = new System.Windows.Forms.Panel();
            this.buttonEndLoopNow = new DarkUI.Controls.DarkButton();
            this.buttonStartLoopNow = new DarkUI.Controls.DarkButton();
            this.upDownEndLoopMilliseconds = new DarkUI.Controls.DarkNumericUpDown();
            this.upDownEndLoopSeconds = new DarkUI.Controls.DarkNumericUpDown();
            this.upDownEndLoopMinutes = new DarkUI.Controls.DarkNumericUpDown();
            this.upDownStartLoopMilliseconds = new DarkUI.Controls.DarkNumericUpDown();
            this.upDownStartLoopSeconds = new DarkUI.Controls.DarkNumericUpDown();
            this.upDownStartLoopMinutes = new DarkUI.Controls.DarkNumericUpDown();
            this.upDownCurrentMilliseconds = new DarkUI.Controls.DarkNumericUpDown();
            this.upDownCurrentSeconds = new DarkUI.Controls.DarkNumericUpDown();
            this.upDownCurrentMinutes = new DarkUI.Controls.DarkNumericUpDown();
            this.labelPositionValue = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelLoopEnd = new System.Windows.Forms.Label();
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
            this.sliderPlayTime = new MediaSlider.MediaSlider();
            this.menuStrip = new DarkUI.Controls.DarkMenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecent1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecent2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecent3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecent4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecent5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecent6 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecent7 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecent8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControls.SuspendLayout();
            this.toolStripChannels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCue)).BeginInit();
            this.panelLoop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownEndLoopMilliseconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownEndLoopSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownEndLoopMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownStartLoopMilliseconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownStartLoopSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownStartLoopMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCurrentMilliseconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCurrentSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCurrentMinutes)).BeginInit();
            this.panelPresets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRenderer)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.labelFilename.BackColor = System.Drawing.Color.Transparent;
            this.labelFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
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
            this.labelCurrentlyPlaying.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentlyPlaying.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentlyPlaying.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelCurrentlyPlaying.Location = new System.Drawing.Point(138, 70);
            this.labelCurrentlyPlaying.Name = "labelCurrentlyPlaying";
            this.labelCurrentlyPlaying.Size = new System.Drawing.Size(220, 32);
            this.labelCurrentlyPlaying.TabIndex = 3;
            this.labelCurrentlyPlaying.Text = "Currently playing:";
            this.labelCurrentlyPlaying.Click += new System.EventHandler(this.labelCurrentlyPlaying_Click);
            // 
            // labelPlayDuration0Q
            // 
            this.labelPlayDuration0Q.AutoSize = true;
            this.labelPlayDuration0Q.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayDuration0Q.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelPlayDuration0Q.Location = new System.Drawing.Point(7, 485);
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
            this.labelPlayDuration1Q.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelPlayDuration1Q.Location = new System.Drawing.Point(401, 485);
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
            this.labelPlayDuration2Q.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelPlayDuration2Q.Location = new System.Drawing.Point(807, 485);
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
            this.labelPlayDuration3Q.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelPlayDuration3Q.Location = new System.Drawing.Point(1208, 485);
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
            this.labelPlayDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelPlayDuration.Location = new System.Drawing.Point(1612, 485);
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
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControls.Controls.Add(this.labelChannel);
            this.panelControls.Controls.Add(this.label4);
            this.panelControls.Controls.Add(this.label3);
            this.panelControls.Controls.Add(this.toolStripChannels);
            this.panelControls.Controls.Add(this.comboBoxTimeStretchProfile);
            this.panelControls.Controls.Add(this.upDownCue);
            this.panelControls.Controls.Add(this.sliderEQHi);
            this.panelControls.Controls.Add(this.sliderEQMid);
            this.panelControls.Controls.Add(this.sliderEQLow);
            this.panelControls.Controls.Add(this.sliderVolume);
            this.panelControls.Controls.Add(this.sliderPitch);
            this.panelControls.Controls.Add(this.sliderTempo);
            this.panelControls.Controls.Add(this.labelEQMidValue);
            this.panelControls.Controls.Add(this.labelEQLowValue);
            this.panelControls.Controls.Add(this.labelCueSeconds);
            this.panelControls.Controls.Add(this.labelCue);
            this.panelControls.Controls.Add(this.labelTimeStretchProfile);
            this.panelControls.Controls.Add(this.labelEQHiValue);
            this.panelControls.Controls.Add(this.labelVolumeValue);
            this.panelControls.Controls.Add(this.labelSemitones);
            this.panelControls.Controls.Add(this.labelPitchValue);
            this.panelControls.Controls.Add(this.labelTempoValue);
            this.panelControls.Controls.Add(this.checkBoxSuppressVocals);
            this.panelControls.Controls.Add(this.checkBoxSwapLR);
            this.panelControls.Controls.Add(this.labelEQMid);
            this.panelControls.Controls.Add(this.labelEQHi);
            this.panelControls.Controls.Add(this.labelEQLow);
            this.panelControls.Controls.Add(this.labelEQMin100pc);
            this.panelControls.Controls.Add(this.labelEQ0pc);
            this.panelControls.Controls.Add(this.labelEQ100pc);
            this.panelControls.Controls.Add(this.labelEqualizer);
            this.panelControls.Controls.Add(this.labelVolume25pc);
            this.panelControls.Controls.Add(this.labelVolume75pc);
            this.panelControls.Controls.Add(this.labelVolume0pc);
            this.panelControls.Controls.Add(this.labelVolume50pc);
            this.panelControls.Controls.Add(this.labelVolume100pc);
            this.panelControls.Controls.Add(this.label5);
            this.panelControls.Controls.Add(this.labelPitch8vb);
            this.panelControls.Controls.Add(this.labelPitch0);
            this.panelControls.Controls.Add(this.labelPitch8va);
            this.panelControls.Controls.Add(this.labelPitch);
            this.panelControls.Controls.Add(this.labelX15);
            this.panelControls.Controls.Add(this.labelX05);
            this.panelControls.Controls.Add(this.labelX01);
            this.panelControls.Controls.Add(this.labelX10);
            this.panelControls.Controls.Add(this.labelX20);
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Location = new System.Drawing.Point(15, 515);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1197, 776);
            this.panelControls.TabIndex = 62;
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelChannel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelChannel.Location = new System.Drawing.Point(964, 60);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(106, 32);
            this.labelChannel.TabIndex = 92;
            this.labelChannel.Text = "Channel";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(956, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 117;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(943, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 64);
            this.label3.TabIndex = 116;
            // 
            // toolStripChannels
            // 
            this.toolStripChannels.AutoSize = false;
            this.toolStripChannels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripChannels.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripChannels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripChannels.ImageScalingSize = new System.Drawing.Size(93, 36);
            this.toolStripChannels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonChannelBoth,
            this.buttonChannelLeft,
            this.buttonChannelRight,
            this.buttonChannelDualMono});
            this.toolStripChannels.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStripChannels.Location = new System.Drawing.Point(966, 82);
            this.toolStripChannels.Name = "toolStripChannels";
            this.toolStripChannels.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.toolStripChannels.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripChannels.Size = new System.Drawing.Size(104, 198);
            this.toolStripChannels.TabIndex = 115;
            this.toolStripChannels.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripChannels_ItemClicked);
            // 
            // buttonChannelBoth
            // 
            this.buttonChannelBoth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buttonChannelBoth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonChannelBoth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonChannelBoth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonChannelBoth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonChannelBoth.Name = "buttonChannelBoth";
            this.buttonChannelBoth.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.buttonChannelBoth.Size = new System.Drawing.Size(24, 24);
            this.buttonChannelBoth.Text = "BOTH";
            this.buttonChannelBoth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonChannelLeft
            // 
            this.buttonChannelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buttonChannelLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonChannelLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonChannelLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonChannelLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonChannelLeft.Name = "buttonChannelLeft";
            this.buttonChannelLeft.Size = new System.Drawing.Size(24, 24);
            this.buttonChannelLeft.Text = "LEFT";
            this.buttonChannelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonChannelRight
            // 
            this.buttonChannelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buttonChannelRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonChannelRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonChannelRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonChannelRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonChannelRight.Name = "buttonChannelRight";
            this.buttonChannelRight.Size = new System.Drawing.Size(24, 24);
            this.buttonChannelRight.Text = "RIGHT";
            this.buttonChannelRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonChannelDualMono
            // 
            this.buttonChannelDualMono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buttonChannelDualMono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonChannelDualMono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonChannelDualMono.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonChannelDualMono.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonChannelDualMono.Name = "buttonChannelDualMono";
            this.buttonChannelDualMono.Size = new System.Drawing.Size(24, 24);
            this.buttonChannelDualMono.Text = "MONO";
            this.buttonChannelDualMono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxTimeStretchProfile
            // 
            this.comboBoxTimeStretchProfile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxTimeStretchProfile.FormattingEnabled = true;
            this.comboBoxTimeStretchProfile.Location = new System.Drawing.Point(122, 700);
            this.comboBoxTimeStretchProfile.Name = "comboBoxTimeStretchProfile";
            this.comboBoxTimeStretchProfile.Size = new System.Drawing.Size(464, 40);
            this.comboBoxTimeStretchProfile.TabIndex = 114;
            this.comboBoxTimeStretchProfile.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeStretchProfile_SelectedIndexChanged);
            // 
            // upDownCue
            // 
            this.upDownCue.Location = new System.Drawing.Point(691, 701);
            this.upDownCue.Name = "upDownCue";
            this.upDownCue.Size = new System.Drawing.Size(68, 39);
            this.upDownCue.TabIndex = 113;
            this.upDownCue.ValueChanged += new System.EventHandler(this.upDownCue_ValueChanged);
            // 
            // sliderEQHi
            // 
            this.sliderEQHi.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.sliderEQHi.Animated = false;
            this.sliderEQHi.AnimationSize = 0.2F;
            this.sliderEQHi.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            this.sliderEQHi.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.sliderEQHi.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.sliderEQHi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.sliderEQHi.BackGroundImage = null;
            this.sliderEQHi.ButtonAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sliderEQHi.ButtonBorderColor = System.Drawing.Color.Black;
            this.sliderEQHi.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sliderEQHi.ButtonCornerRadius = ((uint)(2u));
            this.sliderEQHi.ButtonSize = new System.Drawing.Size(56, 28);
            this.sliderEQHi.ButtonStyle = MediaSlider.MediaSlider.ButtonType.GlassOverlap;
            this.sliderEQHi.LargeChange = 20;
            this.sliderEQHi.Location = new System.Drawing.Point(831, 107);
            this.sliderEQHi.Margin = new System.Windows.Forms.Padding(0);
            this.sliderEQHi.Maximum = 100;
            this.sliderEQHi.Minimum = -100;
            this.sliderEQHi.Name = "sliderEQHi";
            this.sliderEQHi.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sliderEQHi.ShowButtonOnHover = false;
            this.sliderEQHi.Size = new System.Drawing.Size(76, 513);
            this.sliderEQHi.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.sliderEQHi.SmallChange = 1;
            this.sliderEQHi.SmoothScrolling = false;
            this.sliderEQHi.TabIndex = 112;
            this.sliderEQHi.TickColor = System.Drawing.Color.DarkGray;
            this.sliderEQHi.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sliderEQHi.TickType = MediaSlider.MediaSlider.TickMode.LargeStepped;
            this.sliderEQHi.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sliderEQHi.TrackDepth = 4;
            this.sliderEQHi.TrackFillColor = System.Drawing.Color.Transparent;
            this.sliderEQHi.TrackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(188)))));
            this.sliderEQHi.TrackShadow = false;
            this.sliderEQHi.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.sliderEQHi.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            this.sliderEQHi.Value = 0;
            this.sliderEQHi.ValueChanged += new MediaSlider.MediaSlider.ValueChangedDelegate(this.sliderEQHi_ValueChanged);
            // 
            // sliderEQMid
            // 
            this.sliderEQMid.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.sliderEQMid.Animated = false;
            this.sliderEQMid.AnimationSize = 0.2F;
            this.sliderEQMid.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            this.sliderEQMid.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.sliderEQMid.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.sliderEQMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.sliderEQMid.BackGroundImage = null;
            this.sliderEQMid.ButtonAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sliderEQMid.ButtonBorderColor = System.Drawing.Color.Black;
            this.sliderEQMid.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sliderEQMid.ButtonCornerRadius = ((uint)(2u));
            this.sliderEQMid.ButtonSize = new System.Drawing.Size(56, 28);
            this.sliderEQMid.ButtonStyle = MediaSlider.MediaSlider.ButtonType.GlassOverlap;
            this.sliderEQMid.LargeChange = 20;
            this.sliderEQMid.Location = new System.Drawing.Point(749, 107);
            this.sliderEQMid.Margin = new System.Windows.Forms.Padding(0);
            this.sliderEQMid.Maximum = 100;
            this.sliderEQMid.Minimum = -100;
            this.sliderEQMid.Name = "sliderEQMid";
            this.sliderEQMid.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sliderEQMid.ShowButtonOnHover = false;
            this.sliderEQMid.Size = new System.Drawing.Size(76, 513);
            this.sliderEQMid.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.sliderEQMid.SmallChange = 1;
            this.sliderEQMid.SmoothScrolling = false;
            this.sliderEQMid.TabIndex = 111;
            this.sliderEQMid.TickColor = System.Drawing.Color.DarkGray;
            this.sliderEQMid.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sliderEQMid.TickType = MediaSlider.MediaSlider.TickMode.LargeStepped;
            this.sliderEQMid.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sliderEQMid.TrackDepth = 4;
            this.sliderEQMid.TrackFillColor = System.Drawing.Color.Transparent;
            this.sliderEQMid.TrackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(188)))));
            this.sliderEQMid.TrackShadow = false;
            this.sliderEQMid.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.sliderEQMid.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            this.sliderEQMid.Value = 0;
            this.sliderEQMid.ValueChanged += new MediaSlider.MediaSlider.ValueChangedDelegate(this.sliderEQMid_ValueChanged);
            // 
            // sliderEQLow
            // 
            this.sliderEQLow.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.sliderEQLow.Animated = false;
            this.sliderEQLow.AnimationSize = 0.2F;
            this.sliderEQLow.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            this.sliderEQLow.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.sliderEQLow.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.sliderEQLow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.sliderEQLow.BackGroundImage = null;
            this.sliderEQLow.ButtonAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sliderEQLow.ButtonBorderColor = System.Drawing.Color.Black;
            this.sliderEQLow.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sliderEQLow.ButtonCornerRadius = ((uint)(2u));
            this.sliderEQLow.ButtonSize = new System.Drawing.Size(56, 28);
            this.sliderEQLow.ButtonStyle = MediaSlider.MediaSlider.ButtonType.GlassOverlap;
            this.sliderEQLow.LargeChange = 20;
            this.sliderEQLow.Location = new System.Drawing.Point(670, 107);
            this.sliderEQLow.Margin = new System.Windows.Forms.Padding(0);
            this.sliderEQLow.Maximum = 100;
            this.sliderEQLow.Minimum = -100;
            this.sliderEQLow.Name = "sliderEQLow";
            this.sliderEQLow.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sliderEQLow.ShowButtonOnHover = false;
            this.sliderEQLow.Size = new System.Drawing.Size(76, 513);
            this.sliderEQLow.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.sliderEQLow.SmallChange = 1;
            this.sliderEQLow.SmoothScrolling = false;
            this.sliderEQLow.TabIndex = 110;
            this.sliderEQLow.TickColor = System.Drawing.Color.DarkGray;
            this.sliderEQLow.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sliderEQLow.TickType = MediaSlider.MediaSlider.TickMode.LargeStepped;
            this.sliderEQLow.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sliderEQLow.TrackDepth = 4;
            this.sliderEQLow.TrackFillColor = System.Drawing.Color.Transparent;
            this.sliderEQLow.TrackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(188)))));
            this.sliderEQLow.TrackShadow = false;
            this.sliderEQLow.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.sliderEQLow.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            this.sliderEQLow.Value = 0;
            this.sliderEQLow.ValueChanged += new MediaSlider.MediaSlider.ValueChangedDelegate(this.sliderEQLow_ValueChanged);
            // 
            // sliderVolume
            // 
            this.sliderVolume.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.sliderVolume.Animated = false;
            this.sliderVolume.AnimationSize = 0.2F;
            this.sliderVolume.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            this.sliderVolume.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.sliderVolume.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.sliderVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.sliderVolume.BackGroundImage = null;
            this.sliderVolume.ButtonAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sliderVolume.ButtonBorderColor = System.Drawing.Color.Black;
            this.sliderVolume.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sliderVolume.ButtonCornerRadius = ((uint)(2u));
            this.sliderVolume.ButtonSize = new System.Drawing.Size(56, 28);
            this.sliderVolume.ButtonStyle = MediaSlider.MediaSlider.ButtonType.GlassOverlap;
            this.sliderVolume.LargeChange = 10;
            this.sliderVolume.Location = new System.Drawing.Point(482, 107);
            this.sliderVolume.Margin = new System.Windows.Forms.Padding(0);
            this.sliderVolume.Maximum = 100;
            this.sliderVolume.Minimum = 0;
            this.sliderVolume.Name = "sliderVolume";
            this.sliderVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sliderVolume.ShowButtonOnHover = false;
            this.sliderVolume.Size = new System.Drawing.Size(76, 513);
            this.sliderVolume.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.sliderVolume.SmallChange = 1;
            this.sliderVolume.SmoothScrolling = false;
            this.sliderVolume.TabIndex = 109;
            this.sliderVolume.TickColor = System.Drawing.Color.DarkGray;
            this.sliderVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sliderVolume.TickType = MediaSlider.MediaSlider.TickMode.LargeStepped;
            this.sliderVolume.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sliderVolume.TrackDepth = 4;
            this.sliderVolume.TrackFillColor = System.Drawing.Color.Transparent;
            this.sliderVolume.TrackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(188)))));
            this.sliderVolume.TrackShadow = true;
            this.sliderVolume.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.sliderVolume.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            this.sliderVolume.Value = 75;
            this.sliderVolume.ValueChanged += new MediaSlider.MediaSlider.ValueChangedDelegate(this.sliderVolume_ValueChanged);
            // 
            // sliderPitch
            // 
            this.sliderPitch.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.sliderPitch.Animated = false;
            this.sliderPitch.AnimationSize = 0.2F;
            this.sliderPitch.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            this.sliderPitch.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.sliderPitch.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.sliderPitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.sliderPitch.BackGroundImage = null;
            this.sliderPitch.ButtonAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sliderPitch.ButtonBorderColor = System.Drawing.Color.Black;
            this.sliderPitch.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sliderPitch.ButtonCornerRadius = ((uint)(2u));
            this.sliderPitch.ButtonSize = new System.Drawing.Size(56, 28);
            this.sliderPitch.ButtonStyle = MediaSlider.MediaSlider.ButtonType.GlassOverlap;
            this.sliderPitch.LargeChange = 8;
            this.sliderPitch.Location = new System.Drawing.Point(251, 107);
            this.sliderPitch.Margin = new System.Windows.Forms.Padding(0);
            this.sliderPitch.Maximum = 96;
            this.sliderPitch.Minimum = -96;
            this.sliderPitch.Name = "sliderPitch";
            this.sliderPitch.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sliderPitch.ShowButtonOnHover = false;
            this.sliderPitch.Size = new System.Drawing.Size(76, 513);
            this.sliderPitch.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.sliderPitch.SmallChange = 1;
            this.sliderPitch.SmoothScrolling = false;
            this.sliderPitch.TabIndex = 108;
            this.sliderPitch.TickColor = System.Drawing.Color.DarkGray;
            this.sliderPitch.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sliderPitch.TickType = MediaSlider.MediaSlider.TickMode.LargeStepped;
            this.sliderPitch.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sliderPitch.TrackDepth = 4;
            this.sliderPitch.TrackFillColor = System.Drawing.Color.Transparent;
            this.sliderPitch.TrackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(188)))));
            this.sliderPitch.TrackShadow = false;
            this.sliderPitch.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.sliderPitch.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            this.sliderPitch.Value = 0;
            this.sliderPitch.ValueChanged += new MediaSlider.MediaSlider.ValueChangedDelegate(this.sliderPitch_ValueChanged);
            // 
            // sliderTempo
            // 
            this.sliderTempo.Animated = false;
            this.sliderTempo.AnimationSize = 0.2F;
            this.sliderTempo.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            this.sliderTempo.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.sliderTempo.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.sliderTempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.sliderTempo.BackGroundImage = null;
            this.sliderTempo.ButtonAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sliderTempo.ButtonBorderColor = System.Drawing.Color.Black;
            this.sliderTempo.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sliderTempo.ButtonCornerRadius = ((uint)(2u));
            this.sliderTempo.ButtonSize = new System.Drawing.Size(56, 28);
            this.sliderTempo.ButtonStyle = MediaSlider.MediaSlider.ButtonType.GlassOverlap;
            this.sliderTempo.LargeChange = 20;
            this.sliderTempo.Location = new System.Drawing.Point(87, 107);
            this.sliderTempo.Margin = new System.Windows.Forms.Padding(0);
            this.sliderTempo.Maximum = 200;
            this.sliderTempo.Minimum = 10;
            this.sliderTempo.Name = "sliderTempo";
            this.sliderTempo.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sliderTempo.ShowButtonOnHover = false;
            this.sliderTempo.Size = new System.Drawing.Size(76, 513);
            this.sliderTempo.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.sliderTempo.SmallChange = 1;
            this.sliderTempo.SmoothScrolling = false;
            this.sliderTempo.TabIndex = 107;
            this.sliderTempo.TickColor = System.Drawing.Color.DarkGray;
            this.sliderTempo.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sliderTempo.TickType = MediaSlider.MediaSlider.TickMode.LargeStepped;
            this.sliderTempo.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sliderTempo.TrackDepth = 4;
            this.sliderTempo.TrackFillColor = System.Drawing.Color.Transparent;
            this.sliderTempo.TrackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(188)))));
            this.sliderTempo.TrackShadow = false;
            this.sliderTempo.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.sliderTempo.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            this.sliderTempo.Value = 100;
            this.sliderTempo.ValueChanged += new MediaSlider.MediaSlider.ValueChangedDelegate(this.sliderTempo_ValueChanged);
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
            this.labelCueSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
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
            this.labelCue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelCue.Location = new System.Drawing.Point(628, 703);
            this.labelCue.Name = "labelCue";
            this.labelCue.Size = new System.Drawing.Size(57, 32);
            this.labelCue.TabIndex = 103;
            this.labelCue.Text = "Cue";
            // 
            // labelTimeStretchProfile
            // 
            this.labelTimeStretchProfile.AutoSize = true;
            this.labelTimeStretchProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTimeStretchProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
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
            this.labelTempoValue.ForeColor = System.Drawing.Color.White;
            this.labelTempoValue.Location = new System.Drawing.Point(87, 620);
            this.labelTempoValue.Name = "labelTempoValue";
            this.labelTempoValue.Size = new System.Drawing.Size(70, 32);
            this.labelTempoValue.TabIndex = 95;
            this.labelTempoValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxSuppressVocals
            // 
            this.checkBoxSuppressVocals.AutoSize = true;
            this.checkBoxSuppressVocals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSuppressVocals.Location = new System.Drawing.Point(956, 584);
            this.checkBoxSuppressVocals.Name = "checkBoxSuppressVocals";
            this.checkBoxSuppressVocals.Size = new System.Drawing.Size(210, 36);
            this.checkBoxSuppressVocals.TabIndex = 94;
            this.checkBoxSuppressVocals.Text = "Suppress Vocals";
            this.checkBoxSuppressVocals.UseVisualStyleBackColor = true;
            this.checkBoxSuppressVocals.CheckedChanged += new System.EventHandler(this.checkBoxSuppressVocals_CheckedChanged);
            // 
            // checkBoxSwapLR
            // 
            this.checkBoxSwapLR.AutoSize = true;
            this.checkBoxSwapLR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSwapLR.Location = new System.Drawing.Point(956, 542);
            this.checkBoxSwapLR.Name = "checkBoxSwapLR";
            this.checkBoxSwapLR.Size = new System.Drawing.Size(138, 36);
            this.checkBoxSwapLR.TabIndex = 93;
            this.checkBoxSwapLR.Text = "Swap L/R";
            this.checkBoxSwapLR.UseVisualStyleBackColor = true;
            this.checkBoxSwapLR.CheckedChanged += new System.EventHandler(this.checkBoxSwapLR_CheckedChanged);
            // 
            // labelEQMid
            // 
            this.labelEQMid.AutoSize = true;
            this.labelEQMid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEQMid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelEQMid.Location = new System.Drawing.Point(760, 60);
            this.labelEQMid.Name = "labelEQMid";
            this.labelEQMid.Size = new System.Drawing.Size(59, 32);
            this.labelEQMid.TabIndex = 90;
            this.labelEQMid.Text = "Mid";
            // 
            // labelEQHi
            // 
            this.labelEQHi.AutoSize = true;
            this.labelEQHi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEQHi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelEQHi.Location = new System.Drawing.Point(851, 60);
            this.labelEQHi.Name = "labelEQHi";
            this.labelEQHi.Size = new System.Drawing.Size(39, 32);
            this.labelEQHi.TabIndex = 88;
            this.labelEQHi.Text = "Hi";
            // 
            // labelEQLow
            // 
            this.labelEQLow.AutoSize = true;
            this.labelEQLow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEQLow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
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
            this.labelEQMin100pc.Location = new System.Drawing.Point(603, 591);
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
            this.labelEQ0pc.ForeColor = System.Drawing.Color.White;
            this.labelEQ0pc.Location = new System.Drawing.Point(630, 350);
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
            this.labelEQ100pc.Location = new System.Drawing.Point(610, 107);
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
            this.labelEqualizer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelEqualizer.Location = new System.Drawing.Point(728, 28);
            this.labelEqualizer.Name = "labelEqualizer";
            this.labelEqualizer.Size = new System.Drawing.Size(119, 32);
            this.labelEqualizer.TabIndex = 82;
            this.labelEqualizer.Text = "Equalizer";
            // 
            // labelVolume25pc
            // 
            this.labelVolume25pc.AutoSize = true;
            this.labelVolume25pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolume25pc.Location = new System.Drawing.Point(432, 469);
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
            this.labelVolume75pc.Location = new System.Drawing.Point(432, 233);
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
            this.labelVolume0pc.Location = new System.Drawing.Point(442, 591);
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
            this.labelVolume100pc.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label5.Location = new System.Drawing.Point(452, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 75;
            this.label5.Text = "Volume";
            // 
            // labelPitch8vb
            // 
            this.labelPitch8vb.AutoSize = true;
            this.labelPitch8vb.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPitch8vb.Location = new System.Drawing.Point(210, 591);
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
            this.labelPitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelPitch.Location = new System.Drawing.Point(251, 60);
            this.labelPitch.Name = "labelPitch";
            this.labelPitch.Size = new System.Drawing.Size(71, 32);
            this.labelPitch.TabIndex = 70;
            this.labelPitch.Text = "Pitch";
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
            this.labelX05.Location = new System.Drawing.Point(40, 497);
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
            this.labelX01.Location = new System.Drawing.Point(46, 591);
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 63;
            this.label1.Text = "Tempo";
            // 
            // overlayPosition
            // 
            this.overlayPosition.BackColor = System.Drawing.Color.Transparent;
            this.overlayPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overlayPosition.Location = new System.Drawing.Point(15, 126);
            this.overlayPosition.Name = "overlayPosition";
            this.overlayPosition.Size = new System.Drawing.Size(2, 319);
            this.overlayPosition.TabIndex = 66;
            // 
            // panelLoop
            // 
            this.panelLoop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelLoop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLoop.Controls.Add(this.buttonEndLoopNow);
            this.panelLoop.Controls.Add(this.buttonStartLoopNow);
            this.panelLoop.Controls.Add(this.upDownEndLoopMilliseconds);
            this.panelLoop.Controls.Add(this.upDownEndLoopSeconds);
            this.panelLoop.Controls.Add(this.upDownEndLoopMinutes);
            this.panelLoop.Controls.Add(this.upDownStartLoopMilliseconds);
            this.panelLoop.Controls.Add(this.upDownStartLoopSeconds);
            this.panelLoop.Controls.Add(this.upDownStartLoopMinutes);
            this.panelLoop.Controls.Add(this.upDownCurrentMilliseconds);
            this.panelLoop.Controls.Add(this.upDownCurrentSeconds);
            this.panelLoop.Controls.Add(this.upDownCurrentMinutes);
            this.panelLoop.Controls.Add(this.labelPositionValue);
            this.panelLoop.Controls.Add(this.labelPosition);
            this.panelLoop.Controls.Add(this.labelLoopEnd);
            this.panelLoop.Controls.Add(this.label2);
            this.panelLoop.Controls.Add(this.checkBoxLoop);
            this.panelLoop.Location = new System.Drawing.Point(1218, 515);
            this.panelLoop.Name = "panelLoop";
            this.panelLoop.Size = new System.Drawing.Size(450, 292);
            this.panelLoop.TabIndex = 63;
            // 
            // buttonEndLoopNow
            // 
            this.buttonEndLoopNow.Location = new System.Drawing.Point(348, 233);
            this.buttonEndLoopNow.Name = "buttonEndLoopNow";
            this.buttonEndLoopNow.Padding = new System.Windows.Forms.Padding(5);
            this.buttonEndLoopNow.Size = new System.Drawing.Size(86, 39);
            this.buttonEndLoopNow.TabIndex = 129;
            this.buttonEndLoopNow.Text = "Now";
            this.buttonEndLoopNow.Click += new System.EventHandler(this.buttonEndLoopNow_Click);
            // 
            // buttonStartLoopNow
            // 
            this.buttonStartLoopNow.Location = new System.Drawing.Point(348, 188);
            this.buttonStartLoopNow.Name = "buttonStartLoopNow";
            this.buttonStartLoopNow.Padding = new System.Windows.Forms.Padding(5);
            this.buttonStartLoopNow.Size = new System.Drawing.Size(86, 39);
            this.buttonStartLoopNow.TabIndex = 128;
            this.buttonStartLoopNow.Text = "Now";
            this.buttonStartLoopNow.Click += new System.EventHandler(this.buttonStartLoopNow_Click);
            // 
            // upDownEndLoopMilliseconds
            // 
            this.upDownEndLoopMilliseconds.Location = new System.Drawing.Point(259, 233);
            this.upDownEndLoopMilliseconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.upDownEndLoopMilliseconds.Name = "upDownEndLoopMilliseconds";
            this.upDownEndLoopMilliseconds.Size = new System.Drawing.Size(83, 39);
            this.upDownEndLoopMilliseconds.TabIndex = 127;
            this.upDownEndLoopMilliseconds.ValueChanged += new System.EventHandler(this.upDownEndLoopMilliseconds_ValueChanged);
            // 
            // upDownEndLoopSeconds
            // 
            this.upDownEndLoopSeconds.Location = new System.Drawing.Point(170, 233);
            this.upDownEndLoopSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.upDownEndLoopSeconds.Name = "upDownEndLoopSeconds";
            this.upDownEndLoopSeconds.Size = new System.Drawing.Size(83, 39);
            this.upDownEndLoopSeconds.TabIndex = 126;
            this.upDownEndLoopSeconds.VisibleChanged += new System.EventHandler(this.upDownEndLoopSeconds_ValueChanged);
            // 
            // upDownEndLoopMinutes
            // 
            this.upDownEndLoopMinutes.Location = new System.Drawing.Point(81, 233);
            this.upDownEndLoopMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.upDownEndLoopMinutes.Name = "upDownEndLoopMinutes";
            this.upDownEndLoopMinutes.Size = new System.Drawing.Size(83, 39);
            this.upDownEndLoopMinutes.TabIndex = 125;
            this.upDownEndLoopMinutes.VisibleChanged += new System.EventHandler(this.upDownEndLoopMinutes_ValueChanged);
            // 
            // upDownStartLoopMilliseconds
            // 
            this.upDownStartLoopMilliseconds.Location = new System.Drawing.Point(259, 188);
            this.upDownStartLoopMilliseconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.upDownStartLoopMilliseconds.Name = "upDownStartLoopMilliseconds";
            this.upDownStartLoopMilliseconds.Size = new System.Drawing.Size(83, 39);
            this.upDownStartLoopMilliseconds.TabIndex = 124;
            this.upDownStartLoopMilliseconds.ValueChanged += new System.EventHandler(this.upDownStartLoopMilliseconds_ValueChanged);
            // 
            // upDownStartLoopSeconds
            // 
            this.upDownStartLoopSeconds.Location = new System.Drawing.Point(170, 188);
            this.upDownStartLoopSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.upDownStartLoopSeconds.Name = "upDownStartLoopSeconds";
            this.upDownStartLoopSeconds.Size = new System.Drawing.Size(83, 39);
            this.upDownStartLoopSeconds.TabIndex = 123;
            this.upDownStartLoopSeconds.ValueChanged += new System.EventHandler(this.upDownStartLoopSeconds_ValueChanged);
            // 
            // upDownStartLoopMinutes
            // 
            this.upDownStartLoopMinutes.Location = new System.Drawing.Point(81, 188);
            this.upDownStartLoopMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.upDownStartLoopMinutes.Name = "upDownStartLoopMinutes";
            this.upDownStartLoopMinutes.Size = new System.Drawing.Size(83, 39);
            this.upDownStartLoopMinutes.TabIndex = 122;
            this.upDownStartLoopMinutes.ValueChanged += new System.EventHandler(this.upDownStartLoopMinutes_ValueChanged);
            // 
            // upDownCurrentMilliseconds
            // 
            this.upDownCurrentMilliseconds.Location = new System.Drawing.Point(259, 60);
            this.upDownCurrentMilliseconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.upDownCurrentMilliseconds.Name = "upDownCurrentMilliseconds";
            this.upDownCurrentMilliseconds.Size = new System.Drawing.Size(83, 39);
            this.upDownCurrentMilliseconds.TabIndex = 121;
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
            this.upDownCurrentSeconds.TabIndex = 120;
            this.upDownCurrentSeconds.ValueChanged += new System.EventHandler(this.upDownCurrent_ValueChanged);
            // 
            // upDownCurrentMinutes
            // 
            this.upDownCurrentMinutes.Location = new System.Drawing.Point(81, 60);
            this.upDownCurrentMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.upDownCurrentMinutes.Name = "upDownCurrentMinutes";
            this.upDownCurrentMinutes.Size = new System.Drawing.Size(83, 39);
            this.upDownCurrentMinutes.TabIndex = 114;
            this.upDownCurrentMinutes.ValueChanged += new System.EventHandler(this.upDownCurrent_ValueChanged);
            // 
            // labelPositionValue
            // 
            this.labelPositionValue.AutoSize = true;
            this.labelPositionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
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
            this.labelPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelPosition.Location = new System.Drawing.Point(10, 16);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(61, 32);
            this.labelPosition.TabIndex = 118;
            this.labelPosition.Text = "Pos:";
            // 
            // labelLoopEnd
            // 
            this.labelLoopEnd.AutoSize = true;
            this.labelLoopEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoopEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelLoopEnd.Location = new System.Drawing.Point(8, 236);
            this.labelLoopEnd.Name = "labelLoopEnd";
            this.labelLoopEnd.Size = new System.Drawing.Size(59, 32);
            this.labelLoopEnd.TabIndex = 110;
            this.labelLoopEnd.Text = "End:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(8, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 32);
            this.label2.TabIndex = 105;
            this.label2.Text = "Start:";
            // 
            // checkBoxLoop
            // 
            this.checkBoxLoop.AutoSize = true;
            this.checkBoxLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxLoop.Location = new System.Drawing.Point(81, 140);
            this.checkBoxLoop.Name = "checkBoxLoop";
            this.checkBoxLoop.Size = new System.Drawing.Size(94, 36);
            this.checkBoxLoop.TabIndex = 0;
            this.checkBoxLoop.Text = "Loop";
            this.checkBoxLoop.UseVisualStyleBackColor = true;
            this.checkBoxLoop.CheckedChanged += new System.EventHandler(this.checkBoxLoop_CheckedChanged);
            // 
            // panelPresets
            // 
            this.panelPresets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
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
            this.panelPresets.Location = new System.Drawing.Point(1218, 813);
            this.panelPresets.Name = "panelPresets";
            this.panelPresets.Size = new System.Drawing.Size(450, 478);
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
            this.buttonSavePreset.BackColor = System.Drawing.Color.Black;
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
            this.buttonPreset8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonPreset8.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonPreset8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreset8.Location = new System.Drawing.Point(48, 422);
            this.buttonPreset8.Name = "buttonPreset8";
            this.buttonPreset8.Size = new System.Drawing.Size(371, 41);
            this.buttonPreset8.TabIndex = 123;
            this.buttonPreset8.Text = "<Preset not defined>";
            this.buttonPreset8.UseVisualStyleBackColor = false;
            this.buttonPreset8.Click += new System.EventHandler(this.buttonPreset8_Click);
            // 
            // buttonPreset4
            // 
            this.buttonPreset4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonPreset4.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonPreset4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreset4.Location = new System.Drawing.Point(48, 230);
            this.buttonPreset4.Name = "buttonPreset4";
            this.buttonPreset4.Size = new System.Drawing.Size(371, 41);
            this.buttonPreset4.TabIndex = 122;
            this.buttonPreset4.Text = "<Preset not defined>";
            this.buttonPreset4.UseVisualStyleBackColor = false;
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
            this.buttonPreset7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonPreset7.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonPreset7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreset7.Location = new System.Drawing.Point(48, 375);
            this.buttonPreset7.Name = "buttonPreset7";
            this.buttonPreset7.Size = new System.Drawing.Size(371, 41);
            this.buttonPreset7.TabIndex = 119;
            this.buttonPreset7.Text = "<Preset not defined>";
            this.buttonPreset7.UseVisualStyleBackColor = false;
            this.buttonPreset7.Click += new System.EventHandler(this.buttonPreset7_Click);
            // 
            // buttonPreset3
            // 
            this.buttonPreset3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonPreset3.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonPreset3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreset3.Location = new System.Drawing.Point(48, 183);
            this.buttonPreset3.Name = "buttonPreset3";
            this.buttonPreset3.Size = new System.Drawing.Size(371, 41);
            this.buttonPreset3.TabIndex = 118;
            this.buttonPreset3.Text = "<Preset not defined>";
            this.buttonPreset3.UseVisualStyleBackColor = false;
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
            this.buttonPreset6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonPreset6.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonPreset6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreset6.Location = new System.Drawing.Point(48, 328);
            this.buttonPreset6.Name = "buttonPreset6";
            this.buttonPreset6.Size = new System.Drawing.Size(371, 41);
            this.buttonPreset6.TabIndex = 115;
            this.buttonPreset6.Text = "<Preset not defined>";
            this.buttonPreset6.UseVisualStyleBackColor = false;
            this.buttonPreset6.Click += new System.EventHandler(this.buttonPreset6_Click);
            // 
            // buttonPreset2
            // 
            this.buttonPreset2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonPreset2.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonPreset2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreset2.Location = new System.Drawing.Point(48, 136);
            this.buttonPreset2.Name = "buttonPreset2";
            this.buttonPreset2.Size = new System.Drawing.Size(371, 41);
            this.buttonPreset2.TabIndex = 114;
            this.buttonPreset2.Text = "<Preset not defined>";
            this.buttonPreset2.UseVisualStyleBackColor = false;
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
            this.buttonPreset5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonPreset5.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonPreset5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreset5.Location = new System.Drawing.Point(48, 280);
            this.buttonPreset5.Name = "buttonPreset5";
            this.buttonPreset5.Size = new System.Drawing.Size(371, 41);
            this.buttonPreset5.TabIndex = 111;
            this.buttonPreset5.Text = "<Preset not defined>";
            this.buttonPreset5.UseVisualStyleBackColor = false;
            this.buttonPreset5.Click += new System.EventHandler(this.buttonPreset5_Click);
            // 
            // buttonPreset1
            // 
            this.buttonPreset1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonPreset1.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonPreset1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreset1.Location = new System.Drawing.Point(48, 88);
            this.buttonPreset1.Name = "buttonPreset1";
            this.buttonPreset1.Size = new System.Drawing.Size(371, 41);
            this.buttonPreset1.TabIndex = 110;
            this.buttonPreset1.Text = "<Preset not defined>";
            this.buttonPreset1.UseVisualStyleBackColor = false;
            this.buttonPreset1.Click += new System.EventHandler(this.buttonPreset1_Click);
            // 
            // pictureBoxRenderer
            // 
            this.pictureBoxRenderer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pictureBoxRenderer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRenderer.Location = new System.Drawing.Point(15, 126);
            this.pictureBoxRenderer.Name = "pictureBoxRenderer";
            this.pictureBoxRenderer.Size = new System.Drawing.Size(1653, 319);
            this.pictureBoxRenderer.TabIndex = 65;
            this.pictureBoxRenderer.TabStop = false;
            // 
            // sliderPlayTime
            // 
            this.sliderPlayTime.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.sliderPlayTime.Animated = false;
            this.sliderPlayTime.AnimationSize = 0.2F;
            this.sliderPlayTime.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            this.sliderPlayTime.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.sliderPlayTime.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.sliderPlayTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.sliderPlayTime.BackGroundImage = null;
            this.sliderPlayTime.ButtonAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sliderPlayTime.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sliderPlayTime.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sliderPlayTime.ButtonCornerRadius = ((uint)(2u));
            this.sliderPlayTime.ButtonSize = new System.Drawing.Size(16, 16);
            this.sliderPlayTime.ButtonStyle = MediaSlider.MediaSlider.ButtonType.Hybrid;
            this.sliderPlayTime.LargeChange = 5;
            this.sliderPlayTime.Location = new System.Drawing.Point(7, 445);
            this.sliderPlayTime.Margin = new System.Windows.Forms.Padding(0);
            this.sliderPlayTime.Maximum = 500;
            this.sliderPlayTime.Minimum = 0;
            this.sliderPlayTime.Name = "sliderPlayTime";
            this.sliderPlayTime.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.sliderPlayTime.ShowButtonOnHover = false;
            this.sliderPlayTime.Size = new System.Drawing.Size(1668, 40);
            this.sliderPlayTime.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.sliderPlayTime.SmallChange = 1;
            this.sliderPlayTime.SmoothScrolling = false;
            this.sliderPlayTime.TabIndex = 113;
            this.sliderPlayTime.TickColor = System.Drawing.Color.DarkGray;
            this.sliderPlayTime.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.sliderPlayTime.TickType = MediaSlider.MediaSlider.TickMode.LargeStepped;
            this.sliderPlayTime.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sliderPlayTime.TrackDepth = 4;
            this.sliderPlayTime.TrackFillColor = System.Drawing.Color.Transparent;
            this.sliderPlayTime.TrackProgressColor = System.Drawing.Color.White;
            this.sliderPlayTime.TrackShadow = false;
            this.sliderPlayTime.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.sliderPlayTime.TrackStyle = MediaSlider.MediaSlider.TrackType.Progress;
            this.sliderPlayTime.Value = 0;
            this.sliderPlayTime.ValueChanged += new MediaSlider.MediaSlider.ValueChangedDelegate(this.sliderPlayTime_ValueChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1684, 40);
            this.menuStrip.TabIndex = 114;
            this.menuStrip.Text = "darkMenuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRecent1,
            this.menuItemRecent2,
            this.menuItemRecent3,
            this.menuItemRecent4,
            this.menuItemRecent5,
            this.menuItemRecent6,
            this.menuItemRecent7,
            this.menuItemRecent8,
            this.toolStripSeparator1,
            this.menuItemExit});
            this.toolStripMenuItemFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(71, 36);
            this.toolStripMenuItemFile.Text = "&File";
            this.toolStripMenuItemFile.DropDownOpening += new System.EventHandler(this.menuItemFile_DropDownOpening);
            this.toolStripMenuItemFile.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuItemFile_Clicked);
            // 
            // menuItemRecent1
            // 
            this.menuItemRecent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemRecent1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemRecent1.Name = "menuItemRecent1";
            this.menuItemRecent1.Size = new System.Drawing.Size(342, 44);
            this.menuItemRecent1.Text = "menuItemRecent1";
            // 
            // menuItemRecent2
            // 
            this.menuItemRecent2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemRecent2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemRecent2.Name = "menuItemRecent2";
            this.menuItemRecent2.Size = new System.Drawing.Size(342, 44);
            this.menuItemRecent2.Text = "menuItemRecent2";
            // 
            // menuItemRecent3
            // 
            this.menuItemRecent3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemRecent3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemRecent3.Name = "menuItemRecent3";
            this.menuItemRecent3.Size = new System.Drawing.Size(342, 44);
            this.menuItemRecent3.Text = "menuItemRecent3";
            // 
            // menuItemRecent4
            // 
            this.menuItemRecent4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemRecent4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemRecent4.Name = "menuItemRecent4";
            this.menuItemRecent4.Size = new System.Drawing.Size(342, 44);
            this.menuItemRecent4.Text = "menuItemRecent4";
            // 
            // menuItemRecent5
            // 
            this.menuItemRecent5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemRecent5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemRecent5.Name = "menuItemRecent5";
            this.menuItemRecent5.Size = new System.Drawing.Size(342, 44);
            this.menuItemRecent5.Text = "menuItemRecent5";
            // 
            // menuItemRecent6
            // 
            this.menuItemRecent6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemRecent6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemRecent6.Name = "menuItemRecent6";
            this.menuItemRecent6.Size = new System.Drawing.Size(342, 44);
            this.menuItemRecent6.Text = "menuItemRecent6";
            // 
            // menuItemRecent7
            // 
            this.menuItemRecent7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemRecent7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemRecent7.Name = "menuItemRecent7";
            this.menuItemRecent7.Size = new System.Drawing.Size(342, 44);
            this.menuItemRecent7.Text = "menuItemRecent7";
            // 
            // menuItemRecent8
            // 
            this.menuItemRecent8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemRecent8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemRecent8.Name = "menuItemRecent8";
            this.menuItemRecent8.Size = new System.Drawing.Size(342, 44);
            this.menuItemRecent8.Text = "menuItemRecent8";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(339, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(342, 44);
            this.menuItemExit.Text = "E&xit";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1684, 1305);
            this.Controls.Add(this.overlayPosition);
            this.Controls.Add(this.pictureBoxRenderer);
            this.Controls.Add(this.sliderPlayTime);
            this.Controls.Add(this.panelPresets);
            this.Controls.Add(this.panelLoop);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.labelPlayDuration);
            this.Controls.Add(this.labelPlayDuration3Q);
            this.Controls.Add(this.labelPlayDuration2Q);
            this.Controls.Add(this.labelPlayDuration1Q);
            this.Controls.Add(this.labelPlayDuration0Q);
            this.Controls.Add(this.labelCurrentlyPlaying);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Practice Session";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.toolStripChannels.ResumeLayout(false);
            this.toolStripChannels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCue)).EndInit();
            this.panelLoop.ResumeLayout(false);
            this.panelLoop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownEndLoopMilliseconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownEndLoopSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownEndLoopMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownStartLoopMilliseconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownStartLoopSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownStartLoopMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCurrentMilliseconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCurrentSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownCurrentMinutes)).EndInit();
            this.panelPresets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRenderer)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Label labelCurrentlyPlaying;
        private System.Windows.Forms.Label labelPlayDuration0Q;
        private System.Windows.Forms.Label labelPlayDuration1Q;
        private System.Windows.Forms.Label labelPlayDuration2Q;
        private System.Windows.Forms.Label labelPlayDuration3Q;
        private System.Windows.Forms.Label labelPlayDuration;
        private System.Windows.Forms.Timer PlayTimeUpdateTimer;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label labelCueSeconds;
        private System.Windows.Forms.Label labelCue;
        private System.Windows.Forms.Label labelTimeStretchProfile;
        private System.Windows.Forms.Label labelEQHiValue;
        private System.Windows.Forms.Label labelVolumeValue;
        private System.Windows.Forms.Label labelSemitones;
        private System.Windows.Forms.Label labelPitchValue;
        private System.Windows.Forms.Label labelTempoValue;
        private System.Windows.Forms.CheckBox checkBoxSuppressVocals;
        private System.Windows.Forms.CheckBox checkBoxSwapLR;
        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.Label labelEQMid;
        private System.Windows.Forms.Label labelEQHi;
        private System.Windows.Forms.Label labelEQLow;
        private System.Windows.Forms.Label labelEQMin100pc;
        private System.Windows.Forms.Label labelEQ0pc;
        private System.Windows.Forms.Label labelEQ100pc;
        private System.Windows.Forms.Label labelEqualizer;
        private System.Windows.Forms.Label labelVolume25pc;
        private System.Windows.Forms.Label labelVolume75pc;
        private System.Windows.Forms.Label labelVolume0pc;
        private System.Windows.Forms.Label labelVolume50pc;
        private System.Windows.Forms.Label labelVolume100pc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPitch8vb;
        private System.Windows.Forms.Label labelPitch0;
        private System.Windows.Forms.Label labelPitch8va;
        private System.Windows.Forms.Label labelPitch;
        private System.Windows.Forms.Label labelX15;
        private System.Windows.Forms.Label labelX05;
        private System.Windows.Forms.Label labelX01;
        private System.Windows.Forms.Label labelX10;
        private System.Windows.Forms.Label labelX20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLoop;
        private System.Windows.Forms.CheckBox checkBoxLoop;
        private System.Windows.Forms.Label labelLoopEnd;
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
        private System.Windows.Forms.Label labelEQMidValue;
        private System.Windows.Forms.Label labelEQLowValue;
        private System.Windows.Forms.PictureBox pictureBoxRenderer;
        private System.Windows.Forms.Label labelPositionValue;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label overlayPosition;
        private MediaSlider.MediaSlider sliderTempo;
        private MediaSlider.MediaSlider sliderPitch;
        private MediaSlider.MediaSlider sliderVolume;
        private MediaSlider.MediaSlider sliderEQHi;
        private MediaSlider.MediaSlider sliderEQMid;
        private MediaSlider.MediaSlider sliderEQLow;
        private MediaSlider.MediaSlider sliderPlayTime;
        private DarkUI.Controls.DarkMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecent1;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecent2;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecent3;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecent4;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecent5;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecent6;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecent7;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecent8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private DarkUI.Controls.DarkNumericUpDown upDownCue;
        private DarkUI.Controls.DarkNumericUpDown upDownCurrentMilliseconds;
        private DarkUI.Controls.DarkNumericUpDown upDownCurrentSeconds;
        private DarkUI.Controls.DarkNumericUpDown upDownCurrentMinutes;
        private DarkUI.Controls.DarkNumericUpDown upDownEndLoopMilliseconds;
        private DarkUI.Controls.DarkNumericUpDown upDownEndLoopSeconds;
        private DarkUI.Controls.DarkNumericUpDown upDownEndLoopMinutes;
        private DarkUI.Controls.DarkNumericUpDown upDownStartLoopMilliseconds;
        private DarkUI.Controls.DarkNumericUpDown upDownStartLoopSeconds;
        private DarkUI.Controls.DarkNumericUpDown upDownStartLoopMinutes;
        private DarkUI.Controls.DarkToolStrip toolStripChannels;
        private DarkUI.Controls.DarkComboBox comboBoxTimeStretchProfile;
        private ToolStripButton buttonChannelBoth;
        private ToolStripButton buttonChannelLeft;
        private ToolStripButton buttonChannelRight;
        private ToolStripButton buttonChannelDualMono;
        private DarkUI.Controls.DarkButton buttonEndLoopNow;
        private DarkUI.Controls.DarkButton buttonStartLoopNow;
        private Label label4;
        private Label label3;
    }
}