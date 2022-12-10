using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Manipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // working with method from Directory move, drives, gets, parents
            //"C:\Users\Cangel\Desktop\C-Sharp"
            string path = @"C:\Users\Cangel\Desktop\C-Sharp\Practice";
            bool res = Directory.Exists(@"C:\Users\Cangel\Desktop\C-Sharp\Practice");

            var father = Directory.GetParent(path);
            listBox1.Items.Add(father);
            listBox1.Items.Add(res);

            //if (res == false)
            //{
            //    Directory.CreateDirectory(@"C:\Users\Cangel\Desktop\C-Sharp\Practice");
            //}
            //if (res) { Directory.Delete(@"C:\Users\Cangel\Desktop\C-Sharp\Practice"); }
        }
    }
}
