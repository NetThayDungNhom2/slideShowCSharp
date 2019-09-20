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

        private int imageNumber = 1, img1, img2, img3, img4, img5, img6, img7;

        private void LoadNextImage()
        {
            if(imageNumber==10)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);

            if (imageNumber == 1) img1 = 8;
            else if (imageNumber == 2) img1 = 9;
            else if (imageNumber == 3) img1 = 10;
            else img1 = imageNumber - 3;
            pictureBox1.ImageLocation = string.Format(@"Images\{0}.jpg", img1);

            if (imageNumber == 1) img2 = 9;
            else if (imageNumber == 2) img2 = 10;
            else img2 = imageNumber - 2;
            pictureBox2.ImageLocation = string.Format(@"Images\{0}.jpg", img2);

            if (imageNumber == 1) img3 = 10;
            else img3 = imageNumber - 1;
            pictureBox3.ImageLocation = string.Format(@"Images\{0}.jpg", img3);

            img4 = imageNumber;
            pictureBox4.ImageLocation = string.Format(@"Images\{0}.jpg", img4);

            if (imageNumber == 10) img5 = 1;
            else img5 = imageNumber + 1;
            pictureBox5.ImageLocation = string.Format(@"Images\{0}.jpg", img5);

            if (imageNumber == 10) img6 = 2;
            else if (imageNumber == 9) img6 = 1;
            else img6 = imageNumber + 2;
            pictureBox6.ImageLocation = string.Format(@"Images\{0}.jpg", img6);

            if (imageNumber == 10) img7 = 3;
            else if (imageNumber == 9) img7 = 2;
            else if (imageNumber == 8) img7 = 1;
            else img7 = imageNumber + 3;
            pictureBox7.ImageLocation = string.Format(@"Images\{0}.jpg", img7);

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
            
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            imageNumber++;
            if (imageNumber == 11)
            {
                imageNumber = 1;
            }
            LoadNextImage();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            imageNumber--;
            if (imageNumber == 0)
            {
                imageNumber = 10;
            }
            LoadNextImage();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
       
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
  
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
     
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
