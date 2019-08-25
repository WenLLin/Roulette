using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Numbers : WinLogic
    {
        public override string PlayerBet()
        {
            Console.Write("\nEnter the number that you want to bet on: ");
            string playerBet = Console.ReadLine();

            return playerBet;
        }        
    }
}
