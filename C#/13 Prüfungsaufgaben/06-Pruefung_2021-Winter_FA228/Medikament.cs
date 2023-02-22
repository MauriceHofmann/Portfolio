using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Pruefung_2021_Winter_FA228
{
    class Medikament
    {
        //=========================
        // Attribute
        //=========================

        private string haltbarkeitsdatum;
        private string name;
        private string wirksamkeit;
        private long id;

        private Medikamentenform arzneiForm;


        //=========================
        // Konstruktor
        //=========================
        public Medikament(string haltbarkeitsdatum, string name, string wirksamkeit, Medikamentenform formInfos)
        {
            this.haltbarkeitsdatum = haltbarkeitsdatum;
            this.name = name;
            this.wirksamkeit = wirksamkeit;
            this.arzneiForm = formInfos;
        }

        //=========================
        // Methoden
        //=========================
        #region Getter- und Setter-Methoden
        public string GetHaltbarkeitsdatum()
        {
            return this.haltbarkeitsdatum;
        }
        public void SetHaltbarkeitsdatum(string haltbarkeitsdatum)
        {
            this.haltbarkeitsdatum = haltbarkeitsdatum;
        }

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetWirksamkeit()
        {
            return this.wirksamkeit;
        }
        public void SetWirksamkeit(string wirksamkeit)
        {
            this.wirksamkeit = wirksamkeit;
        }

        public long GetId()
        {
            return this.id;
        }
        public void SetId(long id)
        {
            this.id = id;
        }

        public Medikamentenform GetArzneiForm()
        {
            return this.arzneiForm;
        }
        public void SetArzneiForm(Medikamentenform arzneiForm)
        {
            this.arzneiForm = arzneiForm;
        }
        #endregion
    }
}
