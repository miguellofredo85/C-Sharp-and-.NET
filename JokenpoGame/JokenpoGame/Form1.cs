using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokenpoGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void StartGame(int option)
        {
            labelResult.Visible= false;
            Game play = new Game();

            switch(play.Play(option))
            {
                case Game.Result.Win:
                    picResult.BackgroundImage = Image.FromFile("imagens/Ganhar.png");
                    goto default; 
                case Game.Result.Lost:
                    picResult.BackgroundImage = Image.FromFile("imagens/Perder.png");
                    goto default;
                case Game.Result.Draw:
                    picResult.BackgroundImage = Image.FromFile("imagens/Empatar.png");
                    goto default;
                default:
                    pictureBox1.Image = play.ImgPlayer;
                    pictureBox2.Image = play.ImgPc;
                    break;
            }
        }
    }
}
























