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
       // bool toMemory = true; // 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            axVideoCap1.SampleBufferMode = 4;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            for (short i = 0; i < axVideoCap1.GetDeviceCount(); i ++ )
            {
                this.deviceComboBox.Items.Add(axVideoCap1.GetDeviceName(i));
            }
            if (this.deviceComboBox.Items.Count > 0)
            {
                this.deviceComboBox.SelectedIndex = 0;
            }

       
            for (short i = 0; i < axVideoCap1.GetVideoFormatCount(); i++  )
            {
                this.videoFormatComboBox.Items.Add(axVideoCap1.GetVideoFormatName(i));
            }
            if (this.videoFormatComboBox.Items.Count > 0)
            {
                this.videoFormatComboBox.SelectedIndex = 0;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.Device = (short)this.deviceComboBox.SelectedIndex;
            this.axVideoCap1.VideoFormat=(short)this.videoFormatComboBox.SelectedIndex;

            this.axVideoCap1.Start();
            groupBox1.Enabled = false;
            if (radioButton4.Checked)
                button1.Enabled = true;
            else
                button1.Enabled = false;

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.Stop();
            groupBox1.Enabled = true;
          //  toMemory = true;
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.SampleBufferMode = 4;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.SampleBufferMode = 5;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.SampleBufferMode = 2;
        }

        private void axVideoCap1_SampleBuffer(object sender, AxVIDEOCAPLib._DVideoCapEvents_SampleBufferEvent e)
        {
           // if (toMemory)
           // { 
                this.listBox1.Items.Add(e.iwidth.ToString() + "x" + e.iheight.ToString() + " resolution sample received");
                //toMemory = false;
          //  }
           

        }
        private void axVideoCap1_SampleBuffer2(object sender, AxVIDEOCAPLib._DVideoCapEvents_SampleBuffer2Event e)
        {
            this.listBox1.Items.Add(e.iwidth.ToString() + "x" + e.iheight.ToString() + " resolution sample received");
            if (axVideoCap1.SampleBufferMode == 4)
            {
                pictureBox1.Image =  axVideoCap1.SampleBuffer2Picture();
                axVideoCap1.DeleteSampleBufferPicture();
            }

            if (axVideoCap1.SampleBufferMode == 5)
            {
                IntPtr iBitmapHandle;
                iBitmapHandle = (IntPtr)axVideoCap1.SampleBuffer2HBITMAP();
                Image myImage = Image.FromHbitmap(iBitmapHandle);

                pictureBox1.Image = myImage;
                axVideoCap1.DeleteImageHandle((int)iBitmapHandle);
            }

           
        }
        


        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.axVideoCap1.SampleBufferMode = 3;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int width=0,height=0;
            if (radioButton4.Checked)
            {

                int[,] objArray = (int[,])this.axVideoCap1.GetSampleBufferRGB(ref width, ref height);

                Bitmap bm = new Bitmap(width, height);
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        Color clr = ColorTranslator.FromWin32((int)objArray[x, y]);
                        bm.SetPixel(x, y, clr);
                    }
                }
                pictureBox1.Image = (Image)bm;
            }

        }

        private void axVideoCap1_Capturing(object sender, AxVIDEOCAPLib._DVideoCapEvents_CapturingEvent e)
        {

        }

       

       
     

       
    }
}