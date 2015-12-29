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

        

            for (short i = 0; i < axVideoCap1.GetAudioInputPinCount(); i++ )
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
           
        }

      
    

       
       

        private void aspectRatioCheckBox_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.AspectRatio = this.aspectRatioCheckBox.Checked;
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
            if (chkdualdisplay.Checked)
                this.axVideoCap1.UseDualDisplay = true;
            else
               this.axVideoCap1.UseDualDisplay = false;

            this.ControlCap();
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
            this.axVideoCap1.TVMute = true;



            for (short i = 0; i < axVideoCap1.GetAudioInputPinCount(); i ++ )
            {
                this.audioInputComboBox.Items.Add(axVideoCap1.GetAudioInputPinName(i));
            }
            if (this.audioInputComboBox.Items.Count > 0)
            {
                this.audioInputComboBox.SelectedIndex = 0;
            }
      
            for (short i = 0; i < axVideoCap1.GetDeviceCount(); i ++ )
            {
                this.deviceComboBox.Items.Add(axVideoCap1.GetDeviceName(i));
            }
            if (this.deviceComboBox.Items.Count > 0)
            {
                this.deviceComboBox.SelectedIndex = 0;
            }


            for (short i = 0; i < axVideoCap1.GetVideoInputCount(); i++ )
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

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.ShowDualScreen(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.ShowDualScreen(true);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     

       
    }
}