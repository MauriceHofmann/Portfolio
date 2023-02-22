using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenarbeitNr._1
{
    class Person
    {
        //===========================
        // Attribute
        //===========================
        private string nachname;
        private string vorname;


        //===========================
        // Konstruktoren
        //===========================
        public Person()
        {
            //Default-Konstruktor
        }

        public Person(string nn, string vn)
        {
            this.nachname = nn;
            this.vorname = vn;
        }


        //===========================
        // Methoden
        //===========================
        public string getNachname()
        {
            return this.nachname;
        }

        public string getVorname()
        {
            return this.vorname;
        }
    }
}