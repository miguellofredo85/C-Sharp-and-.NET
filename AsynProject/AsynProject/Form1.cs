using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynProject
{
    public partial class Form1 : Form
    {
        public static ListBox lstBox;


        public Form1()
        {
            InitializeComponent();
            lstBox = listBox1;
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Adding event: click here");
            Exemplo obj = new Exemplo();
            obj.Task_LongTime();
            listBox1.Items.Add("Button event done");
        }

        private async void btnExecAsync_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Adding event: click here");

            ExemploAsync obj = new ExemploAsync();
            await obj.Task_LongTime();

            listBox1.Items.Add("Button event conclude");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
