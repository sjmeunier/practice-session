
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            openFileDialog = new OpenFileDialog();
            labelFilename = new Label();
            labelCurrentlyPlaying = new Label();
            labelPlayDuration0Q = new Label();
            labelPlayDuration1Q = new Label();
            labelPlayDuration2Q = new Label();
            labelPlayDuration3Q = new Label();
            labelPlayDuration = new Label();
            PlayTimeUpdateTimer = new Timer(components);
            buttonOpenFile = new Button();
            buttonPlay = new Button();
            panelControls = new Panel();
            labelChannel = new Label();
            label4 = new Label();
            label3 = new Label();
            toolStripChannels = new DarkUI.Controls.DarkToolStrip();
            buttonChannelBoth = new ToolStripButton();
            buttonChannelLeft = new ToolStripButton();
            buttonChannelRight = new ToolStripButton();
            buttonChannelDualMono = new ToolStripButton();
            comboBoxTimeStretchProfile = new DarkUI.Controls.DarkComboBox();
            upDownCue = new DarkUI.Controls.DarkNumericUpDown();
            sliderEQHi = new MediaSlider.MediaSlider();
            sliderEQMid = new MediaSlider.MediaSlider();
            sliderEQLow = new MediaSlider.MediaSlider();
            sliderVolume = new MediaSlider.MediaSlider();
            sliderPitch = new MediaSlider.MediaSlider();
            sliderTempo = new MediaSlider.MediaSlider();
            labelEQMidValue = new Label();
            labelEQLowValue = new Label();
            labelCueSeconds = new Label();
            labelCue = new Label();
            labelTimeStretchProfile = new Label();
            labelEQHiValue = new Label();
            labelVolumeValue = new Label();
            labelSemitones = new Label();
            labelPitchValue = new Label();
            labelTempoValue = new Label();
            checkBoxSuppressVocals = new CheckBox();
            checkBoxSwapLR = new CheckBox();
            labelEQMid = new Label();
            labelEQHi = new Label();
            labelEQLow = new Label();
            labelEQMin100pc = new Label();
            labelEQ0pc = new Label();
            labelEQ100pc = new Label();
            labelEqualizer = new Label();
            labelVolume25pc = new Label();
            labelVolume75pc = new Label();
            labelVolume0pc = new Label();
            labelVolume50pc = new Label();
            labelVolume100pc = new Label();
            label5 = new Label();
            labelPitch8vb = new Label();
            labelPitch0 = new Label();
            labelPitch8va = new Label();
            labelPitch = new Label();
            labelX15 = new Label();
            labelX05 = new Label();
            labelX01 = new Label();
            labelX10 = new Label();
            labelX20 = new Label();
            label1 = new Label();
            overlayPosition = new Label();
            panelLoop = new Panel();
            buttonEndLoopNow = new DarkUI.Controls.DarkButton();
            buttonStartLoopNow = new DarkUI.Controls.DarkButton();
            upDownEndLoopMilliseconds = new DarkUI.Controls.DarkNumericUpDown();
            upDownEndLoopSeconds = new DarkUI.Controls.DarkNumericUpDown();
            upDownEndLoopMinutes = new DarkUI.Controls.DarkNumericUpDown();
            upDownStartLoopMilliseconds = new DarkUI.Controls.DarkNumericUpDown();
            upDownStartLoopSeconds = new DarkUI.Controls.DarkNumericUpDown();
            upDownStartLoopMinutes = new DarkUI.Controls.DarkNumericUpDown();
            upDownCurrentMilliseconds = new DarkUI.Controls.DarkNumericUpDown();
            upDownCurrentSeconds = new DarkUI.Controls.DarkNumericUpDown();
            upDownCurrentMinutes = new DarkUI.Controls.DarkNumericUpDown();
            labelPositionValue = new Label();
            labelPosition = new Label();
            labelLoopEnd = new Label();
            label2 = new Label();
            checkBoxLoop = new CheckBox();
            panelPresets = new Panel();
            buttonReset = new Button();
            buttonSavePreset = new Button();
            labelPreset4 = new Label();
            labelPreset8 = new Label();
            buttonPreset8 = new Button();
            buttonPreset4 = new Button();
            labelPreset3 = new Label();
            labelPreset7 = new Label();
            buttonPreset7 = new Button();
            buttonPreset3 = new Button();
            labelPreset2 = new Label();
            labelPreset6 = new Label();
            buttonPreset6 = new Button();
            buttonPreset2 = new Button();
            labelPreset1 = new Label();
            labelPreset5 = new Label();
            buttonPreset5 = new Button();
            buttonPreset1 = new Button();
            pictureBoxRenderer = new PictureBox();
            sliderPlayTime = new MediaSlider.MediaSlider();
            menuStrip = new DarkUI.Controls.DarkMenuStrip();
            toolStripMenuItemFile = new ToolStripMenuItem();
            menuItemRecent1 = new ToolStripMenuItem();
            menuItemRecent2 = new ToolStripMenuItem();
            menuItemRecent3 = new ToolStripMenuItem();
            menuItemRecent4 = new ToolStripMenuItem();
            menuItemRecent5 = new ToolStripMenuItem();
            menuItemRecent6 = new ToolStripMenuItem();
            menuItemRecent7 = new ToolStripMenuItem();
            menuItemRecent8 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuItemExit = new ToolStripMenuItem();
            toolStripMenuHelp = new ToolStripMenuItem();
            menuItemAbout = new ToolStripMenuItem();
            overlayStart = new GlassyPanel();
            overlayEnd = new GlassyPanel();
            panelControls.SuspendLayout();
            toolStripChannels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)upDownCue).BeginInit();
            panelLoop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)upDownEndLoopMilliseconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownEndLoopSeconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownEndLoopMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownStartLoopMilliseconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownStartLoopSeconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownStartLoopMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownCurrentMilliseconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownCurrentSeconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upDownCurrentMinutes).BeginInit();
            panelPresets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRenderer).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "All Music Files|*.mp3;*.wav;*.ogg;*.flac;*.wma;*.aiff;*.m4a|MP3 files|*.mp3|WAV files|*.wav|Ogg Vorbis files|*.ogg|FLAC files|*.flac|WMA files|*.wma|AIFF files|*.aiff|M4A files|*.m4a";
            // 
            // labelFilename
            // 
            labelFilename.AutoSize = true;
            labelFilename.BackColor = System.Drawing.Color.Transparent;
            labelFilename.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelFilename.Location = new System.Drawing.Point(196, 33);
            labelFilename.Margin = new Padding(2, 0, 2, 0);
            labelFilename.Name = "labelFilename";
            labelFilename.Size = new System.Drawing.Size(97, 15);
            labelFilename.TabIndex = 2;
            labelFilename.Text = "<No file loaded>";
            labelFilename.Click += labelFilename_Click;
            // 
            // labelCurrentlyPlaying
            // 
            labelCurrentlyPlaying.AutoSize = true;
            labelCurrentlyPlaying.BackColor = System.Drawing.Color.Transparent;
            labelCurrentlyPlaying.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelCurrentlyPlaying.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelCurrentlyPlaying.Location = new System.Drawing.Point(74, 33);
            labelCurrentlyPlaying.Margin = new Padding(2, 0, 2, 0);
            labelCurrentlyPlaying.Name = "labelCurrentlyPlaying";
            labelCurrentlyPlaying.Size = new System.Drawing.Size(104, 15);
            labelCurrentlyPlaying.TabIndex = 3;
            labelCurrentlyPlaying.Text = "Currently playing:";
            labelCurrentlyPlaying.Click += labelCurrentlyPlaying_Click;
            // 
            // labelPlayDuration0Q
            // 
            labelPlayDuration0Q.AutoSize = true;
            labelPlayDuration0Q.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelPlayDuration0Q.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelPlayDuration0Q.Location = new System.Drawing.Point(4, 227);
            labelPlayDuration0Q.Margin = new Padding(2, 0, 2, 0);
            labelPlayDuration0Q.Name = "labelPlayDuration0Q";
            labelPlayDuration0Q.Size = new System.Drawing.Size(27, 12);
            labelPlayDuration0Q.TabIndex = 48;
            labelPlayDuration0Q.Text = "00:00";
            labelPlayDuration0Q.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPlayDuration1Q
            // 
            labelPlayDuration1Q.AutoSize = true;
            labelPlayDuration1Q.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelPlayDuration1Q.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelPlayDuration1Q.Location = new System.Drawing.Point(216, 227);
            labelPlayDuration1Q.Margin = new Padding(2, 0, 2, 0);
            labelPlayDuration1Q.Name = "labelPlayDuration1Q";
            labelPlayDuration1Q.Size = new System.Drawing.Size(27, 12);
            labelPlayDuration1Q.TabIndex = 49;
            labelPlayDuration1Q.Text = "00:00";
            labelPlayDuration1Q.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPlayDuration2Q
            // 
            labelPlayDuration2Q.AutoSize = true;
            labelPlayDuration2Q.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelPlayDuration2Q.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelPlayDuration2Q.Location = new System.Drawing.Point(435, 227);
            labelPlayDuration2Q.Margin = new Padding(2, 0, 2, 0);
            labelPlayDuration2Q.Name = "labelPlayDuration2Q";
            labelPlayDuration2Q.Size = new System.Drawing.Size(27, 12);
            labelPlayDuration2Q.TabIndex = 50;
            labelPlayDuration2Q.Text = "00:00";
            labelPlayDuration2Q.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPlayDuration3Q
            // 
            labelPlayDuration3Q.AutoSize = true;
            labelPlayDuration3Q.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelPlayDuration3Q.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelPlayDuration3Q.Location = new System.Drawing.Point(650, 227);
            labelPlayDuration3Q.Margin = new Padding(2, 0, 2, 0);
            labelPlayDuration3Q.Name = "labelPlayDuration3Q";
            labelPlayDuration3Q.Size = new System.Drawing.Size(27, 12);
            labelPlayDuration3Q.TabIndex = 51;
            labelPlayDuration3Q.Text = "00:00";
            labelPlayDuration3Q.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPlayDuration
            // 
            labelPlayDuration.AutoSize = true;
            labelPlayDuration.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelPlayDuration.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelPlayDuration.Location = new System.Drawing.Point(868, 227);
            labelPlayDuration.Margin = new Padding(2, 0, 2, 0);
            labelPlayDuration.Name = "labelPlayDuration";
            labelPlayDuration.Size = new System.Drawing.Size(27, 12);
            labelPlayDuration.TabIndex = 52;
            labelPlayDuration.Text = "00:00";
            labelPlayDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlayTimeUpdateTimer
            // 
            PlayTimeUpdateTimer.Interval = 50;
            PlayTimeUpdateTimer.Tick += PlayTimeUpdateTimer_Tick;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackgroundImage = Properties.Resources.OpenFolder;
            buttonOpenFile.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOpenFile.FlatStyle = FlatStyle.Flat;
            buttonOpenFile.Location = new System.Drawing.Point(8, 29);
            buttonOpenFile.Margin = new Padding(2, 1, 2, 1);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new System.Drawing.Size(24, 24);
            buttonOpenFile.TabIndex = 56;
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonPlay
            // 
            buttonPlay.BackgroundImage = Properties.Resources.Play;
            buttonPlay.BackgroundImageLayout = ImageLayout.Stretch;
            buttonPlay.FlatStyle = FlatStyle.Flat;
            buttonPlay.Location = new System.Drawing.Point(40, 29);
            buttonPlay.Margin = new Padding(2, 1, 2, 1);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new System.Drawing.Size(24, 24);
            buttonPlay.TabIndex = 57;
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // panelControls
            // 
            panelControls.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            panelControls.BorderStyle = BorderStyle.FixedSingle;
            panelControls.Controls.Add(labelChannel);
            panelControls.Controls.Add(label4);
            panelControls.Controls.Add(label3);
            panelControls.Controls.Add(toolStripChannels);
            panelControls.Controls.Add(comboBoxTimeStretchProfile);
            panelControls.Controls.Add(upDownCue);
            panelControls.Controls.Add(sliderEQHi);
            panelControls.Controls.Add(sliderEQMid);
            panelControls.Controls.Add(sliderEQLow);
            panelControls.Controls.Add(sliderVolume);
            panelControls.Controls.Add(sliderPitch);
            panelControls.Controls.Add(sliderTempo);
            panelControls.Controls.Add(labelEQMidValue);
            panelControls.Controls.Add(labelEQLowValue);
            panelControls.Controls.Add(labelCueSeconds);
            panelControls.Controls.Add(labelCue);
            panelControls.Controls.Add(labelTimeStretchProfile);
            panelControls.Controls.Add(labelEQHiValue);
            panelControls.Controls.Add(labelVolumeValue);
            panelControls.Controls.Add(labelSemitones);
            panelControls.Controls.Add(labelPitchValue);
            panelControls.Controls.Add(labelTempoValue);
            panelControls.Controls.Add(checkBoxSuppressVocals);
            panelControls.Controls.Add(checkBoxSwapLR);
            panelControls.Controls.Add(labelEQMid);
            panelControls.Controls.Add(labelEQHi);
            panelControls.Controls.Add(labelEQLow);
            panelControls.Controls.Add(labelEQMin100pc);
            panelControls.Controls.Add(labelEQ0pc);
            panelControls.Controls.Add(labelEQ100pc);
            panelControls.Controls.Add(labelEqualizer);
            panelControls.Controls.Add(labelVolume25pc);
            panelControls.Controls.Add(labelVolume75pc);
            panelControls.Controls.Add(labelVolume0pc);
            panelControls.Controls.Add(labelVolume50pc);
            panelControls.Controls.Add(labelVolume100pc);
            panelControls.Controls.Add(label5);
            panelControls.Controls.Add(labelPitch8vb);
            panelControls.Controls.Add(labelPitch0);
            panelControls.Controls.Add(labelPitch8va);
            panelControls.Controls.Add(labelPitch);
            panelControls.Controls.Add(labelX15);
            panelControls.Controls.Add(labelX05);
            panelControls.Controls.Add(labelX01);
            panelControls.Controls.Add(labelX10);
            panelControls.Controls.Add(labelX20);
            panelControls.Controls.Add(label1);
            panelControls.Location = new System.Drawing.Point(8, 241);
            panelControls.Margin = new Padding(2, 1, 2, 1);
            panelControls.Name = "panelControls";
            panelControls.Size = new System.Drawing.Size(645, 365);
            panelControls.TabIndex = 62;
            // 
            // labelChannel
            // 
            labelChannel.AutoSize = true;
            labelChannel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelChannel.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelChannel.Location = new System.Drawing.Point(519, 28);
            labelChannel.Margin = new Padding(2, 0, 2, 0);
            labelChannel.Name = "labelChannel";
            labelChannel.Size = new System.Drawing.Size(51, 15);
            labelChannel.TabIndex = 92;
            labelChannel.Text = "Channel";
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(515, 38);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 8);
            label4.TabIndex = 117;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(508, 126);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 30);
            label3.TabIndex = 116;
            // 
            // toolStripChannels
            // 
            toolStripChannels.AutoSize = false;
            toolStripChannels.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolStripChannels.Dock = DockStyle.None;
            toolStripChannels.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripChannels.ImageScalingSize = new System.Drawing.Size(93, 36);
            toolStripChannels.Items.AddRange(new ToolStripItem[] { buttonChannelBoth, buttonChannelLeft, buttonChannelRight, buttonChannelDualMono });
            toolStripChannels.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStripChannels.Location = new System.Drawing.Point(520, 38);
            toolStripChannels.Name = "toolStripChannels";
            toolStripChannels.Padding = new Padding(3, 0, 1, 0);
            toolStripChannels.RenderMode = ToolStripRenderMode.System;
            toolStripChannels.Size = new System.Drawing.Size(72, 99);
            toolStripChannels.TabIndex = 115;
            toolStripChannels.ItemClicked += toolStripChannels_ItemClicked;
            // 
            // buttonChannelBoth
            // 
            buttonChannelBoth.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            buttonChannelBoth.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buttonChannelBoth.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            buttonChannelBoth.ImageScaling = ToolStripItemImageScaling.None;
            buttonChannelBoth.ImageTransparentColor = System.Drawing.Color.Magenta;
            buttonChannelBoth.Name = "buttonChannelBoth";
            buttonChannelBoth.Overflow = ToolStripItemOverflow.Never;
            buttonChannelBoth.Size = new System.Drawing.Size(67, 19);
            buttonChannelBoth.Text = "BOTH";
            buttonChannelBoth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonChannelLeft
            // 
            buttonChannelLeft.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            buttonChannelLeft.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buttonChannelLeft.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            buttonChannelLeft.ImageScaling = ToolStripItemImageScaling.None;
            buttonChannelLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            buttonChannelLeft.Name = "buttonChannelLeft";
            buttonChannelLeft.Size = new System.Drawing.Size(67, 19);
            buttonChannelLeft.Text = "LEFT";
            buttonChannelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonChannelRight
            // 
            buttonChannelRight.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            buttonChannelRight.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buttonChannelRight.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            buttonChannelRight.ImageScaling = ToolStripItemImageScaling.None;
            buttonChannelRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            buttonChannelRight.Name = "buttonChannelRight";
            buttonChannelRight.Size = new System.Drawing.Size(67, 19);
            buttonChannelRight.Text = "RIGHT";
            buttonChannelRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonChannelDualMono
            // 
            buttonChannelDualMono.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            buttonChannelDualMono.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buttonChannelDualMono.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            buttonChannelDualMono.ImageScaling = ToolStripItemImageScaling.None;
            buttonChannelDualMono.ImageTransparentColor = System.Drawing.Color.Magenta;
            buttonChannelDualMono.Name = "buttonChannelDualMono";
            buttonChannelDualMono.Size = new System.Drawing.Size(24, 24);
            buttonChannelDualMono.Text = "MONO";
            buttonChannelDualMono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxTimeStretchProfile
            // 
            comboBoxTimeStretchProfile.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxTimeStretchProfile.FormattingEnabled = true;
            comboBoxTimeStretchProfile.Location = new System.Drawing.Point(66, 328);
            comboBoxTimeStretchProfile.Margin = new Padding(2, 1, 2, 1);
            comboBoxTimeStretchProfile.Name = "comboBoxTimeStretchProfile";
            comboBoxTimeStretchProfile.Size = new System.Drawing.Size(252, 24);
            comboBoxTimeStretchProfile.TabIndex = 114;
            comboBoxTimeStretchProfile.SelectedIndexChanged += comboBoxTimeStretchProfile_SelectedIndexChanged;
            // 
            // upDownCue
            // 
            upDownCue.Location = new System.Drawing.Point(372, 329);
            upDownCue.Margin = new Padding(2, 1, 2, 1);
            upDownCue.Name = "upDownCue";
            upDownCue.Size = new System.Drawing.Size(37, 23);
            upDownCue.TabIndex = 113;
            upDownCue.ValueChanged += upDownCue_ValueChanged;
            // 
            // sliderEQHi
            // 
            sliderEQHi.AccessibleRole = AccessibleRole.TitleBar;
            sliderEQHi.Animated = false;
            sliderEQHi.AnimationSize = 0.2F;
            sliderEQHi.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            sliderEQHi.AutoScrollMargin = new System.Drawing.Size(0, 0);
            sliderEQHi.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            sliderEQHi.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            sliderEQHi.BackGroundImage = null;
            sliderEQHi.ButtonAccentColor = System.Drawing.Color.FromArgb(128, 64, 64, 64);
            sliderEQHi.ButtonBorderColor = System.Drawing.Color.Black;
            sliderEQHi.ButtonColor = System.Drawing.Color.FromArgb(160, 0, 0, 0);
            sliderEQHi.ButtonCornerRadius = 2U;
            sliderEQHi.ButtonSize = new System.Drawing.Size(56, 28);
            sliderEQHi.ButtonStyle = MediaSlider.MediaSlider.ButtonType.GlassOverlap;
            sliderEQHi.LargeChange = 20;
            sliderEQHi.Location = new System.Drawing.Point(447, 50);
            sliderEQHi.Margin = new Padding(0);
            sliderEQHi.Maximum = 100;
            sliderEQHi.Minimum = -100;
            sliderEQHi.Name = "sliderEQHi";
            sliderEQHi.Orientation = Orientation.Vertical;
            sliderEQHi.ShowButtonOnHover = false;
            sliderEQHi.Size = new System.Drawing.Size(41, 240);
            sliderEQHi.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            sliderEQHi.SmallChange = 1;
            sliderEQHi.SmoothScrolling = false;
            sliderEQHi.TabIndex = 112;
            sliderEQHi.TickColor = System.Drawing.Color.DarkGray;
            sliderEQHi.TickStyle = TickStyle.Both;
            sliderEQHi.TickType = MediaSlider.MediaSlider.TickMode.LargeStepped;
            sliderEQHi.TrackBorderColor = System.Drawing.Color.FromArgb(160, 255, 255, 255);
            sliderEQHi.TrackDepth = 4;
            sliderEQHi.TrackFillColor = System.Drawing.Color.Transparent;
            sliderEQHi.TrackProgressColor = System.Drawing.Color.FromArgb(5, 101, 188);
            sliderEQHi.TrackShadow = false;
            sliderEQHi.TrackShadowColor = System.Drawing.Color.DarkGray;
            sliderEQHi.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            sliderEQHi.Value = 0;
            sliderEQHi.ValueChanged += sliderEQHi_ValueChanged;
            // 
            // sliderEQMid
            // 
            sliderEQMid.AccessibleRole = AccessibleRole.TitleBar;
            sliderEQMid.Animated = false;
            sliderEQMid.AnimationSize = 0.2F;
            sliderEQMid.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            sliderEQMid.AutoScrollMargin = new System.Drawing.Size(0, 0);
            sliderEQMid.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            sliderEQMid.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            sliderEQMid.BackGroundImage = null;
            sliderEQMid.ButtonAccentColor = System.Drawing.Color.FromArgb(128, 64, 64, 64);
            sliderEQMid.ButtonBorderColor = System.Drawing.Color.Black;
            sliderEQMid.ButtonColor = System.Drawing.Color.FromArgb(160, 0, 0, 0);
            sliderEQMid.ButtonCornerRadius = 2U;
            sliderEQMid.ButtonSize = new System.Drawing.Size(56, 28);
            sliderEQMid.ButtonStyle = MediaSlider.MediaSlider.ButtonType.GlassOverlap;
            sliderEQMid.LargeChange = 20;
            sliderEQMid.Location = new System.Drawing.Point(403, 50);
            sliderEQMid.Margin = new Padding(0);
            sliderEQMid.Maximum = 100;
            sliderEQMid.Minimum = -100;
            sliderEQMid.Name = "sliderEQMid";
            sliderEQMid.Orientation = Orientation.Vertical;
            sliderEQMid.ShowButtonOnHover = false;
            sliderEQMid.Size = new System.Drawing.Size(41, 240);
            sliderEQMid.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            sliderEQMid.SmallChange = 1;
            sliderEQMid.SmoothScrolling = false;
            sliderEQMid.TabIndex = 111;
            sliderEQMid.TickColor = System.Drawing.Color.DarkGray;
            sliderEQMid.TickStyle = TickStyle.Both;
            sliderEQMid.TickType = MediaSlider.MediaSlider.TickMode.LargeStepped;
            sliderEQMid.TrackBorderColor = System.Drawing.Color.FromArgb(160, 255, 255, 255);
            sliderEQMid.TrackDepth = 4;
            sliderEQMid.TrackFillColor = System.Drawing.Color.Transparent;
            sliderEQMid.TrackProgressColor = System.Drawing.Color.FromArgb(5, 101, 188);
            sliderEQMid.TrackShadow = false;
            sliderEQMid.TrackShadowColor = System.Drawing.Color.DarkGray;
            sliderEQMid.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            sliderEQMid.Value = 0;
            sliderEQMid.ValueChanged += sliderEQMid_ValueChanged;
            // 
            // sliderEQLow
            // 
            sliderEQLow.AccessibleRole = AccessibleRole.TitleBar;
            sliderEQLow.Animated = false;
            sliderEQLow.AnimationSize = 0.2F;
            sliderEQLow.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            sliderEQLow.AutoScrollMargin = new System.Drawing.Size(0, 0);
            sliderEQLow.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            sliderEQLow.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            sliderEQLow.BackGroundImage = null;
            sliderEQLow.ButtonAccentColor = System.Drawing.Color.FromArgb(128, 64, 64, 64);
            sliderEQLow.ButtonBorderColor = System.Drawing.Color.Black;
            sliderEQLow.ButtonColor = System.Drawing.Color.FromArgb(160, 0, 0, 0);
            sliderEQLow.ButtonCornerRadius = 2U;
            sliderEQLow.ButtonSize = new System.Drawing.Size(56, 28);
            sliderEQLow.ButtonStyle = MediaSlider.MediaSlider.ButtonType.GlassOverlap;
            sliderEQLow.LargeChange = 20;
            sliderEQLow.Location = new System.Drawing.Point(361, 50);
            sliderEQLow.Margin = new Padding(0);
            sliderEQLow.Maximum = 100;
            sliderEQLow.Minimum = -100;
            sliderEQLow.Name = "sliderEQLow";
            sliderEQLow.Orientation = Orientation.Vertical;
            sliderEQLow.ShowButtonOnHover = false;
            sliderEQLow.Size = new System.Drawing.Size(41, 240);
            sliderEQLow.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            sliderEQLow.SmallChange = 1;
            sliderEQLow.SmoothScrolling = false;
            sliderEQLow.TabIndex = 110;
            sliderEQLow.TickColor = System.Drawing.Color.DarkGray;
            sliderEQLow.TickStyle = TickStyle.Both;
            sliderEQLow.TickType = MediaSlider.MediaSlider.TickMode.LargeStepped;
            sliderEQLow.TrackBorderColor = System.Drawing.Color.FromArgb(160, 255, 255, 255);
            sliderEQLow.TrackDepth = 4;
            sliderEQLow.TrackFillColor = System.Drawing.Color.Transparent;
            sliderEQLow.TrackProgressColor = System.Drawing.Color.FromArgb(5, 101, 188);
            sliderEQLow.TrackShadow = false;
            sliderEQLow.TrackShadowColor = System.Drawing.Color.DarkGray;
            sliderEQLow.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            sliderEQLow.Value = 0;
            sliderEQLow.ValueChanged += sliderEQLow_ValueChanged;
            // 
            // sliderVolume
            // 
            sliderVolume.AccessibleRole = AccessibleRole.TitleBar;
            sliderVolume.Animated = false;
            sliderVolume.AnimationSize = 0.2F;
            sliderVolume.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            sliderVolume.AutoScrollMargin = new System.Drawing.Size(0, 0);
            sliderVolume.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            sliderVolume.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            sliderVolume.BackGroundImage = null;
            sliderVolume.ButtonAccentColor = System.Drawing.Color.FromArgb(128, 64, 64, 64);
            sliderVolume.ButtonBorderColor = System.Drawing.Color.Black;
            sliderVolume.ButtonColor = System.Drawing.Color.FromArgb(160, 0, 0, 0);
            sliderVolume.ButtonCornerRadius = 2U;
            sliderVolume.ButtonSize = new System.Drawing.Size(56, 28);
            sliderVolume.ButtonStyle = MediaSlider.MediaSlider.ButtonType.GlassOverlap;
            sliderVolume.LargeChange = 10;
            sliderVolume.Location = new System.Drawing.Point(260, 50);
            sliderVolume.Margin = new Padding(0);
            sliderVolume.Maximum = 100;
            sliderVolume.Minimum = 0;
            sliderVolume.Name = "sliderVolume";
            sliderVolume.Orientation = Orientation.Vertical;
            sliderVolume.ShowButtonOnHover = false;
            sliderVolume.Size = new System.Drawing.Size(41, 240);
            sliderVolume.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            sliderVolume.SmallChange = 1;
            sliderVolume.SmoothScrolling = false;
            sliderVolume.TabIndex = 109;
            sliderVolume.TickColor = System.Drawing.Color.DarkGray;
            sliderVolume.TickStyle = TickStyle.Both;
            sliderVolume.TickType = MediaSlider.MediaSlider.TickMode.LargeStepped;
            sliderVolume.TrackBorderColor = System.Drawing.Color.FromArgb(160, 255, 255, 255);
            sliderVolume.TrackDepth = 4;
            sliderVolume.TrackFillColor = System.Drawing.Color.Transparent;
            sliderVolume.TrackProgressColor = System.Drawing.Color.FromArgb(5, 101, 188);
            sliderVolume.TrackShadow = true;
            sliderVolume.TrackShadowColor = System.Drawing.Color.DarkGray;
            sliderVolume.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            sliderVolume.Value = 75;
            sliderVolume.ValueChanged += sliderVolume_ValueChanged;
            // 
            // sliderPitch
            // 
            sliderPitch.AccessibleRole = AccessibleRole.TitleBar;
            sliderPitch.Animated = false;
            sliderPitch.AnimationSize = 0.2F;
            sliderPitch.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            sliderPitch.AutoScrollMargin = new System.Drawing.Size(0, 0);
            sliderPitch.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            sliderPitch.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            sliderPitch.BackGroundImage = null;
            sliderPitch.ButtonAccentColor = System.Drawing.Color.FromArgb(128, 64, 64, 64);
            sliderPitch.ButtonBorderColor = System.Drawing.Color.Black;
            sliderPitch.ButtonColor = System.Drawing.Color.FromArgb(160, 0, 0, 0);
            sliderPitch.ButtonCornerRadius = 2U;
            sliderPitch.ButtonSize = new System.Drawing.Size(56, 28);
            sliderPitch.ButtonStyle = MediaSlider.MediaSlider.ButtonType.GlassOverlap;
            sliderPitch.LargeChange = 8;
            sliderPitch.Location = new System.Drawing.Point(135, 50);
            sliderPitch.Margin = new Padding(0);
            sliderPitch.Maximum = 96;
            sliderPitch.Minimum = -96;
            sliderPitch.Name = "sliderPitch";
            sliderPitch.Orientation = Orientation.Vertical;
            sliderPitch.ShowButtonOnHover = false;
            sliderPitch.Size = new System.Drawing.Size(41, 240);
            sliderPitch.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            sliderPitch.SmallChange = 1;
            sliderPitch.SmoothScrolling = false;
            sliderPitch.TabIndex = 108;
            sliderPitch.TickColor = System.Drawing.Color.DarkGray;
            sliderPitch.TickStyle = TickStyle.Both;
            sliderPitch.TickType = MediaSlider.MediaSlider.TickMode.LargeStepped;
            sliderPitch.TrackBorderColor = System.Drawing.Color.FromArgb(160, 255, 255, 255);
            sliderPitch.TrackDepth = 4;
            sliderPitch.TrackFillColor = System.Drawing.Color.Transparent;
            sliderPitch.TrackProgressColor = System.Drawing.Color.FromArgb(5, 101, 188);
            sliderPitch.TrackShadow = false;
            sliderPitch.TrackShadowColor = System.Drawing.Color.DarkGray;
            sliderPitch.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            sliderPitch.Value = 0;
            sliderPitch.ValueChanged += sliderPitch_ValueChanged;
            // 
            // sliderTempo
            // 
            sliderTempo.Animated = false;
            sliderTempo.AnimationSize = 0.2F;
            sliderTempo.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            sliderTempo.AutoScrollMargin = new System.Drawing.Size(0, 0);
            sliderTempo.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            sliderTempo.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            sliderTempo.BackGroundImage = null;
            sliderTempo.ButtonAccentColor = System.Drawing.Color.FromArgb(128, 64, 64, 64);
            sliderTempo.ButtonBorderColor = System.Drawing.Color.Black;
            sliderTempo.ButtonColor = System.Drawing.Color.FromArgb(160, 0, 0, 0);
            sliderTempo.ButtonCornerRadius = 2U;
            sliderTempo.ButtonSize = new System.Drawing.Size(56, 28);
            sliderTempo.ButtonStyle = MediaSlider.MediaSlider.ButtonType.GlassOverlap;
            sliderTempo.LargeChange = 20;
            sliderTempo.Location = new System.Drawing.Point(47, 50);
            sliderTempo.Margin = new Padding(0);
            sliderTempo.Maximum = 200;
            sliderTempo.Minimum = 10;
            sliderTempo.Name = "sliderTempo";
            sliderTempo.Orientation = Orientation.Vertical;
            sliderTempo.ShowButtonOnHover = false;
            sliderTempo.Size = new System.Drawing.Size(41, 240);
            sliderTempo.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            sliderTempo.SmallChange = 1;
            sliderTempo.SmoothScrolling = false;
            sliderTempo.TabIndex = 107;
            sliderTempo.TickColor = System.Drawing.Color.DarkGray;
            sliderTempo.TickStyle = TickStyle.Both;
            sliderTempo.TickType = MediaSlider.MediaSlider.TickMode.LargeStepped;
            sliderTempo.TrackBorderColor = System.Drawing.Color.FromArgb(160, 255, 255, 255);
            sliderTempo.TrackDepth = 4;
            sliderTempo.TrackFillColor = System.Drawing.Color.Transparent;
            sliderTempo.TrackProgressColor = System.Drawing.Color.FromArgb(5, 101, 188);
            sliderTempo.TrackShadow = false;
            sliderTempo.TrackShadowColor = System.Drawing.Color.DarkGray;
            sliderTempo.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            sliderTempo.Value = 100;
            sliderTempo.ValueChanged += sliderTempo_ValueChanged;
            // 
            // labelEQMidValue
            // 
            labelEQMidValue.Location = new System.Drawing.Point(403, 291);
            labelEQMidValue.Margin = new Padding(2, 0, 2, 0);
            labelEQMidValue.Name = "labelEQMidValue";
            labelEQMidValue.Size = new System.Drawing.Size(38, 15);
            labelEQMidValue.TabIndex = 106;
            labelEQMidValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelEQLowValue
            // 
            labelEQLowValue.Location = new System.Drawing.Point(362, 291);
            labelEQLowValue.Margin = new Padding(2, 0, 2, 0);
            labelEQLowValue.Name = "labelEQLowValue";
            labelEQLowValue.Size = new System.Drawing.Size(38, 15);
            labelEQLowValue.TabIndex = 105;
            labelEQLowValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCueSeconds
            // 
            labelCueSeconds.AutoSize = true;
            labelCueSeconds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCueSeconds.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelCueSeconds.Location = new System.Drawing.Point(412, 330);
            labelCueSeconds.Margin = new Padding(2, 0, 2, 0);
            labelCueSeconds.Name = "labelCueSeconds";
            labelCueSeconds.Size = new System.Drawing.Size(29, 15);
            labelCueSeconds.TabIndex = 104;
            labelCueSeconds.Text = "secs";
            // 
            // labelCue
            // 
            labelCue.AutoSize = true;
            labelCue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelCue.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelCue.Location = new System.Drawing.Point(338, 330);
            labelCue.Margin = new Padding(2, 0, 2, 0);
            labelCue.Name = "labelCue";
            labelCue.Size = new System.Drawing.Size(28, 15);
            labelCue.TabIndex = 103;
            labelCue.Text = "Cue";
            // 
            // labelTimeStretchProfile
            // 
            labelTimeStretchProfile.AutoSize = true;
            labelTimeStretchProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTimeStretchProfile.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelTimeStretchProfile.Location = new System.Drawing.Point(6, 328);
            labelTimeStretchProfile.Margin = new Padding(2, 0, 2, 0);
            labelTimeStretchProfile.Name = "labelTimeStretchProfile";
            labelTimeStretchProfile.Size = new System.Drawing.Size(47, 15);
            labelTimeStretchProfile.TabIndex = 100;
            labelTimeStretchProfile.Text = "Profile:";
            // 
            // labelEQHiValue
            // 
            labelEQHiValue.Location = new System.Drawing.Point(442, 291);
            labelEQHiValue.Margin = new Padding(2, 0, 2, 0);
            labelEQHiValue.Name = "labelEQHiValue";
            labelEQHiValue.Size = new System.Drawing.Size(38, 15);
            labelEQHiValue.TabIndex = 99;
            labelEQHiValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelVolumeValue
            // 
            labelVolumeValue.Location = new System.Drawing.Point(255, 291);
            labelVolumeValue.Margin = new Padding(2, 0, 2, 0);
            labelVolumeValue.Name = "labelVolumeValue";
            labelVolumeValue.Size = new System.Drawing.Size(38, 15);
            labelVolumeValue.TabIndex = 98;
            labelVolumeValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSemitones
            // 
            labelSemitones.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelSemitones.Location = new System.Drawing.Point(126, 306);
            labelSemitones.Margin = new Padding(2, 0, 2, 0);
            labelSemitones.Name = "labelSemitones";
            labelSemitones.Size = new System.Drawing.Size(58, 15);
            labelSemitones.TabIndex = 97;
            labelSemitones.Text = "Semi-tones";
            labelSemitones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPitchValue
            // 
            labelPitchValue.Location = new System.Drawing.Point(135, 291);
            labelPitchValue.Margin = new Padding(2, 0, 2, 0);
            labelPitchValue.Name = "labelPitchValue";
            labelPitchValue.Size = new System.Drawing.Size(38, 15);
            labelPitchValue.TabIndex = 96;
            labelPitchValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTempoValue
            // 
            labelTempoValue.ForeColor = System.Drawing.Color.White;
            labelTempoValue.Location = new System.Drawing.Point(47, 291);
            labelTempoValue.Margin = new Padding(2, 0, 2, 0);
            labelTempoValue.Name = "labelTempoValue";
            labelTempoValue.Size = new System.Drawing.Size(38, 15);
            labelTempoValue.TabIndex = 95;
            labelTempoValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxSuppressVocals
            // 
            checkBoxSuppressVocals.AutoSize = true;
            checkBoxSuppressVocals.FlatStyle = FlatStyle.Flat;
            checkBoxSuppressVocals.Location = new System.Drawing.Point(515, 274);
            checkBoxSuppressVocals.Margin = new Padding(2, 1, 2, 1);
            checkBoxSuppressVocals.Name = "checkBoxSuppressVocals";
            checkBoxSuppressVocals.Size = new System.Drawing.Size(106, 19);
            checkBoxSuppressVocals.TabIndex = 94;
            checkBoxSuppressVocals.Text = "Suppress Vocals";
            checkBoxSuppressVocals.UseVisualStyleBackColor = true;
            checkBoxSuppressVocals.CheckedChanged += checkBoxSuppressVocals_CheckedChanged;
            // 
            // checkBoxSwapLR
            // 
            checkBoxSwapLR.AutoSize = true;
            checkBoxSwapLR.FlatStyle = FlatStyle.Flat;
            checkBoxSwapLR.Location = new System.Drawing.Point(515, 254);
            checkBoxSwapLR.Margin = new Padding(2, 1, 2, 1);
            checkBoxSwapLR.Name = "checkBoxSwapLR";
            checkBoxSwapLR.Size = new System.Drawing.Size(72, 19);
            checkBoxSwapLR.TabIndex = 93;
            checkBoxSwapLR.Text = "Swap L/R";
            checkBoxSwapLR.UseVisualStyleBackColor = true;
            checkBoxSwapLR.CheckedChanged += checkBoxSwapLR_CheckedChanged;
            // 
            // labelEQMid
            // 
            labelEQMid.AutoSize = true;
            labelEQMid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelEQMid.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelEQMid.Location = new System.Drawing.Point(409, 28);
            labelEQMid.Margin = new Padding(2, 0, 2, 0);
            labelEQMid.Name = "labelEQMid";
            labelEQMid.Size = new System.Drawing.Size(28, 15);
            labelEQMid.TabIndex = 90;
            labelEQMid.Text = "Mid";
            // 
            // labelEQHi
            // 
            labelEQHi.AutoSize = true;
            labelEQHi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelEQHi.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelEQHi.Location = new System.Drawing.Point(458, 28);
            labelEQHi.Margin = new Padding(2, 0, 2, 0);
            labelEQHi.Name = "labelEQHi";
            labelEQHi.Size = new System.Drawing.Size(19, 15);
            labelEQHi.TabIndex = 88;
            labelEQHi.Text = "Hi";
            // 
            // labelEQLow
            // 
            labelEQLow.AutoSize = true;
            labelEQLow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelEQLow.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelEQLow.Location = new System.Drawing.Point(366, 28);
            labelEQLow.Margin = new Padding(2, 0, 2, 0);
            labelEQLow.Name = "labelEQLow";
            labelEQLow.Size = new System.Drawing.Size(30, 15);
            labelEQLow.TabIndex = 86;
            labelEQLow.Text = "Low";
            // 
            // labelEQMin100pc
            // 
            labelEQMin100pc.AutoSize = true;
            labelEQMin100pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelEQMin100pc.Location = new System.Drawing.Point(325, 277);
            labelEQMin100pc.Margin = new Padding(2, 0, 2, 0);
            labelEQMin100pc.Name = "labelEQMin100pc";
            labelEQMin100pc.Size = new System.Drawing.Size(31, 12);
            labelEQMin100pc.TabIndex = 85;
            labelEQMin100pc.Text = "-100%";
            labelEQMin100pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEQ0pc
            // 
            labelEQ0pc.AutoSize = true;
            labelEQ0pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelEQ0pc.ForeColor = System.Drawing.Color.White;
            labelEQ0pc.Location = new System.Drawing.Point(339, 164);
            labelEQ0pc.Margin = new Padding(2, 0, 2, 0);
            labelEQ0pc.Name = "labelEQ0pc";
            labelEQ0pc.Size = new System.Drawing.Size(17, 12);
            labelEQ0pc.TabIndex = 84;
            labelEQ0pc.Text = "0%";
            labelEQ0pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEQ100pc
            // 
            labelEQ100pc.AutoSize = true;
            labelEQ100pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelEQ100pc.Location = new System.Drawing.Point(328, 50);
            labelEQ100pc.Margin = new Padding(2, 0, 2, 0);
            labelEQ100pc.Name = "labelEQ100pc";
            labelEQ100pc.Size = new System.Drawing.Size(27, 12);
            labelEQ100pc.TabIndex = 83;
            labelEQ100pc.Text = "100%";
            labelEQ100pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEqualizer
            // 
            labelEqualizer.AutoSize = true;
            labelEqualizer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelEqualizer.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelEqualizer.Location = new System.Drawing.Point(392, 13);
            labelEqualizer.Margin = new Padding(2, 0, 2, 0);
            labelEqualizer.Name = "labelEqualizer";
            labelEqualizer.Size = new System.Drawing.Size(57, 15);
            labelEqualizer.TabIndex = 82;
            labelEqualizer.Text = "Equalizer";
            // 
            // labelVolume25pc
            // 
            labelVolume25pc.AutoSize = true;
            labelVolume25pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelVolume25pc.Location = new System.Drawing.Point(233, 220);
            labelVolume25pc.Margin = new Padding(2, 0, 2, 0);
            labelVolume25pc.Name = "labelVolume25pc";
            labelVolume25pc.Size = new System.Drawing.Size(22, 12);
            labelVolume25pc.TabIndex = 80;
            labelVolume25pc.Text = "25%";
            labelVolume25pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVolume75pc
            // 
            labelVolume75pc.AutoSize = true;
            labelVolume75pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelVolume75pc.Location = new System.Drawing.Point(233, 109);
            labelVolume75pc.Margin = new Padding(2, 0, 2, 0);
            labelVolume75pc.Name = "labelVolume75pc";
            labelVolume75pc.Size = new System.Drawing.Size(22, 12);
            labelVolume75pc.TabIndex = 79;
            labelVolume75pc.Text = "75%";
            labelVolume75pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVolume0pc
            // 
            labelVolume0pc.AutoSize = true;
            labelVolume0pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelVolume0pc.Location = new System.Drawing.Point(238, 277);
            labelVolume0pc.Margin = new Padding(2, 0, 2, 0);
            labelVolume0pc.Name = "labelVolume0pc";
            labelVolume0pc.Size = new System.Drawing.Size(17, 12);
            labelVolume0pc.TabIndex = 78;
            labelVolume0pc.Text = "0%";
            labelVolume0pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVolume50pc
            // 
            labelVolume50pc.AutoSize = true;
            labelVolume50pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelVolume50pc.Location = new System.Drawing.Point(233, 164);
            labelVolume50pc.Margin = new Padding(2, 0, 2, 0);
            labelVolume50pc.Name = "labelVolume50pc";
            labelVolume50pc.Size = new System.Drawing.Size(22, 12);
            labelVolume50pc.TabIndex = 77;
            labelVolume50pc.Text = "50%";
            labelVolume50pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVolume100pc
            // 
            labelVolume100pc.AutoSize = true;
            labelVolume100pc.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelVolume100pc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            labelVolume100pc.Location = new System.Drawing.Point(227, 50);
            labelVolume100pc.Margin = new Padding(2, 0, 2, 0);
            labelVolume100pc.Name = "labelVolume100pc";
            labelVolume100pc.Size = new System.Drawing.Size(27, 12);
            labelVolume100pc.TabIndex = 76;
            labelVolume100pc.Text = "100%";
            labelVolume100pc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            label5.Location = new System.Drawing.Point(243, 28);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 15);
            label5.TabIndex = 75;
            label5.Text = "Volume";
            // 
            // labelPitch8vb
            // 
            labelPitch8vb.AutoSize = true;
            labelPitch8vb.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelPitch8vb.Location = new System.Drawing.Point(113, 277);
            labelPitch8vb.Margin = new Padding(2, 0, 2, 0);
            labelPitch8vb.Name = "labelPitch8vb";
            labelPitch8vb.Size = new System.Drawing.Size(19, 12);
            labelPitch8vb.TabIndex = 73;
            labelPitch8vb.Text = "8vb";
            labelPitch8vb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPitch0
            // 
            labelPitch0.AutoSize = true;
            labelPitch0.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelPitch0.Location = new System.Drawing.Point(113, 164);
            labelPitch0.Margin = new Padding(2, 0, 2, 0);
            labelPitch0.Name = "labelPitch0";
            labelPitch0.Size = new System.Drawing.Size(10, 12);
            labelPitch0.TabIndex = 72;
            labelPitch0.Text = "0";
            labelPitch0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPitch8va
            // 
            labelPitch8va.AutoSize = true;
            labelPitch8va.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelPitch8va.Location = new System.Drawing.Point(113, 50);
            labelPitch8va.Margin = new Padding(2, 0, 2, 0);
            labelPitch8va.Name = "labelPitch8va";
            labelPitch8va.Size = new System.Drawing.Size(19, 12);
            labelPitch8va.TabIndex = 71;
            labelPitch8va.Text = "8va";
            labelPitch8va.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPitch
            // 
            labelPitch.AutoSize = true;
            labelPitch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPitch.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelPitch.Location = new System.Drawing.Point(135, 28);
            labelPitch.Margin = new Padding(2, 0, 2, 0);
            labelPitch.Name = "labelPitch";
            labelPitch.Size = new System.Drawing.Size(35, 15);
            labelPitch.TabIndex = 70;
            labelPitch.Text = "Pitch";
            // 
            // labelX15
            // 
            labelX15.AutoSize = true;
            labelX15.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelX15.Location = new System.Drawing.Point(25, 105);
            labelX15.Margin = new Padding(2, 0, 2, 0);
            labelX15.Name = "labelX15";
            labelX15.Size = new System.Drawing.Size(21, 12);
            labelX15.TabIndex = 68;
            labelX15.Text = "x1.5";
            labelX15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelX05
            // 
            labelX05.AutoSize = true;
            labelX05.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelX05.Location = new System.Drawing.Point(22, 233);
            labelX05.Margin = new Padding(2, 0, 2, 0);
            labelX05.Name = "labelX05";
            labelX05.Size = new System.Drawing.Size(21, 12);
            labelX05.TabIndex = 67;
            labelX05.Text = "x0.5";
            labelX05.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelX01
            // 
            labelX01.AutoSize = true;
            labelX01.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelX01.Location = new System.Drawing.Point(25, 277);
            labelX01.Margin = new Padding(2, 0, 2, 0);
            labelX01.Name = "labelX01";
            labelX01.Size = new System.Drawing.Size(21, 12);
            labelX01.TabIndex = 66;
            labelX01.Text = "x0.1";
            labelX01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelX10
            // 
            labelX10.AutoSize = true;
            labelX10.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelX10.Location = new System.Drawing.Point(25, 170);
            labelX10.Margin = new Padding(2, 0, 2, 0);
            labelX10.Name = "labelX10";
            labelX10.Size = new System.Drawing.Size(21, 12);
            labelX10.TabIndex = 65;
            labelX10.Text = "x1.0";
            labelX10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelX20
            // 
            labelX20.AutoSize = true;
            labelX20.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelX20.Location = new System.Drawing.Point(25, 50);
            labelX20.Margin = new Padding(2, 0, 2, 0);
            labelX20.Name = "labelX20";
            labelX20.Size = new System.Drawing.Size(21, 12);
            labelX20.TabIndex = 64;
            labelX20.Text = "x2.0";
            labelX20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            label1.Location = new System.Drawing.Point(40, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 63;
            label1.Text = "Tempo";
            // 
            // overlayPosition
            // 
            overlayPosition.BackColor = System.Drawing.Color.Transparent;
            overlayPosition.BorderStyle = BorderStyle.FixedSingle;
            overlayPosition.Location = new System.Drawing.Point(8, 59);
            overlayPosition.Margin = new Padding(2, 0, 2, 0);
            overlayPosition.Name = "overlayPosition";
            overlayPosition.Size = new System.Drawing.Size(2, 151);
            overlayPosition.TabIndex = 66;
            // 
            // panelLoop
            // 
            panelLoop.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            panelLoop.BorderStyle = BorderStyle.FixedSingle;
            panelLoop.Controls.Add(buttonEndLoopNow);
            panelLoop.Controls.Add(buttonStartLoopNow);
            panelLoop.Controls.Add(upDownEndLoopMilliseconds);
            panelLoop.Controls.Add(upDownEndLoopSeconds);
            panelLoop.Controls.Add(upDownEndLoopMinutes);
            panelLoop.Controls.Add(upDownStartLoopMilliseconds);
            panelLoop.Controls.Add(upDownStartLoopSeconds);
            panelLoop.Controls.Add(upDownStartLoopMinutes);
            panelLoop.Controls.Add(upDownCurrentMilliseconds);
            panelLoop.Controls.Add(upDownCurrentSeconds);
            panelLoop.Controls.Add(upDownCurrentMinutes);
            panelLoop.Controls.Add(labelPositionValue);
            panelLoop.Controls.Add(labelPosition);
            panelLoop.Controls.Add(labelLoopEnd);
            panelLoop.Controls.Add(label2);
            panelLoop.Controls.Add(checkBoxLoop);
            panelLoop.Location = new System.Drawing.Point(656, 241);
            panelLoop.Margin = new Padding(2, 1, 2, 1);
            panelLoop.Name = "panelLoop";
            panelLoop.Size = new System.Drawing.Size(243, 138);
            panelLoop.TabIndex = 63;
            // 
            // buttonEndLoopNow
            // 
            buttonEndLoopNow.Location = new System.Drawing.Point(187, 109);
            buttonEndLoopNow.Margin = new Padding(2, 1, 2, 1);
            buttonEndLoopNow.Name = "buttonEndLoopNow";
            buttonEndLoopNow.Padding = new Padding(3, 2, 3, 2);
            buttonEndLoopNow.Size = new System.Drawing.Size(46, 18);
            buttonEndLoopNow.TabIndex = 129;
            buttonEndLoopNow.Text = "Now";
            buttonEndLoopNow.Click += buttonEndLoopNow_Click;
            // 
            // buttonStartLoopNow
            // 
            buttonStartLoopNow.Location = new System.Drawing.Point(187, 88);
            buttonStartLoopNow.Margin = new Padding(2, 1, 2, 1);
            buttonStartLoopNow.Name = "buttonStartLoopNow";
            buttonStartLoopNow.Padding = new Padding(3, 2, 3, 2);
            buttonStartLoopNow.Size = new System.Drawing.Size(46, 18);
            buttonStartLoopNow.TabIndex = 128;
            buttonStartLoopNow.Text = "Now";
            buttonStartLoopNow.Click += buttonStartLoopNow_Click;
            // 
            // upDownEndLoopMilliseconds
            // 
            upDownEndLoopMilliseconds.Location = new System.Drawing.Point(139, 109);
            upDownEndLoopMilliseconds.Margin = new Padding(2, 1, 2, 1);
            upDownEndLoopMilliseconds.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            upDownEndLoopMilliseconds.Name = "upDownEndLoopMilliseconds";
            upDownEndLoopMilliseconds.Size = new System.Drawing.Size(45, 23);
            upDownEndLoopMilliseconds.TabIndex = 127;
            upDownEndLoopMilliseconds.ValueChanged += upDownEndLoopMilliseconds_ValueChanged;
            // 
            // upDownEndLoopSeconds
            // 
            upDownEndLoopSeconds.Location = new System.Drawing.Point(92, 109);
            upDownEndLoopSeconds.Margin = new Padding(2, 1, 2, 1);
            upDownEndLoopSeconds.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            upDownEndLoopSeconds.Name = "upDownEndLoopSeconds";
            upDownEndLoopSeconds.Size = new System.Drawing.Size(45, 23);
            upDownEndLoopSeconds.TabIndex = 126;
            upDownEndLoopSeconds.ValueChanged += upDownEndLoopSeconds_ValueChanged;
            // 
            // upDownEndLoopMinutes
            // 
            upDownEndLoopMinutes.Location = new System.Drawing.Point(44, 109);
            upDownEndLoopMinutes.Margin = new Padding(2, 1, 2, 1);
            upDownEndLoopMinutes.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            upDownEndLoopMinutes.Name = "upDownEndLoopMinutes";
            upDownEndLoopMinutes.Size = new System.Drawing.Size(45, 23);
            upDownEndLoopMinutes.TabIndex = 125;
            upDownEndLoopMinutes.ValueChanged += upDownEndLoopMinutes_ValueChanged;
            // 
            // upDownStartLoopMilliseconds
            // 
            upDownStartLoopMilliseconds.Location = new System.Drawing.Point(139, 88);
            upDownStartLoopMilliseconds.Margin = new Padding(2, 1, 2, 1);
            upDownStartLoopMilliseconds.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            upDownStartLoopMilliseconds.Name = "upDownStartLoopMilliseconds";
            upDownStartLoopMilliseconds.Size = new System.Drawing.Size(45, 23);
            upDownStartLoopMilliseconds.TabIndex = 124;
            upDownStartLoopMilliseconds.ValueChanged += upDownStartLoopMilliseconds_ValueChanged;
            // 
            // upDownStartLoopSeconds
            // 
            upDownStartLoopSeconds.Location = new System.Drawing.Point(92, 88);
            upDownStartLoopSeconds.Margin = new Padding(2, 1, 2, 1);
            upDownStartLoopSeconds.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            upDownStartLoopSeconds.Name = "upDownStartLoopSeconds";
            upDownStartLoopSeconds.Size = new System.Drawing.Size(45, 23);
            upDownStartLoopSeconds.TabIndex = 123;
            upDownStartLoopSeconds.ValueChanged += upDownStartLoopSeconds_ValueChanged;
            // 
            // upDownStartLoopMinutes
            // 
            upDownStartLoopMinutes.Location = new System.Drawing.Point(44, 88);
            upDownStartLoopMinutes.Margin = new Padding(2, 1, 2, 1);
            upDownStartLoopMinutes.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            upDownStartLoopMinutes.Name = "upDownStartLoopMinutes";
            upDownStartLoopMinutes.Size = new System.Drawing.Size(45, 23);
            upDownStartLoopMinutes.TabIndex = 122;
            upDownStartLoopMinutes.ValueChanged += upDownStartLoopMinutes_ValueChanged;
            // 
            // upDownCurrentMilliseconds
            // 
            upDownCurrentMilliseconds.Location = new System.Drawing.Point(139, 28);
            upDownCurrentMilliseconds.Margin = new Padding(2, 1, 2, 1);
            upDownCurrentMilliseconds.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            upDownCurrentMilliseconds.Name = "upDownCurrentMilliseconds";
            upDownCurrentMilliseconds.Size = new System.Drawing.Size(45, 23);
            upDownCurrentMilliseconds.TabIndex = 121;
            upDownCurrentMilliseconds.ValueChanged += upDownCurrent_ValueChanged;
            // 
            // upDownCurrentSeconds
            // 
            upDownCurrentSeconds.Location = new System.Drawing.Point(92, 28);
            upDownCurrentSeconds.Margin = new Padding(2, 1, 2, 1);
            upDownCurrentSeconds.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            upDownCurrentSeconds.Name = "upDownCurrentSeconds";
            upDownCurrentSeconds.Size = new System.Drawing.Size(45, 23);
            upDownCurrentSeconds.TabIndex = 120;
            upDownCurrentSeconds.ValueChanged += upDownCurrent_ValueChanged;
            // 
            // upDownCurrentMinutes
            // 
            upDownCurrentMinutes.Location = new System.Drawing.Point(44, 28);
            upDownCurrentMinutes.Margin = new Padding(2, 1, 2, 1);
            upDownCurrentMinutes.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            upDownCurrentMinutes.Name = "upDownCurrentMinutes";
            upDownCurrentMinutes.Size = new System.Drawing.Size(45, 23);
            upDownCurrentMinutes.TabIndex = 114;
            upDownCurrentMinutes.ValueChanged += upDownCurrent_ValueChanged;
            // 
            // labelPositionValue
            // 
            labelPositionValue.AutoSize = true;
            labelPositionValue.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelPositionValue.Location = new System.Drawing.Point(44, 8);
            labelPositionValue.Margin = new Padding(2, 0, 2, 0);
            labelPositionValue.Name = "labelPositionValue";
            labelPositionValue.Size = new System.Drawing.Size(60, 15);
            labelPositionValue.TabIndex = 119;
            labelPositionValue.Text = "0:00 / 0:00";
            labelPositionValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPosition.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelPosition.Location = new System.Drawing.Point(5, 8);
            labelPosition.Margin = new Padding(2, 0, 2, 0);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new System.Drawing.Size(29, 15);
            labelPosition.TabIndex = 118;
            labelPosition.Text = "Pos:";
            // 
            // labelLoopEnd
            // 
            labelLoopEnd.AutoSize = true;
            labelLoopEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelLoopEnd.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            labelLoopEnd.Location = new System.Drawing.Point(4, 111);
            labelLoopEnd.Margin = new Padding(2, 0, 2, 0);
            labelLoopEnd.Name = "labelLoopEnd";
            labelLoopEnd.Size = new System.Drawing.Size(30, 15);
            labelLoopEnd.TabIndex = 110;
            labelLoopEnd.Text = "End:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(225, 225, 225, 225);
            label2.Location = new System.Drawing.Point(4, 89);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 15);
            label2.TabIndex = 105;
            label2.Text = "Start:";
            // 
            // checkBoxLoop
            // 
            checkBoxLoop.AutoSize = true;
            checkBoxLoop.FlatStyle = FlatStyle.Flat;
            checkBoxLoop.Location = new System.Drawing.Point(44, 66);
            checkBoxLoop.Margin = new Padding(2, 1, 2, 1);
            checkBoxLoop.Name = "checkBoxLoop";
            checkBoxLoop.Size = new System.Drawing.Size(50, 19);
            checkBoxLoop.TabIndex = 0;
            checkBoxLoop.Text = "Loop";
            checkBoxLoop.UseVisualStyleBackColor = true;
            checkBoxLoop.CheckedChanged += checkBoxLoop_CheckedChanged;
            // 
            // panelPresets
            // 
            panelPresets.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            panelPresets.BorderStyle = BorderStyle.FixedSingle;
            panelPresets.Controls.Add(buttonReset);
            panelPresets.Controls.Add(buttonSavePreset);
            panelPresets.Controls.Add(labelPreset4);
            panelPresets.Controls.Add(labelPreset8);
            panelPresets.Controls.Add(buttonPreset8);
            panelPresets.Controls.Add(buttonPreset4);
            panelPresets.Controls.Add(labelPreset3);
            panelPresets.Controls.Add(labelPreset7);
            panelPresets.Controls.Add(buttonPreset7);
            panelPresets.Controls.Add(buttonPreset3);
            panelPresets.Controls.Add(labelPreset2);
            panelPresets.Controls.Add(labelPreset6);
            panelPresets.Controls.Add(buttonPreset6);
            panelPresets.Controls.Add(buttonPreset2);
            panelPresets.Controls.Add(labelPreset1);
            panelPresets.Controls.Add(labelPreset5);
            panelPresets.Controls.Add(buttonPreset5);
            panelPresets.Controls.Add(buttonPreset1);
            panelPresets.Location = new System.Drawing.Point(656, 381);
            panelPresets.Margin = new Padding(2, 1, 2, 1);
            panelPresets.Name = "panelPresets";
            panelPresets.Size = new System.Drawing.Size(243, 225);
            panelPresets.TabIndex = 64;
            // 
            // buttonReset
            // 
            buttonReset.BackgroundImage = Properties.Resources.Trash;
            buttonReset.BackgroundImageLayout = ImageLayout.Stretch;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Location = new System.Drawing.Point(34, 5);
            buttonReset.Margin = new Padding(2, 1, 2, 1);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new System.Drawing.Size(24, 24);
            buttonReset.TabIndex = 126;
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonSavePreset
            // 
            buttonSavePreset.BackColor = System.Drawing.Color.Black;
            buttonSavePreset.BackgroundImage = Properties.Resources.Save;
            buttonSavePreset.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSavePreset.FlatStyle = FlatStyle.Flat;
            buttonSavePreset.Location = new System.Drawing.Point(5, 5);
            buttonSavePreset.Margin = new Padding(2, 1, 2, 1);
            buttonSavePreset.Name = "buttonSavePreset";
            buttonSavePreset.Size = new System.Drawing.Size(24, 24);
            buttonSavePreset.TabIndex = 65;
            buttonSavePreset.UseVisualStyleBackColor = false;
            buttonSavePreset.Click += buttonSavePreset_Click;
            // 
            // labelPreset4
            // 
            labelPreset4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPreset4.Location = new System.Drawing.Point(5, 109);
            labelPreset4.Margin = new Padding(0);
            labelPreset4.Name = "labelPreset4";
            labelPreset4.Size = new System.Drawing.Size(19, 15);
            labelPreset4.TabIndex = 125;
            labelPreset4.Text = "4:";
            labelPreset4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPreset8
            // 
            labelPreset8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPreset8.Location = new System.Drawing.Point(5, 200);
            labelPreset8.Margin = new Padding(0);
            labelPreset8.Name = "labelPreset8";
            labelPreset8.Size = new System.Drawing.Size(19, 15);
            labelPreset8.TabIndex = 124;
            labelPreset8.Text = "8:";
            labelPreset8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonPreset8
            // 
            buttonPreset8.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            buttonPreset8.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            buttonPreset8.FlatStyle = FlatStyle.Flat;
            buttonPreset8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonPreset8.Location = new System.Drawing.Point(26, 198);
            buttonPreset8.Margin = new Padding(2, 1, 2, 1);
            buttonPreset8.Name = "buttonPreset8";
            buttonPreset8.Size = new System.Drawing.Size(200, 21);
            buttonPreset8.TabIndex = 123;
            buttonPreset8.Text = "<Preset not defined>";
            buttonPreset8.UseVisualStyleBackColor = false;
            buttonPreset8.Click += buttonPreset8_Click;
            // 
            // buttonPreset4
            // 
            buttonPreset4.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            buttonPreset4.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            buttonPreset4.FlatStyle = FlatStyle.Flat;
            buttonPreset4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonPreset4.Location = new System.Drawing.Point(26, 108);
            buttonPreset4.Margin = new Padding(2, 1, 2, 1);
            buttonPreset4.Name = "buttonPreset4";
            buttonPreset4.Size = new System.Drawing.Size(200, 21);
            buttonPreset4.TabIndex = 122;
            buttonPreset4.Text = "<Preset not defined>";
            buttonPreset4.UseVisualStyleBackColor = false;
            buttonPreset4.Click += buttonPreset4_Click;
            // 
            // labelPreset3
            // 
            labelPreset3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPreset3.Location = new System.Drawing.Point(5, 87);
            labelPreset3.Margin = new Padding(0);
            labelPreset3.Name = "labelPreset3";
            labelPreset3.Size = new System.Drawing.Size(19, 15);
            labelPreset3.TabIndex = 121;
            labelPreset3.Text = "3:";
            labelPreset3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPreset7
            // 
            labelPreset7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPreset7.Location = new System.Drawing.Point(5, 178);
            labelPreset7.Margin = new Padding(0);
            labelPreset7.Name = "labelPreset7";
            labelPreset7.Size = new System.Drawing.Size(19, 15);
            labelPreset7.TabIndex = 120;
            labelPreset7.Text = "7:";
            labelPreset7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonPreset7
            // 
            buttonPreset7.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            buttonPreset7.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            buttonPreset7.FlatStyle = FlatStyle.Flat;
            buttonPreset7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonPreset7.Location = new System.Drawing.Point(26, 176);
            buttonPreset7.Margin = new Padding(2, 1, 2, 1);
            buttonPreset7.Name = "buttonPreset7";
            buttonPreset7.Size = new System.Drawing.Size(200, 21);
            buttonPreset7.TabIndex = 119;
            buttonPreset7.Text = "<Preset not defined>";
            buttonPreset7.UseVisualStyleBackColor = false;
            buttonPreset7.Click += buttonPreset7_Click;
            // 
            // buttonPreset3
            // 
            buttonPreset3.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            buttonPreset3.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            buttonPreset3.FlatStyle = FlatStyle.Flat;
            buttonPreset3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonPreset3.Location = new System.Drawing.Point(26, 86);
            buttonPreset3.Margin = new Padding(2, 1, 2, 1);
            buttonPreset3.Name = "buttonPreset3";
            buttonPreset3.Size = new System.Drawing.Size(200, 21);
            buttonPreset3.TabIndex = 118;
            buttonPreset3.Text = "<Preset not defined>";
            buttonPreset3.UseVisualStyleBackColor = false;
            buttonPreset3.Click += buttonPreset3_Click;
            // 
            // labelPreset2
            // 
            labelPreset2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPreset2.Location = new System.Drawing.Point(5, 65);
            labelPreset2.Margin = new Padding(0);
            labelPreset2.Name = "labelPreset2";
            labelPreset2.Size = new System.Drawing.Size(19, 15);
            labelPreset2.TabIndex = 117;
            labelPreset2.Text = "2:";
            labelPreset2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPreset6
            // 
            labelPreset6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPreset6.Location = new System.Drawing.Point(5, 156);
            labelPreset6.Margin = new Padding(0);
            labelPreset6.Name = "labelPreset6";
            labelPreset6.Size = new System.Drawing.Size(19, 15);
            labelPreset6.TabIndex = 116;
            labelPreset6.Text = "6:";
            labelPreset6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonPreset6
            // 
            buttonPreset6.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            buttonPreset6.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            buttonPreset6.FlatStyle = FlatStyle.Flat;
            buttonPreset6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonPreset6.Location = new System.Drawing.Point(26, 154);
            buttonPreset6.Margin = new Padding(2, 1, 2, 1);
            buttonPreset6.Name = "buttonPreset6";
            buttonPreset6.Size = new System.Drawing.Size(200, 21);
            buttonPreset6.TabIndex = 115;
            buttonPreset6.Text = "<Preset not defined>";
            buttonPreset6.UseVisualStyleBackColor = false;
            buttonPreset6.Click += buttonPreset6_Click;
            // 
            // buttonPreset2
            // 
            buttonPreset2.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            buttonPreset2.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            buttonPreset2.FlatStyle = FlatStyle.Flat;
            buttonPreset2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonPreset2.Location = new System.Drawing.Point(26, 64);
            buttonPreset2.Margin = new Padding(2, 1, 2, 1);
            buttonPreset2.Name = "buttonPreset2";
            buttonPreset2.Size = new System.Drawing.Size(200, 21);
            buttonPreset2.TabIndex = 114;
            buttonPreset2.Text = "<Preset not defined>";
            buttonPreset2.UseVisualStyleBackColor = false;
            buttonPreset2.Click += buttonPreset2_Click;
            // 
            // labelPreset1
            // 
            labelPreset1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPreset1.Location = new System.Drawing.Point(5, 43);
            labelPreset1.Margin = new Padding(0);
            labelPreset1.Name = "labelPreset1";
            labelPreset1.Size = new System.Drawing.Size(19, 15);
            labelPreset1.TabIndex = 113;
            labelPreset1.Text = "1:";
            labelPreset1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPreset5
            // 
            labelPreset5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPreset5.Location = new System.Drawing.Point(5, 133);
            labelPreset5.Margin = new Padding(0);
            labelPreset5.Name = "labelPreset5";
            labelPreset5.Size = new System.Drawing.Size(19, 15);
            labelPreset5.TabIndex = 112;
            labelPreset5.Text = "5:";
            labelPreset5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonPreset5
            // 
            buttonPreset5.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            buttonPreset5.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            buttonPreset5.FlatStyle = FlatStyle.Flat;
            buttonPreset5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonPreset5.Location = new System.Drawing.Point(26, 131);
            buttonPreset5.Margin = new Padding(2, 1, 2, 1);
            buttonPreset5.Name = "buttonPreset5";
            buttonPreset5.Size = new System.Drawing.Size(200, 21);
            buttonPreset5.TabIndex = 111;
            buttonPreset5.Text = "<Preset not defined>";
            buttonPreset5.UseVisualStyleBackColor = false;
            buttonPreset5.Click += buttonPreset5_Click;
            // 
            // buttonPreset1
            // 
            buttonPreset1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            buttonPreset1.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            buttonPreset1.FlatStyle = FlatStyle.Flat;
            buttonPreset1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonPreset1.Location = new System.Drawing.Point(26, 41);
            buttonPreset1.Margin = new Padding(2, 1, 2, 1);
            buttonPreset1.Name = "buttonPreset1";
            buttonPreset1.Size = new System.Drawing.Size(200, 21);
            buttonPreset1.TabIndex = 110;
            buttonPreset1.Text = "<Preset not defined>";
            buttonPreset1.UseVisualStyleBackColor = false;
            buttonPreset1.Click += buttonPreset1_Click;
            // 
            // pictureBoxRenderer
            // 
            pictureBoxRenderer.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            pictureBoxRenderer.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxRenderer.Location = new System.Drawing.Point(8, 59);
            pictureBoxRenderer.Margin = new Padding(2, 1, 2, 1);
            pictureBoxRenderer.Name = "pictureBoxRenderer";
            pictureBoxRenderer.Size = new System.Drawing.Size(891, 151);
            pictureBoxRenderer.TabIndex = 65;
            pictureBoxRenderer.TabStop = false;
            pictureBoxRenderer.MouseDown += pictureBoxRenderer_MouseDown;
            // 
            // sliderPlayTime
            // 
            sliderPlayTime.AccessibleRole = AccessibleRole.TitleBar;
            sliderPlayTime.Animated = false;
            sliderPlayTime.AnimationSize = 0.2F;
            sliderPlayTime.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            sliderPlayTime.AutoScrollMargin = new System.Drawing.Size(0, 0);
            sliderPlayTime.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            sliderPlayTime.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            sliderPlayTime.BackGroundImage = null;
            sliderPlayTime.ButtonAccentColor = System.Drawing.Color.FromArgb(80, 255, 255, 255);
            sliderPlayTime.ButtonBorderColor = System.Drawing.Color.FromArgb(120, 224, 224, 224);
            sliderPlayTime.ButtonColor = System.Drawing.Color.FromArgb(200, 255, 255, 255);
            sliderPlayTime.ButtonCornerRadius = 2U;
            sliderPlayTime.ButtonSize = new System.Drawing.Size(16, 16);
            sliderPlayTime.ButtonStyle = MediaSlider.MediaSlider.ButtonType.Hybrid;
            sliderPlayTime.LargeChange = 5;
            sliderPlayTime.Location = new System.Drawing.Point(4, 209);
            sliderPlayTime.Margin = new Padding(0);
            sliderPlayTime.Maximum = 500;
            sliderPlayTime.Minimum = 0;
            sliderPlayTime.Name = "sliderPlayTime";
            sliderPlayTime.Orientation = Orientation.Horizontal;
            sliderPlayTime.ShowButtonOnHover = false;
            sliderPlayTime.Size = new System.Drawing.Size(898, 19);
            sliderPlayTime.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            sliderPlayTime.SmallChange = 1;
            sliderPlayTime.SmoothScrolling = false;
            sliderPlayTime.TabIndex = 113;
            sliderPlayTime.TickColor = System.Drawing.Color.DarkGray;
            sliderPlayTime.TickStyle = TickStyle.TopLeft;
            sliderPlayTime.TickType = MediaSlider.MediaSlider.TickMode.LargeStepped;
            sliderPlayTime.TrackBorderColor = System.Drawing.Color.FromArgb(160, 255, 255, 255);
            sliderPlayTime.TrackDepth = 4;
            sliderPlayTime.TrackFillColor = System.Drawing.Color.Transparent;
            sliderPlayTime.TrackProgressColor = System.Drawing.Color.White;
            sliderPlayTime.TrackShadow = false;
            sliderPlayTime.TrackShadowColor = System.Drawing.Color.DarkGray;
            sliderPlayTime.TrackStyle = MediaSlider.MediaSlider.TrackType.Progress;
            sliderPlayTime.Value = 0;
            sliderPlayTime.ValueChanged += sliderPlayTime_ValueChanged;
            sliderPlayTime.MouseDown += sliderPlayTime_MouseDown;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            menuStrip.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItemFile, toolStripMenuHelp });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(2, 1, 0, 1);
            menuStrip.Size = new System.Drawing.Size(906, 24);
            menuStrip.TabIndex = 114;
            menuStrip.Text = "darkMenuStrip1";
            menuStrip.ItemClicked += menuStrip_ItemClicked;
            // 
            // toolStripMenuItemFile
            // 
            toolStripMenuItemFile.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolStripMenuItemFile.DropDownItems.AddRange(new ToolStripItem[] { menuItemRecent1, menuItemRecent2, menuItemRecent3, menuItemRecent4, menuItemRecent5, menuItemRecent6, menuItemRecent7, menuItemRecent8, toolStripSeparator1, menuItemExit });
            toolStripMenuItemFile.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            toolStripMenuItemFile.Size = new System.Drawing.Size(37, 22);
            toolStripMenuItemFile.Text = "&File";
            toolStripMenuItemFile.DropDownOpening += menuItemFile_DropDownOpening;
            toolStripMenuItemFile.DropDownItemClicked += menuItemFile_Clicked;
            // 
            // menuItemRecent1
            // 
            menuItemRecent1.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            menuItemRecent1.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            menuItemRecent1.Name = "menuItemRecent1";
            menuItemRecent1.Size = new System.Drawing.Size(171, 22);
            menuItemRecent1.Text = "menuItemRecent1";
            // 
            // menuItemRecent2
            // 
            menuItemRecent2.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            menuItemRecent2.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            menuItemRecent2.Name = "menuItemRecent2";
            menuItemRecent2.Size = new System.Drawing.Size(171, 22);
            menuItemRecent2.Text = "menuItemRecent2";
            // 
            // menuItemRecent3
            // 
            menuItemRecent3.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            menuItemRecent3.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            menuItemRecent3.Name = "menuItemRecent3";
            menuItemRecent3.Size = new System.Drawing.Size(171, 22);
            menuItemRecent3.Text = "menuItemRecent3";
            // 
            // menuItemRecent4
            // 
            menuItemRecent4.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            menuItemRecent4.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            menuItemRecent4.Name = "menuItemRecent4";
            menuItemRecent4.Size = new System.Drawing.Size(171, 22);
            menuItemRecent4.Text = "menuItemRecent4";
            // 
            // menuItemRecent5
            // 
            menuItemRecent5.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            menuItemRecent5.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            menuItemRecent5.Name = "menuItemRecent5";
            menuItemRecent5.Size = new System.Drawing.Size(171, 22);
            menuItemRecent5.Text = "menuItemRecent5";
            // 
            // menuItemRecent6
            // 
            menuItemRecent6.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            menuItemRecent6.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            menuItemRecent6.Name = "menuItemRecent6";
            menuItemRecent6.Size = new System.Drawing.Size(171, 22);
            menuItemRecent6.Text = "menuItemRecent6";
            // 
            // menuItemRecent7
            // 
            menuItemRecent7.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            menuItemRecent7.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            menuItemRecent7.Name = "menuItemRecent7";
            menuItemRecent7.Size = new System.Drawing.Size(171, 22);
            menuItemRecent7.Text = "menuItemRecent7";
            // 
            // menuItemRecent8
            // 
            menuItemRecent8.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            menuItemRecent8.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            menuItemRecent8.Name = "menuItemRecent8";
            menuItemRecent8.Size = new System.Drawing.Size(171, 22);
            menuItemRecent8.Text = "menuItemRecent8";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripSeparator1.Margin = new Padding(0, 0, 0, 1);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // menuItemExit
            // 
            menuItemExit.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            menuItemExit.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            menuItemExit.Name = "menuItemExit";
            menuItemExit.Size = new System.Drawing.Size(171, 22);
            menuItemExit.Text = "E&xit";
            // 
            // toolStripMenuHelp
            // 
            toolStripMenuHelp.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            toolStripMenuHelp.DropDownItems.AddRange(new ToolStripItem[] { menuItemAbout });
            toolStripMenuHelp.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripMenuHelp.Name = "toolStripMenuHelp";
            toolStripMenuHelp.Size = new System.Drawing.Size(44, 22);
            toolStripMenuHelp.Text = "&Help";
            toolStripMenuHelp.DropDownItemClicked += menuItemHelp_Clicked;
            // 
            // menuItemAbout
            // 
            menuItemAbout.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            menuItemAbout.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            menuItemAbout.Name = "menuItemAbout";
            menuItemAbout.Size = new System.Drawing.Size(107, 22);
            menuItemAbout.Text = "&About";
            // 
            // overlayStart
            // 
            overlayStart.BackColor = System.Drawing.Color.FromArgb(30, 30, 70);
            overlayStart.Location = new System.Drawing.Point(8, 59);
            overlayStart.Margin = new Padding(2, 1, 2, 1);
            overlayStart.Name = "overlayStart";
            overlayStart.Opacity = 50;
            overlayStart.Size = new System.Drawing.Size(5, 150);
            overlayStart.TabIndex = 115;
            overlayStart.MouseDown += overlayStart_MouseDown;
            // 
            // overlayEnd
            // 
            overlayEnd.BackColor = System.Drawing.Color.FromArgb(70, 30, 30);
            overlayEnd.Location = new System.Drawing.Point(893, 59);
            overlayEnd.Margin = new Padding(2, 1, 2, 1);
            overlayEnd.Name = "overlayEnd";
            overlayEnd.Opacity = 50;
            overlayEnd.Size = new System.Drawing.Size(5, 150);
            overlayEnd.TabIndex = 116;
            overlayEnd.MouseDown += overlayEnd_MouseDown;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            ClientSize = new System.Drawing.Size(906, 614);
            Controls.Add(overlayEnd);
            Controls.Add(overlayStart);
            Controls.Add(overlayPosition);
            Controls.Add(pictureBoxRenderer);
            Controls.Add(sliderPlayTime);
            Controls.Add(panelPresets);
            Controls.Add(panelLoop);
            Controls.Add(panelControls);
            Controls.Add(buttonPlay);
            Controls.Add(buttonOpenFile);
            Controls.Add(labelPlayDuration);
            Controls.Add(labelPlayDuration3Q);
            Controls.Add(labelPlayDuration2Q);
            Controls.Add(labelPlayDuration1Q);
            Controls.Add(labelPlayDuration0Q);
            Controls.Add(labelCurrentlyPlaying);
            Controls.Add(labelFilename);
            Controls.Add(menuStrip);
            ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
            Name = "MainForm";
            Text = "Practice Session";
            Load += MainForm_Load;
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            toolStripChannels.ResumeLayout(false);
            toolStripChannels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)upDownCue).EndInit();
            panelLoop.ResumeLayout(false);
            panelLoop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)upDownEndLoopMilliseconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownEndLoopSeconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownEndLoopMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownStartLoopMilliseconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownStartLoopSeconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownStartLoopMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownCurrentMilliseconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownCurrentSeconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)upDownCurrentMinutes).EndInit();
            panelPresets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxRenderer).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog;
        private Label labelFilename;
        private Label labelCurrentlyPlaying;
        private Label labelPlayDuration0Q;
        private Label labelPlayDuration1Q;
        private Label labelPlayDuration2Q;
        private Label labelPlayDuration3Q;
        private Label labelPlayDuration;
        private Timer PlayTimeUpdateTimer;
        private Button buttonOpenFile;
        private Button buttonPlay;
        private Panel panelControls;
        private Label labelCueSeconds;
        private Label labelCue;
        private Label labelTimeStretchProfile;
        private Label labelEQHiValue;
        private Label labelVolumeValue;
        private Label labelSemitones;
        private Label labelPitchValue;
        private Label labelTempoValue;
        private CheckBox checkBoxSuppressVocals;
        private CheckBox checkBoxSwapLR;
        private Label labelChannel;
        private Label labelEQMid;
        private Label labelEQHi;
        private Label labelEQLow;
        private Label labelEQMin100pc;
        private Label labelEQ0pc;
        private Label labelEQ100pc;
        private Label labelEqualizer;
        private Label labelVolume25pc;
        private Label labelVolume75pc;
        private Label labelVolume0pc;
        private Label labelVolume50pc;
        private Label labelVolume100pc;
        private Label label5;
        private Label labelPitch8vb;
        private Label labelPitch0;
        private Label labelPitch8va;
        private Label labelPitch;
        private Label labelX15;
        private Label labelX05;
        private Label labelX01;
        private Label labelX10;
        private Label labelX20;
        private Label label1;
        private Panel panelLoop;
        private CheckBox checkBoxLoop;
        private Label labelLoopEnd;
        private Label label2;
        private Panel panelPresets;
        private Label labelPreset2;
        private Label labelPreset6;
        private Button buttonPreset6;
        private Button buttonPreset2;
        private Label labelPreset1;
        private Label labelPreset5;
        private Button buttonPreset5;
        private Button buttonPreset1;
        private Label labelPreset4;
        private Label labelPreset8;
        private Button buttonPreset8;
        private Button buttonPreset4;
        private Label labelPreset3;
        private Label labelPreset7;
        private Button buttonPreset7;
        private Button buttonPreset3;
        private Button buttonReset;
        private Button buttonSavePreset;
        private Label labelEQMidValue;
        private Label labelEQLowValue;
        private PictureBox pictureBoxRenderer;
        private Label labelPositionValue;
        private Label labelPosition;
        private Label overlayPosition;
        private MediaSlider.MediaSlider sliderTempo;
        private MediaSlider.MediaSlider sliderPitch;
        private MediaSlider.MediaSlider sliderVolume;
        private MediaSlider.MediaSlider sliderEQHi;
        private MediaSlider.MediaSlider sliderEQMid;
        private MediaSlider.MediaSlider sliderEQLow;
        private MediaSlider.MediaSlider sliderPlayTime;
        private DarkUI.Controls.DarkMenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItemFile;
        private ToolStripMenuItem menuItemRecent1;
        private ToolStripMenuItem menuItemRecent2;
        private ToolStripMenuItem menuItemRecent3;
        private ToolStripMenuItem menuItemRecent4;
        private ToolStripMenuItem menuItemRecent5;
        private ToolStripMenuItem menuItemRecent6;
        private ToolStripMenuItem menuItemRecent7;
        private ToolStripMenuItem menuItemRecent8;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuItemExit;
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
        private ToolStripMenuItem toolStripMenuHelp;
        private ToolStripMenuItem menuItemAbout;
        private GlassyPanel overlayStart;
        private GlassyPanel overlayEnd;
    }
}