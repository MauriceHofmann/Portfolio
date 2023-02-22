using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//Vorher die dll "MySql.´Data.dll" zu den Verweisen hinzufügen, dann kann man auf den Namespace verweisen.

/// <summary>
/// MessageBox, wenn eine Methode erfolgreich ausgeführt wurde
/// TextBoxen müssen gefüllt sein um eine neuen Kontakt anzulegen
/// </summary>

namespace KontaktbuchMitDatenbank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Verbindung zur Datenbank
        //In einem sog. Connection-String werden die nötigen Verbindungsinformationen angegeben
        static string ipAdresse = "";
        static string datenbankName = "kontakte";
        static string user = "";
        static string passwort = "";

        static string connectionString = $"SERVER = {ipAdresse}; DATABASE = {datenbankName};USER ID = {user}; PASSWORD = {passwort};";

        MySqlConnection connection = new MySqlConnection(connectionString);

        //=======================================================
        //Diese Methode fügt Datensätze in die Datenbank ein
        //=======================================================
        private void btnErstellen_Click(object sender, EventArgs e)
        {
            try
            {
                //Daten aus den Texboxen lesen
                string vorname = txtBoxVorname.Text;
                string nachname = txtBoxNachname.Text;
                string telefonnummer = txtBoxTelefonnummer.Text;

                //Verbindung zur Datenbank - Nachdem die Zugangsdaten gesetzt wurden, kann der "Kanal" zur Datenbank geöffnet werden
                connection.Open();

                //SQl-Statement um ein Datensatz in die Tabelle zu speichern wird in einer String-Variable gespeichert. Dieser SQL-Befehl wird an die Datenbank gesendet
                string insertStatement = "INSERT INTO kontakte (vorname, nachname, telefonnummer) VALUES ('" + vorname + "', '" + nachname + "', '" + telefonnummer + "');";
                //MessageBox.Show(insertStatement);

                //Damit der MySQL-Server das SQL-Statement verarbeiten kann, muss es in ein MySqlCommand-Objekt umgewandelt werden.
                MySqlCommand command = new MySqlCommand();

                //Der Command benötigt allerdings noch den CommandText, was hier dem InsertStatement entspricht und  die Connection, damit er weiß, welche Verbindung er zum Datenbank-Server verwenden soll.
                command.CommandText = insertStatement;
                command.Connection = connection;

                //Die Folgende Methode der Kommand-Klasse führt nun den Befehl aus
                command.ExecuteNonQuery();

                //Die Verbindung zur Datenbank muss nun noch geschlossen werden
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //=======================================================
        //Diese Methode bearbeitet Datensätze aus der Datenbank
        //=======================================================
        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            //Alte Werte des Kontaktes zum Abgleich
            string kontakt = Convert.ToString(lstBoxKontakte.SelectedItem);
            string[] kontaktSplit = kontakt.Split(' ');
            string vornameAlt = kontaktSplit[0];
            string nachnameAlt = kontaktSplit[1];
            
            //Neue Werte des Kontaktes, die der Nutzer in der TextBox ändert
            string vorname = txtBoxVorname.Text;
            string nachname = txtBoxNachname.Text;
            string telefonnummer = txtBoxTelefonnummer.Text;

            connection.Open();

            string updateStatement = "UPDATE kontakte SET Vorname = '" + vorname + "', Nachname = '" + nachname + "', Telefonnummer = '" + telefonnummer + "' WHERE Vorname = '" + vornameAlt + "' AND Nachname = '" + nachnameAlt + "'";

            MySqlCommand command = new MySqlCommand();

            command.CommandText = updateStatement;
            command.Connection = connection;

            command.ExecuteNonQuery();

            connection.Close();
        }

        //=======================================================
        //Diese Methode löscht Datensätze aus der Datenbank
        //=======================================================
        private void btnLoeschen_Click(object sender, EventArgs e)
        {    
            try
            {
                string vorname = txtBoxVorname.Text;
                string nachname = txtBoxNachname.Text;

                connection.Open();

                string deleteStatement = "DELETE FROM kontakte WHERE Vorname = '" + vorname + "' AND Nachname = '" + nachname + "'";

                MySqlCommand command = new MySqlCommand();

                command.CommandText = deleteStatement;
                command.Connection = connection;

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //=======================================================
        //Diese Methode liefert alle Datensätze aus der Datenbank
        //=======================================================
        private void btnLaden_Click(object sender, EventArgs e)
        {
            //Löscht alle Kontakte aus der Liste, da bei mehrfachem Ausführen die Kontakte nicht häufig angezeigt, sondern immer neu geladen werden
            lstBoxKontakte.Items.Clear();
            try
            {
                connection.Open();

                string selectStatement = "SELECT * FROM kontakte";

                MySqlCommand command = new MySqlCommand();

                command.CommandText = selectStatement;
                command.Connection = connection;

                //Reader wird benötigt, um Daten aus der Datenbank zu lesen
                MySqlDataReader reader;
                reader = command.ExecuteReader();

                //Ausgabe in der ListBox
                while (reader.Read())
                {
                    lstBoxKontakte.Items.Add(reader["vorname"] + " " + reader["nachname"]);
                }

                reader.Close();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //=======================================================
        //Diese Methode zeigt Datensatzwerte in der TextBox an
        //=======================================================
        private void lstBoxKontakte_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Variablen initialisieren
                string vorname = string.Empty;
                string nachname = string.Empty;
                string telefonnummer = string.Empty;

                //ListBoxItem splitten in Vor- und Nachname
                string kontakt = Convert.ToString(lstBoxKontakte.SelectedItem);
                string[] kontaktSplit = kontakt.Split(' ');
                vorname = kontaktSplit[0];
                nachname = kontaktSplit[1];

                connection.Open();

                string bringContact = "SELECT * FROM kontakte WHERE Vorname = '" + vorname + "' AND Nachname = '" + nachname + "'";

                MySqlCommand command = new MySqlCommand();

                command.CommandText = bringContact;
                command.Connection = connection;

                MySqlDataReader reader;
                reader = command.ExecuteReader();

                //Vor-, Nachname und Telefonnummer werden hier vom übereinstimmenden Kontakt geliefert und in die Variablen gespeichert.
                while (reader.Read())
                {
                    vorname = Convert.ToString(reader["Vorname"]);
                    nachname = Convert.ToString(reader["Nachname"]);
                    telefonnummer = Convert.ToString(reader["Telefonnummer"]);
                }

                reader.Close();
                connection.Close();

                //Gelieferte Werte eines Kontaktes in die Datenbank schreiben
                txtBoxVorname.Text = vorname;
                txtBoxNachname.Text = nachname;
                txtBoxTelefonnummer.Text = telefonnummer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSuchen_TextChanged(object sender, EventArgs e)
        {
            lstBoxKontakte.Items.Clear();
            try
            {
                string eingabe = txtSuchen.Text;
                string selectLikeStatement = "SELECT * FROM kontakte WHERE Vorname LIKE '" + eingabe + "%' OR Nachname LIKE '" + eingabe + "%'";

                connection.Open();

                MySqlCommand command = new MySqlCommand();
                MySqlDataReader reader;

                command.Connection = connection;
                command.CommandText = selectLikeStatement;

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lstBoxKontakte.Items.Add(reader["vorname"] + " " + reader["nachname"]);
                }
                reader.Close();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
