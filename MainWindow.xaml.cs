using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Linq;
using System.Xml.Serialization;

namespace lab7
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

        Grupa grupa1 = new Grupa()
        {
            Nazwa = "S32",
            Studenci = new List<Student>()
            {
                new Student() {Nazwisko = "Kowalski", Ocena = 4.5},
                new Student() {Nazwisko = "Nowak", Ocena = 3.5},
                new Student() {Nazwisko = "Rak", Ocena = 4},
                new Student() {Nazwisko = "Mak", Ocena = 2.5},
            }
        };

        private void btnMeld_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("C:\\Users\\Student\\Documents\\cs_kolDN\\lab7\\rejestr.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter= new StreamWriter(fs);
            streamWriter.WriteLine(DateTime.Now.ToShortDateString());
            streamWriter.Close();
        }

        private void btnCzyt_Click(object sender, RoutedEventArgs e)
        {
            //FileStream fs = new FileStream("C:\\Users\\Student\\Documents\\cs_kolDN\\lab7\\dane.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader= new StreamReader(@"C:\Users\Student\Documents\cs_kolDN\lab7\dane.txt");
            List<double> data = new List<double>();

            while(streamReader.Peek() != -1) {
                string liczba = streamReader.ReadLine();
                data.Add(Convert.ToDouble(liczba));
            }
            streamReader.Close();
            
            foreach(var liczba in data)
            {

                lbDane.Items.Add($"{liczba:F3}");

            }
            var srednia = data.Average(); //sprawdzac czy jest wiecej niz 0 obiektow w data
            var min = data.Min();
            var max = data.Max();

            lAvg.Content = srednia.ToString();
            lMin.Content = min.ToString();
            lMax.Content = max.ToString();

        }

        private void btnGrupa_Click(object sender, RoutedEventArgs e)
        {
            grupa1.Wyswietl(ref lbGrupa);
        }

        private void btnZapisz_Click(object sender, RoutedEventArgs e)
        {
            
            SaveFileDialog fileDialog= new SaveFileDialog();
            fileDialog.FileName = "grupa.xml";
            fileDialog.Filter = "XML-File | *.xml";
            if (fileDialog.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(fileDialog.FileName, FileMode.Create);
                XmlSerializer serializer = new XmlSerializer(typeof(Grupa));
                serializer.Serialize(fileStream, grupa1);
                fileStream.Close();
            }

        }

        private void btnWczytaj_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.FileName = "grupa.xml";
            fileDialog.Filter = "XML-File | *.xml";
            if (fileDialog.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(fileDialog.FileName, FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(Grupa));
                Grupa nowaGrupa = (Grupa)serializer.Deserialize(fileStream);
                fileStream.Close();
                nowaGrupa.Wyswietl(ref lbGrupa);
            }
            

        }
    }
}
