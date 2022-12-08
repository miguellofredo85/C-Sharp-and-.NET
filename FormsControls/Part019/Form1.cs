using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MountTree();
            
        }
        private void MountTree()
        {
            treeView1.BeginUpdate();

            treeView1.Nodes.Add("Miguel");
            treeView1.Nodes[0].Nodes.Add("is");
            treeView1.Nodes[0].Nodes[0].Nodes.Add("the");
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("best");
            treeView1.Nodes.Add("Yes!");


            treeView1.EndUpdate();
        }
    }
}
