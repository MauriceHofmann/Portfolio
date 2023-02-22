using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._2_Pruefung_2019_Winter_FA228_FIAE
{
    class Program
    {
        static void Main(string[] args)
        {
            Praxis praxis = new Praxis();

            Physiobehandlung physiobehandlung1 = new Physiobehandlung("A12345", "Chirogymnastik", 12.87);
            Physiobehandlung physiobehandlung2 = new Physiobehandlung("A12345", "Wärmeanwendung", 4.23);

            Standardbehandlung standardbehandlung1 = new Standardbehandlung("A12345", "Arthrose", 45.12);
            Standardbehandlung standardbehandlung2 = new Standardbehandlung("A12345", "Ultraschall", 26.80);

            praxis.addBehandlung(physiobehandlung1);
            praxis.addBehandlung(physiobehandlung2);
            praxis.addBehandlung(standardbehandlung1);
            praxis.addBehandlung(standardbehandlung2);

            Console.WriteLine("Die Gesamtkosten allerBehandlungen der Praxis betragen " + praxis.ermittleKosten() + " EUR");


            /////////////////////////////////////////////////////////////////////////////
            //Patient patient = new Patient("A12345", "Musterann", "Max");
            //praxis.patienten.Add(patient);

            //Console.Write(praxis.zeigePatienten(2));
            /////////////////////////////////////////////////////////////////////////////

            Console.ReadKey();
        }
    }
}
