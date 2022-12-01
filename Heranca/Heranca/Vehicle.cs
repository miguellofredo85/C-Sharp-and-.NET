using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal abstract class Vehicle //abstract will not allow us to instance class Vehicle, will work only to herance it
    {
        public string Cor { get; set; }
        public string Model { get; set; }

        public abstract void Aceleration(); // abstract methods doesnt have implementation
        public abstract void Stop();
    }
}
