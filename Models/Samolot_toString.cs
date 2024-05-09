using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_DBEF.Models
{
    public partial class Samolot
    {
        public override string ToString()
        {
            return $"{Producent} {Model} {Pulap} {Predkosc} {Udzwig}";
        }
    }
}
