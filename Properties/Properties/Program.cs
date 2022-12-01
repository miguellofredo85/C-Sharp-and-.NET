using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Test t = new Test();
            t.Name = "Charles";
            t.Age= 38;

            Console.WriteLine($"{t.Name} {t.Lastname}"); 
            Console.WriteLine(t.Age);

            Console.ReadKey();
        }
    }
}
