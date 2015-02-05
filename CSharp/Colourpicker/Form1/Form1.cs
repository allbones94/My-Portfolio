using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {

        int red;
        int green;
        int blue;

        public Form1()
        {
            InitializeComponent();
        }

       

        private void btn_HelloWorld_Click(object sender, EventArgs e)
        {
            btn_HelloWorld.Text = "Hello World";
        }

        private void tb_red_Scroll(object sender, EventArgs e)
        {
            red = tb_red.Value;
            green = tb_green.Value;
            blue = tb_blue.Value;

            this.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }

        private void tb_green_Scroll(object sender, EventArgs e)
        {
            red = tb_red.Value;
            green = tb_green.Value;
            blue = tb_blue.Value;

            this.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }

        private void tb_blue_Scroll(object sender, EventArgs e)
        {
            red = tb_red.Value;
            green = tb_green.Value;
            blue = tb_blue.Value;

            this.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }
    }
}
