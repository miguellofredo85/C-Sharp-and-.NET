using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Conta
    {
        private string _client;
        private float _value;
        private float _tax= 10;
        public void Cash(float money)
        {
            money += _tax;
            _value -= money;
        }

        public void Desposit(float money) 
        {
            money -= _tax;
            _value += money;
        }
    }
}
