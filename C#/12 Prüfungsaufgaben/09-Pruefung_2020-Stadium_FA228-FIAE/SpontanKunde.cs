using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Pruefung_2020_Stadium_FA228_FIAE
{
    class SpontanKunde : Kunde
    {
        //===============================
        // Attribute
        //===============================
        private string email;


        //===============================
        // Konstruktor
        //===============================
        public SpontanKunde(string name, string email) : base(name)
        {
            this.email = email;
        }


        //===============================
        // Methoden
        //===============================
        public double BerechneKartePreis()
        {
            double preis = base.BerechneKartenPreis();

            return preis;
        }
    }
}
