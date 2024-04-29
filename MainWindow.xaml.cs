using Lab8_entity.Models;
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

namespace Lab8_entity
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

        private void btnShowDb_Click(object sender, RoutedEventArgs e)
        {
            var db = new DbUczelnia();

            //foreach (var student in db.Studenci)
            //{
            //    lbxData.Items.Add(student);
            //}

            lbxData.ItemsSource = db.Studenci.ToList();
            lblAvgOcen.Content = db.Studenci.Average(s=>s.Ocena);
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            string imie = txtImie.Text;
            string nazwisko = txtNazwisko.Text;
            byte wiek = Convert.ToByte(txtWiek.Text);
            double? ocena = Convert.ToDouble(txtOcena.Text);

            var db = new DbUczelnia();

            Student student = new Student()
            {Imie = imie, Nazwisko=nazwisko, Wiek=wiek, Ocena=ocena };

            db.Studenci.Add(student);
            db.SaveChanges();

            lbxData.ItemsSource = db.Studenci.ToList();


        }
    }
}