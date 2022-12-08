using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Human
    {
        public virtual void Eyes()
        {
            Console.WriteLine("Human eyes");
        }
        public virtual void Hair() 
        {
            Console.WriteLine("Human hair");
        }
    }
    internal class Person:Human
    {
        public override void Eyes()
        {
            Console.WriteLine("Person eyes");
        }
        public sealed override void Hair() 
        {
            Console.WriteLine("Person hair");
        }
    }
        class Man : Person
    {
        public override void Eyes() 
        {
            Console.WriteLine("Man eyes");
        }
    }
}
