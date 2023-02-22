using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenarbeitNr._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erzeugen eines sozialen Netzwerkes
            SozialesNetzwerk sozialesNetzwerk = new SozialesNetzwerk();

            //Erzeugen von zwei Personen
            Person michaelHerrmann = new Person("Herrmann", "Michael");
            Person sabineSchulze = new Person("Schulze", "Sabine");

            //Beide Personen dem Netzwerk hinzufügen
            sozialesNetzwerk.hinzufuegenMitglied(michaelHerrmann);
            sozialesNetzwerk.hinzufuegenMitglied(sabineSchulze);

            //Zwei Nachrichten erstellen und jeweils einer Person zuweisen
            Textnachricht textNachrichtMichael = new Textnachricht("Hallo Freunde, ich bin neu hier im Netzwerk! :)", michaelHerrmann);
            Bildnachricht bildNachrichtSabine = new Bildnachricht("Sommerurlaub.png", sabineSchulze);

            //Jede der beiden Nachrichten bekommt ein 'Like'
            textNachrichtMichael.hinzufuegenLike();
            bildNachrichtSabine.hinzufuegenLike();

            //Beide Nachrichten werden dem Netzwerk hinzugefügt
            sozialesNetzwerk.hinzufuegenNachricht(textNachrichtMichael);
            sozialesNetzwerk.hinzufuegenNachricht(bildNachrichtSabine);

            //Ausgabe aller Nachrichten im Netzwerk
            Console.WriteLine(sozialesNetzwerk.getAlleNachrichten());

            //Zur Kontrolle, dass das Konsolenfenster offen bleibt
            Console.ReadKey();
        }
    }
}
