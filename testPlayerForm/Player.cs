using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WumpusLocations;
namespace WumpusPlayer
{
    public class Player
    {
        public int Arrows { get; set; } // The number of arrows left
        public int Gold { get; set; } // The amount of gold left
        public int Turns { get; set; } // The number of turns it has been
        public bool WumpusDead { get; set; } // Whether the Wumpus is dead or not

        public List<bool> Upgrades = new List<bool>
        {
            false, // Shield
            false
        }; // The list of upgrades that the player has

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
        /// <param name="i"> The index of the cave to move to, 1-based </param>
        /// <param name="paths"> The array of paths for the current cave, 1-based </param>
        /// <returns> Returns true if the player can move to that cave and false otherwise </returns>
        public bool PlayerMove(int i, int[] paths)
        {
            foreach (int path in paths)
            {
                if (path == i)
                {
                    return true;
                }
            }

            return false;
        }
        
        /// <summary>
        /// Calculates the score at the end of the game
        /// Score = 100 - turns + gold + (5 * arrows) + (50 if wumpusDead == true else 0)
        /// </summary>
        /// <returns> Returns the score </returns>
        public int CalculateScore()
        {
            if (WumpusDead)
            {
                return 100 - Turns + Gold + (5 * Arrows) + 50;
            }

            return 100 - Turns + Gold + (5 * Arrows);
        }

        /// <summary>
        /// Grants an upgrade to the player
        /// </summary>
        /// <param name="upgrade"> The string name of the upgrade </param>
        /// <returns></returns>
        public void GainUpgrade(string upgrade)
        {
            if (upgrade == "Shield".ToLower())
            {
                Upgrades[0] = true;
            }
            else if (upgrade == "") ;
        }
    }
}
