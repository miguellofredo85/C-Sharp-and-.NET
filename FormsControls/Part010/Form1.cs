using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("Áddress");
            ListViewItem item1 = new ListViewItem("Gabriel");
            item1.SubItems.Add("7593127546");
            item1.SubItems.Add("gabriel1234@gmail.com");
            item1.SubItems.Add("Hotel California 5465");
            listView1.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("Joseph");
            item2.SubItems.Add("453847297");
            item2.SubItems.Add("joemarch@gmail.com");
            item2.SubItems.Add("Carolina West 324");
            listView1.Items.Add(item2);

            ListViewItem item3 = new ListViewItem("Lana");
            item3.SubItems.Add("2313400809");
            item3.SubItems.Add("lanarodes@gmail.com");
            item3.SubItems.Add("Sirlunganda 2345786");
            listView1.Items.Add(item3);

            ListViewItem item4 = new ListViewItem(new string[] {"Arthur", "6454565664", "asff@yahoo.com", "New Jersey 56"});
            listView1.Items.Add(item4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listView1.Items.Clear();
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
    }
}
