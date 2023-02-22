using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor
{

    class Fahrzeug
    {
        /// <summary>
        /// Fahrzeuge haben nun zwei Eigenschaften: eine Bezeichnung (mit dem Datentyp string) und eine Geschwindigkeit (mit dem Datentyp int).
        /// Die Zuweisung des Wertes einer Eigenschaft im Konstruktor zählt nicht zu den Wertänderungen. Falls es für die betreffende Eigenschaft keine weiteren Zuweisungen gibt,
        /// wird der Schreibschutz für diese Eigenschaft mithilfe des Attributs readonly empfohlen.
        /// </summary>
        private readonly string bezeichnung;
        private int geschwindigkeit;

        /// <summary>
        /// Es sind vier Konstruktormethoden mit dem Namen Fahrzeug() vereinbart, diese unterscheiden sich in der sogenannten Signatur, d. h. bei der Anzahl und 
        /// den Datentypen der Parameter. Durch diese Unterscheidung kann das Programm bei der Objekterzeugung erkennen, welche der vier Konstruktormethoden 
        /// verwendet werden soll.
        /// Dies wird als Methodenüberladung bezeichnet. Neben der Konstruktormethode können auch andere Methoden auf diese Weise überladen werden. Das ist eine 
        /// recht häufige Vorgehensweise: Sie machen etwas mit dem Objekt, senden dabei bestimmte Daten, und das Objekt weiß aufgrund der Klassendefinition und der 
        /// versschiedenen Methodendefinitionenen, wie es mit den Daten verfahren soll.
        /// </summary>
 

        ///Der erste Konstruktor erwartet eine Zeichenkette und eine ganze Zahl. Beide Eigenschaften werden mit den gewünschten Werten vorbesetzt.
        public Fahrzeug(string _bezeichnung, int _geschwindigkeit)
        {
            bezeichnung = _bezeichnung;
            geschwindigkeit = _geschwindigkeit;        
        }


        /// Der zweite Konstruktor erwartet eine Zeichenkette. Diese wird der Bezeichnung zugewiesen. Die Geschwindigkeit wird mit 0 vorbesetzt.
        public Fahrzeug(string _bezeichnung)
        {
            bezeichnung = _bezeichnung;
            geschwindigkeit = 0;
        }

        /// Analog dazu erwartet der dritte Konstruktor eine ganze Zahl. Diese wird der Geschwindigkeit zugewiesen. Die Bezeichnung wird mit dem Text -leer- vorbesetzt.
        public Fahrzeug(int _geschwindigkeit)
        {
            geschwindigkeit = _geschwindigkeit;
        }

        /// Konstruktoren können sich auch gegenseitig aufrufen. Das sehen Sie beim vierten Konstruktor. Dieser Konstruktor erwartet keine Parameter. Er ruft mithilfe
        /// des Schlüsselwortes this, das immer auf das aktuelle Objekt verweist, den ersten Konstruktor auf, mit dem Text -leer- und der Zahl 0. Der erste Konstruktor
        /// muss bereits vorher definiert sein.
        public Fahrzeug() : this("(leer)", 0)
        {
        }

        /// Jede vordefinierte oder eigene Klasse erbt die Methode ToString() von der Basisklasse object. Die Methode dient zur Ausgabe der Daten eines Objekt als Zeichenkette.
        /// Falls es eine spezifische Methode ToString() innerhalb einer Klasse geben soll, muss die Methode der Basisklasse mit override überschrieben werden. Hier dient ToString()
        /// als Alternative für die Methode Ausgabe()
        /// Falls eine Meethode mithilfe von override als überschreibend gekennzeichnet wird, kann sie eine gleichnamige Methode der Basisklasse überschreiben, die entweder mit virtual,
        /// mit abstract oder selbst mit override gekennzeichnet ist.
        public override string ToString()                       
        {
            return "Bezeichnung: " + bezeichnung + "\n" +
                "Geschwindigkeit: " + geschwindigkeit + "\n";
        }
        public void Beschleunigen(int wert)
        {
            geschwindigkeit += wert;
        }




    }
}
