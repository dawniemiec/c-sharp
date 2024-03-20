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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Gwiazda(100, 80, 80);
            //GwiazdaRekur(100, 80, 80,5);
            
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
            }
            else if (dzialanie == typDzialania.Min)
            {
                double min = Math.Min(a, b);
                MessageBox.Show($"Wynik działania sumy to: {min:F2}");
            }
            else if (dzialanie == typDzialania.Max)
            {
                double max = Math.Max(a, b);
                MessageBox.Show($"Wynik działania sumy to: {max:F2}");
            }

        }

        private void sum_Checked(object sender, RoutedEventArgs e)
        {
            turboLiczydlo(typDzialania.Sum, 5, 6);
        }

        private void min_Checked(object sender, RoutedEventArgs e)
        {
            turboLiczydlo(typDzialania.Min, 5, 6);

        }

        private void Gwiazda(double dlRam, double x, double y)
        {
            double angle = 60;
            double st_angle = 0;
            for(int i = 0; i < 6; i++)
            {
                double X2 = x + dlRam * Math.Cos(st_angle * Math.PI / 180);
                double Y2 = y +dlRam* Math.Sin(st_angle * Math.PI / 180);
                RysujLinie(x, X2, y, Y2);
                st_angle += angle;
            }
        }
        private void GwiazdaRekur(double dlRam, double x, double y, double minDlugosc)
        {
            double angle = 60;
            double st_angle = 0;
            for (int i = 0; i < 6; i++)
            {
                double X2 = x + dlRam * Math.Cos(st_angle * Math.PI / 180);
                double Y2 = y + dlRam * Math.Sin(st_angle * Math.PI / 180);
                RysujLinie(x, X2, y, Y2);
                if (dlRam >= minDlugosc)
                {
                    GwiazdaRekur(dlRam / 3, X2, Y2, minDlugosc);
                }

                st_angle += angle;
            }
        }
        private void RysujLinie(double wspX1, double wspX2, double wspY1, double wspY2, int grubosc = 1, SolidColorBrush kolor = null)
        {
            if (kolor == null) kolor = System.Windows.Media.Brushes.Black;
            var mLine = new Line();
            mLine.X1 = wspX1; mLine.Y1 = wspY1;
            mLine.X2 = wspX2; mLine.Y2 = wspY2;
            mLine.Stroke = kolor;
            mLine.StrokeThickness = grubosc;
            cvBg.Children.Add(mLine);
        }

        private void refSwap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            //MessageBox.Show($"A={a}, B={b}");
        }

        private void test3_Click(object sender, RoutedEventArgs e)
        {
            int A = 23, B = 12;
            refSwap(ref A, ref B);
            MessageBox.Show($"A={A}, B={B}");
        }

        private void test4_Click(object sender, RoutedEventArgs e)
        {
            double[,] liczba = new double[5, 3]
            {
                { 1.234, 5.678, 9.012 },
                { 3.456, 7.890, 1.234 },
                { 5.678, 0.123, 4.567 },
                { 7.890, 2.345, 7.890 },
                { 9.012, 4.567, 0.123 }
            };
            double[] sumKol = new double[3];
            for(int i = 0; i < liczba.GetLength(0); i++)
            {
                double sumaWiersza = 0;
                string wiersz = "";
                for(int j= 0; j < liczba.GetLength(1); j++)
                {
                    sumaWiersza += liczba[i, j];
                    wiersz+=string.Format("{0:0.0}", liczba[i,j]).PadLeft(8);
                    wiersz += $" ";
                    sumKol[j] += liczba[i, j];
                }
                wiersz += $" [{sumaWiersza:0.0}]";
                lBox.Items.Add(wiersz);
            }
            string kolRes = "";
            for(int i = 0; i < sumKol.Length; i++)
            {
                kolRes += $"[{sumKol[i]:0.0}]".PadLeft(8);
                kolRes+= $" ";
            }
            lBox.Items.Add(kolRes);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[][] jagged = new int[3][];
            int j = 6;
            for (int i=0; i<3; i++)
            {
                
                jagged[i] = new int[j];
                j--;
                
            }
            j = 6;
            for (int i = 0; i < jagged.Length; i++)
            {
                for(int k = 0; k < j; k++)
                {
                    jagged[i][k] = (i + 1) * (k + 2);
                    j--;
                }
            }
        }
    }
}
