using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WumpusLocations;
namespace WumpusPLayer
{
    public class Player
    {
        public int Arrows { get; set; } // The amount of arrows left
        public int Gold { get; set; } // The amount of gold left
        public int Turns { get; set; } // The amount of turns it has been
        public bool WumpusDead { get; set; } // Whether the Wumpus is dead or not
        public Player(int arrows, int gold, int turns, bool wumpusDead)
        {
            Arrows = arrows;
            Gold = gold;
            Turns = turns;
            WumpusDead = wumpusDead;
        }

        /// <summary>
        /// Moves the player to the chosen location
        /// </summary>
        /// <param name="i"> The index of the cave to move to </param>
        /// <param name="paths"> The array of paths for the current cave </param>
        /// <returns> Returns true if the player can move and false otherwise </returns>
        public bool PlayerMove(int i, int[] paths)
        {
            
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
