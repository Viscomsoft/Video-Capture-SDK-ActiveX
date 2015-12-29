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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.axVideoCap1 = new AxVIDEOCAPLib.AxVideoCap();
            this.chkdualdisplay = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.deviceComboBox.Location = new System.Drawing.Point(83, 20);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(256, 21);
            this.deviceComboBox.TabIndex = 1;
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
            this.tVMuteCheckBox.Size = new System.Drawing.Size(67, 18);
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
            this.aspectRatioCheckBox.Size = new System.Drawing.Size(87, 18);
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
            this.captureVideoCheckBox.Size = new System.Drawing.Size(93, 18);
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
            this.captureAudioCheckBox.Size = new System.Drawing.Size(93, 18);
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
            this.showPreviewCheckBox.Size = new System.Drawing.Size(163, 18);
            this.showPreviewCheckBox.TabIndex = 11;
            this.showPreviewCheckBox.Text = "Show Preview when Capture";
            this.showPreviewCheckBox.UseVisualStyleBackColor = true;
            // 
            // previewButton
            // 
            this.previewButton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewButton.Location = new System.Drawing.Point(21, 210);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 23);
            this.previewButton.TabIndex = 2;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // axVideoCap1
            // 
            this.axVideoCap1.Enabled = true;
            this.axVideoCap1.Location = new System.Drawing.Point(27, 264);
            this.axVideoCap1.Name = "axVideoCap1";
            this.axVideoCap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoCap1.OcxState")));
            this.axVideoCap1.Size = new System.Drawing.Size(475, 339);
            this.axVideoCap1.TabIndex = 12;
            // 
            // chkdualdisplay
            // 
            this.chkdualdisplay.AutoSize = true;
            this.chkdualdisplay.Checked = true;
            this.chkdualdisplay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkdualdisplay.Location = new System.Drawing.Point(125, 211);
            this.chkdualdisplay.Name = "chkdualdisplay";
            this.chkdualdisplay.Size = new System.Drawing.Size(107, 17);
            this.chkdualdisplay.TabIndex = 13;
            this.chkdualdisplay.Text = "Use Dual Display";
            this.chkdualdisplay.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 24);
            this.button1.TabIndex = 14;
            this.button1.Text = "Hide Screen of Monitor 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 25);
            this.button2.TabIndex = 15;
            this.button2.Text = "Show Screen of Monitor 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Make sure you have multimonitor display card and selected extend my Window Deskto" +
    "p onto monitor 2 in Display Properties";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkdualdisplay);
            this.Controls.Add(this.axVideoCap1);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Dual Display";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox tVMuteCheckBox;
        private System.Windows.Forms.CheckBox aspectRatioCheckBox;
        private System.Windows.Forms.CheckBox captureVideoCheckBox;
        private System.Windows.Forms.CheckBox captureAudioCheckBox;
        private System.Windows.Forms.CheckBox showPreviewCheckBox;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private AxVIDEOCAPLib.AxVideoCap axVideoCap1;
        private System.Windows.Forms.CheckBox chkdualdisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;

    }
}

