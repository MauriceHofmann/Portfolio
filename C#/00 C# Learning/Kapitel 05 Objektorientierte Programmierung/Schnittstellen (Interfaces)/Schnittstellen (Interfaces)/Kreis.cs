using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnittstellen__Interfaces_
{
    class Kreis : IAenderbar, ICloneable
    {
        private string farbe;
        private double radius;

        public Kreis(string farbe, double radius)
        {
            this.farbe = farbe;
            this.radius = radius;
        }

        public void Vergroessern(double faktor)
        {
            radius = radius * faktor;
        }

        public void Faerben(string farbe)
        {
            this.farbe = farbe;
        }

        public object Clone()
        {
            Kreis tmp = new Kreis(farbe, radius);
            return tmp;
        }

        public override string ToString()
        {
            return "Farbe: " + farbe + ", Radius: " + radius;
        }
    }
}
