using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenpoGame
{
    internal class Game
    {
        public enum Result
        { 
            Win, Lost , Draw
        }
        public static Image[] images = 
        {  
             Image.FromFile("imagens/Pedra.png"),
             Image.FromFile("imagens/Tesoura.png"),
             Image.FromFile("imagens/Papel.png")
        };
        public Image ImgPc { get; private set; }
        public Image ImgPlayer { get; private set; }

        public Result Play(int player)
        {
            int pc = PcPlayer();

            ImgPlayer = images[player];
            ImgPc= images[pc]; 

            if (pc == player)
            {
            return Result.Draw;
            }
            else if ((player == 0 && pc == 1) || (player == 1 && pc == 2) || (player == 2 && pc == 0)) 
            {
                return Result.Win;  
            }
            else
            {
                return Result.Lost;
            }

        }
        private int PcPlayer()
        {
            int mil = DateTime.Now.Millisecond;
            
            if (mil< 333)
            {
                return 0;
            }
            else if (mil >= 333 && mil < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}























