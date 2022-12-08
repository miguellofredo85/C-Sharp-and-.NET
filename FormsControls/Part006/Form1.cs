using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.Items.Add("Monopatin", true);
            checkedListBox1.Items.Add("Titanic", false);

            int qtty = checkedListBox1.Items.Count;
            MessageBox.Show("Total items " + qtty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // checkedListBox1.Items.Clear();
            // checkedListBox1.Items.AddRange(new object[] { "Sarlangoso", "Pombadeiro", "Urlingatacambe" });
            // bool result = checkedListBox1.Items.Contains("Moto");
            // MessageBox.Show("Yes it's "+result);
            // checkedListBox1.Items.Remove("Moto");
            // checkedListBox1.Items.RemoveAt(0);
            // checkedListBox1.Items.Insert(5, "Horse");


            // var ch = checkedListBox1.CheckedItems;
            var ch = checkedListBox1.SelectedItems;
            foreach (object item in ch)
            {
                MessageBox.Show((string)item);
            }
        
        }
    }
}
