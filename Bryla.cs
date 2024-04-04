using Lab04;
using System;
using System.Linq;
using System.Windows.Navigation;

namespace Geometria
{
    public abstract class Bryla : IWyswietl
    {
        private string nazwa;
        private double gestosc;
        private decimal cenaKg;

        public string Nazwa { 
            get { return nazwa; }
        }
        public double Gestosc { 
            get { return gestosc; }
        }
        public  decimal CenaKg {
            get { return cenaKg; }
        }

        public Bryla(string nazwa, double gestosc, decimal cena)
        {
            this.nazwa = nazwa;
            this.gestosc = gestosc;
            this.cenaKg = cena;
        }

        public abstract double ObliczObjetosc();
        public double ObliczMase()
        {
            return Gestosc * ObliczObjetosc();
        }
        public decimal ObliczCene()
        {
            return Convert.ToDecimal(ObliczMase()) * CenaKg;
        }

        public override string ToString()
        {
            return $"Nazwa: {Nazwa} Gêstoœæ: {Gestosc} Cena za kg: {CenaKg} Masa: {ObliczMase()} Obj.: {ObliczObjetosc()} Cena finalnie: {ObliczCene()} ";
        }

        public abstract string PobierzIdentyfikator();
    }
}
