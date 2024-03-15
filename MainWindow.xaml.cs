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

namespace lab2kol
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rysujPłot();
            //gr.D @DNiemiec s.2 IPpp
        }

        private void rysujPłot()
        {
            Rectangle rect1= new Rectangle();
            Rectangle rect2= new Rectangle();
            rect1.Width = 610;
            rect1.Height = 25;
            rect1.Fill = Brushes.Black;
            rect2.Width = 610;
            rect2.Height = 25;
            rect2.Fill = Brushes.Black;
            Canvas.SetTop(rect1, 100);
            Canvas.SetTop(rect2, 200);
            cvBg.Children.Add(rect1);
            cvBg.Children.Add(rect2);
            int xPos = 10;

            for (int i = 0; i < 20; i++)
            {
                int w = 20;
                Rectangle rectPion = new Rectangle();
                rectPion.Width = w;
                rectPion.Height = 300;
                rectPion.Fill = Brushes.Black;
                Canvas.SetTop((rectPion), 50);
                Canvas.SetLeft((rectPion), xPos);
                cvBg.Children.Add(rectPion);
                xPos += w+10;

            }

        }
    }
}
