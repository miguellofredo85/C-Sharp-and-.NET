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

namespace FormInDeep
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide(); 
            FormSecond form = new FormSecond("Miguel is awesome!!!");
            //form.Message = "Miguel is awesome!!!";
            form.ShowDialog();
            
            if (form.Message != null)
            {
                label1.Text = form.Message;
            }

            Show();

        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new FormSecond()) );
            t.Start();
        }

        private void mFileNew_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new FormMain())).Start();
        }

        private void mFileOpen_Click(object sender, EventArgs e)
        {
            Hide();
            FormSecond f = new FormSecond();
            f.ShowDialog();
            Show();
        }

        private void mFileClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mDeveloper_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Miguel Lofredo");
        }

        private void mVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 7.6.2");
        }

        private void comboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMenu.SelectedIndex == 0)
            {
                menuFile.Text = "File";
                menuHelp.Text = "Help";

            }
            else if (comboMenu.SelectedIndex == 1)
            {
                menuFile.Text = "Arquivo";
                menuHelp.Text = "Ajuda";
            }
            else
            {
                menuFile.Text = "Archivo";
                menuHelp.Text = "Ayuda";
            }
        }

        private void mSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                label1.Text = mSearch.Text;
                mSearch.Text = "";

            }
        }
    }
}
