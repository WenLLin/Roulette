using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class HighLow : WinLogic
    {      
        //Low Number
        public override void WinOne()
        {
            if (luckyNum-1 < 19 && Convert.ToInt32(split[0]) < 19)
            {
                Console.WriteLine("Lucky Bet, you won!");
            }
            else
            {
                Console.WriteLine("Better luck next time.");
            }
            Console.WriteLine(string.Join("/", split[0]));
        }

        //High Number
        public void WinTwo()
        {
            if (luckyNum - 1 > 18 && Convert.ToInt32(split[0]) > 18)
            {
                Console.WriteLine("Lucky Bet, you won!");
            }
            else
            {
                Console.WriteLine("Better luck next time.");
            }
            Console.WriteLine(string.Join("/", split[0]));
        }
    }
}
