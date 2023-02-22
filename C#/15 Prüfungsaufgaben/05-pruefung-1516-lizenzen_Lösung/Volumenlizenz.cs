using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_pruefung_1516_lizenzen_Lösung
{
    class Volumenlizenz : Artikel
    {
        //==========================
        // Attribute
        //==========================
        private int anzahl;

        //==========================
        // Konstruktor
        //==========================
        public Volumenlizenz(int anzahl, int nummer, string bezeichnung, double preis) : base (nummer, bezeichnung, preis)
        {
            if(anzahl < 10)
            {
                this.anzahl = 10;
            }
            else
            {
                this.anzahl = anzahl;
            }
        }

        //==========================
        // Methoden
        //==========================
        public override double getPreis()
        {
            return this.preis * this.anzahl * 0.90;
        }
    }
}
