using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class RedBlack : WinLogic
    {
        //Red
        public override void WinOne()
        {
            if (split[1] == "R")
            {
                Console.WriteLine("Lucky Bet, you won!");
            }
            else
            {
                Console.WriteLine("Better luck next time.");
            }
            Console.WriteLine(string.Join("/", split[0]));
        }

        public void WinTwo()
        {
            if (split[1] == "B")
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
