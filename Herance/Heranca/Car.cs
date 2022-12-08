using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Car : Vehicle 
    {
        public int MaxVelocity { get; set; }
        
        public void Motor()
        {
            Console.WriteLine("Starting engine!");
        }
        public override void Aceleration()
        {
            Console.WriteLine("Aceleration Car");
        }
        public override void Stop()
        {
            Console.WriteLine("Stopping Car");
        }
    }
}
