using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("images/microsoft.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("images/github.png");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("images/c-logo-icon-28402.png");
        }
    }
}
