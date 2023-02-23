using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vernam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Chiffriere("Ölkännchen", "geheimcode"));
            Console.ReadKey();
        }

        static string Chiffriere(string klartext, string schluesselwort)
        {
            //Hier kommt die Logik meiner Funktion
            string geheimtext = "";

            //Durch alle Buchstaben
            for (int i = 0; i < klartext.Length; i++)
            {
                //Für den Buchstaben vom klartext den ASCII-Wert berechnen
                char a = klartext[i];
                //Char umgewandelt in int => Automatischer ASCII-Wert (ohne Typecasting)
                int b = a;
                //Console.WriteLine(a);

                //Für den Buchstaben vom Schlüsselwort den ASCII-Wert berechnen
                char c = schluesselwort[i];
                int d = c;
                //Console.WriteLine(d);

                //ASCII-Wert von beiden Werten mit Modulo 256 berechnen und ausgeben
                int asciiNeu = (b + d) % 256;
                //Console.WriteLine(asciiNeu);
                
                geheimtext += (char)asciiNeu;
            }
            return geheimtext;
        }
    }
}
 