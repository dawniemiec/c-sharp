using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_dom
{
    public class Zadanie
    {
        private string opis;
        private DateTime dataWprowadzenia;
        public string Opis { get; set; }
        public DateTime DataWprowadzenia { get; set; }

        public Zadanie(string opis) {
            Opis = opis;
            DataWprowadzenia = DateTime.Now;
        }

    }
}
