using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._2_Pruefung_2019_Winter_FA228_FIAE
{
    class Patient
    {
        //=========================
        // Attribute
        //=========================
        private string kvNummer;
        private string name;
        private string vorname;


        //=========================
        // Konstruktor
        //=========================
        public Patient()
        {
            //Default-Konstruktor
        }

        public Patient(string kvNummer, string name, string vorname)
        {
            this.kvNummer = kvNummer;
            this.name = name;
            this.vorname = vorname;
        }


        //=========================
        // Methoden
        //=========================
        public string getKvNummer()
        {
            return this.kvNummer;
        }

        public string getName()
        {
            return this.name;
        }

        public string getVorname()
        {
            return this.vorname;
        }
    }
}
