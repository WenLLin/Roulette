using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class App
    {
        public void Run()
        {
            Table table = new Table();
            table.Coloring();
            Numbers numbers = new Numbers();
            EvenOdd evenOdd = new EvenOdd();
            RedBlack redsBlacks = new RedBlack();
            HighLow highLow = new HighLow();
            Dozens dozens = new Dozens();
            Column column = new Column();
            Street street = new Street();
            SixNumber sixNumber = new SixNumber();
            Split split = new Split();
            Corner corner = new Corner();

            ConsoleKeyInfo cki;
            Console.WriteLine("\nHow would you like to bet: ");
            Console.WriteLine("\n1. Straight Bet\t2. Evens/Odds\t3. Reds/Blacks\t4. Lows/Highs\t5. Dozens\n\n" +
                              "6. Columns\t7. Street\t8. 6 Numbers\t9. Split\t0. Corner");

            for (int i = 0; i < 10; i++)
            {
                cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.D1:
                        numbers.WinOne();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("\nE: Even\t\tO: Odd");
                        cki = Console.ReadKey(true);
                        if (cki.Key == ConsoleKey.E)
                        {
                            evenOdd.WinOne();
                        }
                        else if (cki.Key == ConsoleKey.O)
                        {
                            evenOdd.WinTwo();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("\nPick a color\n");
                        Console.WriteLine("R: Red\t\tB: Black");
                        cki = Console.ReadKey(true);
                        if (cki.Key == ConsoleKey.R)
                        {
                            redsBlacks.WinOne();
                        }
                        else if (cki.Key == ConsoleKey.B)
                        {
                            redsBlacks.WinTwo();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("\nL: 1-18\t\tH: 19-36");
                        cki = Console.ReadKey(true);
                        if (cki.Key == ConsoleKey.L)
                        {
                            highLow.WinOne();
                        }
                        else if (cki.Key == ConsoleKey.H)
                        {
                            highLow.WinTwo();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine("\nF: 1-12\tS: 13-24\tT: 25-36");
                        cki = Console.ReadKey(true);
                        if (cki.Key == ConsoleKey.F)
                        {
                            dozens.WinOne();
                        }
                        else if (cki.Key == ConsoleKey.S)
                        {
                            dozens.WinTwo();
                        }
                        else if (cki.Key == ConsoleKey.T)
                        {
                            dozens.WinThree();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                        }
                        break;
                    case ConsoleKey.D6:
                        column.WinOne();
                        break;
                    case ConsoleKey.D7:
                        street.WinOne();
                        break;
                    case ConsoleKey.D8:
                        sixNumber.WinOne();
                        break;
                    case ConsoleKey.D9:
                        split.WinOne();
                        break;
                    case ConsoleKey.D0:
                        corner.WinOne();
                        break;
                }
            }
        }
    }
}
