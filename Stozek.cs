using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Stozek:Kula
    {
        private double wysokosc;

        public double Wysokosc
        {
            get { return wysokosc; }
            set {
                if (value > 0) { wysokosc = value; }
                else throw new ArgumentException("ujemna wysokość");
            }
        }

        public Stozek(double wysokosc, string nazwa, double gest, decimal cena, double prom) : base(prom, nazwa, gest, cena)
        {
            this.wysokosc = wysokosc;
        }

        public override double ObliczObjetosc()
        {
            return 1.0 / 3.0 * Wysokosc * Math.PI * Math.Pow(Promien, 2);
        }
        public override string PobierzIdentyfikator()
        {
            return base.PobierzIdentyfikator()+Wysokosc;
        }
    }
}
