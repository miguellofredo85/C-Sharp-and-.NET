using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part027
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string txt = "";
        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txt = textBox1.Text;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt = textBox1.Text;
            textBox1.Text = "";
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt != null && txt != "")
            {
                textBox2.Text = txt;
            }
        }
    }
}
