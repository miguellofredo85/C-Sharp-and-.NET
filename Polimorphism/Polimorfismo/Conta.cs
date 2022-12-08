using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class CaixaEletronico : ICount
    {
        public string User { get; set; }

        public void Deposit()
        {
           
        }

        public void Get()
        {
           
        }

        public void Total()
        {
        
        } 
        public void Getloan()
        {

        }
    }
    interface ICount // always abstract and by default and cant change it access.
    {
        string User { get; set; }
        void Deposit();
        void Get();

        void Total();
    }
}
