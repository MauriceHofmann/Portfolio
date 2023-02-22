using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._3_Pruefung_2020_Winter_FA228_FIAE
{
    class MC2
    {
        private Display display;
        private List<Shaft> muenzschaechte = new List<Shaft>();

        public void initialize()
        {
            Shaft ct1 = new Shaft(1, 4);
            muenzschaechte.Add(ct1);

            Shaft ct2 = new Shaft(2, 5);
            muenzschaechte.Add(ct2);

            Shaft ct5 = new Shaft(5, 2);
            muenzschaechte.Add(ct5);

            Shaft ct10 = new Shaft(10, 2);
            muenzschaechte.Add(ct10);

            Shaft ct20 = new Shaft(20, 9);
            muenzschaechte.Add(ct20);

            Shaft ct50 = new Shaft(50, 8);
            muenzschaechte.Add(ct50);

            Shaft ct100 = new Shaft(100, 2);
            muenzschaechte.Add(ct100);

            Shaft ct200 = new Shaft(200, 1);
            muenzschaechte.Add(ct200);
        }

        public Display getDisplay()
        {
            return display;
        }

        public int countShafts()
        {
            return muenzschaechte.Count;
        }

        public Shaft getShaft(int no)
        {
            Shaft gesuchterShaft = new Shaft();

            foreach(Shaft shaft in muenzschaechte)
            {
                if(shaft.getCoinType() == no)
                {
                    gesuchterShaft = shaft;
                }
            }

            return gesuchterShaft;
        }

        public float getInsertedCoinValue()
        {
            float coinValue = 0;

            foreach(Shaft shaft in muenzschaechte)
            {
                coinValue += shaft.getCountCoins() * shaft.getCoinType();
            }

            return coinValue;
        }

        public void cancelPaymentOperation()
        {
            Console.WriteLine("Das sind die bisher eingeworfenen Münzen:");
            foreach(Shaft shaft in muenzschaechte)
            {
                Console.WriteLine(shaft.getCountCoins() + " * " + shaft.getCoinType() + "Ct");
            }

            Console.WriteLine("Summe: " + getInsertedCoinValue() + "Ct");
            Console.WriteLine("Der Münzenzähler wird zurückgesetzt");

            muenzschaechte.Clear();
        }

        //Diese Getter-Methode wird extra benötigt in "CoffeeDispenser"
        public List<Shaft> getMuenzenschaechte()
        {
            return muenzschaechte;
        }
    }
}
