using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    abstract class WinLogic
    {
        protected Random rand;
        protected int luckyNum;
        protected Table table;
        protected List<string> wheel;
        protected string[] split;

        public WinLogic()
        {
            this.rand = new Random(); 
            this.luckyNum = rand.Next(0, 37);
            this.table = new Table();
            this.wheel = table.Wheel();
            this.split = wheel[luckyNum].Split(',');            
        }

        public virtual string PlayerBet()
        {
            string bet = "";
            return bet;
        }
            //Straight Bet
        public virtual void WinOne()
        {
            if (Convert.ToInt32(split[0]) == Convert.ToInt32(PlayerBet()))
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
