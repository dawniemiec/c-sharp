using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab5
{
    public class Stozek
    {
        private double wysokosc;
        private double promien;

        public double Wysokosc
        {
            get { return wysokosc; }
            set
            {
                if (value > 0) { wysokosc = value; }
                else
                {
                    if(Zdarzenie != null) { Zdarzenie("Wysokość nie może być ujemna"); }
                    
                }
            }
        }
        public double Promien
        {
            get { return promien; }
            set
            {
                if (value > 0) { promien = value; }
                else
                {
                    Zdarzenie?.Invoke("Promień nie może być ujemny");
                }
            }
        }

        public Stozek(double wysokosc, double prom)
        {
            this.wysokosc = wysokosc;
            this.promien = prom;

        }
        public Stozek() { }

        public double ObliczObjetosc()
        {
            return 1.0 / 3.0 * Wysokosc * Math.PI * Math.Pow(Promien, 2);
        }

        public delegate void ObslugaBledu(string opisBledu);
        public event ObslugaBledu Zdarzenie;
    }
}
