using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motoryzacja
{
    public class PojazdMechaniczny : Pojazd
    {
        private double mocSilnika;
        public double MocSilnika
        {
            get { return mocSilnika; }
            set
            {
                if (value < 0) throw new ArgumentException("Ujemna moc przyda się tylko na rachunku za prąd");
                mocSilnika = value;
            }
        }

        public PojazdMechaniczny() : base() { }
        public PojazdMechaniczny(int kola, double predkosc, string nazwa) : base(kola, predkosc, nazwa)
        {
            MocSilnika = 0;
        }
        public PojazdMechaniczny(int kola, double predkosc, string nazwa, double moc) : base(kola, predkosc, nazwa)
        {
            MocSilnika = moc;
        }

        public override string ToString()
        {
            return base.ToString() + $" Moc: {MocSilnika}";
        }
    }
}