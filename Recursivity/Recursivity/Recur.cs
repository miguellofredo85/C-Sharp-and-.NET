using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivity
{
    internal class Recur
    {
        public void Recursiv(string message, int n)
        {
            if (n > 0)
            {   
                Console.WriteLine(message);
                Recursiv(message, n - 1);
            }
        }
    }
}
