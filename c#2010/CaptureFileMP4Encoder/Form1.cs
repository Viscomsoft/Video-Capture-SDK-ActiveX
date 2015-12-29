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

        public uint Color2Uint32(Color clr)
        {

            int t;
            byte[] a;

            t = ColorTranslator.ToOle(clr);
            
            a = BitConverter.GetBytes(t);

            return BitConverter.ToUInt32(a, 0);

        }

        private void audioDeviceComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.audioInputComboBox.Items.Clear();
            this.axVideoCap1.RefreshAudioInputPin((short)this.audioDeviceComboBox.SelectedIndex);

            foreach (AudioInputPin myAudioInput in this.axVideoCap1.AudioInputPins)
            {
                this.audioInputComboBox.Items.Add(myAudioInput.Name);
            }

            if (this.audioInputComboBox.Items.Count > 0)
            {
                this.audioInputComboBox.SelectedIndex = 0;
            }
        }

       

        private void deviceComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.videoInputComboBox.Items.Clear();
            this.videoFormatComboBox.Items.Clear();

            this.axVideoCap1.RefreshVideoDevice((short)this.deviceComboBox.SelectedIndex); ;


            for (int i = 0; i < (int)axVideoCap1.GetVideoInputCount(); i++)
            {
                this.videoInputComboBox.Items.Add(axVideoCap1.GetVideoInputName((short)i));
            }
            if (this.videoInputComboBox.Items.Count > 0)
            {
                this.videoInputComboBox.SelectedIndex = 0;
            }
            for (int i = 0; i < (int)axVideoCap1.GetVideoFormatCount(); i++)
            {
                this.videoFormatComboBox.Items.Add(axVideoCap1.GetVideoFormatName((short)i));
            }
            if (this.videoFormatComboBox.Items.Count > 0)
            {
                this.videoFormatComboBox.SelectedIndex = 0;
            }
        }

   

       
        private void aspectRatioCheckBox_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.AspectRatio = this.aspectRatioCheckBox.Checked;
        }

     

      
      


        private void tVMuteCheckBox_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.TVMute = this.tVMuteCheckBox.Checked;
        }

        private void useAudioCapCheckBox_Click(object sender, EventArgs e)
        {
         
        }

        private void useVideoCapCheckBox_Click(object sender, EventArgs e)
        {
        
        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            this.colorDialog1.Color = this.axVideoCap1.BackgroundColor;
            if (this.colorDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.axVideoCap1.BackgroundColor = this.colorDialog1.Color;
            }
        }

   
       

        private void previewButton_Click(object sender, EventArgs e)
        {
            this.ControlCap();
            this.axVideoCap1.SyncMode = 1;

            this.axVideoCap1.CaptureMode = false;
            this.axVideoCap1.Start();

          
        }

        private void ControlCap()
        {
            this.axVideoCap1.Device = (short)this.deviceComboBox.SelectedIndex;

            this.axVideoCap1.VideoInput = (short)this.videoInputComboBox.SelectedIndex;

            this.axVideoCap1.VideoFormat = (short)this.videoFormatComboBox.SelectedIndex;

            this.axVideoCap1.AudioDevice = (short)this.audioDeviceComboBox.SelectedIndex;

            this.axVideoCap1.AudioInputPin = (short)this.audioInputComboBox.SelectedIndex;

      
        }

      
      
        private void captureButton_Click(object sender, EventArgs e)
        {
            this.ControlCap();
            this.saveFileDialog1.Filter = "MP4 File (*.mp4)|*.mp4";
            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {

                axVideoCap1.UseMp4EncoderPlugin = true;
                axVideoCap1.Mp4Videobitrate = Convert.ToInt32(txtmp4videobitrate.Text);
                axVideoCap1.Mp4Audiobitrate = Convert.ToInt32(txtmp4audiobitrate.Text);
                axVideoCap1.Mp4AudioSamplerate = Convert.ToInt32(cboaudiosamplerate.Text);
                axVideoCap1.Mp4Audiochannel = (short)Convert.ToInt32(txtaudiochannels.Text);
                axVideoCap1.Mp4Width = (short)Convert.ToInt32(txtmp4width.Text);
                axVideoCap1.Mp4Height = (short)Convert.ToInt32(txtmp4height.Text);

               


                this.axVideoCap1.CaptureVideo = this.captureVideoCheckBox.Checked;
                this.axVideoCap1.CaptureAudio = this.captureAudioCheckBox.Checked;

                this.axVideoCap1.ShowPreview = this.showPreviewCheckBox.Checked;
             
                this.axVideoCap1.CaptureMode = true;
                this.axVideoCap1.CaptureFileName = this.saveFileDialog1.FileName;

                this.axVideoCap1.SyncMode = 1;
                short result = this.axVideoCap1.Start();

            
                switch (result)
                {
                    case -1:
                        MessageBox.Show("Capture Failure");
                        return;
                    case -2:
                        MessageBox.Show("Capture file not found");
                        return;

                    case -3:
                        MessageBox.Show("MP4 Plugin supported on Windows 7 or Windows 8 above only");
                        return;
                }

                this.previewButton.Enabled = false;
                this.captureButton.Enabled = false;
                this.stopButton.Enabled = true;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.ShowPreview = true;
            this.axVideoCap1.CaptureMode = false;
            this.axVideoCap1.Stop();

            this.axVideoCap1.Start();

            this.previewButton.Enabled = true;
            this.captureButton.Enabled = true;
            this.stopButton.Enabled = false;

        }

     

        private void videoCompressorButton_Click(object sender, EventArgs e)
        {

            
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.Pause();
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.Resume();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            string strApp;
            int iFindIndex;

        
       
            cboaudiosamplerate.Items.Add("48000");
            cboaudiosamplerate.Items.Add("44100");
            cboaudiosamplerate.SelectedIndex = 0;

           

            this.axVideoCap1.TVMute = true;
            
        


          

            for (int i = 0; i < (int)axVideoCap1.GetAudioInputPinCount() ; i++ )
                this.audioInputComboBox.Items.Add(axVideoCap1.GetAudioInputPinName((short)i));
          
            if (this.audioInputComboBox.Items.Count > 0)
            {
                this.audioInputComboBox.SelectedIndex = 0;
            }

            for (int i = 0; i < (int)axVideoCap1.GetDeviceCount();i++ )
                {
                    this.deviceComboBox.Items.Add(axVideoCap1.GetDeviceName((short)i));
                }
            if (this.deviceComboBox.Items.Count > 0)
            {
                this.deviceComboBox.SelectedIndex = 0;
            }


            for (int i = 0; i < (int)axVideoCap1.GetVideoInputCount();i++ )
                {
                    this.videoInputComboBox.Items.Add(axVideoCap1.GetVideoInputName((short)i));
                }
            if (this.videoInputComboBox.Items.Count > 0)
            {
                this.videoInputComboBox.SelectedIndex = 0;
            }

            for (int i = 0; i < (int)axVideoCap1.GetVideoFormatCount();i++ )
                {
                    this.videoFormatComboBox.Items.Add(axVideoCap1.GetVideoFormatName((short)i));
                }
            if (this.videoFormatComboBox.Items.Count > 0)
            {
                this.videoFormatComboBox.SelectedIndex = 0;
            }

            for (int i = 0; i < (int)axVideoCap1.GetAudioDeviceCount();i++ )
            {
                this.audioDeviceComboBox.Items.Add(axVideoCap1.GetAudioDeviceName((short)i));
            }

            if (this.audioDeviceComboBox.Items.Count > 0)
            {
                this.audioDeviceComboBox.SelectedIndex = 0;
            }

           
        }

        private void dateFontNameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
        }

        private void useAudioCapCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void showImageCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void alphaChannelTrackBar_Scroll(object sender, EventArgs e)
        {
          
        }

        private void deviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void useVideoCapCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}