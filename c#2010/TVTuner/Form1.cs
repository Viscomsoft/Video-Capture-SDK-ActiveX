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

        private void videoFormatComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //SetVideoFormat();
        }

        private void SetVideoFormat()
        {
            this.axVideoCap1.VideoFormat = (short)this.videoFormatComboBox.SelectedIndex;
        }

        private void videoInputComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //SetVideoInput();
        }

        private void SetVideoInput()
        {
            this.axVideoCap1.VideoInput = (short)this.videoInputComboBox.SelectedIndex;
        }

        private void videoStandardComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //this.axVideoCap1.VideoStandard = (short)this.videoStandardComboBox.SelectedIndex;
        }

        private void muteCheckBox_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.TVMute = this.muteCheckBox.Checked;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.Start();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.Device = (short)this.deviceComboBox.SelectedIndex;
            this.axVideoCap1.VideoInput = (short)this.videoInputComboBox.SelectedIndex;
            this.axVideoCap1.VideoFormat = (short)this.videoFormatComboBox.SelectedIndex;
            this.axVideoCap1.CountryCode = Convert.ToInt16(this.countryCodeTextBox.Text);
       
            this.axVideoCap1.AudioDevice = 0;
            this.axVideoCap1.AudioInputPin = 0;
   

            this.axVideoCap1.Start();
          
           bool isTVDevice = this.axVideoCap1.ScanTVChannels();
            if (!isTVDevice)
            {

                MessageBox.Show("No TV Tuner");

                return;
            }

         

            this.changeButton.Enabled = true;

       
               this.listBox1.Items.Clear();

          
           foreach (TVChannel myTVChannel in this.axVideoCap1.TVChannels)
            {
              if (myTVChannel.SignalStatus != 0)
                {
                   this.listBox1.Items.Add(myTVChannel.ChannelNo);
                }
            }
        


        }

        private void Start()
        {
            this.Text = "Scanning. Please wait ...";
            this.axVideoCap1.Device = (short)this.deviceComboBox.SelectedIndex;

            short a = (short)this.deviceComboBox.SelectedIndex;
           

            this.axVideoCap1.VideoInput =0;
            this.axVideoCap1.VideoFormat =0;
            this.axVideoCap1.AudioDevice = 0;
            this.axVideoCap1.AudioInputPin = 0;

            this.axVideoCap1.Start();
            return;
            bool isTVDevice = this.axVideoCap1.ScanTVChannels();
            if (!isTVDevice)
            {
                
                this.Text = "";
               
                return;
            }

            this.Text = "";

            this.changeButton.Enabled = true;

            this.listBox1.Items.Clear();
            foreach (TVChannel myTVChannel in this.axVideoCap1.TVChannels)
            {
                if (myTVChannel.SignalStatus != 0)
                {
                    this.listBox1.Items.Add(myTVChannel.ChannelNo);
                }
            }

            this.startButton.Enabled = false;
            this.deviceComboBox.Enabled = false;
            this.snapShotButton.Enabled = true;
            this.captureButton.Enabled = true;
            this.Text = "TV Tuner";
        }

        private void snapShotButton_Click(object sender, EventArgs e)
        {
            string strFileName = Application.StartupPath + "\\test.bmp";
            bool result = this.axVideoCap1.SnapShot(strFileName);
            if (result)
            {
                this.pictureBox1.Load(strFileName);
            }
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "Avi File (*.avi)|*.avi";
            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.axVideoCap1.OutputWMV = false;
                this.axVideoCap1.CaptureVideo = true;
                this.axVideoCap1.CaptureAudio = true;
                this.axVideoCap1.UseVideoCompressor = false;
                this.axVideoCap1.UseAudioCompressor = false;
                this.axVideoCap1.CaptureMode = true;
                this.axVideoCap1.CaptureFileName = this.saveFileDialog1.FileName;
     
                this.axVideoCap1.Start();


                this.captureButton.Enabled = false;
                this.stopCaptureButton.Enabled = true;
            }
        }

        private void stopCaptureButton_Click(object sender, EventArgs e)
        {
            this.startButton.Enabled = true;
            this.deviceComboBox.Enabled = true;

            this.axVideoCap1.Stop();

            this.axVideoCap1.CaptureMode = false;
            this.axVideoCap1.Start();

            this.stopCaptureButton.Enabled = false;
            this.captureButton.Enabled = true;
        }

        private void propPageButton_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.ShowVideoCapturePropertyPage(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.videoStandardComboBox.Items.AddRange(new string[]{"Digital sensor","NTSC (M) standard, 7.5 IRE black","NTSC (M) standard, 0 IRE black (Japan)",
                "NTSC-433","PAL -B standard","PAL (D) standard","PAL (H) standard","PAL (I) standard",
                "PAL (M) standard","PAL (N) standard","PAL-60 standard","SECAM (B) standard","SECAM (D) standard",
                "SECAM (G) standard","SECAM (H) standard","SECAM (K) standard","SECAM (K1) standard",
                "SECAM (L) standard","SECAM (L1) standard","Combination (N) PAL standard (Argentina) "});
            this.videoStandardComboBox.SelectedIndex = 0;

            this.changeButton.Enabled = false;

          
            for (short i = 0; i < axVideoCap1.GetVideoInputCount(); i++)
            {
                this.videoInputComboBox.Items.Add(axVideoCap1.GetVideoInputName(i));
            }
            if (this.videoInputComboBox.Items.Count > 0)
            {
                this.videoInputComboBox.SelectedIndex = 0;
            }


            for (short i = 0; i < axVideoCap1.GetDeviceCount(); i++)
            {
                this.deviceComboBox.Items.Add(axVideoCap1.GetDeviceName(i));
            }

            if (this.deviceComboBox.Items.Count > 0)
            {
                this.deviceComboBox.SelectedIndex = 0;
            }

            for (short i = 0; i < axVideoCap1.GetVideoFormatCount(); i++)
            {
                this.videoFormatComboBox.Items.Add(axVideoCap1.GetVideoFormatName(i));
            }
            if (this.videoFormatComboBox.Items.Count > 0)
            {
                this.videoFormatComboBox.SelectedIndex = 0;
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.listBox1.Text))
            {
                this.axVideoCap1.Channel = Convert.ToInt16(this.listBox1.Text);
            }
        }
    }
}