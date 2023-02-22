using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._3_Pruefung_2020_Winter_FA228_FIAE
{
    abstract class Dispenser
    {
        protected MC2 mc2 = new MC2();

        public abstract void start();

        public abstract bool orderProduct(float prize);
    }
}
