using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("The message", "Ttile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           //  MessageBox.Show("The message", "Ttile", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Random r = new Random();
            ////int rand = r.Next() / 100000000;
            ////Random r = new Random(DateTime.Now.Millisecond);
            ////int rand = r.Next(100);
            //double rand = r.Next(200);
            //label1.Text = "The number is " + rand;
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            // label1.Text = TimeSpan.FromMinutes(10).ToString();
            // label1.Text = TimeSpan.FromDays(9.10).ToString();
            // label1.Text = TimeSpan.FromTicks(100).ToString();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString();
            //label1.Text = DateTime.Today.ToString();
            //label1.Text = DateTime.DaysInMonth(2020,03).ToString(); // days in a month
            //label1.Text = DateTime.IsLeapYear(3050).ToString(); // bisiesto year true or false
            //label1.Text = DateTime.Now.ToShortDateString();
            //label1.Text = DateTime.Now.ToLongDateString();
            //label1.Text = DateTime.Now.ToShortTimeString(); // just hours
            // label1.Text = DateTime.Now.ToShortTimeString();
            //label1.Text = DateTime.Now.ToString("yy-MM-dd HH:mm:ss"); // Formating date time 

            //DateTime dateTime = new DateTime(1985, 03, 20, 14, 50, 00);
            //label1.Text = dateTime.AddYears(2).ToString(); // 1987
            //label1.Text = dateTime.ToString();
            //TimeSpan time = new TimeSpan(23, 6, 32, 12);
            //label1.Text = time.ToString();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            //Color color1 = Color.FromArgb(170, Color.DarkSlateBlue); // 170 is for transparency
            Color color1 = Color.FromArgb(230, 120, 111); // transparency and RGB colors combination
            Color color = Color.Azure;
            label1.BackColor= color;
            // play with method fromknowncolor, fromname,
            //label1.ForeColor= Color.Chocolate; // Font color
            label1.ForeColor = color1;

            Color buttonColorText = label1.ForeColor;
            Color buttonColorBack = label1.BackColor;
            btnColor.ForeColor= buttonColorText;
            btnColor.BackColor= buttonColorBack; 
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            //Font letter = new Font("Arial, sans-serif", 32, FontStyle.Bold, GraphicsUnit.Point);
            //Font letter = new Font("Comic Sans MS", 32, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Pixel);
            Font letter = new Font(FontFamily.GenericMonospace, 32, FontStyle.Bold, GraphicsUnit.Point);

            label1.Text = "Welcome to the amazing C#  world's";
            label1.Font = letter;

        }

        private void btnEnv_Click(object sender, EventArgs e)
        {
            // Enviroment is related to the system itself.

            //label1.Text = Environment.GetEnvironmentVariable("PATH");
            //label1.Text = Environment.GetFolderPath(Environment.SpecialFolder.System); 
            //label1.Text = Environment.CurrentDirectory;
            //string[] drives= Environment.GetLogicalDrives();

            //foreach (string drive in drives)
            //{
            //    label1.Text = drive;
            //}
            //string user = Environment.UserName;
            int cpu = Environment.ProcessorCount;
            
            label1.Text = cpu.ToString();
        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            //Application.Exit(); // exit program
            string pathexec = Application.ExecutablePath;
            string folder = Application.StartupPath;
            //Application.Restart();
            label1.Text= folder;
        }
    }
}
















