using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringsManipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExecut_Click(object sender, EventArgs e)
        {
            string text = "This var type is alphanumeric";
            string name = "Miguel Angel Lofredo";
            #region
            /*if (text.Contains("var"))
            {
                label1.Text = "Got it";
            }
            else { 
                label1.Text = "Not contain";
            }
            int num = 500;
            bool res = false;

            label1.Text = num.ToString();
            label1.Text = res.ToString();*/
            #endregion
            //label1.Text = name.ToUpper();

            char[] space = {' '}; // can add more types of separator like {" ", "-"}
            string[] newText = text.Split(space);
            label1.Text = "";
            foreach (string s in newText)
            {
                label1.Text += s + "\n";
            }
        
        
        
        
        }
    }
}
