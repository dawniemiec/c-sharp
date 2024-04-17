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
    /// Logika interakcji dla klasy DodajZadanie.xaml
    /// </summary>
    public partial class DodajZadanie : Window
    {
        public DodajZadanie()
        {
            InitializeComponent();
        }
        private Zadanie zadanie;
        
        public Zadanie Zad
        {
            get { return zadanie; }
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            zadanie = new Zadanie(OpisaZadania.Text);
            this.Close();
        }
    }
}
