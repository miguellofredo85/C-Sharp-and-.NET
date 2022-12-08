using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_temperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;
            Console.WriteLine("---- Convert Temperatures -----");
            Console.Write("Insert celsius temperature: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            f = (c * 9 / 5) + 32;
            k = c * 273.15;
            Console.WriteLine($"{c} grades celsius = {f} farenheit");
            Console.WriteLine($"{c} grades celsius = {k} kelvin");
            Console.ReadKey();
        }
    }
}
