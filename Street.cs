using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Street : WinLogic
    {
        public override void WinOne()
        {
            int binNum = Convert.ToInt32(split[0]);
            int street = binNum % 3;
            
            Console.Write("Enter a number on the street you want to bet on: ");
            int playerBet = Convert.ToInt32(Console.ReadLine());

            if (luckyNum < 35)
            {
                switch (street)
                {
                    case 0:
                        if (playerBet == binNum || playerBet == binNum - 1
                            || playerBet == binNum - 2)
                        {
                            Console.WriteLine("Lucky bet, you WON!");
                        }
                        else
                        {
                            Console.WriteLine("Better luck next time");
                        }
                        break;
                    case 1:
                        if (playerBet == binNum || playerBet == binNum + 1
                            || playerBet == binNum + 2)
                        {
                            Console.WriteLine("Lucky bet, you WON!");
                        }
                        else
                        {
                            Console.WriteLine("Better luck next time");
                        }
                        break;
                    case 2:
                        if (playerBet == binNum || playerBet == binNum - 1
                            || playerBet == binNum + 1)
                        {
                            Console.WriteLine("Lucky bet, you WON!");
                        }
                        else
                        {
                            Console.WriteLine("Better luck next time");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Better luck next time");
            }
        }
    }
}
