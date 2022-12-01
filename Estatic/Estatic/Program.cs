using Estatic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatico
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            #region
           /* Matematica.taxa = 10;

            int valor1 = Matematica.Adicionar(200);
            int valor2 = Matematica.Diminucao(200);

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);

            Console.ReadKey(); */
            #endregion

            Pessoa.major = 20;
            Pessoa p1 = new Pessoa();

            p1.name = "Miguel";
            p1.age = Pessoa.Date(1985);

            Console.WriteLine(p1.name);
            Console.WriteLine(p1.age);
            Console.WriteLine(Pessoa.major);

            Console.ReadKey();

        }
    }
}
