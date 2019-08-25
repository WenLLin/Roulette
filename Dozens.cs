using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Dozens : WinLogic
    {
        public override void WinOne()
        {
            Console.WriteLine(string.Join("/", split[0]));
            if (Convert.ToInt32(split[0]) < 13)
            {
                Console.WriteLine("Lucky Bet, you won!");
            }
            else
            {
                Console.WriteLine("Better luck next time.");
            }
        }

        public void WinTwo()
        {
            Console.WriteLine(string.Join("/", split[0]));
            if (Convert.ToInt32(split[0]) < 25 && Convert.ToInt32(split[0]) > 12)
            {
                Console.WriteLine("Lucky Bet, you won!");
            }
            else
            {
                Console.WriteLine("Better luck next time.");
            }
        }

        public void WinThree()
        {
            Console.WriteLine(string.Join("/", split[0]));
            if (Convert.ToInt32(split[0]) > 24)
            {
                Console.WriteLine("Lucky Bet, you won!");
            }
            else
            {
                Console.WriteLine("Better luck next time.");
            }
        }
    }
}
