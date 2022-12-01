using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ProyectOne
{
    class Calculator
    {

     static void Main(string[] args)
        {
        float num1 = 0; 
        float num2 = 0;
        Console.WriteLine("Ingrese un valor numerico: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro mas: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("que tipo de operacion desea hacer (suma/resta/div/mult): ");
            
                switch (Console.ReadLine())
            {
                case "suma":
                    Console.WriteLine("Su resultado es: ", + (num1 + num2));
                    break;
                case "resta":
                    Console.WriteLine("Su resultado es: " + (num1 - num2));
                    break;
                case "div":
                    Console.WriteLine("Su resultado es: " + (num1 / num2));
                    break; 
                case "mult":
                    Console.WriteLine("Su resultado es: " + (num1 * num2));
                    break;
            }
        }
    }
}