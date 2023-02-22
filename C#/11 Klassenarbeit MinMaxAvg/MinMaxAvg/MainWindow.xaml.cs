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
using System.Globalization;

namespace MinMaxAvg
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

        private void BtnAuswerten_Click(object sender, RoutedEventArgs e)
        {
            /*Aufgabe 1 (17P)
            Sie erhalten von Ihren Geschäftsfilialen im November jeweils eine Liste
            mit Umsatzdaten. Die Datei "Ums2020Berlin.txt" enthält die Daten der
            Filiale Berlin. Diese Datei soll nun von Ihnen ausgewertet werden.
            Gehen Sie folgendermaßen vor:
            - Öffnen Sie die Datei mittels FileStream und StreamReader.
                 Achten Sie auf korrektes Öffnen UND Schließen!
            - Lesen Sie die Zeilen der Datei einzeln ein.
            - Der Dateiname und Pfad darf "hard codiert" werden.
            - Berechnen Sie den durchschnittlichen Monatsumsatz, so wie den Min- und Max-Wert
                über alle 12 Monate.
            - Geben Sie den Monatsumsatz wie in der GUI gezeigt aus.
                Die Teilstrings "Durchschnittlicher Monatsumsatz:" und "€." müssen 
                 in der Ausgabe enthalten sein. Das Rechenergebnis muss nicht gerundet werden.
            - Zu Ihrer Hilfe stehen Ihnen CodeSnippets in der Datei "HilfeCodeSnippets.cs" 
                 zur Verfügung.
              
            Bepunktung: Sauberer Dateizugriff 5P, Codeformatierung 2P, Logik 8P, Ausgabe 2P
            */
            //Bitte hier programmieren:

            //Deklaration der Variablen
            string dateiname;
            string zeile;
            string[] zeilenSplit;
            double umsatz;
            double maxUmsatz;
            double minUmsatz;
            double durchschnittlicherUmsatz;
            double umsatzSummiert;
            int anzahlDerMonate;
            string maxUmsatzAusgabe;
            string minUmsatzAusgabe;
            string durchschnittlicherUmsatzAusgabe;

            //Zugriff auf die Datei herstellen
            dateiname = "Ums2020Berlin.txt";
            FileStream fileStream = new FileStream(dateiname, FileMode.Open);
            StreamReader reader = new StreamReader(fileStream);

            //Anfangswert setzten um  sinnvoll vergleichen zu können
            maxUmsatz = double.MinValue;
            minUmsatz = double.MaxValue;

            //Weitere Variablen werden für die spätere Verwendung initialisiert
            umsatzSummiert = 0;
            anzahlDerMonate = 0;

            //while-Schleife zum auslesen der Zeilen
            while (reader.EndOfStream == false)
            {
                //Zeile aus der Datei einlesen und den Umsatz entnehmen
                zeile = reader.ReadLine();
                zeilenSplit = zeile.Split('#');
                umsatz = Convert.ToDouble(zeilenSplit[0]);

                //Maximaler Umsatz suchen
                if (umsatz > maxUmsatz)
                {
                    maxUmsatz = umsatz;
                }

                //Minimalen Umsatz suchen
                if (umsatz < minUmsatz)
                {
                    minUmsatz = umsatz;
                }

                //Für die Berechung des durchschnittlichen Umsatz die Monate zählen und alle Umsätze addieren
                umsatzSummiert += umsatz;
                anzahlDerMonate++;
            }

            //Berechnung des durchschnittlichen Umsatzes
            durchschnittlicherUmsatz = umsatzSummiert / anzahlDerMonate;

            //Datei wieder schließen
            reader.Close();
            fileStream.Close();

            //Fließkommazahlen explizit in string konvertieren für die Ausgabe auf der Oberfläche
            maxUmsatzAusgabe = Convert.ToString(maxUmsatz);
            minUmsatzAusgabe = Convert.ToString(minUmsatz);
            durchschnittlicherUmsatzAusgabe = Convert.ToString(durchschnittlicherUmsatz);

            //Ausgabe auf der Oberfläche
            lblAusgabe.Content = "Durchschnitt: " + durchschnittlicherUmsatzAusgabe + " € - Max: " + maxUmsatzAusgabe + " € - Min: " + minUmsatzAusgabe + " €";
        }

        //bx: Sehr saubere Umsetzung. Prima!

        /*Aufgabe 2 (3P) - SCRUM
         * Welche drei Fragen muss jedes Teammitglied bei einem Daily-Standup beantworten?
         * 
         * Ihre Antwort:
         *Das Daily-Scrum ist ein tägliches Standup-Meeting um die Kommunikation der Teammitglieder 
         *bestand zu halten. Allerdings sollen möglichst nur die wichtigsten Themen angesprochen werden,
         *wobei die Wahrscheinlichkeit deutlich höher ist, dass sich das Gespräch in die Länge zieht, wenn 
         *man es im sitzen durchführen würde, deshalb Stand-Up.
         *Jedes Mitglied des Entwicklungsteams beantwortet die folgenden drei Fragen:
         *      1. Was habe ich gestern alles geschafft / erledigt?
         *      2. Was möchte ich heute alles erledigen oder umsetzen?
         *      3. Gibt es Hindernisse oder Schwierigkeiten die momentan meine Arbeit beeinträchtigen?
         */


        /* Aufgabe 3 (6P) - SCRUM
         * Erläutern Sie folgende Begriffe in SCRUM:
         * a) DoD (Definition of Done)
         *      Der Product Owner stellt die fachlichen Anforderungen und priorisiert sie. Ebenfalls muss er 
         *      das 'Increment of potentially shipable Functionality', das am Ende eines Sprint entsteht im
         *      Sprint-Review-Meeting überprüfen, ob es in der Art und Weise erledigt wurde, dass es seinen 
         *      Anforderungen entspricht.
         *      Dafür zieht der Product Owner die 'Definition of Done' zu Hand, worin im vorhinein festgelegt wurde,
         *      welche Anforderungen das Produkt Inkrement erfüllen muss, damit es in der Art und Weise umgesetzt wurde
         *      wie es vorgegeben war.
         *      
         * 
         * 
         * b) Sprint
         *      Im Sprint wird das 'Increment of potentially shipable Functionality' entwickelt. 
         *      In diesem Zeitraum, der ca. 2-4 Wochen andauert, arbeitet das Entwicklungsteam 
         *      selbstständig und fokussiert an der Entwicklung des Produktinkrements. 
         *      In diesem Zeitraum dürfen keine weiteren Anforderungen durch den Product Owner an das
         *      Entwicklungsteam gestellt werden. Darauf achtet der Scrum Master. Während des Sprints 
         *      führt das Entwicklungsteam ein tägliches Meeting durch, das Daily-Scrum.
         * 
         * 
         * c) Produktinkrement
         *      Das gesamte Projekt wird in Ausbaustufen nach und nach zusammengestellt. Das macht eine agile
         *      Projektmanagementmanagement aus. Es wird nicht das gesamte Projekt auf einmal geplant und
         *      umgesetzt, sondern Stück für Stück. Dabei kann flexibler auf Marktveränderungen und 
         *      auf weitere Anforderungen der Stakeholder reagiert werden.
         *      Nach einem Sprint, in dem das Projekt umgesetzt wird, sollte ein 'Increment of potentially
         *      shipable Functionality' entstehen. Dies ist ein funktionierender Teil des gesamt Projekts.
         *      Der Scrum-Prozess hat mehrere Sprints und es wird nach einem Sprint, Sprint-Review und der Retrospektive
         *      erneut bei einem Sprint planning begonnen, worin der nächste Sprint geplant wird.
         *      Der Scrum-Prozess läuft solange, bis keine Anforderungen mehr im Product Backlog vorhanden sind,
         *      dabei kann nicht vorhergesagt werden aus wievielen Sprint, und später auch Produktinkrementen, ein
         *      Scrum-Projekt besteht, da dies von der Größe des Projekts abhängig ist.
         *          
         */
    }
}
