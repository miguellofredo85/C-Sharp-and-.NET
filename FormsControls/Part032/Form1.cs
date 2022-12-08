using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part032
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!bgW.IsBusy)
            {
                bgW.RunWorkerAsync();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bgW.WorkerSupportsCancellation)
            {
                bgW.CancelAsync();
            }
        }

        private void bgW_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0;i < 10; i++)
            {
                if (bgW.CancellationPending)
                {
                   e.Cancel = true;
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                    bgW.ReportProgress(i*10);
                }
            }
        }

        private void bgW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label1.Text = e.ProgressPercentage.ToString() + "%";
            progressBar1.Value = e.ProgressPercentage;
        }

        private void bgW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                label1.Text = "Cancel";
            }
            else if (e.Error != null)
            {
                label1.Text += e.Error.Message.ToString();
            }
            else
            {
                label1.Text = "100% Completed";
                progressBar1.Value = 100;
            }
        }
    }
}
