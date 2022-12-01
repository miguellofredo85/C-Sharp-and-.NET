using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your weight in kg");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Height in mts");
            double height = double.Parse(Console.ReadLine());

            double imc = peso / (height * height)*10000;

            if (imc <= 20) 
            {
                Console.WriteLine($"IMC = {imc} - below weight");
            }
            else if (imc > 20 && imc <= 24) 
            {
                Console.WriteLine($"IMC = {imc} -  nice ");
            }
            else if (imc > 24 && imc <= 30)
            {
                Console.WriteLine($"IMC = {imc} -  well done ");
            }
            else
            {
                Console.WriteLine($"IMC = {imc} -  you are fat ");
            }
            Console.ReadKey();
        }
    }
}
