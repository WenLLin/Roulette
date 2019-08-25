using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Corner : WinLogic
    {
        public override void WinOne()
        {
            int binNum = Convert.ToInt32(split[0]);
            int column = binNum % 3;
            Console.Write("Enter a number that you want to bet on: ");
            int playerBet = Convert.ToInt32(Console.ReadLine());

            if (luckyNum <3)
            {
                switch (column)
                {
                    case 0:
                        if (playerBet == binNum - 4 || playerBet == binNum - 3
                            || playerBet == binNum - 1 )
                        {
                            Console.WriteLine("Lucky bet, you WON!");
                        }
                        else
                        {
                            Console.WriteLine("Better luck next time");
                        }
                        break;
                    case 1:
                        if (playerBet == binNum + 4 || playerBet == binNum + 3
                            || playerBet == binNum + 1)
                        {
                            Console.WriteLine("Lucky bet, you WON!");
                        }
                        else
                        {
                            Console.WriteLine("Better luck next time");
                        }
                        break;
                    case 2:
                        if (playerBet == binNum - 1 || playerBet == binNum + 4 || playerBet == binNum + 3
                            || playerBet == binNum + 2 || playerBet == binNum + 1)
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
            else if (luckyNum < 35)
            {
                switch (column)
                {
                    case 0:
                        if (playerBet == binNum - 4 || playerBet == binNum - 3
                            || playerBet == binNum - 1 || playerBet == binNum + 3 
                            || playerBet == binNum +2 )
                        {
                            Console.WriteLine("Lucky bet, you WON!");
                        }
                        else
                        {
                            Console.WriteLine("Better luck next time");
                        }
                        break;
                    case 1:
                        if (playerBet == binNum + 4 || playerBet == binNum + 3
                            || playerBet == binNum + 1 || playerBet == binNum - 3
                            || playerBet == binNum - 2)
                        {
                            Console.WriteLine("Lucky bet, you WON!");
                        }
                        else
                        {
                            Console.WriteLine("Better luck next time");
                        }
                        break;
                    case 2:
                        if (playerBet == binNum - 4 || playerBet == binNum - 3
                            || playerBet == binNum - 2 || playerBet == binNum - 1
                            || playerBet == binNum + 4 || playerBet == binNum + 3
                            || playerBet == binNum + 2 || playerBet == binNum + 1)
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
    }
}
