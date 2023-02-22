using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_pruefung_1516_lizenzen_Lösung
{
    class Kunde
    {
        //==========================
        // Attribute
        //==========================
        private int kundennummer;
        private string name;
        private string strasse;
        private int plz;
        private string ort;

        //==========================
        // Konstruktor
        //==========================
        public Kunde(int kundennummer, string name, string strasse, int plz, string ort)
        {
            this.kundennummer = kundennummer;
            this.name = name;
            this.strasse = strasse;

            if(plz > 0 && plz < 100000)
            {
                this.plz = plz;
            }
            else
            {
                this.plz = 99999;
            }

            this.ort = ort;
        }

        //==========================
        // Methoden
        //==========================
        public int getKundennummer(string kundenname)
        {
            return this.kundennummer;
        }

        public string getName()
        {
            return this.name;
        }

        public int getPlz()
        {
            return this.plz;
        }

        public string getOrt()
        {
            return this.ort;
        }

        public string getStrasse()
        {
            return this.strasse;
        }
    }
}
