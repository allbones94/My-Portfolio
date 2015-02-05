using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Moveable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            player.Left = 200;
        
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            player.Top += 100;
        }

       
    }
}
