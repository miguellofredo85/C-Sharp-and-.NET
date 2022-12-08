using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                radioButton1.ForeColor= Color.Red;
                radioButton3.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Black;
            }
            else if (radioButton2.Checked)
            {
                radioButton2.ForeColor= Color.Blue;
                radioButton1.ForeColor = Color.Black;
                radioButton3.ForeColor = Color.Black;
            }
            else if (radioButton3.Checked)
            {
                radioButton3.ForeColor= Color.Green;
                radioButton2.ForeColor = Color.Black;
                radioButton1.ForeColor = Color.Black;
            }
        }
    }
}
