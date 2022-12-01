using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_bidimensional_arrays_multplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[2, 3];
            int[,] array2 = new int[3, 2];
            int[,] array3 = new int[2, 2];

            Console.WriteLine("---- First Matrix ----");
            for (int line = 0; line < 2; line++) 
            {
                for ( int column = 0; column < 3; column++)
                {
                    Console.Write($"Posicion [{line}][{column}]  = ");
                    array1[line, column] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("---- Second Matrix ----");
            for (int line = 0; line < 3; line++)
            {
                for (int column = 0; column < 2; column++)
                {
                    Console.Write($"Posicion [{line}][{column}]  = ");
                    array2[line, column] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Multiplication matrix 1 and matrix 2");
            array3[0,0] = (array1[0, 0] * array2[0, 0]) + (array1[0, 1] * array2[1, 0]) + (array1[0, 2] * array2[2, 0]);
            array3[1,0] = (array1[1, 0] * array2[0, 0]) + (array1[1, 1] * array2[1, 0]) + (array1[1, 2] * array2[2, 0]);
            array3[0,1] = (array1[0, 0] * array2[0, 1]) + (array1[0, 1] * array2[1, 1]) + (array1[0, 2] * array2[2, 1]);
            array3[1,1] = (array1[1, 0] * array2[0, 1]) + (array1[1, 1] * array2[1, 1]) + (array1[1, 2] * array2[2, 1]);

            Console.WriteLine($"{array3[0,0]} | {array3[0,1]}");
            Console.WriteLine($"{array3[1, 0]} | {array3[1, 1]}");

            Console.ReadKey();

        }
    }
}
