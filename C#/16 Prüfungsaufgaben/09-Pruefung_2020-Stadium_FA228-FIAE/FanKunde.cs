using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Pruefung_2020_Stadium_FA228_FIAE
{
    class FanKunde : Kunde
    {
        //===============================
        // Attribute
        //===============================
        private string clubName;
        private Loge loge;


        //===============================
        // Konstruktor
        //===============================
        public FanKunde(string name, string clubName) : base(name)
        {
            this.clubName = clubName;
        }


        //===============================
        // Methoden
        //===============================
        public double BrechneKartenPreis()
        {
            double preis = base.BerechneKartenPreis();

            preis = preis - preis * 0.3;

            return preis;
        }
    }
}
