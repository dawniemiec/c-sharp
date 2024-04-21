using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab6dom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Towar> listaTowarow = new List<Towar>() {
            new Towar() {Nazwa="Soczek", Cena=10, Ilosc=1, Kat=Kategoria.kategoria1 },
            new Towar() {Nazwa="Pudełko", Cena=12, Ilosc=2, Kat=Kategoria.kategoria2 },
            new Towar() {Nazwa="Skarpetki", Cena=12, Ilosc=6, Kat=Kategoria.kategoria3 },
            new Towar() {Nazwa="Zapałki", Cena=100, Ilosc=7, Kat=Kategoria.kategoria3 },
            new Towar() {Nazwa="Szafa", Cena=5, Ilosc=80, Kat=Kategoria.kategoria2 },
            new Towar() {Nazwa="Jadło", Cena=6, Ilosc=45, Kat=Kategoria.kategoria1 },
            new Towar() {Nazwa="Komoda", Cena=10, Ilosc=1, Kat=Kategoria.kategoria2 },
            new Towar() {Nazwa="Półka", Cena=45, Ilosc=10, Kat=Kategoria.kategoria2 },
            new Towar() {Nazwa="Golonko", Cena=3, Ilosc=13, Kat=Kategoria.kategoria1 },
            new Towar() {Nazwa="Nitka", Cena=10, Ilosc=167, Kat=Kategoria.kategoria3 },
        };

        

        private void linq1_Click(object sender, RoutedEventArgs e)
        {
            //var items = listaTowarow.Where(i => i.Ilosc > 5).OrderByDescending(i => i.Ilosc);

            var items = from towar in listaTowarow where towar.Ilosc > 5 orderby towar.Ilosc descending select towar;

            foreach (var item in items)
            {
                lBox.Items.Add(item);
            }
        }

        private void linq2_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                var kategoria = (Kategoria)i;
                //var itemsCount = listaTowarow.Where(item=>item.Kat == kategoria).Count();

                var itemsCount = (from towar in listaTowarow where towar.Kat == kategoria select towar).Count();

                lBox.Items.Add($"{kategoria}: {itemsCount} obiektów");
            }

        }

        private void linq3_Click(object sender, RoutedEventArgs e)
        {
            //var itemsMoreThanAvg = listaTowarow.Where(item => item.Cena > listaTowarow.Average(item => item.Cena)).Select(item=>$"{item.Nazwa}: {item.Cena}");

            var itemsMoreThanAvg = from towar in listaTowarow where towar.Cena > (from towarAvg in listaTowarow select towarAvg.Cena).Average() select new { towar.Nazwa, towar.Cena };

            foreach (var item in itemsMoreThanAvg)
            {
                lBox.Items.Add(item);
            }
        }

        private void linq4_Click(object sender, RoutedEventArgs e)
        {
            //var itemsGroups = listaTowarow.GroupBy(items => items.Kat).Select(group => new
            //{
            //    kategoria = group.Key,
            //    ilosc = group.Count(),
            //    avgCena = group.Average(item => item.Cena)
            //});

            var itemsGroups = from towar in listaTowarow
                              group towar by towar.Kat into groupCat
                              select new
                              {
                                  kategoria = groupCat.Key,
                                  ilosc = groupCat.Count(),
                                  avgCena = groupCat.Average(item => item.Cena)
                              };


            foreach (var item in itemsGroups)
            {
                lBox.Items.Add(item);
            }

        }

        private void linq5_Click(object sender, RoutedEventArgs e)
        {
            //var max = listaTowarow.OrderByDescending(items=>items.Cena).FirstOrDefault();
            var max = (from towar in listaTowarow orderby towar.Cena descending select towar).First();

            if (max != null)
            {
                lBox.Items.Add($"{max.Nazwa}: {max.Cena}");
            }
        }

        private void minmax_Click(object sender, RoutedEventArgs e)
        {
            var zakres = listaTowarow.MinMax(i => i.Ilosc);
            var ceny = listaTowarow.MinMax(i => i.Cena);
            string[] napisy = { "aaa", "asdasd", "fdfsfweSas" };
            var zakNap = napisy.MinMax(i => i.Length);
        }

        static (double P, double Obw) ObliczKolo (double r)
        {
            double p = Math.PI * r * r;
            double o = 2 * Math.PI * r;
            return(p, o);
        }

        private void action_Click(object sender, RoutedEventArgs e)
        {
            Towar towar = new Towar(){Nazwa= "Laptop",Cena=3500,Ilosc=7,Kat=Kategoria.kategoria1};
            towar.Wyswietl(str => MessageBox.Show(str));
            towar.Wyswietl(str=>actionL.Content= str);
        }
    }
}
