using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.lastname = "";
            t.Execute();

            Man m = new Man();
           // m.name = "Miguel";
            m.Metod();

            Human h = new Human();
            h.age = 18;
        }
    }
}
