using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTransferServer
{
    public partial class Form1 : Form
    {
        Task work;
        public Form1()
        {
            InitializeComponent();
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            linkFile.Text = FTServer.SaveFolder;
            FTServer.ListMessages = listLogs; 
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            int port = (int)numericUpDown1.Value;
            string endIP = txtIP.Text;
            try
            {
                FTServer.Ip = endIP;
                FTServer.HostPort = port;
                work = Task.Factory.StartNew( () =>
                {
                    FTServer.ServerInit();
                });
            }
            catch (Exception ex)
            {
                listLogs.Invoke(new Action(() => {
                    listLogs.Items.Add("Error connection " + ex.Message);
                    listLogs.SetSelected(listLogs.Items.Count - 1, true);
                }));
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
            }
            catch (Exception ex)
            {
                listLogs.Invoke(new Action(() => {
                    listLogs.Items.Add("Error: " + ex.Message);
                    listLogs.SetSelected(listLogs.Items.Count - 1, true);
                }));
            }
        }

        private void linkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if(dialog.ShowDialog() != DialogResult.Cancel)
            {
                FTServer.SaveFolder = dialog.SelectedPath + @"\";
                linkFile.Text = FTServer.SaveFolder;
            }
        }
    }
}
