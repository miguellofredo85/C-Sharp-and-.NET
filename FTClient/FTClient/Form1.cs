using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace FTClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FTClient.LabelMessage = labelStat;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Send File";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                linkLabel1.Text = dialog.FileName;
            }
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || 
                string.IsNullOrEmpty(numericUpDown1.Value.ToString()) ||
                linkLabel1.Text == "Select file...")
            {
                labelStat.ForeColor= Color.Red;
                labelStat.Text = "Invalid Data";
                return;
            }

            string addressIP = textBox1.Text.Trim();
            int port = (int)numericUpDown1.Value;
            string fileName = linkLabel1.Text;

            FTClient.IPaddress = addressIP;
            FTClient.HostPort= port;

            try
            {
                Task.Factory.StartNew(() => {
                    FTClient.SendFile(fileName);
                });
            }
            catch (Exception ex)
            {
                labelStat.ForeColor = Color.Red;
                labelStat.Text = "Error: \n"+ex.Message;
            }
        }
    }
}
