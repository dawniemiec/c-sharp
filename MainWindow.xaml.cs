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
using System.Xaml;

namespace Lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //for(int i= 0; i < 2; i++) {
            //    myGrid.ColumnDefinitions.Add(new ColumnDefinition());
            //    myGrid.RowDefinitions.Add(new RowDefinition());
            //}
            //myGrid.ShowGridLines = true;
            //Grid.SetColumn(lbxTest1, 1);
            //Grid.SetRow(lbxTest1, 1);
            //Grid.SetColumn(btnTest1, 2);
            //Grid.SetRow(btnTest1, 1);

            
        }
        private double Iloczyn(double a, double b) {
            return a * b;
        }
        private double Kwadrat(double a)
        {
            return Iloczyn(a, a);
        }
        private double PoleKola(double r)
        {
            return Iloczyn(Math.PI, Kwadrat(r));
        }
        private double ObjetoscWalca(double h, double r)
        {
            return Iloczyn(PoleKola(r), h);
        }
        private double ObjetoscWalca(double h)
        {
            return ObjetoscWalca(h, h / 2);
        }

        private void btnTest1_Click(object sender, RoutedEventArgs e)
        {
            double a, b, r, h;
            a = 5; b = 2; r = 4; h = 3;

            lbxTest1.Items.Add(Iloczyn(a, b));
            lbxTest1.Items.Add(Kwadrat(a));
            lbxTest1.Items.Add(PoleKola(r));
            lbxTest1.Items.Add(ObjetoscWalca(h,r));
            lbxTest1.Items.Add(ObjetoscWalca(h));

        }

        private void Prostokat(double szer, double wys, out double pole, out double obw, out double przek)
        {
            pole = Iloczyn(szer, wys);
            obw = 2 * szer + 2 * wys;
            przek = Math.Sqrt(Kwadrat(wys) + Kwadrat(szer));

        }

        private void btnTest3_Click(object sender, RoutedEventArgs e)
        {
            double szer, wys, pole, obw, przek;
            wys = Convert.ToDouble(txtWys.Text);
            szer = Convert.ToDouble(txtSzer.Text);

            Prostokat(szer, wys, out pole, out obw, out przek);
            MessageBox.Show($"Pole prostokąta wynosi: {pole:F2}, obwód: {obw:F2}, a przekąna: {przek:F2}");
        }

        private void btnTest4_Click(object sender, RoutedEventArgs e)
        {
            double[,] arrPunkt = new double[,] { { 10, 10, 10, 150 }, { 90, 10, 90, 150 }, { 10, 10, 90, 10 }, { 10, 40, 90, 40 } };
            System.Windows.Media.Color[] colors = { Colors.Green, Colors.Green, Colors.Red, Colors.Black };
            
            for(int i =0; i < 4; i++)
            {
                rysLinie(arrPunkt[i, 0], arrPunkt[i, 1], arrPunkt[i, 2], arrPunkt[i, 3], colors[i]);
            }
        }
        private void rysLinie(double x1, double y1, double x2, double y2, Color color)
        {
            SolidColorBrush brush= new SolidColorBrush(color);

            Line mLine = new Line();
            mLine.X1 = x1;
            mLine.X2 = x2;
            mLine.Y1 = y1;
            mLine.Y2= y2;
            mLine.Stroke = brush;
            mLine.StrokeThickness = 1;
            cv4.Children.Add(mLine);
        }

        enum typDzialania
        {
            Sum = 0,
            Min = 1,
            Max = 2
        }

        private void turboLiczydlo(typDzialania dzialanie, double a, double b)
        {
            if (dzialanie == typDzialania.Sum)
            {
                double suma = a + b;
                MessageBox.Show($"Wynik działania sumy to: {suma:F2}");
            } else if (dzialanie == typDzialania.Min)
            {
                double min = Math.Min(a, b);
                MessageBox.Show($"Wynik działania sumy to: {min:F2}");
            }
            else if (dzialanie == typDzialania.Max)
            {
                double max = Math.Max(a,b);
                MessageBox.Show($"Wynik działania sumy to: {max:F2}");
            }

        }
    }
}
