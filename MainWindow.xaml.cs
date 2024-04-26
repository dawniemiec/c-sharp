using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
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

namespace lab7dom
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

        private void SerialJSON_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog fileDialog= new SaveFileDialog();
            fileDialog.FileName= "Grupa.json";
            
            if(fileDialog.ShowDialog() == true)
            {
                string json = JsonSerializer.Serialize<Grupa>(grupa1);
                File.WriteAllTextAsync(fileDialog.FileName,json);
            }
        }

        private void DesJson_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog= new OpenFileDialog();
            if(fileDialog.ShowDialog() == true)
            {
                string jsonToDeserialize = File.ReadAllText(fileDialog.FileName);
                Grupa nowa = JsonSerializer.Deserialize<Grupa>(jsonToDeserialize);
            }
        }

        private void Zapisz_Click(object sender, RoutedEventArgs e)
        {
            grupa1.ZapiszDoPliku("plikgrupy.txt");
        }

        private void PlikBmp_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog= new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.bmp";
            if(fileDialog.ShowDialog() == true)
            {
                

                var stream = File.Open(fileDialog.FileName,FileMode.Open,FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(stream);
                binaryReader.ReadBytes(18);
          
                int szerr = binaryReader.ReadInt32();
                int wyss = binaryReader.ReadInt32();
                binaryReader.ReadBytes(2);
                int kol = binaryReader.ReadInt16();
                //byte[] kol = binaryReader.ReadBytes(2);

                szer.Content = szerr;
                wys.Content = wyss;
                kolory.Content = kol;

                binaryReader.Dispose();

                BitmapImage bitmapImage = new BitmapImage(new Uri(fileDialog.FileName));
                img.Source = bitmapImage;

            }

        }
    }
}
