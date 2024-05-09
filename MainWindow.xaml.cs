using lab8_DBEF.Models;
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

namespace lab8_DBEF
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

        private void btnRef_Click(object sender, RoutedEventArgs e)
        {
            var db = new DbAeroklub();
            lbxData.ItemsSource = db.Samoloty.ToList();
            lAvgPulap.Content = db.Samoloty.Average(s=>s.Pulap);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var db = new DbAeroklub();
            string producent = txtProd.Text;
            string model = txtModel.Text;
            double predk = Convert.ToDouble(txtPredkosc.Text);
            double pul = Convert.ToDouble(txtPulap.Text);
            double udzwig = Convert.ToDouble(txtUdzwig.Text);

            Samolot samolot = new Samolot() { Producent = producent, Model = model, Predkosc = predk, Pulap = pul, Udzwig = udzwig };
            db.Samoloty.Add(samolot);
            db.SaveChanges();
            lbxData.ItemsSource = db.Samoloty.ToList();

        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var db = new DbAeroklub();
            int id = Convert.ToInt32(txtId.Text);
            var samolot = db.Samoloty.Find(id);
            if (samolot != null)
            {
                db.Remove(samolot);
                db.SaveChanges();
                lbxData.ItemsSource = db.Samoloty.ToList();


            }

        }
    }
}