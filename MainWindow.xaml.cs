using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab6
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

        List<Towar> listaTowarow =  new List<Towar>() { 
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

        private void f1_Click(object sender, RoutedEventArgs e)
        { 
            //zwykła funkcja na rosenbrocka?
            double funkRosenbrocka(double x,double y)
            {
                return Math.Pow((1 - x), 2) + 100 * Math.Pow(y - x * x, 2);
            }
            var wynik = Statyczna.ZnajdzMinimumFunkcji2D(-5, -5, 5, 5, 10000, funkRosenbrocka);
            posX.Content= wynik.Item1;
            posY.Content= wynik.Item2;
            value.Content= wynik.Item3;
        }

        private void f2_Click(object sender, RoutedEventArgs e)
        {
            var wynik = Statyczna.ZnajdzMinimumFunkcji2D(-10,-10,10,10,1000, (x,y) =>Math.Pow(x-4,2)+Math.Pow(y+2,2));
            posX.Content = wynik.Item1;
            posY.Content = wynik.Item2;
            value.Content = wynik.Item3;
        }

        private void linq1_Click(object sender, RoutedEventArgs e)
        {
            var items = listaTowarow.Where(i => i.Ilosc > 5).OrderByDescending(i=>i.Ilosc);
            foreach (var item in items)
            {
                lBox.Items.Add(item);
            }
        }

        public static (U min, U max) MinMax<T,U>(this IEnumerable<T> collection, Func<U,T> funkcja) where U:IComparable<U>{
            U? fMin = default(U);
            U? fMax = default(U);

            if(collection == null) throw new ArgumentNullException(nameof(collection));

            foreach (T item in collection)
            {
               //łeeeeeeeeeeee?
               
            }
               
            return (fMin, fMax);
        }
    }
}
