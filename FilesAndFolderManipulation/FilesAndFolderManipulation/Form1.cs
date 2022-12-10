using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesAndFolderManipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string folder2 = @"C:\Users\Cangel\Desktop";
            string folder = @"C:\Users\Cangel\Desktop\C-Sharp\";
            string file = "proba.txt";

            //bool result = File.Exists(folder+file);
            // label1.Text = result.ToString();
            // File.Delete(folder + file);
            // File.Create(folder + file).Close(); // if file already exist will delete and create a new one

            //if (File.Exists(folder + file))
            //{
            //    File.Copy(folder+file, folder+"copyproba.txt");
            //}
            //else
            //{
            //    label1.Text = "Doesn exist";
            //}
            //File.Move(folder + file, folder2);
            File.WriteAllText(folder + file, "Writting just for fun!", Encoding.Default);    
            // label1.Text = File.ReadAllText(folder+file,Encoding.Default);
        
            label1.Text = File.GetCreationTime(folder+file).ToString();
        
        }
    }
}
