using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form f = new Form();
            Form r = new Rectangle();
            Form t = new Triangle();
            Form c = new Circle();

            //f.Design();
            r.Design();
            t.Design(); 
            c.Design();
            

            Console.ReadKey();
        }
    }
}
