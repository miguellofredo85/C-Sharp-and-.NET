using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal sealed class Truck : Car // sealed will work to NOT herance the class Truck
    {
        public bool ExtendCabine { get; set; }
    }
}
