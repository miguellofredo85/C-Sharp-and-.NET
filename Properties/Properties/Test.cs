using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Test
    {
        //Definition properties field
        private string _name; // underscore for private
        // private string Lastname { get; set; } // properties can get and set by default and change any value of the property
        public string Lastname { get; } = "Lofredo"; // get Lofredo by default
        private int _age;

        // Accesing properties from methods

        public string Name
        { 
            get { return _name; } 
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set {
                if (value < 18)
                {
                    Console.WriteLine("Below 18 years, can't do this...");
                }
                else
                {
                    _age = value;
                }
                 
            }
        }
        public void Presentation()
        {
            if (_name != "")
            {
                Console.WriteLine($"Bem vindo {_name}");
            }
        }
    }
}
