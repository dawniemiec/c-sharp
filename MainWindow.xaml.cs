using System;
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
using Motoryzacja;

namespace lab3
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
        private void WyswietlPojazdy(List<Pojazd> list)
        {
            foreach(Pojazd p in list)
            {
                lBoxPojazd.Items.Add(p);
            }
        }

        private void btnZadA_Click(object sender, RoutedEventArgs e)
        {
            //var pojazd = new Pojazd();
            //pojazd.Nazwa = "125p";
            List<Pojazd> listP = new List<Pojazd>() { new Pojazd()};
            listP.Add(new Pojazd(100, "Maluch"));
            listP.Add(new Pojazd(300, "Lambo"));
            listP.Add(new Pojazd(30, 600, "Italo"));
            listP.Add(new Pojazd(16, 123.54, "EP07"));
            listP.Add(new PojazdMechaniczny());
            listP.Add(new PojazdMechaniczny(4, 90, "Aygo", 45));
            listP.Add(new Samochod());
            listP.Add(new Samochod("Citroen", 4,200,"Spacetourer", 180));
            WyswietlPojazdy(listP);

        }
    }
}
