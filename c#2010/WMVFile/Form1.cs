using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VIDEOCAPLib;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cusProfileComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (this.cusProfileComboBox.SelectedIndex)
            {
                case 0:
                    this.axVideoCap1.WMVCustomFileName = "C:\\Program Files\\VideoCap ActiveX Control\\Profiles\\320x240.prx";
                    break;
                case 1:
                    this.axVideoCap1.WMVCustomFileName = "C:\\Program Files\\VideoCap ActiveX Control\\Profiles\\640x480.prx";
                    break;
                case 2:
                    this.axVideoCap1.WMVCustomFileName = "C:\\Program Files\\VideoCap ActiveX Control\\Profiles\\800x600.prx";
                    break;
                case 3:
                    this.axVideoCap1.WMVCustomFileName = "C:\\Program Files\\VideoCap ActiveX Control\\Profiles\\1024x768.prx";
                    break;
                case 4:
                    this.axVideoCap1.WMVCustomFileName = "C:\\Program Files\\VideoCap  ActiveX Control\\Profiles\\1280x1024.prx";
                    break;
            }
        }

        private void profileComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.axVideoCap1.WMVProfile = (short)this.profileComboBox.SelectedIndex;
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.Device = 0;
            this.axVideoCap1.AudioInputPin = (short)this.audioInputComboBox.SelectedIndex;
            this.axVideoCap1.SyncMode = 1;
            this.axVideoCap1.Start();

        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "wmv File (*.wmv)|*.wmv";
            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.axVideoCap1.WMVProfile = (short)this.profileComboBox.SelectedIndex;
                this.axVideoCap1.CaptureFileName = this.saveFileDialog1.FileName;
                this.axVideoCap1.OutputWMV = true;
                this.axVideoCap1.CaptureMode = true;
                this.axVideoCap1.AudioInputPin = (short)this.audioInputComboBox.SelectedIndex;
                this.axVideoCap1.SyncMode = 1;
                this.axVideoCap1.Start();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.Stop();
            this.axVideoCap1.CaptureMode = false;
            this.axVideoCap1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (short i = 0; i < axVideoCap1.GetWMVProfileCount(); i++)
            {
                this.profileComboBox.Items.Add(axVideoCap1.GetWMVProfileName(i));
            }

                if (this.profileComboBox.Items.Count > 0)
                {
                    this.profileComboBox.SelectedIndex = 0;
                }

                for (short i = 0; i < axVideoCap1.GetAudioInputPinCount(); i ++ )
                {
                    this.audioInputComboBox.Items.Add(axVideoCap1.GetAudioInputPinName(i));
                }
            if (this.audioInputComboBox.Items.Count > 0)
            {
                this.audioInputComboBox.SelectedIndex = 0;
            }

            this.cusProfileComboBox.Items.AddRange(new string[]{"Window Media Video/Audio 9 for 320x240","Window Media Video/Audio 9 for 640x480",
                "Window Media Video/Audio 9 for 800x600","Window Media Video/Audio 9 for 1024x768","Window Media Video/Audio 9 for 1280x1024"});
            this.cusProfileComboBox.SelectedIndex = 0;

        }

        private void advProfileRadioButton_Click(object sender, EventArgs e)
        {
            this.profileComboBox.Enabled = false;
            this.cusProfileComboBox.Enabled = true;
        }

        private void defaultProfileRadioButton_Click(object sender, EventArgs e)
        {
            this.profileComboBox.Enabled = true;
            this.cusProfileComboBox.Enabled = false;
        }
    }
}