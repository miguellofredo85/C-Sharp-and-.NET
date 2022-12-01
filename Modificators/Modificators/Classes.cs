using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificators
{
    class Test
    {
        // private cant be acces grom other classes or instance
        private string name;
        public string lastname;
        private void method1() { }
        public void Execute() { }
    }
    class Human
    {
        protected string name; // protected is for the class and its herance, not instances
        private string lastname;
        internal int age; // not showing for other aplication when imported
    }
    class Man : Human
    {
        public void Metod()
        {
            name = "";
        }
    }
}
