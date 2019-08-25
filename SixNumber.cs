using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class SixNumber : WinLogic
    {
        public override void WinOne()
        {
            int binNum = Convert.ToInt32(split[0]);
            int street = binNum % 3;
            int evenRow = street % 2;
            Console.Write("Enter a number that you want to bet on: ");
            int playerBet = Convert.ToInt32(Console.ReadLine());

            if (luckyNum < 35)
            {
                if (evenRow == 0)
                {
                    switch (street)
                    {
                        case 0:
                            if (playerBet == binNum || playerBet == binNum - 1
                                || playerBet == binNum - 2 || playerBet == binNum - 3
                                || playerBet == binNum - 4 || playerBet == binNum - 5)
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
                                || playerBet == binNum + 2 || playerBet == binNum - 1
                                || playerBet == binNum - 2 || playerBet == binNum - 3)
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
                                || playerBet == binNum + 1 || playerBet == binNum - 2 
                                || playerBet == binNum - 3 || playerBet == binNum - 4)
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
                else if (evenRow == 1)
                {
                    switch (street)
                    {
                        case 0:
                            if (playerBet == binNum || playerBet == binNum - 1
                                || playerBet == binNum - 2 || playerBet == binNum +1
                                || playerBet == binNum +2 || playerBet == binNum +3)
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
                                || playerBet == binNum + 2 || playerBet == binNum +3
                                || playerBet == binNum +4 || playerBet == binNum +5)
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
                                || playerBet == binNum + 1 || playerBet == binNum + 2
                                || playerBet == binNum + 3 || playerBet == binNum + 4)
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
            }
            else
            {
                Console.WriteLine("Better luck next time");
            }
        }
    }
}
