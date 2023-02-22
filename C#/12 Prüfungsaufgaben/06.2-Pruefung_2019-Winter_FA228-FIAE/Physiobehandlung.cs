using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._2_Pruefung_2019_Winter_FA228_FIAE
{
    class Physiobehandlung : Behandlung
    {
        //=========================
        // Konstruktor
        //=========================
        public Physiobehandlung()
        {
            //Default-Konstruktor
        }

        public Physiobehandlung(string kvNummer, string beschreibung, double kostensatz) : base(kvNummer, beschreibung, kostensatz)
        {
            //Übergabe an den parameterisierten Konstruktor der Basis-Klasse
        }

        //=========================
        // Methoden
        //=========================
        public override double getKosten()
        {
            return base.getKostensatz() * 1.5;
        }
    }
}
