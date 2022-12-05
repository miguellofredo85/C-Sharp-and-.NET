using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task Part One
            ////Task t1 = new Task(Work);
            //t1.Start();

            //Task t2= Task.Run(Work);

            //Task.Run(Work);
            //Task.Factory.StartNew(Work);
            //Task.Run(() => 
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("One more task");

            //    }
            //});
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Another task work");

            //}
            #endregion
            #region Task Part Two 
            //Task[] t =
            //{
            //    Task.Run(() =>  Console.WriteLine("Number 1") ),
            //    Task.Run(() =>  Console.WriteLine("Number 2") ),
            //    Task.Run(() => Console.WriteLine("Number 3") )
            //};

            //Task.WaitAll( t );
            #endregion

            //Task<int> t2 = Task.Factory.StartNew(() => Double(4)); // typing Task returning an int
            //Console.WriteLine(t2.Result);

            #region Task Part Three

            // Each Task is waiting for the before to finish
            Task<int> t1 = Task.Factory.StartNew(() => 
            {
                return 8; //new Random().Next(10); 
            });

            Task<int> t2 = t1.ContinueWith((num) =>
            {
                return num.Result * 2;
            });

            Task<string> t3 = t2.ContinueWith((num) =>
            {
                return $"Final count: {num.Result}";
            });

            Console.WriteLine(t3.Result);
            #endregion
            Console.ReadKey();
        }

        static int Double(int x) 
        {
            return x*2;
        }
        private static void Work()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Task work");

            }
        }
    }
}
