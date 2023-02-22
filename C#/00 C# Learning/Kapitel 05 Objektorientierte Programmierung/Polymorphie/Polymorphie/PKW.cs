using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    class PKW : Fahrzeug
    {
        private int insassen;

        public PKW()
        {
            insassen = 0;
        }

        public PKW(string bezeichnung, int geschwindigkeit, int insassen) : base (bezeichnung, geschwindigkeit)
        {
            this.insassen = insassen;
        }

        public override string ToString()
        {
            return base.ToString() + "Insassen: " + insassen + "\n\n";
        }
    }
}
