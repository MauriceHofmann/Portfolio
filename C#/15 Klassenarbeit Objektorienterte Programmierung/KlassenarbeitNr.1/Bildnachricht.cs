using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenarbeitNr._1
{
    class Bildnachricht : Nachricht
    {
        //===========================
        // Attribute
        //===========================
        private string dateiname;


        //===========================
        // Konstruktoren
        //===========================
        public Bildnachricht()
        {
            //Default-Konstruktor
        }

        public Bildnachricht(string dateiname, Person absender) : base(absender)
        {
            this.dateiname = dateiname;
        }


        //===========================
        // Methoden
        //===========================
        public override string getNachricht()
        {
            string ausgabe = string.Empty;
            ausgabe = base.absender.getVorname() + " " +base.absender.getNachname() + ": " + this.dateiname + "\nAnzahl der Likes: " + base.likes;

            return ausgabe;
        }
    }
}
