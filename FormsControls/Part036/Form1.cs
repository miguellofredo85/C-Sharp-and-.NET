using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part036
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() != DialogResult.Cancel)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string txt = richTextBox1.Text;
            Font letter = new Font("Arial", 20, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Black);
            e.Graphics.DrawString(txt,letter,brush, new Point(20,20));
        }
    }
}
