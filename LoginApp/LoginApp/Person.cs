using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    internal class Person
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string Civil { get; set; }
        public string Phone { get; set; }
        public bool House { get; set; }
        public bool Car { get; set; }
        public char Gender { get; set; }
    }
}
