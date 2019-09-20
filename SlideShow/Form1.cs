using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace SlideShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if(imageNumber==10)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void buttonRight_Click_1(object sender, EventArgs e)
        {
            imageNumber++;
            if (imageNumber == 11)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            imageNumber--;
            if (imageNumber == 0)
            {
                imageNumber = 10;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
        }
    }
}
