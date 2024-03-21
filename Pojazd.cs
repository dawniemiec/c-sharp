using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motoryzacja
{
    public class Pojazd
    {
        private int liczbaKol;
        private double predkosc;
        private static int liczbaPojazdow;
        public int LP { get; set; }
        public string Nazwa { get; set; }
        public int LiczbaKol 
        { 
            get { return this.liczbaKol; }
            private set { if (value <= 0)
                {
                    throw new ArgumentException("Pojazd musi mieć więcej niż 0 kół!");
                }else if(value.GetType() != typeof(int))
                {
                    throw new ArgumentException("Wypadałoby, żeby liczba kół była liczbą całkowitą");
                }
                  this.liczbaKol = value;
            }
        }
        public double Predkosc
        {
            get { return this.predkosc;}
            private set
            {
                if (value.GetType()!= typeof(double)) {
                    throw new ArgumentException("Jesteś zza oceanu, że prędkość podajesz w czymś innym niż liczby?");
                } else if(value <0)
                {
                    throw new ArgumentException("Ten manewr będzie nas kosztować 50 lat świetlnych - przyśpiesz");
                }
                this.predkosc = value;
            }
        }
        static Pojazd()
        {
            liczbaPojazdow= 0;
        }
        public Pojazd()
        {
            LP = ++liczbaPojazdow;
        }
        public Pojazd(int kola, double predkosc, string nazwa):this()
        {
            LiczbaKol = kola;
            Predkosc = predkosc;
            Nazwa = nazwa;
        }
        public Pojazd(double predkosc, string nazwa) : this(4, predkosc, nazwa) { }
        public override string ToString()
        {
            return $"Lp: {LP}/{liczbaPojazdow} {Nazwa} V: {Predkosc} L. kół: {LiczbaKol}";
        }

    }

}
