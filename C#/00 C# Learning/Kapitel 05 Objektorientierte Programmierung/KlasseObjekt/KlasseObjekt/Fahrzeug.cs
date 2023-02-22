using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseObjekt
{
    class Fahrzeug
    {
        /// <summary>
        /// Die Klassendefinition steht in der Datei Fahrzeug.cs.
        /// Die neue Klasse befindet sich im gleichen Namensraum wie das eigentliche Programm KlasseObjekt.
        /// </summary>
        
        /// Ein Fahrzeug hat die Eigenschaft geschwindigkeit, hier vom Datentyp int.
        /// Eigenschaften  sind meist innerhalb einer Klasse gekapselt. Dies wird durch das Schlüsselwort private gekennzeichnet. Kapselung bedeutet, dass das betreffende Element
        /// von einem Programmteil außerhalb der Klasse aus nicht direkt erreichbar ist. Das ist eines der wichtigsten Konzepte der objektorientierten Programmierung:
        /// Bestimmte Elemente wie z.B. Eigenschaften, sollen nur über definierte Zugänge erreichbar bzw. veränderbar sein. Die Deklatration public int geschwindigkeit würde diesem 
        /// Prinzip der Datenkapselung demnach widersprechen.
        private int geschwindigkeit;

        /// Die Methode Ausgabe() dient zur kommentierten Ausgabe des Werts der Eigsnchaft geschwindigkeit. Daher wird ihrem Namen eine Zeichenkette zugewiesen, die u. a. den Wert
        /// der Eigenschaft beinhaltet. 
        /// Die Methode Ausgabe() wird mit dem Schlüsselwort public öffentlich gemacht d.h. sie ist von einem Programmteil aus erreichbar, der außerhalb der Klasse steht. Soll es
        /// klasseninterne Methoden geben, die nur von anderen Methoden innerhalb der Klasse erreichbar sind, können Sie sie mit dem Schlüsselwort private aber ebenso kapseln wie Eigenschaften.
        public string Ausgabe()
        {
            return "Geschwindigkeit: " + geschwindigkeit;
        }

        /// Die Methode Beschleunigen() soll dazu dienen, den Wert der Eigenschaft geschwindigkeit zu verändern. Beim Aufruf wird der Methode ein (postiver oder negativer) Wert übergeben,
        /// der zu dem bisherigen Wert der Eigenschaft geschwindigkeit hinzuaddiert wird.
        /// Das Schlüsselwort this kennzeichnet dieses Objekt. Später werden verschiedene Objekte der Klasse Fahrzeug erzeugt. Für jedes dieser Objekte kann die Methode Beschleunigen()
        /// aufgerufen werden. in diesem Fall wird genau dieses Objekt beschleunigt. Dieser Zusammenhang wird duech die Benutzung von this noch einmal hervorgehoben, obwohl das nicht unbedingt
        /// notwendig wäre. Auch in der Methode Ausgabe() könnten Sie this.geschwindigkeit schreiben.
        public void Beschleunigen(int wert)
        {
            geschwindigkeit += wert;
            // this.geschwindigkeit += wert;
        }
    }
}
