using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadConsole
{
    //without thread the program is executed line by line.
    // instead with thread the program execut all simultaneasly 
    // IsBackground will execute in fg "Principal" and will terminate the program once get to
    // 10 times no matters with the Work(), cause this will continue in bg, to see this comment 
    // and un comment ReadKey
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(Work));
            t.IsBackground = true;
            t.Start();
            t.Join(); // will execute Work() as principal thread, then execute "Principal" 
            
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("Principal");
            }
            Console.ReadKey();  
        }
        static void Work()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Executing work");
            }
        }
    }
}
