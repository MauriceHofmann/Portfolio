using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._3_Pruefung_2020_Winter_FA228_FIAE
{
    class Shaft
    {
        private int coinType;
        private int countCoins;

        public Shaft()
        {

        }

        public Shaft(int coinType, int countCoins)
        {
            this.coinType = coinType;
            this.countCoins = countCoins;
        }

        public int getCoinType()
        {
            return this.coinType;
        }

        public int getCountCoins()
        {
            return this.countCoins;
        }

        public void disCharge()
        {
            this.countCoins --;
        }
    }
}
