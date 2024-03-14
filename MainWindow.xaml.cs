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

namespace trees
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rysujElipse(0, 0, 100, 100, Brushes.Green);
            rysujKolo(150, 150, 50, Brushes.Black);
            rysujDrzewo(150, 350, 100, 50);
            rysLosSzpalDrzew(290, 0, 300, 0, 150, 0, 100);
            //Line line= new Line();
            //line.X1 = 150;
            //line.X2= 150;
            //line.Y1= 0;
            //line.Y2= 150;
            //line.Stroke= Brushes.Black;
            //line.StrokeThickness= 1;
            //cvBg.Children.Add(line);
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

        public void rysujElipse(double x, double y, double w, double h, SolidColorBrush color)
        {
            Ellipse ellipse = new Ellipse();
            //ellipse.Stroke= color;
            ellipse.Fill= color;
            ellipse.Width = w;
            ellipse.Height= h;
            Canvas.SetTop(ellipse,y);
            Canvas.SetLeft(ellipse,x);
            cvBg.Children.Add(ellipse);
        }
        private void rysujOkrag(double x, double y, double w, double h, SolidColorBrush color)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Stroke= color;
            ellipse.StrokeThickness = 10;
            ellipse.Width = w;
            ellipse.Height = h;
            Canvas.SetTop(ellipse, y);
            Canvas.SetLeft(ellipse, x);
            cvBg.Children.Add(ellipse);
        }

        public void rysujKolo(double x, double y, double r, SolidColorBrush color)
        {
            rysujElipse(x-r, y-r, r*2, r*2, color);
        }
        private void rysujDrzewo(double x, double y, double l, double r)
        {
            RysujLinie(x, x, y, y - l, 10, Brushes.Brown);
            rysujKolo(x, y - l - r, r, Brushes.Green);
            rysujOkrag(x - r, y - l - 2*r, r * 2, r * 2, Brushes.DarkGreen);

        }
        private void rysLosSzpalDrzew(double y, int minP, int maxP, int minPL, int maxPL, int minR, int maxR)
        {
            Random gen = new Random();
            cvBg.Children.Clear();
            for(int i=0; i<4; i++)
            {
                double x = gen.Next(minP, maxP);
                double l = gen.Next(minPL, maxPL);
                double r = gen.Next(minR, maxR);
                rysujDrzewo(x, y, l, r);
            }
        }
    }
}
