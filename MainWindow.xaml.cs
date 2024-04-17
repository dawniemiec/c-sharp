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
using System.Xml.Serialization;

namespace lab5_dom
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
        Samochod sam1 = new Samochod(5);
        private Queue<Zadanie> kolejkaZadan = new Queue<Zadanie>();

       
        private void btnZwieksz_Click(object sender, RoutedEventArgs e)
        {
            
            
            ((IZwiekszany)sam1).Zmien();
            listOut.Items.Add(sam1.Predkosc);

        }

        private void btnZmniejsz_Click(object sender, RoutedEventArgs e)
        {
            ((IZmniejszany)sam1).Zmien();
            listOut.Items.Add(sam1.Predkosc);

        }

        private void btnPoprawAuto_Click(object sender, RoutedEventArgs e)
        {

            Samochod nowszy = ((IPoprawialny<Samochod>)sam1).PobierzLepszaWersje();

        }

        private void DodajZad(Zadanie zad)
        {
            kolejkaZadan.Enqueue(zad);
        }
        private Zadanie PobierzZad()
        {
            if (kolejkaZadan.Count > 0)
            {
                return kolejkaZadan.Dequeue();
            }
            else throw new ArgumentOutOfRangeException("Nie ma więcej zadań");
        }

        private void btnDodZad_Click(object sender, RoutedEventArgs e)
        {
            var dodDialog = new DodajZadanie();
            dodDialog.ShowDialog();
            Zadanie zad = dodDialog.Zad;
            DodajZad(zad);

        }

        private void btnPobZad_Click(object sender, RoutedEventArgs e)
        {
            Zadanie zadanie = PobierzZad();
            var showZadanie = new PobierzZadanie(zadanie);
            showZadanie.ShowDialog();


        }
    }
}
