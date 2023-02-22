using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Pruefung_2020_Stadium_FA228_FIAE
{
    class VIPKunde : Kunde
    {
        //===============================
        // Attribute
        //===============================
        private string telefonnummer;
        private List<VIPKunde> VIPFreunde = new List<VIPKunde>();
        private Loge loge;


        //===============================
        // Konstruktor
        //===============================
        public VIPKunde(string name, string telefonN) : base(name)
        {
            this.telefonnummer = telefonN;
        }

        public VIPKunde(string name, string telefnr, List<VIPKunde> freunde) : base(name)
        {
            this.telefonnummer = telefnr;
            this.VIPFreunde = freunde;
        }

        //===============================
        // Methoden
        //===============================
        public double BerechneKartenPreis()
        {
            double preis = base.BerechneKartenPreis();

            if(VIPFreunde.Count > 1)
            {
                preis = preis - preis * 0.05;
            }

            return preis;
        }
    }
}
