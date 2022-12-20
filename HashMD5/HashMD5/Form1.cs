using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; // Import for crypt

namespace HashMD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            CryptoMD5 md5 = new CryptoMD5();
            txtOut.Text = md5.MD5Return(txtIn.Text);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string passDB = "E10ADC3949BA59ABBE56E057F20F883E"; // 123456
            string pass = txtIn.Text;

            CryptoMD5 crypto = new CryptoMD5();
            bool res = crypto.CompareMD5(pass, passDB);

            if (res)
            {
                labelResult.Text = "Iquals";
            }
            else
            {
                labelResult.Text = "Not iquals";
            }
        }
    }
}
