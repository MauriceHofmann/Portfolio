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

namespace VernamWPF
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

        //Diese Methode verschlüsselt einen Klartext mithilfe eines Schlüsselwortes in einen Geheimtext.
        //Hierfür wird das Schema der Verschlüsselung nach Vernam verwendet.
        static string Chiffriere(string klartext, string schluesselwort)
        {
            string geheimtext = "";

            for (int i = 0; i < klartext.Length; i++)
            {
                //ASCII-Wert von jeweils einem Buchstabe des Klartext
                char buchstabeKlartext = klartext[i];
                int ASCIIKlartext = buchstabeKlartext;

                //ASCII-Wert von jeweils einem Buchstabe des Schlüsselwortes
                char buchstabeSchluesselwort = schluesselwort[i];
                int ASCIISchluesselwort = buchstabeSchluesselwort;

                //Berechnung des ASCII-Wertes aus der Summe von Klartext und Schlüsselwort Modulo 256
                int ASCII = (ASCIIKlartext + ASCIISchluesselwort) % 256;

                //Zeichen von ASCI-Wert wählen und aneinanderketten
                geheimtext += Convert.ToChar(ASCII);
            }
            //Verschlüsselter Geheimtext (Folge von Zeichen) zurück ans Hauptprogramm senden
            return geheimtext;
        }

        //Diese Methode liest den Klartext und das Schlüsselwort, welche der Nutzer zuvor angegeben hat und gibt es,
        //nachdem es verschlüsselt wurde, auf der Oberfläche aus.
        private void btnVerschluesseln_Click(object sender, RoutedEventArgs e)
        {
            //Dekklaration und Initialisierung von Variablen 
            string geheimtext;
            string klartext = txtKlartext.Text;
            string schluesselwort = txtSchluesselwort.Password;

            //Methoden-Aufruf mit den Parametern des vom Nutzer eingetragenen Klartexts und des Schlüsselwortes
            geheimtext = Chiffriere(klartext, schluesselwort);

            //Ausgabe des Geheimtexts auf der Oberfläche
            txtAusgabe.Text = geheimtext;
        }

        //Diese Methode beendet die Anwendung sobald der Nutzer auf den Button 'Beenden' klickt.
        private void btnBeenden_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
