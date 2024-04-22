using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace lab7
{
    [Serializable]
    public class Grupa
    {
        public string Nazwa { get; set; }
        public List<Student>? Studenci { get; set; }
        public int LiczbaStudentow { get { return Studenci.Count(); } }
        public double? SredniaOcen { get {
                if (Studenci.Count == 0 || Studenci == null) return null;
                return Studenci.Average(st => st.Ocena);
            } 
        }

        public void Wyswietl(ref ListBox box)
        {
            box.Items.Add($"Grupa: {Nazwa}");
            foreach(var student in Studenci)
            {
                box.Items.Add($"\t{student.Nazwisko} {student.Ocena}");
            }
            box.Items.Add($"Liczba studentów: {LiczbaStudentow}");
            box.Items.Add($"Średnia ocen: {SredniaOcen}");
        }
    }
}
