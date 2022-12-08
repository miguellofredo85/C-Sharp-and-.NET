using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object words = textBox1.Text;
            listBox1.Items.Add(words);
            textBox1.Focus();
            textBox1.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            object item = listBox1.SelectedItem;
            listBox1.Items.Remove(item);
        }

        private void btnRemoveIn_Click(object sender, EventArgs e)
        {
            int item = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(item);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = listBox1.SelectedItem.ToString();
            textBox1.Text = name;
        }

        private void btnQtty_Click(object sender, EventArgs e)
        {
            int qttyitem = listBox1.Items.Count;
            MessageBox.Show("Total list items "+qttyitem);        }
    }
}
