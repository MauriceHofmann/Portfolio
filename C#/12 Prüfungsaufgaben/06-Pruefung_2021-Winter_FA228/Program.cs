using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Pruefung_2021_Winter_FA228
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablettenform tablettenform = new Tablettenform(2.0, 8.0, 3.0, 1508, 200);

            Medikament[] produzierteMedikamente = new Medikament[60];

            for(int i = 0; i < 60; i++)
            {
                Medikament medikament = new Medikament("15.08.2025", "Eucaliptum", "Zur Schmerzlinderung bei Bronchialbeschwerden", tablettenform);
                medikament.SetId(3101);

                produzierteMedikamente[i] = medikament;
            }

            Blister blister = new Blister(2, 6, 2015, produzierteMedikamente);

            blister.entnehmen(1, 1);
            blister.entnehmen(2, 5);

            blister.druckeBestandInfo();

            Console.ReadKey();
        }
    }
}
