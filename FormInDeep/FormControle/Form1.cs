using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControle
{
    public partial class Form1 : Form
    {
        Label label1 = new Label();
        Button btn1 = new Button();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            label1.Location = new Point(200, 100);
            label1.Size = new Size(300, 100);
            label1.AutoSize= false;
            label1.BackColor= Color.White;
            label1.ForeColor= Color.Black;
            label1.Font = new Font("Arial", 20, FontStyle.Italic, GraphicsUnit.Point);
            label1.Text= "Coding my label one ";


            btn1.Location = new Point(40, 100);
            btn1.Size = new Size(110, 100);
            btn1.Font = new Font("Arial", 20, FontStyle.Italic, GraphicsUnit.Point);
            btn1.AutoSize= false;
            btn1.BackColor = Color.Gray;
            btn1.ForeColor = Color.Black;
            btn1.Text= "Click please";

            btn1.Click += btn1_Click;  // can do it cause btn1_Click is a delegate cause EventArgs e
            btn1.MouseHover += Btn1_MouseHover;

            this.Controls.Add(btn1);
            this.Controls.Add(label1);// adding label1
        }

        private void Btn1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Mouse on button";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label1.Text= "Thanks!";

        }
    }
}
