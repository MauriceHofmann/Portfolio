using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahlensystemKonverter
{
    class Program
    {
        /// <summary>
        /// Bitte schreiben Sie ein Programm, das dem Nutzer die Möglichkeit bietet eine beliebige, 
        /// vom Nutzer eingegebene Zahl(Dezimalsystem), in ein anderes Zahlensystem umzuwandeln.
        /// </summary>
        static void Main(string[] args)
        {
            //Der Nutzer soll gebeten werden eine Zahl aus dem Dezimalsystem einzugeben, die er konvertieren möchte. 
            Console.WriteLine("ZAHLENSYSTEM-KONVERTER\n");
            Console.WriteLine("Bitte geben Sie eine Zahl aus dem Dezimalsystem ein, die Sie konvertieren möchten.");
            int eingabeDezimalsystemZahl = Convert.ToInt32(Console.ReadLine());

            //Hat der Nutzer eine Zahl aus dem Dezimalsystem eingegeben, kann der Nutzer wählen in welches Zahlensystem er diese konvertieren möchte.
            Console.WriteLine("\nBitte wählen Sie nun das gewünschte Zahlensystem, in welches Sie die soeben eingegebene Zahl konvertieren möchten: \n\t" +
                              "[1] Dezimalsystem \n\t[2] Binärsystem \n\t[3] Hexadezimalsystem");

            string gewuenschtesZahlensystem = Console.ReadLine();
            KonvertiereInZahlensystem(eingabeDezimalsystemZahl, gewuenschtesZahlensystem);
           
            Console.ReadKey();
        }

        //Konvertieren der Dezimalzahl, die der Nutzer zu Beginn eingegeben
        static void KonvertiereInZahlensystem(int dezimalsystemZahl, string gewuenschtesZahlensystem)
        {
            int basis;
            int rechenErgebnis;
            string restwert;
            string ergebnisZahl = string.Empty;

            switch (gewuenschtesZahlensystem)
            {
                //Dezimalsystem
                case "1":
                    ergebnisZahl = Convert.ToString(dezimalsystemZahl);
                    Console.WriteLine(dezimalsystemZahl + " umgewandelt in das Dezimalsystem ergibt " + ergebnisZahl);
                    break;
              

                //Binärsystem
                case "2":
                    basis = 2;      // 0 und 1

                    while (dezimalsystemZahl != 0)
                    {
                        rechenErgebnis = dezimalsystemZahl / basis;
                        restwert = Convert.ToString(dezimalsystemZahl % basis);

                        ergebnisZahl = restwert + ergebnisZahl;

                        dezimalsystemZahl = rechenErgebnis;
                    }
                    Console.WriteLine(dezimalsystemZahl + " umgewandelt in das Binärsystem ergibt " + ergebnisZahl);
                    break;
                    

                //Hexadezimalsystem
                case "3":
                    basis = 16;      //0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A, B, C, D, E, F

                    while (dezimalsystemZahl != 0)
                    {
                        rechenErgebnis = dezimalsystemZahl / basis;
                        restwert = Convert.ToString(dezimalsystemZahl % basis);

                        switch (restwert)
                        {
                            case "0":
                                restwert = "0";
                                break;
                            case "1":
                                restwert = "1";
                                break;
                            case "2":
                                restwert = "2";
                                break;
                            case "3":
                                restwert = "3";
                                break;
                            case "4":
                                restwert = "4";
                                break;
                            case "5":
                                restwert = "5";
                                break;
                            case "6":
                                restwert = "6";
                                break;
                            case "7":
                                restwert = "7";
                                break;
                            case "8":
                                restwert = "8";
                                break;
                            case "9":
                                restwert = "9";
                                break;
                            case "10":
                                restwert = "A";
                                break;
                            case "11":
                                restwert = "B";
                                break;
                            case "12":
                                restwert = "C";
                                break;
                            case "13":
                                restwert = "D";
                                break;
                            case "14":
                                restwert = "E";
                                break;
                            case "15":
                                restwert = "F";
                                break;
                        }
                        ergebnisZahl = restwert + ergebnisZahl;
                        dezimalsystemZahl = rechenErgebnis;
                    }
                    Console.WriteLine(dezimalsystemZahl + " umgewandelt in das Hexadezimalsystem ergibt " + ergebnisZahl);
                    break;
            }
        }
    }
}
