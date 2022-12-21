using System;

namespace VolumeCilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, A, h, V;

            R = 0;
            while (R <= 0)
            {
                Console.Write("Digite o valor do raio da base do cilindro: ");
                R = double.Parse(Console.ReadLine());
            }

            h = 0;
            while (h <= 0)
            {
                Console.Write("Digite o valor da altura do cilindro: ");
                h = double.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            //área da base
            A = Math.PI * Math.Pow(R, 2);

            //volume do cilindro
            V = A * h;
            Console.WriteLine($"Volume do cilindro {V}");
        }
    }
}
