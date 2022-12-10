using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WriteTxtFiles
{
    public partial class Form1 : Form
    {
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Focus();
            string path = @"C:\Users\Cangel\Desktop\C-Sharp\text.txt";
            StreamWriter writer = new StreamWriter(path, true, Encoding.Default);

            string line = textBox1.Text;
            writer.WriteLine(line); // method Write re write all txt.
            writer.Flush(); // clean buffer
            writer.Dispose();
            writer.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            string path = @"C:\Users\Cangel\Desktop\C-Sharp\text.txt";
            StreamReader reader = new StreamReader(path, Encoding.Default);
            //string txt = reader.ReadToEnd();
            string txt = reader.ReadLine();
            txt += reader.ReadLine();
            txt += reader.ReadLine();

            textBox1.Text = txt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Cangel\Desktop\C-Sharp\text.txt";
            FileStream file = File.OpenRead(path);
            BinaryReader binaryReader = new BinaryReader(file);

            //while (binaryReader.BaseStream.Length != binaryReader.BaseStream.Length)
            //{
            //    byte b = binaryReader.ReadByte();
            //    textBox1.Text += (char)b;
            //}

            buffer = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);

            binaryReader.Close();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Cangel\Desktop\C-Sharp\text.txt";
            FileStream file = File.OpenWrite(path);
            BinaryWriter witer = new BinaryWriter(file);

            witer.Write(buffer);

            witer.Flush();
            witer.Dispose();
            witer.Close();
        }
    }
}
