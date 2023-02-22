using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._2_Pruefung_2019_Winter_FA228_FIAE
{
    abstract class Behandlung
    {
        //=========================
        // Attribute
        //=========================
        private string kvNummer;
        private string beschreibung;
        private double kostensatz;


        //=========================
        // Konstruktor
        //=========================
        public Behandlung()
        {
            //Default-Konstruktor
        }

        public Behandlung(string kvNummer, string beschreibung, double kostensatz)
        {
            this.kvNummer = kvNummer;
            this.beschreibung = beschreibung;
            this.kostensatz = kostensatz;
        }

        //=========================
        // Methoden
        //=========================
        public abstract double getKosten();

        public string getKvNummer()
        {
            return kvNummer;
        }

        public string getBeschreibung()
        {
            return beschreibung;
        }

        public double getKostensatz()
        {
            return kostensatz;
        }
    }
}
