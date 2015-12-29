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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.videoCompressorButton = new System.Windows.Forms.Button();
            this.videoCompressorComboBox = new System.Windows.Forms.ComboBox();
            this.useVideoCapCheckBox = new System.Windows.Forms.CheckBox();
            this.audioCompressorComboBox = new System.Windows.Forms.ComboBox();
            this.useAudioCapCheckBox = new System.Windows.Forms.CheckBox();
            this.audioInputComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.audioDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.videoInputComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.videoFormatComboBox = new System.Windows.Forms.ComboBox();
            this.videoFormatLabel = new System.Windows.Forms.Label();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.deviceLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.tVMuteCheckBox = new System.Windows.Forms.CheckBox();
            this.aspectRatioCheckBox = new System.Windows.Forms.CheckBox();
            this.captureVideoCheckBox = new System.Windows.Forms.CheckBox();
            this.captureAudioCheckBox = new System.Windows.Forms.CheckBox();
            this.showPreviewCheckBox = new System.Windows.Forms.CheckBox();
            this.previewButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.resumeButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.axVideoCap1 = new AxVIDEOCAPLib.AxVideoCap();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.videoCompressorButton);
            this.groupBox1.Controls.Add(this.videoCompressorComboBox);
            this.groupBox1.Controls.Add(this.useVideoCapCheckBox);
            this.groupBox1.Controls.Add(this.audioCompressorComboBox);
            this.groupBox1.Controls.Add(this.useAudioCapCheckBox);
            this.groupBox1.Controls.Add(this.audioInputComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.audioDeviceComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.videoInputComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.videoFormatComboBox);
            this.groupBox1.Controls.Add(this.videoFormatLabel);
            this.groupBox1.Controls.Add(this.deviceComboBox);
            this.groupBox1.Controls.Add(this.deviceLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // videoCompressorButton
            // 
            this.videoCompressorButton.Location = new System.Drawing.Point(615, 98);
            this.videoCompressorButton.Name = "videoCompressorButton";
            this.videoCompressorButton.Size = new System.Drawing.Size(75, 23);
            this.videoCompressorButton.TabIndex = 14;
            this.videoCompressorButton.Text = "Settings";
            this.videoCompressorButton.UseVisualStyleBackColor = true;
            this.videoCompressorButton.Click += new System.EventHandler(this.videoCompressorButton_Click);
            // 
            // videoCompressorComboBox
            // 
            this.videoCompressorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoCompressorComboBox.FormattingEnabled = true;
            this.videoCompressorComboBox.Location = new System.Drawing.Point(345, 100);
            this.videoCompressorComboBox.Name = "videoCompressorComboBox";
            this.videoCompressorComboBox.Size = new System.Drawing.Size(264, 21);
            this.videoCompressorComboBox.TabIndex = 13;
            // 
            // useVideoCapCheckBox
            // 
            this.useVideoCapCheckBox.AutoSize = true;
            this.useVideoCapCheckBox.Checked = true;
            this.useVideoCapCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useVideoCapCheckBox.Location = new System.Drawing.Point(345, 75);
            this.useVideoCapCheckBox.Name = "useVideoCapCheckBox";
            this.useVideoCapCheckBox.Size = new System.Drawing.Size(133, 17);
            this.useVideoCapCheckBox.TabIndex = 12;
            this.useVideoCapCheckBox.Text = "Use Video Compressor";
            this.useVideoCapCheckBox.UseVisualStyleBackColor = true;
            this.useVideoCapCheckBox.Click += new System.EventHandler(this.useVideoCapCheckBox_Click);
            // 
            // audioCompressorComboBox
            // 
            this.audioCompressorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audioCompressorComboBox.FormattingEnabled = true;
            this.audioCompressorComboBox.Location = new System.Drawing.Point(345, 46);
            this.audioCompressorComboBox.Name = "audioCompressorComboBox";
            this.audioCompressorComboBox.Size = new System.Drawing.Size(264, 21);
            this.audioCompressorComboBox.TabIndex = 11;
            // 
            // useAudioCapCheckBox
            // 
            this.useAudioCapCheckBox.AutoSize = true;
            this.useAudioCapCheckBox.Checked = true;
            this.useAudioCapCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useAudioCapCheckBox.Location = new System.Drawing.Point(345, 21);
            this.useAudioCapCheckBox.Name = "useAudioCapCheckBox";
            this.useAudioCapCheckBox.Size = new System.Drawing.Size(133, 17);
            this.useAudioCapCheckBox.TabIndex = 10;
            this.useAudioCapCheckBox.Text = "Use Audio Compressor";
            this.useAudioCapCheckBox.UseVisualStyleBackColor = true;
            this.useAudioCapCheckBox.Click += new System.EventHandler(this.useAudioCapCheckBox_Click);
            this.useAudioCapCheckBox.CheckedChanged += new System.EventHandler(this.useAudioCapCheckBox_CheckedChanged);
            // 
            // audioInputComboBox
            // 
            this.audioInputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audioInputComboBox.FormattingEnabled = true;
            this.audioInputComboBox.Location = new System.Drawing.Point(83, 127);
            this.audioInputComboBox.Name = "audioInputComboBox";
            this.audioInputComboBox.Size = new System.Drawing.Size(256, 21);
            this.audioInputComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Audio Input";
            // 
            // audioDeviceComboBox
            // 
            this.audioDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audioDeviceComboBox.FormattingEnabled = true;
            this.audioDeviceComboBox.Location = new System.Drawing.Point(83, 100);
            this.audioDeviceComboBox.Name = "audioDeviceComboBox";
            this.audioDeviceComboBox.Size = new System.Drawing.Size(256, 21);
            this.audioDeviceComboBox.TabIndex = 7;
            this.audioDeviceComboBox.SelectionChangeCommitted += new System.EventHandler(this.audioDeviceComboBox_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Audio Device";
            // 
            // videoInputComboBox
            // 
            this.videoInputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoInputComboBox.FormattingEnabled = true;
            this.videoInputComboBox.Location = new System.Drawing.Point(83, 73);
            this.videoInputComboBox.Name = "videoInputComboBox";
            this.videoInputComboBox.Size = new System.Drawing.Size(256, 21);
            this.videoInputComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Video Input";
            // 
            // videoFormatComboBox
            // 
            this.videoFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoFormatComboBox.FormattingEnabled = true;
            this.videoFormatComboBox.Location = new System.Drawing.Point(83, 46);
            this.videoFormatComboBox.Name = "videoFormatComboBox";
            this.videoFormatComboBox.Size = new System.Drawing.Size(256, 21);
            this.videoFormatComboBox.TabIndex = 3;
            // 
            // videoFormatLabel
            // 
            this.videoFormatLabel.AutoSize = true;
            this.videoFormatLabel.Location = new System.Drawing.Point(6, 49);
            this.videoFormatLabel.Name = "videoFormatLabel";
            this.videoFormatLabel.Size = new System.Drawing.Size(69, 13);
            this.videoFormatLabel.TabIndex = 2;
            this.videoFormatLabel.Text = "Video Format";
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(83, 19);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(256, 21);
            this.deviceComboBox.TabIndex = 1;
            this.deviceComboBox.SelectionChangeCommitted += new System.EventHandler(this.deviceComboBox_SelectionChangeCommitted);
            // 
            // deviceLabel
            // 
            this.deviceLabel.AutoSize = true;
            this.deviceLabel.Location = new System.Drawing.Point(6, 22);
            this.deviceLabel.Name = "deviceLabel";
            this.deviceLabel.Size = new System.Drawing.Size(41, 13);
            this.deviceLabel.TabIndex = 0;
            this.deviceLabel.Text = "Device";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.backgroundColorButton);
            this.groupBox2.Controls.Add(this.tVMuteCheckBox);
            this.groupBox2.Controls.Add(this.aspectRatioCheckBox);
            this.groupBox2.Controls.Add(this.captureVideoCheckBox);
            this.groupBox2.Controls.Add(this.captureAudioCheckBox);
            this.groupBox2.Controls.Add(this.showPreviewCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(508, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Location = new System.Drawing.Point(79, 124);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(115, 23);
            this.backgroundColorButton.TabIndex = 16;
            this.backgroundColorButton.Text = "Background Color";
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // tVMuteCheckBox
            // 
            this.tVMuteCheckBox.AutoSize = true;
            this.tVMuteCheckBox.Checked = true;
            this.tVMuteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tVMuteCheckBox.Location = new System.Drawing.Point(6, 128);
            this.tVMuteCheckBox.Name = "tVMuteCheckBox";
            this.tVMuteCheckBox.Size = new System.Drawing.Size(67, 17);
            this.tVMuteCheckBox.TabIndex = 15;
            this.tVMuteCheckBox.Text = "TV Mute";
            this.tVMuteCheckBox.UseVisualStyleBackColor = true;
            // 
            // aspectRatioCheckBox
            // 
            this.aspectRatioCheckBox.AutoSize = true;
            this.aspectRatioCheckBox.Checked = true;
            this.aspectRatioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aspectRatioCheckBox.Location = new System.Drawing.Point(6, 100);
            this.aspectRatioCheckBox.Name = "aspectRatioCheckBox";
            this.aspectRatioCheckBox.Size = new System.Drawing.Size(87, 17);
            this.aspectRatioCheckBox.TabIndex = 14;
            this.aspectRatioCheckBox.Text = "Aspect Ratio";
            this.aspectRatioCheckBox.UseVisualStyleBackColor = true;
            this.aspectRatioCheckBox.Click += new System.EventHandler(this.aspectRatioCheckBox_Click);
            // 
            // captureVideoCheckBox
            // 
            this.captureVideoCheckBox.AutoSize = true;
            this.captureVideoCheckBox.Checked = true;
            this.captureVideoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.captureVideoCheckBox.Location = new System.Drawing.Point(6, 72);
            this.captureVideoCheckBox.Name = "captureVideoCheckBox";
            this.captureVideoCheckBox.Size = new System.Drawing.Size(93, 17);
            this.captureVideoCheckBox.TabIndex = 13;
            this.captureVideoCheckBox.Text = "Capture Video";
            this.captureVideoCheckBox.UseVisualStyleBackColor = true;
            // 
            // captureAudioCheckBox
            // 
            this.captureAudioCheckBox.AutoSize = true;
            this.captureAudioCheckBox.Checked = true;
            this.captureAudioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.captureAudioCheckBox.Location = new System.Drawing.Point(6, 44);
            this.captureAudioCheckBox.Name = "captureAudioCheckBox";
            this.captureAudioCheckBox.Size = new System.Drawing.Size(93, 17);
            this.captureAudioCheckBox.TabIndex = 12;
            this.captureAudioCheckBox.Text = "Capture Audio";
            this.captureAudioCheckBox.UseVisualStyleBackColor = true;
            // 
            // showPreviewCheckBox
            // 
            this.showPreviewCheckBox.AutoSize = true;
            this.showPreviewCheckBox.Checked = true;
            this.showPreviewCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPreviewCheckBox.Location = new System.Drawing.Point(6, 16);
            this.showPreviewCheckBox.Name = "showPreviewCheckBox";
            this.showPreviewCheckBox.Size = new System.Drawing.Size(163, 17);
            this.showPreviewCheckBox.TabIndex = 11;
            this.showPreviewCheckBox.Text = "Show Preview when Capture";
            this.showPreviewCheckBox.UseVisualStyleBackColor = true;
            // 
            // previewButton
            // 
            this.previewButton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewButton.Location = new System.Drawing.Point(21, 181);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 23);
            this.previewButton.TabIndex = 2;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // captureButton
            // 
            this.captureButton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureButton.Location = new System.Drawing.Point(102, 181);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(75, 23);
            this.captureButton.TabIndex = 3;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(183, 181);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop Capture";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(264, 181);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 5;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // resumeButton
            // 
            this.resumeButton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeButton.Location = new System.Drawing.Point(345, 181);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(75, 23);
            this.resumeButton.TabIndex = 6;
            this.resumeButton.Text = "Resume";
            this.resumeButton.UseVisualStyleBackColor = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // axVideoCap1
            // 
            this.axVideoCap1.Enabled = true;
            this.axVideoCap1.Location = new System.Drawing.Point(27, 232);
            this.axVideoCap1.Name = "axVideoCap1";
            this.axVideoCap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoCap1.OcxState")));
            this.axVideoCap1.Size = new System.Drawing.Size(475, 371);
            this.axVideoCap1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 620);
            this.Controls.Add(this.axVideoCap1);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Capture file";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox audioInputComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox audioDeviceComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox videoInputComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox videoFormatComboBox;
        private System.Windows.Forms.Label videoFormatLabel;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Label deviceLabel;
        private System.Windows.Forms.Button videoCompressorButton;
        private System.Windows.Forms.ComboBox videoCompressorComboBox;
        private System.Windows.Forms.CheckBox useVideoCapCheckBox;
        private System.Windows.Forms.ComboBox audioCompressorComboBox;
        private System.Windows.Forms.CheckBox useAudioCapCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox tVMuteCheckBox;
        private System.Windows.Forms.CheckBox aspectRatioCheckBox;
        private System.Windows.Forms.CheckBox captureVideoCheckBox;
        private System.Windows.Forms.CheckBox captureAudioCheckBox;
        private System.Windows.Forms.CheckBox showPreviewCheckBox;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private AxVIDEOCAPLib.AxVideoCap axVideoCap1;

    }
}

