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

         
            for (short i = 0; i < axVideoCap1.GetAudioInputPinCount() - 1;i++)
            {
                this.audioInputComboBox.Items.Add(axVideoCap1.GetAudioInputPinName(i));


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

          
            for (short i = 0; i < axVideoCap1.GetVideoInputCount(); i++ )
            {
                this.videoInputComboBox.Items.Add(axVideoCap1.GetVideoInputName(i));
            }
            if (this.videoInputComboBox.Items.Count > 0)
            {
                this.videoInputComboBox.SelectedIndex = 0;
            }

            for (short i = 0; i < axVideoCap1.GetVideoFormatCount(); i++ )
            {
                this.videoFormatComboBox.Items.Add(axVideoCap1.GetVideoFormatName(i));
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

       
       

        private void useAudioCapCheckBox_Click(object sender, EventArgs e)
        {
            this.audioCompressorComboBox.Enabled = this.useAudioCapCheckBox.Checked;
            this.axVideoCap1.UseAudioCompressor = this.useAudioCapCheckBox.Checked;
        }

        private void useVideoCapCheckBox_Click(object sender, EventArgs e)
        {
            this.videoCompressorComboBox.Enabled = this.useVideoCapCheckBox.Checked;
            this.axVideoCap1.UseVideoCompressor = this.useVideoCapCheckBox.Checked;
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
            this.axVideoCap1.Start();

          
        }

        private void ControlCap()
        {
            this.axVideoCap1.Device = (short)this.deviceComboBox.SelectedIndex;

            this.axVideoCap1.VideoInput = (short)this.videoInputComboBox.SelectedIndex;

            this.axVideoCap1.VideoFormat = (short)this.videoFormatComboBox.SelectedIndex;

            this.axVideoCap1.AudioDevice = (short)this.audioDeviceComboBox.SelectedIndex;

            this.axVideoCap1.AudioInputPin = (short)this.audioInputComboBox.SelectedIndex;

            this.axVideoCap1.VideoCompressor = (short)this.videoCompressorComboBox.SelectedIndex;

            this.axVideoCap1.AudioCompressor = (short)this.audioCompressorComboBox.SelectedIndex;

        }

       
        private void captureButton_Click(object sender, EventArgs e)
        {
            this.ControlCap();
            this.saveFileDialog1.Filter = "Avi File (*.avi)|*.avi";
            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.axVideoCap1.CaptureVideo = this.captureVideoCheckBox.Checked;
                this.axVideoCap1.CaptureAudio = this.captureAudioCheckBox.Checked;

                this.axVideoCap1.ShowPreview = this.showPreviewCheckBox.Checked;
                this.axVideoCap1.UseVideoCompressor = this.useVideoCapCheckBox.Checked;
                this.axVideoCap1.UseAudioCompressor = this.useAudioCapCheckBox.Checked;

                this.axVideoCap1.CaptureMode = true;
                this.axVideoCap1.CaptureFileName = this.saveFileDialog1.FileName;

             
                this.axVideoCap1.SyncMode = 1;

                short result = this.axVideoCap1.Start();
               
                switch (result)
                {
                    case -1:
                        MessageBox.Show("Capture Failure,Video, Audio Compressor not correct or capture file opening");
                        return;
                    case -2:
                        MessageBox.Show("Capture file not found");
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

            short videoCompressorIndex = (short)this.videoCompressorComboBox.SelectedIndex;

            bool result = this.axVideoCap1.VideoCompressors.ShowPropertyPage(videoCompressorIndex);
            if (!result)
            {
                MessageBox.Show("No property page");
            }
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
            this.axVideoCap1.TVMute = true;
            
         


            for (short i = 0; i < axVideoCap1.GetAudioInputPinCount() ; i ++ )
            {
                audioInputComboBox.Items.Add(axVideoCap1.GetAudioInputPinName(i));
            }
            if (this.audioInputComboBox.Items.Count > 0)
            {
                this.audioInputComboBox.SelectedIndex = 0;
            }
            
          
            for (short i = 0; i < axVideoCap1.GetDeviceCount() ; i++ )
            {
                deviceComboBox.Items.Add(axVideoCap1.GetDeviceName(i));
            }
            if (this.deviceComboBox.Items.Count > 0)
            {
                this.deviceComboBox.SelectedIndex = 0;
            }

            for (short i = 0; i < axVideoCap1.GetVideoInputCount() ; i++)
            {
                this.videoInputComboBox.Items.Add(axVideoCap1.GetVideoInputName(i));
            }

            if (this.videoInputComboBox.Items.Count > 0)
            {
                this.videoInputComboBox.SelectedIndex = 0;
            }


            for (short i = 0; i < axVideoCap1.GetVideoFormatCount(); i++)
            {
                this.videoFormatComboBox.Items.Add(axVideoCap1.GetVideoFormatName(i));
            }
            if (this.videoFormatComboBox.Items.Count > 0)
            {
                this.videoFormatComboBox.SelectedIndex = 0;
            }


            for (short i = 0; i < axVideoCap1.GetAudioDeviceCount(); i++)
            {
                this.audioDeviceComboBox.Items.Add(axVideoCap1.GetAudioDeviceName(i));
            }
            if (this.audioDeviceComboBox.Items.Count > 0)
            {
                this.audioDeviceComboBox.SelectedIndex = 0;
            }

            int icount = 0;

            for (short i = 0; i < axVideoCap1.GetAudioCompressorCount(); i++)
            {
                this.audioCompressorComboBox.Items.Add(axVideoCap1.GetAudioCompressorName(i));
                if (audioCompressorComboBox.SelectedText == "PCM")
                    this.audioCompressorComboBox.SelectedIndex = icount;

                icount++;
            }

            for (short i = 0; i < this.axVideoCap1.GetVideoCompressorCount(); i++)
            {
                string strVideoComp=this.axVideoCap1.GetVideoCompressorName(i);
                this.videoCompressorComboBox.Items.Add(strVideoComp);

                if (strVideoComp.Substring(0, 4) == "DivX")
                    this.videoCompressorComboBox.SelectedIndex = i;
                else if (strVideoComp.Trim() == "Microsoft Video 1")
                    this.videoCompressorComboBox.SelectedIndex = i;
            
            }

        }

        private void useAudioCapCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}