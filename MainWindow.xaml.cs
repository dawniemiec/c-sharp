using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab9C
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        (double, double, double) MinimalizujFunkcje(double minX, double maxX, double minY, double maxY, int ileIteracji, Func<double, double, double> funkcja)
        {
            double? najlepszyX = null;
            double? najepszyY = null;
            double? najWart = null;

            object semafor = new object();

            Random los = new Random();
            //for (int i = 0; i < ileIteracji; i++)

            ParallelOptions parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = 7
        };

            Parallel.For(0, ileIteracji, parallelOptions, i =>
                {
                    double x, y;
                    lock (los) {
                        x = los.NextDouble() * (maxX - minX) + minX;
                        y = los.NextDouble() * (maxY - minY) + minY;
                    }
                    
                    double wart = funkcja(x, y);
                    lock (semafor) {
                        if (najWart == null || najWart > wart)
                        {
                            najlepszyX = x;
                            najepszyY = y;
                            najWart = wart;
                        }
                    }
                    
                });
            return ((double)najlepszyX, (double)najepszyY, (double)najWart);
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(MinimalizujFunkcje(-10, 10, -10, 10, 1000000000, (x,y)=>Math.Sin(x)+Math.Cos(y)).ToString());
        }
    }
}