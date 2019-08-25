using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Column : WinLogic
    {
        public override void WinOne()
        {
            ConsoleKeyInfo cki;
            Console.WriteLine("Q:Column 1\tW: Column 2\tE: Column 3");
            cki = Console.ReadKey(true);
            
            if (luckyNum < 35)
            {
                if (cki.Key == ConsoleKey.Q)
                {

                    switch (Convert.ToInt32(split[0]) % 3)
                    {
                        case (0):
                            Console.WriteLine("Better luck next time");
                            break;
                        case (1):
                            Console.WriteLine("Lucky bet, you WON!");
                            break;
                        case (2):
                            Console.WriteLine("Better luck next time");
                            break;
                    }
                }
                else if (cki.Key == ConsoleKey.W)
                {
                    switch (Convert.ToInt32(split[0]) % 3)
                    {
                        case (0):
                            Console.WriteLine("Better luck next time");
                            break;
                        case (1):
                            Console.WriteLine("Better luck next time");
                            break;
                        case (2):
                            Console.WriteLine("Lucky bet, you WON!");
                            break;
                    }
                }
                else if (cki.Key == ConsoleKey.E)
                {
                    switch (Convert.ToInt32(split[0]) % 3)
                    {
                        case (0):
                            Console.WriteLine("Lucky bet, you WON!");
                            break;
                        case (1):
                            Console.WriteLine("Better luck next time");
                            break;
                        case (2):
                            Console.WriteLine("Better luck next time");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

                
            }
            else
            {
                Console.WriteLine("Better luck next time");
            }
        }
    }
}
