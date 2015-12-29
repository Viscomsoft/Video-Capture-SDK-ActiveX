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

        private void Form1_Load(object sender, EventArgs e)
        {
           
            for (short i = 0; i < axVideoCap1.GetVideoInputCount(); i++ )
            {
                this.videoInputComboBox.Items.Add(axVideoCap1.GetVideoInputName(i));
            }
            if (this.videoInputComboBox.Items.Count > 0)
            {
                this.videoInputComboBox.SelectedIndex = 0;
            }

            this.FillVideoFormat();
            if (this.videoFormatComboBox.Items.Count > 0)
            {
                this.videoFormatComboBox.SelectedIndex = 0;
            }
            
        }

        private void FillVideoFormat()
        {
           
            for (short i = 0; i < axVideoCap1.GetVideoFormatCount(); i ++ )
            {
                this.videoFormatComboBox.Items.Add(axVideoCap1.GetVideoFormatName(i));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Start();
        }

        private void Start()
        {
            this.axVideoCap1.VideoInput = (short)this.videoInputComboBox.SelectedIndex;
            this.axVideoCap1.VideoFormat = (short)this.videoFormatComboBox.SelectedIndex;
            this.axVideoCap1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strFileName = Application.StartupPath + "\\test.bmp";
            this.axVideoCap1.SnapShot(strFileName);   // to save 
            this.pictureBox1.Load(strFileName);         // to load
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = this.axVideoCap1.SnapShot2Picture();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IntPtr hb=new IntPtr(this.axVideoCap1.SnapShot2HBITMAP());
             this.pictureBox1.Image = Bitmap.FromHbitmap(hb);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.SnapShotJPEG("c:\\test.jpg", 90);
            MessageBox.Show("save to c:\\test.jpg");
        }

        private void videoFormatComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void videoFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}