namespace MineCraft
{
    partial class mainFrm
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitleName = new System.Windows.Forms.Label();
            this.tbctrlMovement = new System.Windows.Forms.TabControl();
            this.tabctrlMovement = new System.Windows.Forms.TabPage();
            this.tbctrlVideo = new System.Windows.Forms.TabPage();
            this.tbctrlAudio = new System.Windows.Forms.TabPage();
            this.tbctrlInterface = new System.Windows.Forms.TabPage();
            this.cbxInputDevice = new System.Windows.Forms.ComboBox();
            this.lblInputDevice = new System.Windows.Forms.Label();
            this.cbxAutoJump = new System.Windows.Forms.CheckBox();
            this.lblAutoJump = new System.Windows.Forms.Label();
            this.lblMouseSensitivity = new System.Windows.Forms.Label();
            this.lblControllerSensitivity = new System.Windows.Forms.Label();
            this.nudMouseSensitivity = new System.Windows.Forms.NumericUpDown();
            this.nudControllerSensitivity = new System.Windows.Forms.NumericUpDown();
            this.lblYaxix = new System.Windows.Forms.Label();
            this.cbxYaxis = new System.Windows.Forms.CheckBox();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.nudBrightness = new System.Windows.Forms.NumericUpDown();
            this.cbxFancyGraphics = new System.Windows.Forms.CheckBox();
            this.lblFancyGraphics = new System.Windows.Forms.Label();
            this.lblVsync = new System.Windows.Forms.Label();
            this.lblFullscreen = new System.Windows.Forms.Label();
            this.lblRenderDistance = new System.Windows.Forms.Label();
            this.lblFieldofView = new System.Windows.Forms.Label();
            this.lblRayTracing = new System.Windows.Forms.Label();
            this.lblUpscaling = new System.Windows.Forms.Label();
            this.cbxVsync = new System.Windows.Forms.CheckBox();
            this.cbxFullScreen = new System.Windows.Forms.CheckBox();
            this.nudRenderDistance = new System.Windows.Forms.NumericUpDown();
            this.nudFieldofView = new System.Windows.Forms.NumericUpDown();
            this.cbxRayTracing = new System.Windows.Forms.CheckBox();
            this.cbxUpscaling = new System.Windows.Forms.CheckBox();
            this.lblMusicVolume = new System.Windows.Forms.Label();
            this.lblSoundVolume = new System.Windows.Forms.Label();
            this.trckbrMusicVolume = new System.Windows.Forms.TrackBar();
            this.trckbrSoundVolume = new System.Windows.Forms.TrackBar();
            this.lblHudTransparency = new System.Windows.Forms.Label();
            this.lblShowCoordinates = new System.Windows.Forms.Label();
            this.nudTransparency = new System.Windows.Forms.NumericUpDown();
            this.cbxShowCoordinates = new System.Windows.Forms.CheckBox();
            this.lblCameraPerspective = new System.Windows.Forms.Label();
            this.cbxCameraPerspective = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.cbxProfile = new System.Windows.Forms.ComboBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.btnLoadProfile = new System.Windows.Forms.Button();
            this.btnSetDefault = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tbctrlMovement.SuspendLayout();
            this.tabctrlMovement.SuspendLayout();
            this.tbctrlVideo.SuspendLayout();
            this.tbctrlAudio.SuspendLayout();
            this.tbctrlInterface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouseSensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudControllerSensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenderDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFieldofView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckbrMusicVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckbrSoundVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransparency)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleName
            // 
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleName.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleName.Location = new System.Drawing.Point(466, 0);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(291, 59);
            this.lblTitleName.TabIndex = 0;
            this.lblTitleName.Text = "Mine Craft";
            // 
            // tbctrlMovement
            // 
            this.tbctrlMovement.Controls.Add(this.tabctrlMovement);
            this.tbctrlMovement.Controls.Add(this.tbctrlVideo);
            this.tbctrlMovement.Controls.Add(this.tbctrlAudio);
            this.tbctrlMovement.Controls.Add(this.tbctrlInterface);
            this.tbctrlMovement.Location = new System.Drawing.Point(21, 102);
            this.tbctrlMovement.Name = "tbctrlMovement";
            this.tbctrlMovement.SelectedIndex = 0;
            this.tbctrlMovement.Size = new System.Drawing.Size(471, 491);
            this.tbctrlMovement.TabIndex = 1;
            // 
            // tabctrlMovement
            // 
            this.tabctrlMovement.Controls.Add(this.cbxYaxis);
            this.tabctrlMovement.Controls.Add(this.lblYaxix);
            this.tabctrlMovement.Controls.Add(this.nudControllerSensitivity);
            this.tabctrlMovement.Controls.Add(this.nudMouseSensitivity);
            this.tabctrlMovement.Controls.Add(this.lblControllerSensitivity);
            this.tabctrlMovement.Controls.Add(this.lblMouseSensitivity);
            this.tabctrlMovement.Controls.Add(this.lblAutoJump);
            this.tabctrlMovement.Controls.Add(this.cbxAutoJump);
            this.tabctrlMovement.Controls.Add(this.lblInputDevice);
            this.tabctrlMovement.Controls.Add(this.cbxInputDevice);
            this.tabctrlMovement.Location = new System.Drawing.Point(4, 25);
            this.tabctrlMovement.Name = "tabctrlMovement";
            this.tabctrlMovement.Padding = new System.Windows.Forms.Padding(3);
            this.tabctrlMovement.Size = new System.Drawing.Size(463, 462);
            this.tabctrlMovement.TabIndex = 0;
            this.tabctrlMovement.Text = "Movement";
            this.tabctrlMovement.UseVisualStyleBackColor = true;
            // 
            // tbctrlVideo
            // 
            this.tbctrlVideo.Controls.Add(this.cbxUpscaling);
            this.tbctrlVideo.Controls.Add(this.cbxRayTracing);
            this.tbctrlVideo.Controls.Add(this.nudFieldofView);
            this.tbctrlVideo.Controls.Add(this.nudRenderDistance);
            this.tbctrlVideo.Controls.Add(this.cbxFullScreen);
            this.tbctrlVideo.Controls.Add(this.cbxVsync);
            this.tbctrlVideo.Controls.Add(this.lblUpscaling);
            this.tbctrlVideo.Controls.Add(this.lblRayTracing);
            this.tbctrlVideo.Controls.Add(this.lblFieldofView);
            this.tbctrlVideo.Controls.Add(this.lblRenderDistance);
            this.tbctrlVideo.Controls.Add(this.lblFullscreen);
            this.tbctrlVideo.Controls.Add(this.lblVsync);
            this.tbctrlVideo.Controls.Add(this.lblFancyGraphics);
            this.tbctrlVideo.Controls.Add(this.cbxFancyGraphics);
            this.tbctrlVideo.Controls.Add(this.nudBrightness);
            this.tbctrlVideo.Controls.Add(this.lblBrightness);
            this.tbctrlVideo.Location = new System.Drawing.Point(4, 25);
            this.tbctrlVideo.Name = "tbctrlVideo";
            this.tbctrlVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tbctrlVideo.Size = new System.Drawing.Size(463, 462);
            this.tbctrlVideo.TabIndex = 1;
            this.tbctrlVideo.Text = "Video";
            this.tbctrlVideo.UseVisualStyleBackColor = true;
            // 
            // tbctrlAudio
            // 
            this.tbctrlAudio.Controls.Add(this.trckbrSoundVolume);
            this.tbctrlAudio.Controls.Add(this.trckbrMusicVolume);
            this.tbctrlAudio.Controls.Add(this.lblSoundVolume);
            this.tbctrlAudio.Controls.Add(this.lblMusicVolume);
            this.tbctrlAudio.Location = new System.Drawing.Point(4, 25);
            this.tbctrlAudio.Name = "tbctrlAudio";
            this.tbctrlAudio.Padding = new System.Windows.Forms.Padding(3);
            this.tbctrlAudio.Size = new System.Drawing.Size(463, 462);
            this.tbctrlAudio.TabIndex = 2;
            this.tbctrlAudio.Text = "Audio";
            this.tbctrlAudio.UseVisualStyleBackColor = true;
            // 
            // tbctrlInterface
            // 
            this.tbctrlInterface.Controls.Add(this.cbxCameraPerspective);
            this.tbctrlInterface.Controls.Add(this.lblCameraPerspective);
            this.tbctrlInterface.Controls.Add(this.cbxShowCoordinates);
            this.tbctrlInterface.Controls.Add(this.nudTransparency);
            this.tbctrlInterface.Controls.Add(this.lblShowCoordinates);
            this.tbctrlInterface.Controls.Add(this.lblHudTransparency);
            this.tbctrlInterface.Location = new System.Drawing.Point(4, 25);
            this.tbctrlInterface.Name = "tbctrlInterface";
            this.tbctrlInterface.Padding = new System.Windows.Forms.Padding(3);
            this.tbctrlInterface.Size = new System.Drawing.Size(463, 462);
            this.tbctrlInterface.TabIndex = 3;
            this.tbctrlInterface.Text = "Interface";
            this.tbctrlInterface.UseVisualStyleBackColor = true;
            // 
            // cbxInputDevice
            // 
            this.cbxInputDevice.FormattingEnabled = true;
            this.cbxInputDevice.Items.AddRange(new object[] {
            "Keyboard",
            "Controller",
            "Touch"});
            this.cbxInputDevice.Location = new System.Drawing.Point(161, 48);
            this.cbxInputDevice.Name = "cbxInputDevice";
            this.cbxInputDevice.Size = new System.Drawing.Size(121, 24);
            this.cbxInputDevice.TabIndex = 0;
            // 
            // lblInputDevice
            // 
            this.lblInputDevice.AutoSize = true;
            this.lblInputDevice.Location = new System.Drawing.Point(29, 56);
            this.lblInputDevice.Name = "lblInputDevice";
            this.lblInputDevice.Size = new System.Drawing.Size(88, 16);
            this.lblInputDevice.TabIndex = 1;
            this.lblInputDevice.Text = "Input Devices";
            // 
            // cbxAutoJump
            // 
            this.cbxAutoJump.AutoSize = true;
            this.cbxAutoJump.Location = new System.Drawing.Point(162, 101);
            this.cbxAutoJump.Name = "cbxAutoJump";
            this.cbxAutoJump.Size = new System.Drawing.Size(18, 17);
            this.cbxAutoJump.TabIndex = 2;
            this.cbxAutoJump.UseVisualStyleBackColor = true;
            // 
            // lblAutoJump
            // 
            this.lblAutoJump.AutoSize = true;
            this.lblAutoJump.Location = new System.Drawing.Point(29, 101);
            this.lblAutoJump.Name = "lblAutoJump";
            this.lblAutoJump.Size = new System.Drawing.Size(71, 16);
            this.lblAutoJump.TabIndex = 3;
            this.lblAutoJump.Text = "Auto-Jump";
            // 
            // lblMouseSensitivity
            // 
            this.lblMouseSensitivity.AutoSize = true;
            this.lblMouseSensitivity.Location = new System.Drawing.Point(29, 153);
            this.lblMouseSensitivity.Name = "lblMouseSensitivity";
            this.lblMouseSensitivity.Size = new System.Drawing.Size(111, 16);
            this.lblMouseSensitivity.TabIndex = 4;
            this.lblMouseSensitivity.Text = "Mouse Sensitivity";
            // 
            // lblControllerSensitivity
            // 
            this.lblControllerSensitivity.AutoSize = true;
            this.lblControllerSensitivity.Location = new System.Drawing.Point(29, 199);
            this.lblControllerSensitivity.Name = "lblControllerSensitivity";
            this.lblControllerSensitivity.Size = new System.Drawing.Size(127, 16);
            this.lblControllerSensitivity.TabIndex = 5;
            this.lblControllerSensitivity.Text = "Controller Sensitivity";
            // 
            // nudMouseSensitivity
            // 
            this.nudMouseSensitivity.Location = new System.Drawing.Point(162, 153);
            this.nudMouseSensitivity.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nudMouseSensitivity.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMouseSensitivity.Name = "nudMouseSensitivity";
            this.nudMouseSensitivity.Size = new System.Drawing.Size(120, 22);
            this.nudMouseSensitivity.TabIndex = 6;
            this.nudMouseSensitivity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudControllerSensitivity
            // 
            this.nudControllerSensitivity.Location = new System.Drawing.Point(162, 197);
            this.nudControllerSensitivity.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nudControllerSensitivity.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudControllerSensitivity.Name = "nudControllerSensitivity";
            this.nudControllerSensitivity.Size = new System.Drawing.Size(120, 22);
            this.nudControllerSensitivity.TabIndex = 7;
            this.nudControllerSensitivity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblYaxix
            // 
            this.lblYaxix.AutoSize = true;
            this.lblYaxix.Location = new System.Drawing.Point(29, 249);
            this.lblYaxix.Name = "lblYaxix";
            this.lblYaxix.Size = new System.Drawing.Size(80, 16);
            this.lblYaxix.TabIndex = 8;
            this.lblYaxix.Text = "Invert Y-Axis";
            // 
            // cbxYaxis
            // 
            this.cbxYaxis.AutoSize = true;
            this.cbxYaxis.Location = new System.Drawing.Point(162, 245);
            this.cbxYaxis.Name = "cbxYaxis";
            this.cbxYaxis.Size = new System.Drawing.Size(18, 17);
            this.cbxYaxis.TabIndex = 9;
            this.cbxYaxis.UseVisualStyleBackColor = true;
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Location = new System.Drawing.Point(25, 53);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(70, 16);
            this.lblBrightness.TabIndex = 0;
            this.lblBrightness.Text = "Brightness";
            // 
            // nudBrightness
            // 
            this.nudBrightness.Location = new System.Drawing.Point(180, 47);
            this.nudBrightness.Name = "nudBrightness";
            this.nudBrightness.Size = new System.Drawing.Size(120, 22);
            this.nudBrightness.TabIndex = 1;
            this.nudBrightness.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // cbxFancyGraphics
            // 
            this.cbxFancyGraphics.AutoSize = true;
            this.cbxFancyGraphics.Location = new System.Drawing.Point(180, 106);
            this.cbxFancyGraphics.Name = "cbxFancyGraphics";
            this.cbxFancyGraphics.Size = new System.Drawing.Size(18, 17);
            this.cbxFancyGraphics.TabIndex = 2;
            this.cbxFancyGraphics.UseVisualStyleBackColor = true;
            // 
            // lblFancyGraphics
            // 
            this.lblFancyGraphics.AutoSize = true;
            this.lblFancyGraphics.Location = new System.Drawing.Point(25, 106);
            this.lblFancyGraphics.Name = "lblFancyGraphics";
            this.lblFancyGraphics.Size = new System.Drawing.Size(101, 16);
            this.lblFancyGraphics.TabIndex = 3;
            this.lblFancyGraphics.Text = "Fancy Graphics";
            // 
            // lblVsync
            // 
            this.lblVsync.AutoSize = true;
            this.lblVsync.Location = new System.Drawing.Point(25, 158);
            this.lblVsync.Name = "lblVsync";
            this.lblVsync.Size = new System.Drawing.Size(56, 16);
            this.lblVsync.TabIndex = 4;
            this.lblVsync.Text = "V - Sync";
            // 
            // lblFullscreen
            // 
            this.lblFullscreen.AutoSize = true;
            this.lblFullscreen.Location = new System.Drawing.Point(25, 212);
            this.lblFullscreen.Name = "lblFullscreen";
            this.lblFullscreen.Size = new System.Drawing.Size(74, 16);
            this.lblFullscreen.TabIndex = 5;
            this.lblFullscreen.Text = "Full Screen";
            // 
            // lblRenderDistance
            // 
            this.lblRenderDistance.AutoSize = true;
            this.lblRenderDistance.Location = new System.Drawing.Point(25, 262);
            this.lblRenderDistance.Name = "lblRenderDistance";
            this.lblRenderDistance.Size = new System.Drawing.Size(108, 16);
            this.lblRenderDistance.TabIndex = 6;
            this.lblRenderDistance.Text = "Render Distance";
            // 
            // lblFieldofView
            // 
            this.lblFieldofView.AutoSize = true;
            this.lblFieldofView.Location = new System.Drawing.Point(25, 313);
            this.lblFieldofView.Name = "lblFieldofView";
            this.lblFieldofView.Size = new System.Drawing.Size(83, 16);
            this.lblFieldofView.TabIndex = 7;
            this.lblFieldofView.Text = "Field of View";
            // 
            // lblRayTracing
            // 
            this.lblRayTracing.AutoSize = true;
            this.lblRayTracing.Location = new System.Drawing.Point(25, 365);
            this.lblRayTracing.Name = "lblRayTracing";
            this.lblRayTracing.Size = new System.Drawing.Size(81, 16);
            this.lblRayTracing.TabIndex = 8;
            this.lblRayTracing.Text = "Ray Tracing";
            // 
            // lblUpscaling
            // 
            this.lblUpscaling.AutoSize = true;
            this.lblUpscaling.Location = new System.Drawing.Point(25, 416);
            this.lblUpscaling.Name = "lblUpscaling";
            this.lblUpscaling.Size = new System.Drawing.Size(68, 16);
            this.lblUpscaling.TabIndex = 9;
            this.lblUpscaling.Text = "Upscaling";
            // 
            // cbxVsync
            // 
            this.cbxVsync.AutoSize = true;
            this.cbxVsync.Location = new System.Drawing.Point(180, 158);
            this.cbxVsync.Name = "cbxVsync";
            this.cbxVsync.Size = new System.Drawing.Size(18, 17);
            this.cbxVsync.TabIndex = 10;
            this.cbxVsync.UseVisualStyleBackColor = true;
            // 
            // cbxFullScreen
            // 
            this.cbxFullScreen.AutoSize = true;
            this.cbxFullScreen.Location = new System.Drawing.Point(180, 212);
            this.cbxFullScreen.Name = "cbxFullScreen";
            this.cbxFullScreen.Size = new System.Drawing.Size(18, 17);
            this.cbxFullScreen.TabIndex = 11;
            this.cbxFullScreen.UseVisualStyleBackColor = true;
            // 
            // nudRenderDistance
            // 
            this.nudRenderDistance.Location = new System.Drawing.Point(180, 262);
            this.nudRenderDistance.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudRenderDistance.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudRenderDistance.Name = "nudRenderDistance";
            this.nudRenderDistance.Size = new System.Drawing.Size(120, 22);
            this.nudRenderDistance.TabIndex = 12;
            this.nudRenderDistance.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // nudFieldofView
            // 
            this.nudFieldofView.Location = new System.Drawing.Point(180, 311);
            this.nudFieldofView.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudFieldofView.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudFieldofView.Name = "nudFieldofView";
            this.nudFieldofView.Size = new System.Drawing.Size(120, 22);
            this.nudFieldofView.TabIndex = 13;
            this.nudFieldofView.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // cbxRayTracing
            // 
            this.cbxRayTracing.AutoSize = true;
            this.cbxRayTracing.Location = new System.Drawing.Point(180, 365);
            this.cbxRayTracing.Name = "cbxRayTracing";
            this.cbxRayTracing.Size = new System.Drawing.Size(18, 17);
            this.cbxRayTracing.TabIndex = 14;
            this.cbxRayTracing.UseVisualStyleBackColor = true;
            // 
            // cbxUpscaling
            // 
            this.cbxUpscaling.AutoSize = true;
            this.cbxUpscaling.Location = new System.Drawing.Point(180, 412);
            this.cbxUpscaling.Name = "cbxUpscaling";
            this.cbxUpscaling.Size = new System.Drawing.Size(18, 17);
            this.cbxUpscaling.TabIndex = 15;
            this.cbxUpscaling.UseVisualStyleBackColor = true;
            // 
            // lblMusicVolume
            // 
            this.lblMusicVolume.AutoSize = true;
            this.lblMusicVolume.Location = new System.Drawing.Point(48, 62);
            this.lblMusicVolume.Name = "lblMusicVolume";
            this.lblMusicVolume.Size = new System.Drawing.Size(91, 16);
            this.lblMusicVolume.TabIndex = 0;
            this.lblMusicVolume.Text = "Music Volume";
            // 
            // lblSoundVolume
            // 
            this.lblSoundVolume.AutoSize = true;
            this.lblSoundVolume.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSoundVolume.Location = new System.Drawing.Point(48, 144);
            this.lblSoundVolume.Name = "lblSoundVolume";
            this.lblSoundVolume.Size = new System.Drawing.Size(95, 16);
            this.lblSoundVolume.TabIndex = 1;
            this.lblSoundVolume.Text = "Sound Volume";
            // 
            // trckbrMusicVolume
            // 
            this.trckbrMusicVolume.Location = new System.Drawing.Point(178, 62);
            this.trckbrMusicVolume.Maximum = 100;
            this.trckbrMusicVolume.Name = "trckbrMusicVolume";
            this.trckbrMusicVolume.Size = new System.Drawing.Size(104, 56);
            this.trckbrMusicVolume.TabIndex = 2;
            this.trckbrMusicVolume.Value = 100;
            // 
            // trckbrSoundVolume
            // 
            this.trckbrSoundVolume.Location = new System.Drawing.Point(178, 144);
            this.trckbrSoundVolume.Maximum = 100;
            this.trckbrSoundVolume.Name = "trckbrSoundVolume";
            this.trckbrSoundVolume.Size = new System.Drawing.Size(104, 56);
            this.trckbrSoundVolume.TabIndex = 3;
            this.trckbrSoundVolume.Value = 100;
            // 
            // lblHudTransparency
            // 
            this.lblHudTransparency.AutoSize = true;
            this.lblHudTransparency.Location = new System.Drawing.Point(26, 51);
            this.lblHudTransparency.Name = "lblHudTransparency";
            this.lblHudTransparency.Size = new System.Drawing.Size(124, 16);
            this.lblHudTransparency.TabIndex = 0;
            this.lblHudTransparency.Text = "HUD Transparency";
            // 
            // lblShowCoordinates
            // 
            this.lblShowCoordinates.AutoSize = true;
            this.lblShowCoordinates.Location = new System.Drawing.Point(26, 109);
            this.lblShowCoordinates.Name = "lblShowCoordinates";
            this.lblShowCoordinates.Size = new System.Drawing.Size(116, 16);
            this.lblShowCoordinates.TabIndex = 1;
            this.lblShowCoordinates.Text = "Show Coordinates";
            // 
            // nudTransparency
            // 
            this.nudTransparency.Location = new System.Drawing.Point(181, 49);
            this.nudTransparency.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudTransparency.Name = "nudTransparency";
            this.nudTransparency.Size = new System.Drawing.Size(120, 22);
            this.nudTransparency.TabIndex = 2;
            this.nudTransparency.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // cbxShowCoordinates
            // 
            this.cbxShowCoordinates.AutoSize = true;
            this.cbxShowCoordinates.Location = new System.Drawing.Point(181, 109);
            this.cbxShowCoordinates.Name = "cbxShowCoordinates";
            this.cbxShowCoordinates.Size = new System.Drawing.Size(18, 17);
            this.cbxShowCoordinates.TabIndex = 3;
            this.cbxShowCoordinates.UseVisualStyleBackColor = true;
            // 
            // lblCameraPerspective
            // 
            this.lblCameraPerspective.AutoSize = true;
            this.lblCameraPerspective.Location = new System.Drawing.Point(26, 167);
            this.lblCameraPerspective.Name = "lblCameraPerspective";
            this.lblCameraPerspective.Size = new System.Drawing.Size(130, 16);
            this.lblCameraPerspective.TabIndex = 4;
            this.lblCameraPerspective.Text = "Camera Perspective";
            // 
            // cbxCameraPerspective
            // 
            this.cbxCameraPerspective.FormattingEnabled = true;
            this.cbxCameraPerspective.Items.AddRange(new object[] {
            "First-Person",
            "Third-Person Front",
            "Third-Person Back"});
            this.cbxCameraPerspective.Location = new System.Drawing.Point(181, 164);
            this.cbxCameraPerspective.Name = "cbxCameraPerspective";
            this.cbxCameraPerspective.Size = new System.Drawing.Size(121, 24);
            this.cbxCameraPerspective.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetDefault);
            this.groupBox1.Controls.Add(this.btnLoadProfile);
            this.groupBox1.Controls.Add(this.btnSaveProfile);
            this.groupBox1.Controls.Add(this.cbxProfile);
            this.groupBox1.Controls.Add(this.txtProfileName);
            this.groupBox1.Controls.Add(this.lblProfile);
            this.groupBox1.Location = new System.Drawing.Point(661, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 267);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblProfile
            // 
            this.lblProfile.Location = new System.Drawing.Point(0, 0);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(377, 45);
            this.lblProfile.TabIndex = 0;
            this.lblProfile.Text = "Player Profile";
            this.lblProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(18, 63);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(140, 22);
            this.txtProfileName.TabIndex = 1;
            // 
            // cbxProfile
            // 
            this.cbxProfile.FormattingEnabled = true;
            this.cbxProfile.Location = new System.Drawing.Point(18, 118);
            this.cbxProfile.Name = "cbxProfile";
            this.cbxProfile.Size = new System.Drawing.Size(121, 24);
            this.cbxProfile.TabIndex = 2;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(27, 217);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(91, 23);
            this.btnSaveProfile.TabIndex = 3;
            this.btnSaveProfile.Text = "Save Profile";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // btnLoadProfile
            // 
            this.btnLoadProfile.Location = new System.Drawing.Point(137, 217);
            this.btnLoadProfile.Name = "btnLoadProfile";
            this.btnLoadProfile.Size = new System.Drawing.Size(99, 23);
            this.btnLoadProfile.TabIndex = 4;
            this.btnLoadProfile.Text = "Load Profile";
            this.btnLoadProfile.UseVisualStyleBackColor = true;
            this.btnLoadProfile.Click += new System.EventHandler(this.btnLoadProfile_Click);
            // 
            // btnSetDefault
            // 
            this.btnSetDefault.Location = new System.Drawing.Point(257, 217);
            this.btnSetDefault.Name = "btnSetDefault";
            this.btnSetDefault.Size = new System.Drawing.Size(91, 23);
            this.btnSetDefault.TabIndex = 5;
            this.btnSetDefault.Text = "Set Default";
            this.btnSetDefault.UseVisualStyleBackColor = true;
            this.btnSetDefault.Click += new System.EventHandler(this.btnSetDefault_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MineCraft.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1226, 630);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbctrlMovement);
            this.Controls.Add(this.lblTitleName);
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Setting Dashboard";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tbctrlMovement.ResumeLayout(false);
            this.tabctrlMovement.ResumeLayout(false);
            this.tabctrlMovement.PerformLayout();
            this.tbctrlVideo.ResumeLayout(false);
            this.tbctrlVideo.PerformLayout();
            this.tbctrlAudio.ResumeLayout(false);
            this.tbctrlAudio.PerformLayout();
            this.tbctrlInterface.ResumeLayout(false);
            this.tbctrlInterface.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMouseSensitivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudControllerSensitivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenderDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFieldofView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckbrMusicVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckbrSoundVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransparency)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.TabControl tbctrlMovement;
        private System.Windows.Forms.TabPage tabctrlMovement;
        private System.Windows.Forms.TabPage tbctrlVideo;
        private System.Windows.Forms.TabPage tbctrlAudio;
        private System.Windows.Forms.TabPage tbctrlInterface;
        private System.Windows.Forms.ComboBox cbxInputDevice;
        private System.Windows.Forms.Label lblAutoJump;
        private System.Windows.Forms.CheckBox cbxAutoJump;
        private System.Windows.Forms.Label lblInputDevice;
        private System.Windows.Forms.NumericUpDown nudMouseSensitivity;
        private System.Windows.Forms.Label lblControllerSensitivity;
        private System.Windows.Forms.Label lblMouseSensitivity;
        private System.Windows.Forms.CheckBox cbxYaxis;
        private System.Windows.Forms.Label lblYaxix;
        private System.Windows.Forms.NumericUpDown nudControllerSensitivity;
        private System.Windows.Forms.Label lblFancyGraphics;
        private System.Windows.Forms.CheckBox cbxFancyGraphics;
        private System.Windows.Forms.NumericUpDown nudBrightness;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.Label lblUpscaling;
        private System.Windows.Forms.Label lblRayTracing;
        private System.Windows.Forms.Label lblFieldofView;
        private System.Windows.Forms.Label lblRenderDistance;
        private System.Windows.Forms.Label lblFullscreen;
        private System.Windows.Forms.Label lblVsync;
        private System.Windows.Forms.CheckBox cbxUpscaling;
        private System.Windows.Forms.CheckBox cbxRayTracing;
        private System.Windows.Forms.NumericUpDown nudFieldofView;
        private System.Windows.Forms.NumericUpDown nudRenderDistance;
        private System.Windows.Forms.CheckBox cbxFullScreen;
        private System.Windows.Forms.CheckBox cbxVsync;
        private System.Windows.Forms.TrackBar trckbrSoundVolume;
        private System.Windows.Forms.TrackBar trckbrMusicVolume;
        private System.Windows.Forms.Label lblSoundVolume;
        private System.Windows.Forms.Label lblMusicVolume;
        private System.Windows.Forms.ComboBox cbxCameraPerspective;
        private System.Windows.Forms.Label lblCameraPerspective;
        private System.Windows.Forms.CheckBox cbxShowCoordinates;
        private System.Windows.Forms.NumericUpDown nudTransparency;
        private System.Windows.Forms.Label lblShowCoordinates;
        private System.Windows.Forms.Label lblHudTransparency;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSetDefault;
        private System.Windows.Forms.Button btnLoadProfile;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.ComboBox cbxProfile;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label lblProfile;
    }
}