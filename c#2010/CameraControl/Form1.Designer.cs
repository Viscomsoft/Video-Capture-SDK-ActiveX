namespace WindowsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.videoInputLabel = new System.Windows.Forms.Label();
            this.videoInputComboBox = new System.Windows.Forms.ComboBox();
            this.previewButton = new System.Windows.Forms.Button();
            this.proPageButton = new System.Windows.Forms.Button();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            this.saturationLabel = new System.Windows.Forms.Label();
            this.saturationTrackBar = new System.Windows.Forms.TrackBar();
            this.hueLabel = new System.Windows.Forms.Label();
            this.hueTrackBar = new System.Windows.Forms.TrackBar();
            this.whiteBalanceLabel = new System.Windows.Forms.Label();
            this.whiteBalanceTrackBar = new System.Windows.Forms.TrackBar();
            this.colorEnableLabel = new System.Windows.Forms.Label();
            this.colorEnableTrackBar = new System.Windows.Forms.TrackBar();
            this.gammaLabel = new System.Windows.Forms.Label();
            this.gammaTrackBar = new System.Windows.Forms.TrackBar();
            this.sharpnessLabel = new System.Windows.Forms.Label();
            this.sharpnessTrackBar = new System.Windows.Forms.TrackBar();
            this.gainLabel = new System.Windows.Forms.Label();
            this.gainTrackBar = new System.Windows.Forms.TrackBar();
            this.backlightCompensationLabel = new System.Windows.Forms.Label();
            this.backlightCompensationTrackBar = new System.Windows.Forms.TrackBar();
            this.axVideoCap1 = new AxVIDEOCAPLib.AxVideoCap();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBalanceTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEnableTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gainTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backlightCompensationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).BeginInit();
            this.SuspendLayout();
            // 
            // videoInputLabel
            // 
            this.videoInputLabel.AutoSize = true;
            this.videoInputLabel.Location = new System.Drawing.Point(272, 28);
            this.videoInputLabel.Name = "videoInputLabel";
            this.videoInputLabel.Size = new System.Drawing.Size(71, 12);
            this.videoInputLabel.TabIndex = 1;
            this.videoInputLabel.Text = "Video Input";
            // 
            // videoInputComboBox
            // 
            this.videoInputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoInputComboBox.FormattingEnabled = true;
            this.videoInputComboBox.Location = new System.Drawing.Point(339, 25);
            this.videoInputComboBox.Name = "videoInputComboBox";
            this.videoInputComboBox.Size = new System.Drawing.Size(121, 20);
            this.videoInputComboBox.TabIndex = 2;
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(275, 59);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(185, 21);
            this.previewButton.TabIndex = 3;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // proPageButton
            // 
            this.proPageButton.Location = new System.Drawing.Point(275, 87);
            this.proPageButton.Name = "proPageButton";
            this.proPageButton.Size = new System.Drawing.Size(185, 21);
            this.proPageButton.TabIndex = 4;
            this.proPageButton.Text = "Show Property Page";
            this.proPageButton.UseVisualStyleBackColor = true;
            this.proPageButton.Click += new System.EventHandler(this.proPageButton_Click);
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Location = new System.Drawing.Point(146, 222);
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(359, 45);
            this.brightnessTrackBar.TabIndex = 5;
            this.brightnessTrackBar.Scroll += new System.EventHandler(this.brightnessTrackBar_Scroll);
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(12, 222);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(65, 12);
            this.brightnessLabel.TabIndex = 6;
            this.brightnessLabel.Text = "Brightness";
            // 
            // contrastLabel
            // 
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.Location = new System.Drawing.Point(12, 269);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(53, 12);
            this.contrastLabel.TabIndex = 8;
            this.contrastLabel.Text = "Contrast";
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Location = new System.Drawing.Point(146, 269);
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Size = new System.Drawing.Size(359, 45);
            this.contrastTrackBar.TabIndex = 7;
            this.contrastTrackBar.Scroll += new System.EventHandler(this.contrastTrackBar_Scroll);
            // 
            // saturationLabel
            // 
            this.saturationLabel.AutoSize = true;
            this.saturationLabel.Location = new System.Drawing.Point(12, 363);
            this.saturationLabel.Name = "saturationLabel";
            this.saturationLabel.Size = new System.Drawing.Size(65, 12);
            this.saturationLabel.TabIndex = 12;
            this.saturationLabel.Text = "Saturation";
            // 
            // saturationTrackBar
            // 
            this.saturationTrackBar.Location = new System.Drawing.Point(146, 363);
            this.saturationTrackBar.Name = "saturationTrackBar";
            this.saturationTrackBar.Size = new System.Drawing.Size(359, 45);
            this.saturationTrackBar.TabIndex = 11;
            this.saturationTrackBar.Scroll += new System.EventHandler(this.saturationTrackBar_Scroll);
            // 
            // hueLabel
            // 
            this.hueLabel.AutoSize = true;
            this.hueLabel.Location = new System.Drawing.Point(12, 316);
            this.hueLabel.Name = "hueLabel";
            this.hueLabel.Size = new System.Drawing.Size(23, 12);
            this.hueLabel.TabIndex = 10;
            this.hueLabel.Text = "Hue";
            // 
            // hueTrackBar
            // 
            this.hueTrackBar.Location = new System.Drawing.Point(146, 316);
            this.hueTrackBar.Name = "hueTrackBar";
            this.hueTrackBar.Size = new System.Drawing.Size(359, 45);
            this.hueTrackBar.TabIndex = 9;
            this.hueTrackBar.Scroll += new System.EventHandler(this.hueTrackBar_Scroll);
            // 
            // whiteBalanceLabel
            // 
            this.whiteBalanceLabel.AutoSize = true;
            this.whiteBalanceLabel.Location = new System.Drawing.Point(12, 560);
            this.whiteBalanceLabel.Name = "whiteBalanceLabel";
            this.whiteBalanceLabel.Size = new System.Drawing.Size(83, 12);
            this.whiteBalanceLabel.TabIndex = 20;
            this.whiteBalanceLabel.Text = "White Balance";
            // 
            // whiteBalanceTrackBar
            // 
            this.whiteBalanceTrackBar.Location = new System.Drawing.Point(146, 560);
            this.whiteBalanceTrackBar.Name = "whiteBalanceTrackBar";
            this.whiteBalanceTrackBar.Size = new System.Drawing.Size(359, 45);
            this.whiteBalanceTrackBar.TabIndex = 19;
            this.whiteBalanceTrackBar.Scroll += new System.EventHandler(this.whiteBalanceTrackBar_Scroll);
            // 
            // colorEnableLabel
            // 
            this.colorEnableLabel.AutoSize = true;
            this.colorEnableLabel.Location = new System.Drawing.Point(12, 513);
            this.colorEnableLabel.Name = "colorEnableLabel";
            this.colorEnableLabel.Size = new System.Drawing.Size(77, 12);
            this.colorEnableLabel.TabIndex = 18;
            this.colorEnableLabel.Text = "Color Enable";
            // 
            // colorEnableTrackBar
            // 
            this.colorEnableTrackBar.Location = new System.Drawing.Point(146, 513);
            this.colorEnableTrackBar.Name = "colorEnableTrackBar";
            this.colorEnableTrackBar.Size = new System.Drawing.Size(359, 45);
            this.colorEnableTrackBar.TabIndex = 17;
            this.colorEnableTrackBar.Scroll += new System.EventHandler(this.colorEnableTrackBar_Scroll);
            // 
            // gammaLabel
            // 
            this.gammaLabel.AutoSize = true;
            this.gammaLabel.Location = new System.Drawing.Point(12, 466);
            this.gammaLabel.Name = "gammaLabel";
            this.gammaLabel.Size = new System.Drawing.Size(35, 12);
            this.gammaLabel.TabIndex = 16;
            this.gammaLabel.Text = "Gamma";
            // 
            // gammaTrackBar
            // 
            this.gammaTrackBar.Location = new System.Drawing.Point(146, 466);
            this.gammaTrackBar.Name = "gammaTrackBar";
            this.gammaTrackBar.Size = new System.Drawing.Size(359, 45);
            this.gammaTrackBar.TabIndex = 15;
            this.gammaTrackBar.Scroll += new System.EventHandler(this.gammaTrackBar_Scroll);
            // 
            // sharpnessLabel
            // 
            this.sharpnessLabel.AutoSize = true;
            this.sharpnessLabel.Location = new System.Drawing.Point(12, 419);
            this.sharpnessLabel.Name = "sharpnessLabel";
            this.sharpnessLabel.Size = new System.Drawing.Size(59, 12);
            this.sharpnessLabel.TabIndex = 14;
            this.sharpnessLabel.Text = "Sharpness";
            // 
            // sharpnessTrackBar
            // 
            this.sharpnessTrackBar.Location = new System.Drawing.Point(146, 419);
            this.sharpnessTrackBar.Name = "sharpnessTrackBar";
            this.sharpnessTrackBar.Size = new System.Drawing.Size(359, 45);
            this.sharpnessTrackBar.TabIndex = 13;
            this.sharpnessTrackBar.Scroll += new System.EventHandler(this.sharpnessTrackBar_Scroll);
            // 
            // gainLabel
            // 
            this.gainLabel.AutoSize = true;
            this.gainLabel.Location = new System.Drawing.Point(12, 654);
            this.gainLabel.Name = "gainLabel";
            this.gainLabel.Size = new System.Drawing.Size(29, 12);
            this.gainLabel.TabIndex = 24;
            this.gainLabel.Text = "Gain";
            // 
            // gainTrackBar
            // 
            this.gainTrackBar.Location = new System.Drawing.Point(146, 654);
            this.gainTrackBar.Name = "gainTrackBar";
            this.gainTrackBar.Size = new System.Drawing.Size(359, 45);
            this.gainTrackBar.TabIndex = 23;
            this.gainTrackBar.Scroll += new System.EventHandler(this.gainTrackBar_Scroll);
            // 
            // backlightCompensationLabel
            // 
            this.backlightCompensationLabel.AutoSize = true;
            this.backlightCompensationLabel.Location = new System.Drawing.Point(12, 607);
            this.backlightCompensationLabel.Name = "backlightCompensationLabel";
            this.backlightCompensationLabel.Size = new System.Drawing.Size(137, 12);
            this.backlightCompensationLabel.TabIndex = 22;
            this.backlightCompensationLabel.Text = "Backlight Compensation";
            // 
            // backlightCompensationTrackBar
            // 
            this.backlightCompensationTrackBar.Location = new System.Drawing.Point(146, 607);
            this.backlightCompensationTrackBar.Name = "backlightCompensationTrackBar";
            this.backlightCompensationTrackBar.Size = new System.Drawing.Size(359, 45);
            this.backlightCompensationTrackBar.TabIndex = 21;
            this.backlightCompensationTrackBar.Scroll += new System.EventHandler(this.backlightCompensationTrackBar_Scroll);
            // 
            // axVideoCap1
            // 
            this.axVideoCap1.Enabled = true;
            this.axVideoCap1.Location = new System.Drawing.Point(13, 16);
            this.axVideoCap1.Name = "axVideoCap1";
            this.axVideoCap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoCap1.OcxState")));
            this.axVideoCap1.Size = new System.Drawing.Size(247, 206);
            this.axVideoCap1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 705);
            this.Controls.Add(this.axVideoCap1);
            this.Controls.Add(this.gainLabel);
            this.Controls.Add(this.gainTrackBar);
            this.Controls.Add(this.backlightCompensationLabel);
            this.Controls.Add(this.backlightCompensationTrackBar);
            this.Controls.Add(this.whiteBalanceLabel);
            this.Controls.Add(this.whiteBalanceTrackBar);
            this.Controls.Add(this.colorEnableLabel);
            this.Controls.Add(this.colorEnableTrackBar);
            this.Controls.Add(this.gammaLabel);
            this.Controls.Add(this.gammaTrackBar);
            this.Controls.Add(this.sharpnessLabel);
            this.Controls.Add(this.sharpnessTrackBar);
            this.Controls.Add(this.saturationLabel);
            this.Controls.Add(this.saturationTrackBar);
            this.Controls.Add(this.hueLabel);
            this.Controls.Add(this.hueTrackBar);
            this.Controls.Add(this.contrastLabel);
            this.Controls.Add(this.contrastTrackBar);
            this.Controls.Add(this.brightnessLabel);
            this.Controls.Add(this.brightnessTrackBar);
            this.Controls.Add(this.proPageButton);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.videoInputComboBox);
            this.Controls.Add(this.videoInputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteBalanceTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEnableTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gainTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backlightCompensationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    
        private System.Windows.Forms.Label videoInputLabel;
        private System.Windows.Forms.ComboBox videoInputComboBox;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button proPageButton;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Label contrastLabel;
        private System.Windows.Forms.TrackBar contrastTrackBar;
        private System.Windows.Forms.Label saturationLabel;
        private System.Windows.Forms.TrackBar saturationTrackBar;
        private System.Windows.Forms.Label hueLabel;
        private System.Windows.Forms.TrackBar hueTrackBar;
        private System.Windows.Forms.Label whiteBalanceLabel;
        private System.Windows.Forms.TrackBar whiteBalanceTrackBar;
        private System.Windows.Forms.Label colorEnableLabel;
        private System.Windows.Forms.TrackBar colorEnableTrackBar;
        private System.Windows.Forms.Label gammaLabel;
        private System.Windows.Forms.TrackBar gammaTrackBar;
        private System.Windows.Forms.Label sharpnessLabel;
        private System.Windows.Forms.TrackBar sharpnessTrackBar;
        private System.Windows.Forms.Label gainLabel;
        private System.Windows.Forms.TrackBar gainTrackBar;
        private System.Windows.Forms.Label backlightCompensationLabel;
        private System.Windows.Forms.TrackBar backlightCompensationTrackBar;
        private AxVIDEOCAPLib.AxVideoCap axVideoCap1;
    }
}

