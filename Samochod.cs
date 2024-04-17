using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_dom
{
    public class Samochod : IZmniejszany, IZwiekszany, IPoprawialny<Samochod>
    {
        private int predkosc;
        private int rocznik;
        public int Predkosc { get { return predkosc; } }
        public int Rocznik { get { return rocznik; } set { rocznik = value; } }

        void IZmniejszany.Zmien()
        {
            predkosc -= 5;
        }

        void IZwiekszany.Zmien()
        {
            predkosc += 10;
        }

        public Samochod() { }
        public Samochod(int rocznik)
        {
            this.rocznik = rocznik;
        }
        Samochod IPoprawialny<Samochod>.PobierzLepszaWersje()
        {
            Samochod kopia = new Samochod(this.rocznik+1);
            return kopia;
        }
    }
}
