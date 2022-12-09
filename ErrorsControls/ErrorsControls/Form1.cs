using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorsControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = { 14, 22, 65, 66, 90, 87, 73, 46 };
                string result = string.Empty;
                for (int i = 0; i < numbers.Length; i++)
                {
                    result += numbers[i] + " ";
                }
                label1.Text = result;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
            finally
            {
                MessageBox.Show("Finally always execute!");
            }
        }
    }
}
