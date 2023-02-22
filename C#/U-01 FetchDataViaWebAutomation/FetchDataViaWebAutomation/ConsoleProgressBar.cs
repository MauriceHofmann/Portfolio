using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchDataViaWebAutomation
{
    class ConsoleProgressBar
    {
        //=======================
        // Variables
        //=======================
        private const char block = '■';
        private const string placeHolder = "                        \n";


        //=======================
        // Methods
        //=======================

        /// <WriteProgressBar-Method>
        /// The progress bar is created. The passed percentage of progress is divided by 10. A block icon is inserted for
        /// each 10% progress. The rest is filled with empty spaces in the progress bar.
        /// </WriteProgressBar-Method>
        public static void WriteProgressBar(int percent, string currentStep = " ", bool update = false)
        {
            //If a progress bar has already been inserted, the value must be set
            //to true to override it and thus it will not be duplicated -> RefreshProgressBar-Method
            if (update == true)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 2);
            }

            Console.Write("Loading... [");
            int percentDividedByTen = percent / 10;

            //Individual digits are gradually overwritten
            //-> Either ■ or empty (a block is set for each 10%)
            for (int i = 0; i < 10; i++)
            {
                if (i >= percentDividedByTen)
                {
                    //Spaces between [] in the progress bar
                    Console.Write(' ');
                }
                else
                {
                    Console.Write(block);
                }
            }

            Console.Write("] {0}%", percent);

            if (currentStep != " ")
            {
                Console.Write("\n" + currentStep + placeHolder);
            }
        }

        /// <RefreshProgressBar-Method>
        /// The WriteProgressBarMethod is executed, except that the update parameter is not passed here and is set to true
        /// by default to override the progress bar.
        /// </RefreshProgressBar-Method>
        public static void RefreshProgressBar(int percent, string currentStep = " ")
        {
            WriteProgressBar(percent, currentStep, true);
        }
    }
}
