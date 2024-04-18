using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public enum Kategoria
    {
        kategoria1,
        kategoria2, 
        kategoria3
    }
    public class Towar
    {
        private string nazwa;
        private double cena;
        private int ilosc;
        private Kategoria kat;

        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public int Ilosc { get; set; }
        public Kategoria Kat { get; set; }

        public override string ToString()
        {
            return $"Nazwa: {Nazwa}, Cena: {Cena}, Ilosc: {Ilosc}, Kategoria: {Kat}";
        }
    }
}
