using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankautomat
{
    public class Konto
    {
        //Variablen
        //public string vorname { get; set; }
        public string vorname;
        public string nachname;
        public double kontostand;
        public string pin;

        //Konstruktor
        public Konto()
        {
            vorname = "";
            nachname = "";
            kontostand = 0;
            pin = "";
        }

        public Konto(string _vorname, string _nachname, string _pin)
        {
            vorname = _vorname;
            nachname = _nachname;
            pin = _pin;
        }

        public static Konto aktuellerKontoNutzer = new Konto();

        //Funktionen
        public double Einzahlen(double einzahlungsBetrag)
        {
            kontostand = Convert.ToDouble(Konto.aktuellerKontoNutzer.kontostand);
            double neuerKontostand = kontostand + einzahlungsBetrag;
            return Math.Round(neuerKontostand, 2);
        }

        public double Auszahlen(double auszahlungsBetrag)
        {
            kontostand = Convert.ToDouble(Konto.aktuellerKontoNutzer.kontostand);
            double neuerKontostand = kontostand - auszahlungsBetrag;
            return Math.Round(neuerKontostand, 2);
        }

        public double KontostandAbfragen()
        {
            kontostand = Convert.ToDouble(Konto.aktuellerKontoNutzer.kontostand);
            return Math.Round(kontostand, 2);
        }
    }
}