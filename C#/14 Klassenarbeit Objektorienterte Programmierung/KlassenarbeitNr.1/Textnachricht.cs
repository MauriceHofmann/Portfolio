using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenarbeitNr._1
{
    class Textnachricht : Nachricht
    {
        //===========================
        // Attribute
        //===========================
        private string nachricht;


        //===========================
        // Konstruktoren
        //===========================
        public Textnachricht()
        {
            //Default-Konstruktor
        }

        public Textnachricht(string nachricht, Person absender) : base(absender)
        {
            this.nachricht = nachricht;
        }


        //===========================
        // Methoden
        //===========================
        public override string getNachricht()
        {
            string ausgabe = string.Empty;
            ausgabe = base.absender.getVorname() + " " + base.absender.getNachname() + ": " + this.nachricht + "\nAnzahl der Likes: " + base.likes;

            return ausgabe;
        }
    }
}
