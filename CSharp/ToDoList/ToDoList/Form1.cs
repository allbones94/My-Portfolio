using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string itemAdd = txtAdd.Text;

            if (itemAdd != "")
            {
                lstboxTODO.Items.Add(itemAdd);
            }

            txtAdd.Text = "";
        }
    }
}
