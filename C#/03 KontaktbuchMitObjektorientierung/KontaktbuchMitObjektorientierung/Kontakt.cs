using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontaktbuchMitObjektorientierung
{
    class Kontakt
    {
        //Eigenschaften
        public string vorname { get; set; }
        public string nachname { get; set; }
        public string telefon { get; set; }


        //Konstruktor
        public Kontakt(string _vorname, string _nachname, string _telefon)
        {
            vorname = _vorname;
            nachname = _nachname;
            telefon = _telefon;
        }

        //Leerkonstruktor
        public Kontakt ()
        {
            vorname = "";
            nachname = "";
            telefon = "";
        }
    }
}
