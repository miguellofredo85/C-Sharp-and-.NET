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

namespace InfoDir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Focus();
            DirectoryInfo info = new DirectoryInfo(@"C:\Users\Cangel\Desktop\C-Sharp\Practice");
            listBox1.Items.Add(info.Attributes);
            listBox1.Items.Add(info.Name);
            listBox1.Items.Add(info.Parent);
            listBox1.Items.Add(info.);

            //delete, creation, wrietime, access, gets, etc...
        }
    }
}
