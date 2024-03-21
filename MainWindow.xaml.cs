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

namespace kol2
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

        public double ObjetoscStozka(double promien, double wys)
        {
            return 1/3.0*wys*Math.PI*Math.Pow(2, promien);
        }

        public void PoliczDaneStozka(double r, double h, out double v, out double mass)
        {
            v = 0; mass = 0;
            v = ObjetoscStozka(r, h);
            mass = v * 0.001;
            

        }

        private void btnLicz_Click(object sender, RoutedEventArgs e)
        {
            double V, mass;
            try
            {
                double r = Convert.ToDouble(txtProm.Text);
                double h = Convert.ToDouble(txtWys.Text);
                PoliczDaneStozka(r, h, out V, out mass);
                MessageBox.Show($"Objętość stożka wynosi {V:F2} cm3, a masa {mass:F2} kg");
            }
            catch(Exception ) { MessageBox.Show($"Błędne wartości pól"); }
            
            
            
            
        }
    }
}
