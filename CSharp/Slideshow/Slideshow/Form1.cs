using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slideshow
{
    public partial class Form1 : Form
    {
        string[] images = {"lion.jpg","elephant.jpg","hippo.jpg"};
        
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
            int imageArraySize = images.Length - 1;
            getImage(imageArraySize);
        }

       
        private void btnNext_Click(object sender, EventArgs e)
        {
            int imageArraySize = images.Length - 1;
            counter++;
            getImage(imageArraySize);
        }

        private void getImage(int size)
        {
            
         
            slideshow.Image = new Bitmap(images[counter]);
            if (counter == size)
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = true;
            }
            else if (counter == 0)
            {
                btnNext.Enabled = true;
                btnPrev.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
                btnPrev.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int imageArraySize = images.Length - 1;
            counter--;
            getImage(imageArraySize);
        }
    }
}
