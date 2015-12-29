using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iResult;
            this.axVideoCap1.StopIPCamera();
            this.axVideoCap1.CaptureMode = false;
           
           iResult= this.axVideoCap1.StartIPCamera(this.textBox1.Text,this.txtUserID.Text,this.txtPass.Text);

           if (iResult != 1)
           {
               if (iResult == -8)
                   MessageBox.Show("The URL is empty");
               if (iResult == -7)
                   MessageBox.Show("Video Compressor cannot use, please select another one");
               if (iResult == -6)
                   MessageBox.Show("Capture Filename empty");
               if (iResult == -5)
                   MessageBox.Show("General network error");
               if (iResult == -4)
                   MessageBox.Show("Authentication failure");
               if (iResult == -3)
                   MessageBox.Show("Invalid Stream, not support this stream format");
               if (iResult == -2)
                   MessageBox.Show("Filter failure");
               if (iResult == -1)
                   MessageBox.Show("Create Graph failure");
           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.StopIPCamera();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
             this.saveFileDialog1.Filter = "JPEG File (*.jpg)|*.jpg";
             if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                 axVideoCap1.SnapShotJPEG(this.saveFileDialog1.FileName, 90);


        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}