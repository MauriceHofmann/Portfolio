using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace UniversalServer.Model
{
    public delegate EventHandler ErrorEventHandler(string msg);
    public class DBAccess
    {
        //Benötigte Verbindungsinformationen für den ConnectionString um eine Verbindung zur Datenbank aufbauen zu können
        static string ipAdress = "127.0.0.1";
        static string database = "smarthome";
        static string user = "TestUser";
        static string password = "TestUser123";
        static string connectionString = $"SERVER = {ipAdress}; DATABASE = {database}; USER = {user}; PASSWORD = {password}";

        static MySqlConnection connection;
        public DBAccess()
        {
            //Hier die Verbindung zur DB herstellen. Siehe Info-Pool
            //Verbindungsdaten dürfen "hard codiert" werden.
            connection = new MySqlConnection(connectionString);
        }

        ///Diese Methode für den Datensatz in die Datenbank ein. Siehe Info-Pool      
        public void InsertData(TempValue t, HumidValue h, PressureValue p, DateTime dt, string ipa)
        {
            string insertStatement = "INSERT INTO sensorendaten (TempValue, HumidValue, PressureValue, DateTime) VALUES ('" + t.Value.ToString() + "','"+ h.Value.ToString() + "','" + p.Value.ToString() + "','" + dt.ToString("yyyy:MM:dd HH:mm:ss") + "')";

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand();

                command.Connection = connection;
                command.CommandText = insertStatement;

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
