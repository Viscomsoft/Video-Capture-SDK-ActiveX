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
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.VideoInput = (short)this.videoInputComboBox.SelectedIndex;

            this.axVideoCap1.Start();
            this.proPageButton.Enabled = true;

            if (this.axVideoCap1.Brightness.Available)
            {
                this.brightnessTrackBar.Minimum = this.axVideoCap1.Brightness.Min;
                this.brightnessTrackBar.Maximum = this.axVideoCap1.Brightness.Max;
                this.brightnessTrackBar.Value = this.axVideoCap1.Brightness.Value;
            }
            else
            {
                this.brightnessTrackBar.Enabled = false;
            }



            if (this.axVideoCap1.Contrast.Available)
            {
                this.contrastTrackBar.Minimum = this.axVideoCap1.Contrast.Min;
                this.contrastTrackBar.Maximum = this.axVideoCap1.Contrast.Max;
                this.contrastTrackBar.Value = this.axVideoCap1.Contrast.Value;
            }
            else
            {
                this.contrastTrackBar.Enabled = false;
            }

            if (this.axVideoCap1.Hue.Available)
            {
                this.hueTrackBar.Minimum = this.axVideoCap1.Hue.Min;
                this.hueTrackBar.Maximum = this.axVideoCap1.Hue.Max;
                this.hueTrackBar.Value = this.axVideoCap1.Hue.Value;
            }
            else
            {
                this.hueTrackBar.Enabled = false;
            }

            if (this.axVideoCap1.Saturation.Available)
            {
                this.saturationTrackBar.Minimum = this.axVideoCap1.Saturation.Min;
                this.saturationTrackBar.Maximum = this.axVideoCap1.Saturation.Max;
                this.saturationTrackBar.Value = this.axVideoCap1.Saturation.Value;
            }
            else
            {
                this.saturationTrackBar.Enabled = false;
            }


            if (this.axVideoCap1.Sharpness.Available)
            {
                this.sharpnessTrackBar.Minimum = this.axVideoCap1.Sharpness.Min;
                this.sharpnessTrackBar.Maximum = this.axVideoCap1.Sharpness.Max;
                this.sharpnessTrackBar.Value = this.axVideoCap1.Sharpness.Value;
            }
            else
            {
                this.sharpnessTrackBar.Enabled = false;
            }


            if (this.axVideoCap1.Gamma.Available)
            {
                this.gammaTrackBar.Minimum = this.axVideoCap1.Gamma.Min;
                this.gammaTrackBar.Maximum = this.axVideoCap1.Gamma.Max;
                this.gammaTrackBar.Value = this.axVideoCap1.Gamma.Value;
            }
            else
            {
                this.gammaTrackBar.Enabled = false;
            }

            if (this.axVideoCap1.ColorEnable.Available)
            {
                this.colorEnableTrackBar.Minimum = this.axVideoCap1.ColorEnable.Min;
                this.colorEnableTrackBar.Maximum = this.axVideoCap1.ColorEnable.Max;
                this.colorEnableTrackBar.Value = this.axVideoCap1.ColorEnable.Value;
            }
            else
            {
                this.colorEnableTrackBar.Enabled = false;
            }

            if (this.axVideoCap1.WhiteBalance.Available)
            {
                this.whiteBalanceTrackBar.Minimum = this.axVideoCap1.WhiteBalance.Min;
                this.whiteBalanceTrackBar.Maximum = this.axVideoCap1.WhiteBalance.Max;
                this.whiteBalanceTrackBar.Value = this.axVideoCap1.WhiteBalance.Value;
            }
            else
            {
                this.whiteBalanceTrackBar.Enabled = false;
            }

            if (this.axVideoCap1.BacklightCompensation.Available)
            {
                this.backlightCompensationTrackBar.Minimum = this.axVideoCap1.BacklightCompensation.Min;
                this.backlightCompensationTrackBar.Maximum = this.axVideoCap1.BacklightCompensation.Max;
                this.backlightCompensationTrackBar.Value = this.axVideoCap1.BacklightCompensation.Value;
            }
            else
            {
                this.backlightCompensationTrackBar.Enabled = false;
            }


            if (this.axVideoCap1.Gain.Available)
            {
                this.gainTrackBar.Minimum = this.axVideoCap1.Gain.Min;
                this.gainTrackBar.Maximum = this.axVideoCap1.Gain.Max;
                this.gainTrackBar.Value = this.axVideoCap1.Gain.Value;
            }
            else
            {
                this.gainTrackBar.Enabled = false;
            }
        }

        private void proPageButton_Click(object sender, EventArgs e)
        {
            this.axVideoCap1.ShowVideoCapturePropertyPage(0);
        }

        private void brightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axVideoCap1.Brightness.Value = this.brightnessTrackBar.Value;
        }

        private void contrastTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axVideoCap1.Contrast.Value = this.contrastTrackBar.Value;
        }

        private void hueTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axVideoCap1.Hue.Value = this.hueTrackBar.Value;
        }

        private void saturationTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axVideoCap1.Saturation.Value = this.hueTrackBar.Value;
        }

        private void sharpnessTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axVideoCap1.Sharpness.Value = this.sharpnessTrackBar.Value;
        }

        private void gammaTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axVideoCap1.Gamma.Value = this.gainTrackBar.Value;
        }

        private void colorEnableTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axVideoCap1.ColorEnable.Value = this.colorEnableTrackBar.Value;
        }

        private void whiteBalanceTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axVideoCap1.WhiteBalance.Value = this.whiteBalanceTrackBar.Value;
        }

        private void backlightCompensationTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axVideoCap1.BacklightCompensation.Value = this.backlightCompensationTrackBar.Value;
        }

        private void gainTrackBar_Scroll(object sender, EventArgs e)
        {
            this.axVideoCap1.Gain.Value = this.gainTrackBar.Value;
        }


    }
}