using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Kula:Bryla
    {
        private double promien;
        public double Promien { 
            get { return promien; }
            set {
                if(value > 0) { promien = value; }
                else throw new ArgumentException("Ujemny p[romień");
            }
        }

        public Kula(double promien, string nazwa, double gest, decimal cena):base(nazwa, gest, cena)
        {
            Promien = promien;
        }

        public override double ObliczObjetosc()
        {
            return 4.0/3.0 * Math.PI*Math.Pow(promien, 3);
        }
        public override string PobierzIdentyfikator()
        {
            return String.Concat(Nazwa, Promien);
        }
    }
}
