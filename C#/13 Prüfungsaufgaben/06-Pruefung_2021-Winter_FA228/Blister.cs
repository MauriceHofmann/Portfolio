using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Pruefung_2021_Winter_FA228
{
    class Blister
    {
        //=========================
        // Attribute
        //=========================
        private int anzahlMulden;
        private int anzahlReihen;
        private int anzahlSpalten;
        private int anzahlMedikamente;
        private bool[,] bestandInfo;
        private long id;

        private List<Medikament> medikamente;


        //=========================
        // Konstruktor
        //=========================
        public Blister(int anzahlReihen, int anzahlSpalten, long id, Medikament[] produzierteMedikamente)
        {
            this.anzahlReihen = anzahlReihen;
            this.anzahlSpalten = anzahlSpalten;
            this.anzahlMulden = anzahlReihen * anzahlSpalten;
            this.medikamente = new List<Medikament>();
            this.id = id;

            //Die produzierten Medikamente werden in die Liste der eigenen Medikamente
            //aufgenommen. Beschränkt wird die Aufnahme duch die Anzahl der Mulden im Blister.

            for (int i = 0; i < anzahlMulden; i++)
            {
                medikamente.Add(produzierteMedikamente[i]);
            }

            //Blister voll
            this.bestandInfo = new bool[anzahlReihen, anzahlSpalten];

            for (int indexReihe = 0; indexReihe < anzahlReihen; indexReihe++)
            {
                for (int indexSpalte = 0; indexSpalte < anzahlSpalten; indexSpalte++)
                {
                        bestandInfo[indexReihe, indexSpalte] = true;
                }
            }

            this.anzahlMedikamente = medikamente.Count;
        }


        //=========================
        // Methoden
        //=========================
        public bool entnehmen(int indexReihe, int indexSpalte)
        {
            if(bestandInfo[indexReihe -1, indexSpalte -1 ] == true)
            {
                bestandInfo[indexReihe -1, indexSpalte -1] = false;
                medikamente.RemoveAt(medikamente.Count -1);
                anzahlMedikamente = medikamente.Count();        //oder anzahlMedikamente --;

                return true;
            }
            else
            {
                return false;
            }
        }

        public void druckeBestandInfo()
        {
            for (int indexReihe = 0; indexReihe < anzahlReihen; indexReihe++)
            {
                for (int indexSpalte = 0; indexSpalte < anzahlSpalten; indexSpalte++)
                {
                    if (bestandInfo[indexReihe, indexSpalte] == false)
                    {
                        Console.Write(" X ");
                    }
                    else if (bestandInfo[indexReihe,indexSpalte] == true)
                    {
                        Console.Write(" O ");
                    }
                }
                Console.WriteLine();
            }
            
        }

        #region Getter- und Setter-Methoden
        public int GetAnzahlMulden()
        {
            return this.anzahlMulden;
        }
        public void SetAnzahlMulden(int anzahlMulden)
        {
            this.anzahlMulden = anzahlMulden;
        }

        public int GetAnzahlReihen()
        {
            return this.anzahlReihen;
        }
        public void SetAnzahlReihen(int anzahlReihen)
        {
            this.anzahlReihen = anzahlReihen;
        }

        public int GetAnzahlSpalten()
        {
            return this.anzahlSpalten;
        }
        public void SetAnzahlSpalten(int anzahlSpalten)
        {
            this.anzahlSpalten = anzahlSpalten;
        }

        public int GetAnzahlMedikamente()
        {
            return this.anzahlMedikamente;
        }
        public void SetAnzahlMedikamente(int anzahlMedikamente)
        {
            this.anzahlMedikamente = anzahlMedikamente;
        }

        public bool[,] GetBestandInfo()
        {
            return this.bestandInfo;
        }
        public void SetBestandInfo(bool[,] bestandInfo)
        {
            this.bestandInfo = bestandInfo;
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
