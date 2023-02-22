using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Tic_Tac_Toe
{
    class Player
    {
        //==================================
        // Variables
        //==================================
        public ImageSource Symbol { get; private set; }
        public int Scorepoints { get; set; }
        public bool OnTurn { get; set; }


        //==================================
        // Constructor
        //==================================
        public Player()
        {
            //Default-Konstruktor
        }

        public Player(ImageSource symbol, int scorepoints, bool onturn)
        {
            this.Symbol = symbol;
            this.Scorepoints = scorepoints;
            this.OnTurn = onturn;
        }
    }
}
