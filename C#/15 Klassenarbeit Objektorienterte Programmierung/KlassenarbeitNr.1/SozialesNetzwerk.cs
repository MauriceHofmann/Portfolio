using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenarbeitNr._1
{
    class SozialesNetzwerk
    {
        //===========================
        // Attribute
        //===========================
        private List<Person> mitgliederliste = new List<Person>();
        private List<Nachricht> nachrichtenliste = new List<Nachricht>();


        //===========================
        // Methoden
        //===========================
        public void hinzufuegenMitglied(Person person)
        {
            mitgliederliste.Add(person);
        }

        public void hinzufuegenNachricht(Nachricht nachricht)
        {
            nachrichtenliste.Add(nachricht);
        }

        public string getAlleNachrichten()
        {
            string alleNachrichten = string.Empty;

            foreach(Nachricht nachricht in nachrichtenliste)
            {
                alleNachrichten += nachricht.getNachricht() + "\n\n";
            }

            return alleNachrichten;
        }
    }
}