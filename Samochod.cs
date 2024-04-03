using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motoryzacja
{
    public class Samochod : PojazdMechaniczny
    {
        private int liczbaPasazerow;
        private string marka;
        public string Marka { get; set; }
        public int LiczbaPasazerow
        {
            get { return this.liczbaPasazerow; }
            set
            {
                if (value.GetType() != typeof(int))
                {
                    throw new ArgumentException("Ilość pasażerów: ęśąść");
                }
                else if (value < 0)
                {
                    throw new ArgumentException("Chyba był wypadek... albo auto wcina pasażerów na wejście");
                }
                this.liczbaPasazerow = value;
            }
        }

        public Samochod() : base() { }
        public Samochod(string marka, int kola, double predkosc, string nazwa, double moc) : base(kola, predkosc, nazwa, moc)
        {
            Marka = marka;
        }
        public override string ToString()
        {
            return base.ToString() + $" Marka: {Marka}";
        }

    }
}