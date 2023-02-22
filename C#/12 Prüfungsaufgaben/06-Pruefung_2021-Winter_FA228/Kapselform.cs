using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Pruefung_2021_Winter_FA228
{
    class Kapselform : Medikamentenform
    {
        //=========================
        // Attribute
        //=========================
        private double gelMengeInG;


        //=========================
        // Konstruktor
        //=========================
        public Kapselform(double gewichtInG, double laengeInMm, double breiteInMm, long id, double gelMengeInG) : base(gewichtInG, laengeInMm, breiteInMm, id)
        {
            this.gelMengeInG = gelMengeInG;
        }


        //=========================
        // Methoden
        //=========================
        public override string wirkstofffreisetzung()
        {
            throw new NotImplementedException();
        }

        #region Getter- und Setter-Methoden
        public double GetGelMengeInG()
        {
            return this.gelMengeInG;
        }
        public void SetGelMengeInG(double getMengeInG)
        {
            this.gelMengeInG = gelMengeInG;
        }
        #endregion
    }
}
