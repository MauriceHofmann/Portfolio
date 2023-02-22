using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Pruefung_2020_Stadium_FA228_FIAE
{
    class Karte
    {
        //===============================
        // Attribute
        //===============================
        private double grundPreis;
        private DateTime spielTag;
        private DateTime gekauftAm;


        //===============================
        // Konstruktor
        //===============================
        public Karte(double grundPreis, DateTime kaufTag, DateTime spielTag)
        {
            this.grundPreis = grundPreis;
            this.spielTag = spielTag;
            this.gekauftAm = kaufTag;
        }

        //===============================
        // Methoden
        //===============================
        public double BerechneKartenPreis()
        {
            //Frühbucherrabatt von 10%, wenn die Karte mind. 30 Tage vor Spieltag gekauft wird
            int differenz = (this.spielTag - this.gekauftAm).Days;

            if(differenz >= 30)
            {
                this.grundPreis = this.grundPreis * 0.9;
                return grundPreis;
            }
            else
            {
                return grundPreis;

            }
        }
    }
}
