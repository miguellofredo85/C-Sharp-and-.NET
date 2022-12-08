 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Car c = new Car();
            Bicicle b = new Bicicle();

            c.Aceleration();
            b.Aceleration();
            c.Stop();
            b.Stop();
           */
           Human n = new Human();
           Person p = new Person();
           Man m = new Man();

            Console.WriteLine("Human");
            n.Eyes();
            n.Hair();
            Console.WriteLine("\nPerson");
            p.Eyes();
            p.Hair();
            Console.WriteLine("\nMan");
            m.Hair();
            m.Eyes();

           Console.ReadKey();
        }
    }
}
