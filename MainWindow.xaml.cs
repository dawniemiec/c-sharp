using Generyki;
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

namespace lab5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var studenci = new Dictionary<int, Student>()
            {
                {10223, new Student{Nazwisko = "Nowak", Ocena = 4.0 } },
                {23768, new Student{Nazwisko = "Kowalski", Ocena = 4.6 } },
                {30568, new Student{Nazwisko = "Maj", Ocena = 5.0 } },
                {10101, new Student{Nazwisko = "Rak", Ocena = 3.0 } }
            };
        }
        void InfoErr(string message)
        {
            MessageBox.Show(message);
        }
        void InfoErrLbl(string message)
        {
            lblError.Content = message;
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            Stozek st1 = new Stozek();
            st1.Zdarzenie += InfoErr;
            st1.Zdarzenie += InfoErrLbl;
            st1.Promien = Convert.ToDouble(txtProm.Text);
            st1.Wysokosc = Convert.ToDouble(txtWys.Text);
            

        }

        private void btnTest2_Click(object sender, RoutedEventArgs e)
        {
            string s1, s2;
            s1 = "str1";
            s2 = "str2";
            Statyczna.ZnajdzWiekszy(s1,s2);

            double a, b;
            a = 6.89;
            b = 100.22;
            Statyczna.ZnajdzWiekszy(a, b);



        }

        private void btReg_Click(object sender, RoutedEventArgs e)
        {
            Regal<double> reg1 = new Regal<double>();
            Regal<Student> reg2 = new Regal<Student>();
            reg1.Polka1 = 65.4;
            reg1.WolnaPolka = 45.6;
            reg1.WstawNaWolnaPolka(67.8);

            Student st1= new Student();
            Student st2= new Student();
            Student st3= new Student();
            reg2.Polka1 = st3;
            reg2.WstawNaWolnaPolka(st1);
            reg2.WolnaPolka = st2;
        }
    }
}
