using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_pruefung_1516_lizenzen_Lösung
{
    abstract class Artikel
    {
        //==========================
        // Attribute
        //==========================
        private int nummer;
        private string bezeichnung;
        protected double preis;


        //==========================
        // Konstruktor
        //==========================
        public Artikel(int nummer, string bezeichnung, double preis)
        {
            this.nummer = nummer;
            this.bezeichnung = bezeichnung;
            this.preis = preis;
        }

        //==========================
        // Methoden
        //==========================
        public int getNummer()
        {
            return this.nummer;
        }

        public string getBezeichnung()
        {
            return this.bezeichnung;
        }

        public abstract double getPreis();
    }
}
