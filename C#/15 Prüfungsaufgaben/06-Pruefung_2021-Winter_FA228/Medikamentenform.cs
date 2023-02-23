using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Pruefung_2021_Winter_FA228
{
    abstract class Medikamentenform
    {
        //=========================
        // Attribute
        //=========================
        private double gewichtInG;
        private double laengeInMm;
        private double breiteInMm;
        private long id;


        //=========================
        // Konstruktor
        //=========================
        public Medikamentenform(double gewichtInG, double laengeInMm, double breiteInMm, long id)
        {
            this.gewichtInG = gewichtInG;
            this.laengeInMm = laengeInMm;
            this.breiteInMm = breiteInMm;
            this.id = id;
        }


        //=========================
        // Methoden
        //=========================
        public abstract string wirkstofffreisetzung();

        #region Getter- und Setter-Methoden
        public double GetGewichtInG()
        {
            return this.gewichtInG;
        }
        public void SetGewichtInG(double gewichtInG)
        {
            this.gewichtInG = gewichtInG;
        }

        public double GetLaengeInMm()
        {
            return this.laengeInMm;
        }
        public void SetLaengeInMm(double laengeInMm)
        {
            this.laengeInMm = laengeInMm;
        }

        public double GetBreiteInMm()
        {
            return this.breiteInMm;
        }
        public void SetBreiteInMm(double breiteInMm)
        {
            this.breiteInMm = breiteInMm;
        }

        public long GetId()
        {
            return this.id;
        }
        public void SetId(long id)
        {
            this.id = id;
        }
        #endregion
    }
}