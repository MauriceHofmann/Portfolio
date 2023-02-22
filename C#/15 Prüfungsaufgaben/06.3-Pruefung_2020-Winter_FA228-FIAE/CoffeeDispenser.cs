using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._3_Pruefung_2020_Winter_FA228_FIAE
{
    class CoffeeDispenser : Dispenser
    {
        public override void start()
        {
            mc2.initialize();
            mc2.getDisplay().print(0, "Münzstand im Wecgsler:");

            string zweiteZeile = "";

            foreach(Shaft shaft in mc2.getMuenzenschaechte())
            {
                zweiteZeile += "[" + shaft.getCountCoins() + "]";
            }

            mc2.getDisplay().print(1, zweiteZeile);
        }

        public override bool orderProduct(float prize)
        {
            if(mc2.getInsertedCoinValue() == prize)
            {
                mc2.getDisplay().print(2, "Zahlvorgang erfolgreich. Bitte entnehmen Sie Ihr Getraenk!");
                return true;
            }
            else if(mc2.getInsertedCoinValue() < prize)
            {
                mc2.getDisplay().print(2, "Wechseln ist nicht möglich, entnehmen Sie Ihre Muenzen.");
                return false;
            }
            else
            {
                mc2.getDisplay().print(2, "Zahlung erfolgreich. Bitte entnehmen Sie bitte das Wechselgeld und Ihr Getraenk.");
                return true;
            }
        }
    }
}
