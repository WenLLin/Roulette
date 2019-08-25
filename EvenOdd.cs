using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class EvenOdd : WinLogic
    {
        //Even
        public override void WinOne()
        {
            
            if (Convert.ToInt32(split[0]) % 2 == 0)
            {
                Console.WriteLine("Lucky Bet, you won!");
            }
            else
            {
                Console.WriteLine("Better luck next time.");
            }
            Console.WriteLine(string.Join("/", split[0]));
        }

        //Odd
        public void WinTwo()
        {            
            
            if (Convert.ToInt32(split[0]) % 2 == 1)
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
