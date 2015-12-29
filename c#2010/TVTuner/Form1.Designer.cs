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
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.deviceLabel = new System.Windows.Forms.Label();
            this.videoInputComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.videoFormatComboBox = new System.Windows.Forms.ComboBox();
            this.videoFormatLabel = new System.Windows.Forms.Label();
            this.videoStandardComboBox = new System.Windows.Forms.ComboBox();
            this.videoStandardLabel = new System.Windows.Forms.Label();
            this.countryCodeLabel = new System.Windows.Forms.Label();
            this.countryCodeTextBox = new System.Windows.Forms.TextBox();
            this.countryCodeDescLabel = new System.Windows.Forms.Label();
            this.channelNoLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.snapShotButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.stopCaptureButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.muteCheckBox = new System.Windows.Forms.CheckBox();
            this.propPageButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.axVideoCap1 = new AxVIDEOCAPLib.AxVideoCap();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(101, 12);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(159, 21);
            this.deviceComboBox.TabIndex = 3;
            // 
            // deviceLabel
            // 
            this.deviceLabel.AutoSize = true;
            this.deviceLabel.Location = new System.Drawing.Point(15, 15);
            this.deviceLabel.Name = "deviceLabel";
            this.deviceLabel.Size = new System.Drawing.Size(41, 13);
            this.deviceLabel.TabIndex = 2;
            this.deviceLabel.Text = "Device";
            // 
            // videoInputComboBox
            // 
            this.videoInputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoInputComboBox.FormattingEnabled = true;
            this.videoInputComboBox.Location = new System.Drawing.Point(101, 39);
            this.videoInputComboBox.Name = "videoInputComboBox";
            this.videoInputComboBox.Size = new System.Drawing.Size(159, 21);
            this.videoInputComboBox.TabIndex = 7;
            this.videoInputComboBox.SelectionChangeCommitted += new System.EventHandler(this.videoInputComboBox_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Video Input";
            // 
            // videoFormatComboBox
            // 
            this.videoFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoFormatComboBox.FormattingEnabled = true;
            this.videoFormatComboBox.Location = new System.Drawing.Point(101, 66);
            this.videoFormatComboBox.Name = "videoFormatComboBox";
            this.videoFormatComboBox.Size = new System.Drawing.Size(247, 21);
            this.videoFormatComboBox.TabIndex = 9;
            this.videoFormatComboBox.SelectionChangeCommitted += new System.EventHandler(this.videoFormatComboBox_SelectionChangeCommitted);
            // 
            // videoFormatLabel
            // 
            this.videoFormatLabel.AutoSize = true;
            this.videoFormatLabel.Location = new System.Drawing.Point(15, 69);
            this.videoFormatLabel.Name = "videoFormatLabel";
            this.videoFormatLabel.Size = new System.Drawing.Size(69, 13);
            this.videoFormatLabel.TabIndex = 8;
            this.videoFormatLabel.Text = "Video Format";
            // 
            // videoStandardComboBox
            // 
            this.videoStandardComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoStandardComboBox.FormattingEnabled = true;
            this.videoStandardComboBox.Location = new System.Drawing.Point(101, 93);
            this.videoStandardComboBox.Name = "videoStandardComboBox";
            this.videoStandardComboBox.Size = new System.Drawing.Size(247, 21);
            this.videoStandardComboBox.TabIndex = 11;
            this.videoStandardComboBox.SelectionChangeCommitted += new System.EventHandler(this.videoStandardComboBox_SelectionChangeCommitted);
            // 
            // videoStandardLabel
            // 
            this.videoStandardLabel.AutoSize = true;
            this.videoStandardLabel.Location = new System.Drawing.Point(15, 96);
            this.videoStandardLabel.Name = "videoStandardLabel";
            this.videoStandardLabel.Size = new System.Drawing.Size(80, 13);
            this.videoStandardLabel.TabIndex = 10;
            this.videoStandardLabel.Text = "Video Standard";
            // 
            // countryCodeLabel
            // 
            this.countryCodeLabel.AutoSize = true;
            this.countryCodeLabel.Location = new System.Drawing.Point(15, 127);
            this.countryCodeLabel.Name = "countryCodeLabel";
            this.countryCodeLabel.Size = new System.Drawing.Size(71, 13);
            this.countryCodeLabel.TabIndex = 12;
            this.countryCodeLabel.Text = "Country Code";
            // 
            // countryCodeTextBox
            // 
            this.countryCodeTextBox.Location = new System.Drawing.Point(101, 120);
            this.countryCodeTextBox.Name = "countryCodeTextBox";
            this.countryCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryCodeTextBox.TabIndex = 13;
            this.countryCodeTextBox.Text = "1";
            // 
            // countryCodeDescLabel
            // 
            this.countryCodeDescLabel.AutoSize = true;
            this.countryCodeDescLabel.Location = new System.Drawing.Point(207, 123);
            this.countryCodeDescLabel.Name = "countryCodeDescLabel";
            this.countryCodeDescLabel.Size = new System.Drawing.Size(262, 13);
            this.countryCodeDescLabel.TabIndex = 14;
            this.countryCodeDescLabel.Text = "if you do not know your country code ,see the help file";
            // 
            // channelNoLabel
            // 
            this.channelNoLabel.AutoSize = true;
            this.channelNoLabel.Location = new System.Drawing.Point(9, 358);
            this.channelNoLabel.Name = "channelNoLabel";
            this.channelNoLabel.Size = new System.Drawing.Size(83, 13);
            this.channelNoLabel.TabIndex = 16;
            this.channelNoLabel.Text = "TV Channel No.";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(267, 9);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 17;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // snapShotButton
            // 
            this.snapShotButton.Location = new System.Drawing.Point(348, 9);
            this.snapShotButton.Name = "snapShotButton";
            this.snapShotButton.Size = new System.Drawing.Size(75, 23);
            this.snapShotButton.TabIndex = 18;
            this.snapShotButton.Text = "SnapShot";
            this.snapShotButton.UseVisualStyleBackColor = true;
            this.snapShotButton.Click += new System.EventHandler(this.snapShotButton_Click);
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(429, 9);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(75, 23);
            this.captureButton.TabIndex = 19;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // stopCaptureButton
            // 
            this.stopCaptureButton.Location = new System.Drawing.Point(510, 9);
            this.stopCaptureButton.Name = "stopCaptureButton";
            this.stopCaptureButton.Size = new System.Drawing.Size(90, 23);
            this.stopCaptureButton.TabIndex = 20;
            this.stopCaptureButton.Text = "Stop Capture";
            this.stopCaptureButton.UseVisualStyleBackColor = true;
            this.stopCaptureButton.Click += new System.EventHandler(this.stopCaptureButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Location = new System.Drawing.Point(267, 37);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 21;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(320, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 185);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 374);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 121);
            this.listBox1.TabIndex = 23;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // muteCheckBox
            // 
            this.muteCheckBox.AutoSize = true;
            this.muteCheckBox.Location = new System.Drawing.Point(201, 374);
            this.muteCheckBox.Name = "muteCheckBox";
            this.muteCheckBox.Size = new System.Drawing.Size(50, 17);
            this.muteCheckBox.TabIndex = 24;
            this.muteCheckBox.Text = "Mute";
            this.muteCheckBox.UseVisualStyleBackColor = true;
            this.muteCheckBox.Click += new System.EventHandler(this.muteCheckBox_Click);
            // 
            // propPageButton
            // 
            this.propPageButton.Location = new System.Drawing.Point(201, 472);
            this.propPageButton.Name = "propPageButton";
            this.propPageButton.Size = new System.Drawing.Size(125, 23);
            this.propPageButton.TabIndex = 25;
            this.propPageButton.Text = "Show Property Page";
            this.propPageButton.UseVisualStyleBackColor = true;
            this.propPageButton.Click += new System.EventHandler(this.propPageButton_Click);
            // 
            // axVideoCap1
            // 
            this.axVideoCap1.Enabled = true;
            this.axVideoCap1.Location = new System.Drawing.Point(16, 161);
            this.axVideoCap1.Name = "axVideoCap1";
            this.axVideoCap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoCap1.OcxState")));
            this.axVideoCap1.Size = new System.Drawing.Size(272, 181);
            this.axVideoCap1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 526);
            this.Controls.Add(this.axVideoCap1);
            this.Controls.Add(this.propPageButton);
            this.Controls.Add(this.muteCheckBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.stopCaptureButton);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.snapShotButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.channelNoLabel);
            this.Controls.Add(this.countryCodeDescLabel);
            this.Controls.Add(this.countryCodeTextBox);
            this.Controls.Add(this.countryCodeLabel);
            this.Controls.Add(this.videoStandardComboBox);
            this.Controls.Add(this.videoStandardLabel);
            this.Controls.Add(this.videoFormatComboBox);
            this.Controls.Add(this.videoFormatLabel);
            this.Controls.Add(this.videoInputComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deviceComboBox);
            this.Controls.Add(this.deviceLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox deviceComboBox;
        private System.Windows.Forms.Label deviceLabel;
        private System.Windows.Forms.ComboBox videoInputComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox videoFormatComboBox;
        private System.Windows.Forms.Label videoFormatLabel;
        private System.Windows.Forms.ComboBox videoStandardComboBox;
        private System.Windows.Forms.Label videoStandardLabel;
        private System.Windows.Forms.Label countryCodeLabel;
        private System.Windows.Forms.TextBox countryCodeTextBox;
        private System.Windows.Forms.Label countryCodeDescLabel;
        private System.Windows.Forms.Label channelNoLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button snapShotButton;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button stopCaptureButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox muteCheckBox;
        private System.Windows.Forms.Button propPageButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private AxVIDEOCAPLib.AxVideoCap axVideoCap1;
    } 
}

