using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_pruefung_1516_lizenzen_Lösung
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde kunde = new Kunde(1, "TestKunde", "Linderstraße", 51352, "Bergisch Neukirschen");
            Einzellizenz einzellizenz = new Einzellizenz(5, "Einzellizenz", 80);
            Volumenlizenz volumenlizenz = new Volumenlizenz(1, 3,"Volumenlizenz", 100);
            Rechnung rechnung = new Rechnung(kunde);

            rechnung.setArtikel(einzellizenz);
            rechnung.setArtikel(volumenlizenz);

            //rechnung.kunde = kunde; //Überflüssig wird im Konstruktor schon zugewiesen

            rechnung.drucken();

            Console.ReadKey();
        }
    }
}
