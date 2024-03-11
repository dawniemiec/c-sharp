using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        private void rysPiramide(int x, int y, int szer, int wys, int ileStopni)
        {
            for (int i = 0; i < ileStopni; i++)
            {
                Rectangle rect = new Rectangle();
                rect.Width = szer;
                rect.Height = wys;
                rect.Fill = Brushes.Black;
                Canvas.SetLeft(rect, y - szer / 2);
                Canvas.SetTop(rect, x);
                cvBg.Children.Add(rect);
                x += wys;
                szer += 30;
            }
        }

        enum kolorDoRozpoczecia
        {
            Czarny = 0,
            Bialy = 1
        }
        private void rysSzach(int kol, int kolorRozp)
        {
            grGrid.Width = 150;
            grGrid.Height = 150;
            for (int i = 0; i < kol; i++)
            {
                grGrid.ColumnDefinitions.Add(new ColumnDefinition());
                grGrid.RowDefinitions.Add(new RowDefinition());
                grGrid.ShowGridLines = true;
            }
            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < kol; j++)
                {
                    bool czyCzarne = (i + j) % 2 == kolorRozp;
                    Rectangle rectangle = new Rectangle();
                    rectangle.Fill = czyCzarne ? System.Windows.Media.Brushes.Black : System.Windows.Media.Brushes.White;
                    Grid.SetColumn(rectangle, i);
                    Grid.SetRow(rectangle, j);
                    grGrid.Children.Add(rectangle);
                }
            }
        }
        public MainWindow()
        {
            InitializeComponent();

            rysPiramide(0, 150, 50, 10, 5);
            rysSzach(5, (int)kolorDoRozpoczecia.Bialy);
            
        }
    }
}
