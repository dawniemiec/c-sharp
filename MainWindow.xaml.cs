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
using Microsoft.Data;
using Microsoft.Data.SqlClient;

namespace lab8
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

        private void btnWyswietl_Click(object sender, RoutedEventArgs e)
        {
            using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sklepik;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                SqlCommand polecenie = new SqlCommand("SELECT * FROM Towary", connection);
                connection.Open();
                //wielokrotne zapytanie
                SqlDataReader reader = polecenie.ExecuteReader();
                while (reader.Read())
                {
                    lbxDane.Items.Add($"{reader["idTowaru"]}. {reader["Nazwa"]}: {reader["Cena"]:F2} ({reader["Ilosc"]} szt.)");
                }
                reader.Close();

                //pojedyncze wywolanie
                SqlCommand polecenie2 = new SqlCommand("SELECT AVG(Cena) FROM Towary", connection);
                decimal avgPrice =(decimal)polecenie2.ExecuteScalar();
                lblAvgPrice.Content = $"{avgPrice:C}";

                connection.Close();

            }
        }
    }
}