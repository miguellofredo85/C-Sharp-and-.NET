using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://"+textBox1.Text);
            tabPage1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://" + textBox2.Text);
            tabPage2.Text = textBox2.Text;

        }
    }
}
