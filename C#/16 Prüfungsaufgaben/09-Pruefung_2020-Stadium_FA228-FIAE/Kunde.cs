using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Pruefung_2020_Stadium_FA228_FIAE
{
    abstract class Kunde
    {
        //===============================
        // Attribute
        //===============================
        private string name;
        private List<Karte> Karten = new List<Karte>();


        //===============================
        // Konstruktor
        //===============================
        public Kunde(string name)
        {
            this.name = name;
        }


        //===============================
        // Methoden
        //===============================
        public double BerechneKartenPreis()
        {
            double gesamtPreis = 0;

            foreach (Karte karten in Karten)
            {
                gesamtPreis += karten.BerechneKartenPreis();
            }

            return gesamtPreis;
        }

        public void KaufeKarte(double grundPreis, DateTime kaufTag, DateTime spielTag)
        {
            Karte gekaufteKarte = new Karte(grundPreis, kaufTag, spielTag);
            Karten.Add(gekaufteKarte);
        }
    }
}
