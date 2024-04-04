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
using Geometria;

namespace Lab04
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

        private void btnOblicz_Click(object sender, RoutedEventArgs e)
        {
            var okno = new DaneWejscioweOkno();
            //okno.Show();
            okno.ShowDialog();
            double wys, szer, pole;

            wys = okno.Wysokosc;
            szer = okno.Szerokosc;
            pole = wys*szer;

            var oknWyj = new DaneWyjscioweOkno(pole);
            oknWyj.ShowDialog();
        }

        private void btnStoz_Click(object sender, RoutedEventArgs e)
        {
            Stozek stozek = new Geometria.Stozek(14, "s", 5.6, 44, 3);
            lblS.Content = stozek;
        }

        private void btnKula_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
