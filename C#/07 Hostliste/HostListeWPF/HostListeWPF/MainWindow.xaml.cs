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
using System.IO;

namespace HostListeWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string zeile;

        public MainWindow()
        {
            InitializeComponent();
        }

        //Diese Methode importiert eine Datei und zeigt sie auf der Oberfläche
        private void btnImport_Click(object sender, RoutedEventArgs e)
        {
            //Zugriff auf Datei 'Rechnerliste.csv' erstellen
            string dateinameRechnerliste = @"Rechnerliste.csv";
            FileStream fileStreamRechnerliste = new FileStream(dateinameRechnerliste, FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStreamRechnerliste);

            while (streamReader.EndOfStream == false)
            {
                zeile = streamReader.ReadLine();
                txtAusgabe.Text += zeile + "\n";
            }
        }

        //Diese Methode erstellt eine neue Datei
        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            //Zugriff auf Datei 'Rechnerliste.csv' erstellen
            string dateinameRechnerliste = @"Rechnerliste.csv";
            FileStream fileStreamRechnerliste = new FileStream(dateinameRechnerliste, FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStreamRechnerliste);

            string dateinameHostliste = "Hostliste.txt";
            FileStream fileStreamHostliste = new FileStream(dateinameHostliste, FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fileStreamHostliste);

            //Deklaration der Variablen
            string zeile;
            string[] zeilenkomponente;
            string mac;
            string raumnummer;
            string rechnernummer;
            string adressbereich = "10.16.";
            string MacIP;

            //Mit Schleife jede Adresse umwandeln
            while (!streamReader.EndOfStream)
            {
                // Zeile für Zeile einlesen
                zeile = streamReader.ReadLine();

                //Zeilenkomponenten speichern
                zeilenkomponente = zeile.Split(';');
                mac = zeilenkomponente[0];
                raumnummer = zeilenkomponente[1];
                rechnernummer = zeilenkomponente[2];

                //MacIP bilden
                MacIP = mac + ";" + adressbereich + raumnummer + "." + rechnernummer + ";";
                
                //MacIP in Datei schreiben
                streamWriter.WriteLine(MacIP);     
            }

            //StreamReader schließen
            streamReader.Close();
            fileStreamRechnerliste.Close();

            //StreamWriter schließen
            streamWriter.Close();
            fileStreamHostliste.Close();

            MessageBox.Show("Datei wurde erfolgreich exportiert");
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtAusgabe.Clear();
        }

        private void btnBeenden_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
