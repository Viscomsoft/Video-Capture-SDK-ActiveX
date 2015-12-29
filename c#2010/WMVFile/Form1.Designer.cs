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
            this.audioInputComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.advProfileRadioButton = new System.Windows.Forms.RadioButton();
            this.defaultProfileRadioButton = new System.Windows.Forms.RadioButton();
            this.previewButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.profileComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cusProfileComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.axVideoCap1 = new AxVIDEOCAPLib.AxVideoCap();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).BeginInit();
            this.SuspendLayout();
            // 
            // audioInputComboBox
            // 
            this.audioInputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audioInputComboBox.FormattingEnabled = true;
            this.audioInputComboBox.Location = new System.Drawing.Point(86, 12);
            this.audioInputComboBox.Name = "audioInputComboBox";
            this.audioInputComboBox.Size = new System.Drawing.Size(256, 21);
            this.audioInputComboBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Audio Input";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.advProfileRadioButton);
            this.groupBox1.Controls.Add(this.defaultProfileRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 50);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // advProfileRadioButton
            // 
            this.advProfileRadioButton.AutoSize = true;
            this.advProfileRadioButton.Location = new System.Drawing.Point(124, 19);
            this.advProfileRadioButton.Name = "advProfileRadioButton";
            this.advProfileRadioButton.Size = new System.Drawing.Size(90, 17);
            this.advProfileRadioButton.TabIndex = 14;
            this.advProfileRadioButton.Text = "WMV9 Profile";
            this.advProfileRadioButton.UseVisualStyleBackColor = true;
            this.advProfileRadioButton.Click += new System.EventHandler(this.advProfileRadioButton_Click);
            // 
            // defaultProfileRadioButton
            // 
            this.defaultProfileRadioButton.AutoSize = true;
            this.defaultProfileRadioButton.Checked = true;
            this.defaultProfileRadioButton.Location = new System.Drawing.Point(6, 19);
            this.defaultProfileRadioButton.Name = "defaultProfileRadioButton";
            this.defaultProfileRadioButton.Size = new System.Drawing.Size(93, 17);
            this.defaultProfileRadioButton.TabIndex = 13;
            this.defaultProfileRadioButton.TabStop = true;
            this.defaultProfileRadioButton.Text = "WMV 8 Profile";
            this.defaultProfileRadioButton.UseVisualStyleBackColor = true;
            this.defaultProfileRadioButton.Click += new System.EventHandler(this.defaultProfileRadioButton_Click);
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(348, 10);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 23);
            this.previewButton.TabIndex = 13;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(429, 10);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(75, 23);
            this.captureButton.TabIndex = 14;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(510, 10);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 15;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // profileComboBox
            // 
            this.profileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profileComboBox.FormattingEnabled = true;
            this.profileComboBox.Location = new System.Drawing.Point(90, 105);
            this.profileComboBox.Name = "profileComboBox";
            this.profileComboBox.Size = new System.Drawing.Size(414, 21);
            this.profileComboBox.TabIndex = 17;
            this.profileComboBox.SelectionChangeCommitted += new System.EventHandler(this.profileComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "WMV 8 Profile";
            // 
            // cusProfileComboBox
            // 
            this.cusProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cusProfileComboBox.Enabled = false;
            this.cusProfileComboBox.FormattingEnabled = true;
            this.cusProfileComboBox.Location = new System.Drawing.Point(90, 132);
            this.cusProfileComboBox.Name = "cusProfileComboBox";
            this.cusProfileComboBox.Size = new System.Drawing.Size(414, 21);
            this.cusProfileComboBox.TabIndex = 19;
            this.cusProfileComboBox.SelectionChangeCommitted += new System.EventHandler(this.cusProfileComboBox_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "WMV 9 Profile";
            // 
            // axVideoCap1
            // 
            this.axVideoCap1.Enabled = true;
            this.axVideoCap1.Location = new System.Drawing.Point(25, 159);
            this.axVideoCap1.Name = "axVideoCap1";
            this.axVideoCap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoCap1.OcxState")));
            this.axVideoCap1.Size = new System.Drawing.Size(586, 248);
            this.axVideoCap1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 419);
            this.Controls.Add(this.axVideoCap1);
            this.Controls.Add(this.cusProfileComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.profileComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.audioInputComboBox);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoCap1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox audioInputComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton advProfileRadioButton;
        private System.Windows.Forms.RadioButton defaultProfileRadioButton;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ComboBox profileComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cusProfileComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private AxVIDEOCAPLib.AxVideoCap axVideoCap1;
    }
}

