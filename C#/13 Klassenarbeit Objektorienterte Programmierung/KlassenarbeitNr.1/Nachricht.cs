using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenarbeitNr._1
{
    abstract class Nachricht
    {
        //===========================
        // Attribute
        //===========================
        protected int likes;
        protected Person absender;


        //===========================
        // Konstruktoren
        //===========================
        public Nachricht()
        {
            //Default-Konstruktor
        }

        public Nachricht(Person absender)
        {
            this.absender = absender;
        }


        //===========================
        // Methoden
        //===========================
        public void hinzufuegenLike()
        {
            this.likes ++;
        }

        public abstract string getNachricht();

        public int getLikes()
        {
            return this.likes;
        }
    }
}