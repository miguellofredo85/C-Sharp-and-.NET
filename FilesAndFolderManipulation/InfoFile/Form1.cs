using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            FileInfo fileInfo = new FileInfo(@"C:\Users\Cangel\Desktop\C-Sharp\proba.txt");
            listBox1.Items.Add(fileInfo.FullName);
            listBox1.Items.Add(fileInfo.Name);
            listBox1.Items.Add(fileInfo.DirectoryName);
            listBox1.Items.Add(fileInfo.Directory.FullName);
            listBox1.Items.Add(fileInfo.CreationTime);
            listBox1.Items.Add(fileInfo.Exists);

            // and so on...
        }
    }
}
