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
    public partial class FormSecond : Form
    {
        public string Message { get; set; }
        public FormSecond()
        {
            InitializeComponent();
        }
        public FormSecond(string message)
        {
            InitializeComponent();
            this.Message = message; 
        }

        private void FormSecond_Load(object sender, EventArgs e)
        {
            txtMessage.Text = Message;
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            Close();
            Thread t = new Thread(() => Application.Run(new FormMain()));   
            t.Start();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text == "" || txtMessage.Text == null) 
            {
                Message= null;
            }
            else
            {
                Message = txtMessage.Text;
            }
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Message= null;
            Close();    
        }
    }
}
