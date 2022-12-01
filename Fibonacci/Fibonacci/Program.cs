using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;

            Console.WriteLine("Insert quantity for the sequence: ");
            int sequence = int.Parse(Console.ReadLine());

            Console.WriteLine($"Fibonacci sequence for {sequence} number/s");

            for (int i = 0; i < sequence; i++)
            {
                if (i < sequence - 1)
                {
                    Console.Write($"{a}, ");
                }
                else
                {
                    Console.WriteLine(a);
                }
                c = a + b;
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}
