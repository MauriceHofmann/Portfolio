using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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

namespace MaxTemp
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Diese Routine (EventHandler des Buttons Auswerten) liest die Werte
        /// zeilenweise aus der Datei temps.csv aus, merkt sich den höchsten Wert
        /// und gibt diesen auf der Oberfläche aus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAuswerten_Click(object sender, RoutedEventArgs e)
        {
            //Deklaration der Variablen
            string dateiname;
            string zeile;
            string [] zeilenKomponenten;
            double temperatur;
            double maxTemp;
            double minTemp;
            double durchschnittlicheTemp;
            double TemperaturenSummiert;
            int schleifendurchlauefe;

            string maxTempAusgabe;
            string minTempAusgabe;
            string durchschnittlicheTempAusgabe;

            //Zugriff auf Datei erstellen.
            dateiname = "temps.csv";
            FileStream fileStream = new FileStream(dateiname, FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);

            //Variablen initialisieren
            TemperaturenSummiert = 0;
            schleifendurchlauefe = 0;

            //Anfangswert setzen, um sinnvoll vergleichen zu können.
            maxTemp = double.MinValue;
            minTemp = double.MaxValue;

            //In einer Schleife die Werte holen und auswerten. Den größten Wert "merken".
            while (streamReader.EndOfStream == false)
            {
                //Temperatur aus der Zeile der Datei entnommen
                zeile = streamReader.ReadLine();
                zeilenKomponenten = zeile.Split(',');
                temperatur = Convert.ToDouble(zeilenKomponenten[2], CultureInfo.InvariantCulture);

                //Maximale Temperatur berechnen
                if (temperatur > maxTemp)
                {
                    maxTemp = temperatur;
                }

                //Minimale Temperatur berechnen
                if (temperatur < minTemp)
                {
                    minTemp = temperatur;
                }

                //Schleifendurchläufe zählen und Temperaturen summieren um die durchschnittliche Temperatur zu berechnen
                TemperaturenSummiert += temperatur;
                schleifendurchlauefe++;
            }

            //Durchschnittliche Temperatur auswerten
            durchschnittlicheTemp = TemperaturenSummiert / schleifendurchlauefe;

            //Datei wieder freigeben.
            streamReader.Close();
            fileStream.Close();

            //Durchschnittliche Temperatur auf 1 Nachkommastelle runden
            durchschnittlicheTemp = Math.Round(durchschnittlicheTemp, 1);

            //Temperaturen für die Ausgabe in String konvertieren 
            maxTempAusgabe = Convert.ToString(maxTemp);
            minTempAusgabe = Convert.ToString(minTemp);
            durchschnittlicheTempAusgabe = Convert.ToString(durchschnittlicheTemp);


            //Höchstwert auf Oberfläche ausgeben.
            lblAusgabe.Content = maxTempAusgabe + "°C ist die höchste Temperatur\n" +
                                 minTempAusgabe + "°C ist die niedrigste Temperatur\n" +
                                 durchschnittlicheTempAusgabe + "°C ist die durchschnittliche Temperatur";
        }
    }
}
