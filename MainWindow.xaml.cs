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
using Microsoft.Data;
using Microsoft.Data.SqlClient;

namespace lab8_DB
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Klaster;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                string nazwa, nrSer;
                byte lRdzeni;
                nazwa = txtName.Text;
                nrSer = txtSerial.Text;
                lRdzeni =Convert.ToByte(txtCores.Text);
                SqlCommand command = new SqlCommand($"INSERT Komputery (Nazwa,NrSeryjny,LiczbaRdzeni) VALUES('{nazwa}','{nrSer}',{lRdzeni})", connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }

        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            int Id =Convert.ToInt32(txtId.Text);
            using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Klaster;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                SqlCommand command = new SqlCommand($"DELETE FROM Komputery WHERE Id={Id}", connection);
                connection.Open();
                command.ExecuteNonQuery();
            }


        }

        private void btnRef_Click(object sender, RoutedEventArgs e)
        {
            using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Klaster;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Komputery", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lbxComputers.Items.Add($"{reader["Id"]}. {reader["Nazwa"]} | {reader["NrSeryjny"]} | {reader["LiczbaRdzeni"]}");
                }
                reader.Close();

                SqlCommand command2 = new SqlCommand("SELECT SUM(LiczbaRdzeni) FROM Komputery", connection);
                int sumOfCores =(int)command2.ExecuteScalar();
                lSumCores.Content = sumOfCores;
                connection.Close();

            }
        }
    }
}
