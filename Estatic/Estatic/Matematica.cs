using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Estatico
{
    internal class Matematica
    {
        public static int taxa; // static e visivel em tudo proyeto

        public static int Adicionar(int valor) 
        {
            return valor + taxa;
        }

        public static int Diminucao(int valor) 
        {
            return valor - taxa;
        }
    }
}
