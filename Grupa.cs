using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace lab7dom
{
        [Serializable]
        public class Grupa
        {
            public string Nazwa { get; set; }
            public List<Student>? Studenci { get; set; }
            public int LiczbaStudentow { get { return Studenci.Count(); } }
            public double? SredniaOcen
            {
                get
                {
                    if (Studenci.Count == 0 || Studenci == null) return null;
                    return Studenci.Average(st => st.Ocena);
                }
            }

            public void Wyswietl(ref ListBox box)
            {
                box.Items.Add($"Grupa: {Nazwa}");
                foreach (var student in Studenci)
                {
                    box.Items.Add($"\t{student.Nazwisko} {student.Ocena}");
                }
                box.Items.Add($"Liczba studentów: {LiczbaStudentow}");
                box.Items.Add($"Średnia ocen: {SredniaOcen}");
            }

            public void ZapiszDoPliku(string nazwaPliku)
        {
            StreamWriter streamWriter = new StreamWriter(nazwaPliku);
            streamWriter.WriteLine($"Grupa: {Nazwa}");
            foreach (var student in Studenci)
            {
                streamWriter.WriteLine($"\t{student.Nazwisko} {student.Ocena}");
            }
            streamWriter.WriteLine($"Liczba studentów: {LiczbaStudentow}");
            streamWriter.WriteLine($"Średnia ocen: {SredniaOcen}");
            streamWriter.Close();
        }
        }
    }
