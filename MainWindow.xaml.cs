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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            txtInputA.Visibility = Visibility.Hidden;
            txtInputB.Visibility = Visibility.Hidden;
            txtInputC.Visibility = Visibility.Hidden;
        }

        private void btnOblicz_Click(object sender, RoutedEventArgs e)
        {
            showResult();
        }

        private void showResult() 
        { 
            double a, b, c, x1 = double.NaN, x2 = double.NaN;
            try { 
                getValues(out a, out b, out c);
                doMath(out x1, out x2, a, b, c);
                if(double.IsNaN(x1) || double.IsNaN(x2))
                {
                    txtWynik.Text = "Równanie nie ma rozwiązań";
                }
                else if (x1 == x2 )
                {
                    txtWynik.Text = $"Równanie ma jeden wspólny pierwiastek: {x1:F2}";
                }
                else { txtWynik.Text = $"Pierwiastki równania to {x1:F2} i {x2:F2}"; }
                
            }
            catch (InvalidOperationException)
            {
                txtWynik.Text = "To nie jest równanie kwadratowe";
            } 
        }

        private void getValues(out double a, out double b, out double c) 
        {
            a = 0; b = 0; c = 0;
            try {
                if (chkA.IsChecked == true)
                {
                    a = Convert.ToDouble(txtInputA.Text);
                }
                if (chkB.IsChecked == true)
                {
                    b = Convert.ToDouble(txtInputB.Text);
                }
                if (chkC.IsChecked == true)
                {
                    c = Convert.ToDouble(txtInputC.Text);
                }
            }
            catch { MessageBox.Show("Zły format liczb"); }
            if (a == 0) throw new InvalidOperationException("Brak parametru a, to nie jest równ. kwadratowe!");
            
        }
        private void doMath(out double x1, out double x2, double a, double b, double c)
        {
            x1 = double.NaN; x2 = double.NaN;
            double delta = b * b - 4 * a * c;
            if (delta > 0) {
                x1 = (-b - (Math.Sqrt(delta))) / (2 * a);
                x2 = (-b + (Math.Sqrt(delta))) / (2 * a);
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
            }
        }

        private void chkA_Click(object sender, RoutedEventArgs e)
        {
            if (chkA.IsChecked == true)
            {
                txtInputA.Visibility = Visibility.Visible;

            }
            else
            {
                txtInputA.Visibility = Visibility.Hidden;
            }
        }
        private void chkB_Click(object sender, RoutedEventArgs e)
        {
            if (chkB.IsChecked == true)
            {
                txtInputB.Visibility = Visibility.Visible;

            }
            else
            {
                txtInputB.Visibility = Visibility.Hidden;
            }
        }
        private void chkC_Click(object sender, RoutedEventArgs e)
        {
            if (chkC.IsChecked == true)
            {
                txtInputC.Visibility = Visibility.Visible;
            }
            else {
                txtInputC.Visibility = Visibility.Hidden;
            }
        }
    }
}
