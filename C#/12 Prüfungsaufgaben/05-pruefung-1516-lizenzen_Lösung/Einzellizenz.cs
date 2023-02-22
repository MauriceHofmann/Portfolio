using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_pruefung_1516_lizenzen_Lösung
{
    class Einzellizenz : Artikel
    {
        //==========================
        // Konstruktor
        //==========================
        public Einzellizenz(int nummer, string bezeichnung, double preis) : base(nummer, bezeichnung, preis)
        {
        }

        //==========================
        // Methoden
        //==========================
        public override double getPreis()
        {
             return base.preis * 1.10;
        }
    }
}
