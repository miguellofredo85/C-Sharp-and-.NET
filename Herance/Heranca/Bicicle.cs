using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Bicicle : Vehicle // methods from Vehicle MUST be called and change abstract for override
    {

        public void Starting() 
        {
            Console.WriteLine("Beggining to move!");
        }
        public override void Aceleration()
        {
            Console.WriteLine("Aceleration Bicicle");
        }
        public override void Stop()
        {
            Console.WriteLine("Stopping Bicicle");
        }
    }

}
