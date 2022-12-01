using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeneralPOO
{
    internal class Alumn
    {
        public string Name { get; private set; }
        private double[] _notes;
        public double media { get { return 0; } }

        public Alumn(string name, int exam)
        {
            Name = name;
            _notes = new double[exam];

        }
        public double GetMedia
        {
            get { return Media(); }
        }
        public void AddNote() 
        {
            for (int i = 0; i < _notes.Length; i++)
            {
                Console.WriteLine($"Nota #{i+1}: ");
                _notes[i] = double.Parse(Console.ReadLine());
            }
        }
        private double Media()
        {
            double total = 0;
            for (int i = 0; i < _notes.Length; i++)
            {
                total += _notes[i];
            }
            return total / _notes.Length;
        }
    }
}
