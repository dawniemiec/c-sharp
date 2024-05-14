using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Walec
    {
        private double gestosc;
        private Kolo podstawa = new Kolo();
        private Prostokat sciana = new Prostokat();
        public double Promien { get {
                return podstawa.Promien;
            } 
            set
            {
                podstawa.Promien = value;
            }
        
        }
        public double Wysokosc { get
            {
                return sciana.Wysokosc;
            }
            set { 
                sciana.Wysokosc = value;
            } 
        }
        public double Gestosc { get
            { return gestosc; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                gestosc = value;
            } }
        public double Pole()
        {
            return 2*Math.PI*Promien*Wysokosc+2*podstawa.Pole();
        }
        public double Objetosc()
        {
            return podstawa.Pole() * Wysokosc;
        }
        public double Masa()
        {
            return Objetosc() * Gestosc;
        }


    }
}
