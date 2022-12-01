using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Miguel Window";
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            label1.Text = "Miguel Lofredo";
        }

        private void Execute_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Mouse enter click";
        }

        private void Execute_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Mouse leave click";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Execute.Size = new Size(200, 50);
        }
    }
}
