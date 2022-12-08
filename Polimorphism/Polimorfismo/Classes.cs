using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Form
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Haigh { get; set; }
        public int Long { get; set; }

        public int Ratio { get; set; }

        public virtual void Design()
        {
            Console.WriteLine("Preparing Form");
        }
        public virtual void Area()
        {
            float area = Long * Haigh; 
        }
    }
    class Circle:Form
    {
        public override void Design()
        {
            base.Design();
            Console.WriteLine("Circle designing");
            
        }
        public override void Area()
        {
            double area = Math.PI * (Ratio*Ratio);
            Console.WriteLine($"Circle area: {area}");
        }
    }
    class Rectangle:Form
    {
        public override void Design()
        {
            base.Design();
            Console.WriteLine("Rectangle designing");
        }
        public override void Area()
        {
            base.Area();
        }
    }
    class Triangle : Form
    {
        public override void Design()
        {
            base.Design();
            Console.WriteLine("Triangle designing");
        }
        public override void Area()
        {
            float area = (Haigh * Long) / 2;
            Console.WriteLine($"Triangle area: {area}");
        }
    }
}
