using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Table
    {
        public void Coloring()
        {
            List<string> table = Wheel();
            int count = 1;
            foreach(var num in table)
            {
                
                if (num.Contains('R'))
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    string[] split = num.Split(',');
                    Console.Write(split[0]);
                    Console.ResetColor();

                }
                else if (num.Contains('B'))
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    string[] split = num.Split(',');
                    Console.Write(split[0]);
                    Console.ResetColor();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(num);
                    Console.ResetColor();
                }

                if (count % 3 == 0)
                {
                    Console.WriteLine(" ");
                }
                count++;
            }
        }

        public List<string> Wheel()
        {
            List<string> table = new List<string>(36);
          
            for (int i = 0; i < 36; i++)
            {
                int num = i +1;
                if (num == 2 || num == 4 || num == 6 || num == 8 || num == 10 || num == 11 || num == 13 || num == 15 || num == 17
                    || num == 20 || num == 22 || num == 24 || num == 26 || num == 28 || num == 29 || num == 31 || num == 33 || num == 35)
                {
                    table.Insert(i, $" {num},B  ");  
                }
                else if (num == 1 || num == 3 || num == 5 || num == 7 || num == 9 || num == 12 || num == 14 || num == 16 || num == 18
                    || num == 19 || num == 21 || num == 23 || num == 25 || num == 27 || num == 30 || num == 32 || num == 34 || num == 36)
                {
                    table.Insert(i, $" {num},R  ");                    
                }
            }

            table.Add("00");
            table.Add("0");

            return table;
        }       
    }
}
