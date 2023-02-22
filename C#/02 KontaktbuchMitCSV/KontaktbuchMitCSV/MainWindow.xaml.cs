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

namespace KontaktbuchMitCSV
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

        //Globale Variablen
        static string filename = Directory.GetCurrentDirectory() + "\\Kontakte.txt";
        static string vorname = string.Empty;
        static string nachname = string.Empty;
        static string telefon = string.Empty;

        //==============================================================================================================================
        //Wenn Programm gestartet wird, werden alle Kontaktdaten aus er Kontakte.txt-Datei entnommen und in die Liste eingefügt
        //Zusätzlich wird ie Liste aktualisiert, wenn ein neuer Kontakt eingefügt wird. => Methode Grid_Loaded wird dann aufgerufen
        //==============================================================================================================================
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                //Zu Beginn muss die Liste gelert werden, da die Kontakte sonst öfters angezeígt werden.
                lstKontakte.Items.Clear();
                //FileStream und StreamReader zum Lesen der Datei
                FileStream fileStream = new FileStream(filename, FileMode.Open);
                StreamReader reader = new StreamReader(fileStream);

                while (reader.EndOfStream == false)
                {
                    //Deklaration der Variablen
                    string zeile;
                    string[] zeilenKomponenten;

                    //Zeile für Zeile einlesen und immer am Trennzeichen (#) splitten um die Atrribute der Kontakte auseinander zu halten
                    zeile = reader.ReadLine();
                    zeilenKomponenten = zeile.Split('#');

                    //Komponenten zuweisen
                    vorname = zeilenKomponenten[0];
                    nachname = zeilenKomponenten[1];
                    telefon = zeilenKomponenten[2];

                    //Liste in der GUI befüllen
                    lstKontakte.Items.Add(vorname + " " + nachname);
                }
                reader.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
           
        }

        //==================================================================================================================================
        //Wenn der Nutzer die Kontaktdaten ansehen will klickt er auf die Liste in der GUI. Jedesmal wird diese Methode dann ausgeführt.
        //Es wird die Kontakt.txt-Datei durchlaufen und nach einer Übereinstimmung gesucht mit dem Vor- und Nachnamen in der Listbox.
        //==================================================================================================================================
        private void lstKontakte_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                //FileStream und StreamReader zum Lesen der Datei
                FileStream fileStream = new FileStream(filename, FileMode.Open);
                StreamReader reader = new StreamReader(fileStream);

                while (reader.EndOfStream == false)
                {
                    //Deklaration der Variablen
                    string zeile;
                    string[] zeilenKomponenten;

                    //Zeile für Zeile einlesen und immer am Trennzeichen (#) splitten um die Atrribute der Kontakte auseinander zu halten
                    zeile = reader.ReadLine();
                    zeilenKomponenten = zeile.Split('#');

                    //Komponenten zuweisen
                    vorname = zeilenKomponenten[0];
                    nachname = zeilenKomponenten[1];
                    telefon = zeilenKomponenten[2];


                    if (Convert.ToString(lstKontakte.SelectedValue) == vorname + " " + nachname)
                    {
                        txtVorname.Text = vorname;
                        txtNachname.Text = nachname;
                        txtTelefon.Text = telefon;
                        break;
                    }
                }
                reader.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //==================================================================================================================================
        //Ein neuer Kontakt soll angelegt werden. Dabei werden die Nutzerausgaben für Vorname, Nachname und Telefonnummer aus der
        //jeweiligen TextBox entnommen und in die Datei Kontakte.txt geschrieben. Anschließend wird die Liste aktualisiert.
        //==================================================================================================================================
        private void btnNeuerKontakt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Neuer FileStream zum Schreiben, da FileMOde.Append benötigt wird, damit die Datei nicht nur geöffnet wird, sondern er auch weis, dass er den 
                //nächsten Eintrag einfach anhängen soll
                FileStream fileStream = new FileStream(filename, FileMode.Append);
                StreamWriter writer = new StreamWriter(fileStream);

                vorname = txtVorname.Text;
                nachname = txtNachname.Text;
                telefon = txtTelefon.Text;

                //Leerzeile einfügen, damit der Writer nicht in der Selben Zeile weiterschreibt
                string speicherungSyntax = vorname + "#" + nachname + "#" + telefon;


                writer.WriteLine(speicherungSyntax);

                writer.Close();
                fileStream.Close();

                Grid_Loaded(sender, e);

                //TextBoxen leeren
                ClearTextBoxes();

                MessageBox.Show(vorname + " " + nachname + " wurde erfolgreich zu Ihren Kontakten hinzugefügt.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //=============================================================================================================================================================
        //Ein bereits bestehender Kontakt soll verändert werden. Dazu wird der ausgewählte Kontakt vorerst aus der Liste entfernt - Wie bei der Löschen-Methode.
        //Anschließend wird der geänderte Kontakt neu angelegt
        //=============================================================================================================================================================
        private void btnBearbeiten_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Zu Beginn wird ein Kontakt gelöscht und im Anschluss neu angelegt
                //Erstellt eine Liste aus der Kontakt.txt-Datei
                List<string> zwischenSpeicherListe = File.ReadAllLines(filename).ToList();

                //Löschen wird nur ausgeführt, wenn die Anzahl der Zeilen in der Liste größer sind als die Nummer der Zeile
                //die gelöscht werden soll => Die Zeile, die gelöscht werden soll, muss schließlich vorhanden sein.
                if (zwischenSpeicherListe.Count >= lstKontakte.SelectedIndex)
                {
                    //Lösche die Zeile, die in der ListBox ausgewählt ist und schreibe anschließend die Datei neu 
                    //anhand der noch vorhanden Zeilen in der Liste.
                    zwischenSpeicherListe.RemoveAt(lstKontakte.SelectedIndex);
                    File.WriteAllLines(filename, zwischenSpeicherListe);

                    btnNeuerKontakt_Click(sender, e);
                    Grid_Loaded(sender, e);
                }

                //TextBoxen leeren
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //=============================================================================================================================================================
        //Der ausgewählte Kontakt soll gelöscht werden. Dazu wird eine neue zwischenspeicher Liste angelegt, und die Person die in der KontaktListe in der GUI
        //ausgewählt ist von der neuen Liste gelöscht. Anschließend wird die Kontakte.txt-Datei neu geschrieben mit den restlichen Namen, die in der zwischenspeicher
        //Liste übrig geblieben sind. Anschließend wird die Liste aktualisiert.
        //=============================================================================================================================================================
        private void btnLoeschen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Erstellt eine zwischenspeicher-Liste aus der Kontakt.txt-Datei
                List<string> zwischenSpeicherListe = File.ReadAllLines(filename).ToList();

                //Löschen wird nur ausgeführt, wenn die Anzahl der Zeilen in der Liste größer sind als die Nummer der Zeile
                //die gelöscht werden soll => Die Zeile, die gelöscht werden soll, muss schließlich vorhanden sein.
                if (zwischenSpeicherListe.Count >= lstKontakte.SelectedIndex)
                {
                    //Lösche die Zeile, die in der ListBox ausgewählt ist und schreibe anschließend die Datei neu 
                    //anhand der noch vorhanden Zeilen in der Liste.
                    zwischenSpeicherListe.RemoveAt(lstKontakte.SelectedIndex);
                    File.WriteAllLines(filename, zwischenSpeicherListe);
                }

                Grid_Loaded(sender, e);

                //TextBoxen leeren
                ClearTextBoxes();

                MessageBox.Show("Kontakt wurde erfolgreich entfernt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearTextBoxes()
        {
            txtVorname.Text = string.Empty;
            txtNachname.Text = string.Empty;
            txtTelefon.Text = string.Empty;
        }
    }
}
