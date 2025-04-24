using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPlayerForm
{
    public class Player
    {
        public string Username { get; set; }
        public int Arrows { get; set; }
        public int Coins { get; set; }
        public int Turns { get; set; }
        public bool WumpusDead { get; set; }

        public Player(string name, int arrows, int coins, int turns, bool wumpusDead)
        {
            Username = name;
            Arrows = arrows;
            Coins = coins;
            Turns = turns;
            WumpusDead = wumpusDead; 
        }

        public int calculateScore(int turns, int coins, int arrows, bool wumpusDead)
        {
            int result = 100;
            result -= turns;
            result += coins;
            result += 5 * arrows;
            if (wumpusDead == true)
            {
                result += 50;
            }

            return result;
        }

        public void addArrow(bool triviaPassed)
        {
            if (triviaPassed)
            {
                Arrows += 2;
            }
        }

        public void removeArrow()
        {
            Arrows--;
        }

        public void addCoins(int coinCount)
        {
            Coins += coinCount;
        }

        public void removeCoins(int coinCount)
        {
            Coins -= coinCount;
        }
    }
}
