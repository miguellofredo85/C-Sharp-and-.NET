using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatic
{
    partial class Pessoa   // partial let us use the class Pessoa from PersonAttributes (before called Pessoa), and re organized the code
    {
        public void Show()
        {
            Console.WriteLine($"Ola sou {name}");
        }
        public static int Date(int birthDate)
        {
            return DateTime.Now.Year - birthDate;
        }
    }
}
