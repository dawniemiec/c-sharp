using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Student : IWyswietl
    {
        private int nrAlbumu;
        private string nazwisko;
        private string imie;

        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public string PobierzIdentyfikator()
        {
            return nrAlbumu.ToString();
        }
    }
}
