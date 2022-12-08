using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show(checkBox1.Text +" "+ true);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                MessageBox.Show(checkBox2.Text +" "+ true);
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                MessageBox.Show(checkBox3.Text + " " + true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string check = "";

            if (checkBox1.Checked)
            {
                check+=checkBox1.Text+" - ";
            }
            if (checkBox2.Checked)
            {
                check += checkBox2.Text + " - ";
            }
            if (checkBox3.Checked)
            {
                MessageBox.Show(check += checkBox3.Text + " - ");
            }
            else
            {
                MessageBox.Show("Any");
            }
        }
    }
}
