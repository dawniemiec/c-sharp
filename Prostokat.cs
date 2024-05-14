using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Prostokat
    {
        private double wysokosc, szerokosc;
        public double Wysokosc { get { return wysokosc; }
            set {
                if(value < 0)
                {
                    throw new ArgumentException("Wysokosc nie moż ebyć ujena");
                }
                wysokosc = value;
            }
        }
        public double Szerokosc { get { return szerokosc; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException("Szerokosc nie moze byc ujemna");
                }
                szerokosc = value;
            }
        }
        public double Pole()
        {
            return Wysokosc*Szerokosc;
        }
        public double Obwod()
        {
            return 2 * Wysokosc + 2 * Szerokosc;
        }
    }
}
