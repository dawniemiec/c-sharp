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

namespace Lab04
{
    /// <summary>
    /// Logika interakcji dla klasy DaneWyjscioweOkno.xaml
    /// </summary>
    public partial class DaneWyjscioweOkno : Window
    {
        private DaneWyjscioweOkno()
        {
            InitializeComponent();
        }

        public DaneWyjscioweOkno(double P):this() 
        {
            tbPole.Text = $"Pole wynosi: {P:F2}";
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
