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
using System.Windows.Shapes;

namespace lab5_dom
{
    /// <summary>
    /// Logika interakcji dla klasy PobierzZadanie.xaml
    /// </summary>
    public partial class PobierzZadanie : Window
    {
        public PobierzZadanie()
        {
            InitializeComponent();
        }
        public PobierzZadanie(Zadanie zad) : this()
        {
            OpisaZadania.Text = zad.Opis;
            DataZadania.Text = zad.DataWprowadzenia.ToString();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
