using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    public class Player
    {
        public int Arrows { get; set; }
        public int Gold { get; set; }
        public int Turns { get; set; }
        public bool WumpusDead { get; set; }

        public Player(int arrows, int gold, int turns, bool wumpusDead)
        {
            Arrows = arrows;
            Gold = gold;
            Turns = turns;
            WumpusDead = wumpusDead;
        }

        public bool PlayerMove(int playerPos, int movePos)
        {
            // "playerPos" is the cave index that the player is in
            // "movePos" is the cave index that the player is going to move to
            // Returns true if the player can move to the cave with index "movePos"
            // Returns false if otherwise
            return true;
        }

        public int ArrowCount()
        {
            // Returns how many arrows the player has
            return Arrows;
        }

        public int GoldCount()
        {
            // Returns how much gold the player has
            return Gold;
        }

        public int TurnsCount()
        {
            // Returns how many turns has passed
            return Turns;
        }                      

        public int CalculateScore(int turns, int gold, int arrows, bool wumpusDead)
        {
            // "turns" is the number of turns that has passed
            // "gold" is the amount of gold the player has
            // "arrows" is the number of arrows the player has
            // "wumpusDead" is true if the Wumpus is dead and false otherwise
            // Returns the score using this formula:
            // 100 - turns + gold + (5 * arrows) + (50 if wumpusDead == true else 0)

            int score = 100;
            score -= turns;
            score += gold;
            score += arrows;
            if (wumpusDead)
            {
                score += 50;
            }

            return score;
        }
    }
}
