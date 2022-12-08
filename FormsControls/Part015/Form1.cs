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

namespace Part015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Task> tasks = new List<Task>();
            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(2000);
                progressBar1.Invoke(new Action(() => progressBar1.PerformStep()));
            })));
            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(3452);
                progressBar1.Invoke(new Action(() => progressBar1.PerformStep()));
            })));
            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(6546);
                progressBar1.Invoke(new Action(() => progressBar1.PerformStep()));
            })));
            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(345);
                progressBar1.Invoke(new Action(() => progressBar1.PerformStep()));
            })));
            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(1874);
                progressBar1.Invoke(new Action(() => progressBar1.PerformStep()));
            })));
            progressBar1.Maximum = tasks.Count;
            progressBar1.Step = 1;

            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i].Start();
            }
        }
    }
}
