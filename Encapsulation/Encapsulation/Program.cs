using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            c._client = "Miguel";
            c._value = 100;

            float value = 100;
            c.Desposit(value);

            float value2 = 50;
            c.Cash(value2);

            Console.WriteLine($"Client: {c._client}");
            Console.WriteLine($"Total: {c._value}");

            Console.ReadKey();
        }
    }
}
