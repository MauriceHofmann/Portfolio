using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    class Fahrzeug
    {
        private string bezeichnung;
        private int geschwindigkeit;

        public Fahrzeug()
        {
            this.bezeichnung = "(leer)";
            this.geschwindigkeit = 0;
        }

        public Fahrzeug(string bezeichnung, int geschwindigkeit)
        {
            this.bezeichnung = bezeichnung;
            this.geschwindigkeit = geschwindigkeit;
        }

        public override string ToString()
        {
            return "Typ: " + GetType() + "\nBezeichnung: " + bezeichnung + "\nGeschwindigkeit: " + geschwindigkeit + "\n\n";
        }
    }
}
