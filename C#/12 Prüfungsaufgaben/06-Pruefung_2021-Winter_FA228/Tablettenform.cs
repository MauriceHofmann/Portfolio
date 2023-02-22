using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Pruefung_2021_Winter_FA228
{
    class Tablettenform : Medikamentenform
    {
        //=========================
        // Attribute
        //=========================
        private double pulverKoernungInUm;


        //=========================
        // Konstruktor
        //=========================
        public Tablettenform(double gewichtInG, double laengeInMm, double breiteInMm, long id, double pulverKoernung) : base(gewichtInG, laengeInMm, breiteInMm, id)
        {
            this.pulverKoernungInUm = pulverKoernung;
        }


        //=========================
        // Methoden
        //=========================
        public override string wirkstofffreisetzung()
        {
            return "Freisetzung des Wirkstoffes durch Zersetzung der Tablette\nPulverkoernung in Mikrometer: " + pulverKoernungInUm;
        }

        #region Getter- und Setter-Methoden
        public double GetPulverKoernungInUm()
        {
            return this.pulverKoernungInUm;
        }
        public void SetPulverKoernungInUm(double pulverKoernungInUm)
        {
            this.pulverKoernungInUm = pulverKoernungInUm;
        }
        #endregion
    }
}
