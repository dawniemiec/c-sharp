using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_entity.Models
{
    public partial class Student
    {
        public override string ToString()
        {
            return $"{Nazwisko} {Imie} {Wiek} {(Ocena ?? 0)}"; //lub {(Ocena?.ToString() ?? "Brak")}
        }
    }
}
