using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeneralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Media general for students";
            Console.Write("How many students: ");
            int nAlum = int.Parse(Console.ReadLine());

            Alumn[] alumns = new Alumn[nAlum];
            
            for (int i = 0 ; i < alumns.Length; i++) 
            {
                Console.Clear();
                Console.Write($"Alumn #{i+1} name:  ");
                string name = Console.ReadLine();

                Console.Write($"Alumn #{i+1} exams: " );
                int exams = int.Parse(Console.ReadLine());

                alumns[i] = new Alumn(name, exams);
                Console.WriteLine($"Insert note for {name}");
                alumns[i].AddNote();
            }
            Console.Clear();

            double mediaGeneral = 0;

            foreach ( Alumn alumn in alumns ) 
            {
                Console.WriteLine($"Alumn {alumn.Name}");
                Console.WriteLine($"Alumn {alumn.GetMedia}\n");

                mediaGeneral += alumn.GetMedia;
            }
            double totalMediaGeneral = mediaGeneral / alumns.Length;
            Console.WriteLine($"general students media = {totalMediaGeneral}");

            Console.ReadKey();
        }
    }
}
