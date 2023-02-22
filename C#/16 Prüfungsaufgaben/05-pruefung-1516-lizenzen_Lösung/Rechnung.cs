using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_pruefung_1516_lizenzen_Lösung
{
    class Rechnung
    {
        //==========================
        // Konstruktor
        //==========================
        private Kunde kunde;
        private List<Artikel> artikelliste = new List<Artikel>();

        //==========================
        // Konstruktor
        //==========================
        public Rechnung(Kunde kunde)
        {
            this.kunde = kunde;
        }

        //==========================
        // Methoden
        //==========================
        public double getGesamtbetrag()
        {
            double summe = 0;

            foreach(Artikel artikel in artikelliste)
            {
                summe += artikel.getPreis();
            }

            return summe;
        }

        public void setArtikel(Artikel artikel)
        {
            artikelliste.Add(artikel);
        }

        public void drucken()
        {
            Console.WriteLine("KUNDENDATEN:");
            Console.WriteLine($"Kunden-Nr: {kunde.getKundennummer(kunde.getName())} \nName: {kunde.getName()} \nStrasse: {kunde.getStrasse()} \nPLZ: {kunde.getPlz()} \nOrt: {kunde.getOrt()}");
            
            Console.WriteLine("\nArtikelliste:");
            Console.WriteLine("---------------------------------------------------");
            foreach(Artikel artikel in artikelliste)
            {
                Console.WriteLine("Bezeichnung: " + artikel.getBezeichnung());
                Console.WriteLine("Artikel-Nr: " + artikel.getNummer());
                Console.WriteLine("Preis: " + artikel.getPreis());
                Console.WriteLine("---------------------------------------------------");
            }

            Console.WriteLine("____________________________________");
            Console.WriteLine("Gesamtbetrag: " + getGesamtbetrag());
        }
    }
}