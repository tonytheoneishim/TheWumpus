using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WumpusTest
{
    public class Locations
    {
        public int Player { get; set; }
        public List<int> Bats { get; set; }
        public List<int> Pits { get; set; }
        public List<int> Wumpus { get; set; }
        public Locations(int player, List<int> bats, List<int> pits, List<int> wumpus)
        {
            Player = player;
            Bats = bats;
            Pits = pits;
            Wumpus = wumpus;
        }

        public bool ShootArrow(int i)
        {
            // "i" is the cave index of where the arrow is being shot at
            // Returns true if the arrow hits the Wumpus and false otherwise
            return true;
        }
        public bool BatNearby(int i)
        {
            // "i" is the index of the cave the player is in
            // Returns true if there's bats in the nearby caves and false otherwise
            return true;
        }

        public bool PitNearby()
        {
            // Returns true if there's a pit in the nearby caves and false otherwise
            return true;
        }

        public bool WumpusNearby()
        {
            // Returns true if the Wumpus in the nearby caves and false otherwise
            return true;
        }

        public bool BuyHint(int gold)
        {
            // "gold" is the amount of gold the player has
            // Returns true if "gold" is greater than or equal to the hint price and false otherwise
            return true;
        }

        public List<int> WumpusLocation()
        {
            // Returns the cave index of the Wumpus's location
            return Wumpus;
        }

        public int PlayerLocation()
        {
            // Returns the cave index of the player's location
            return 1;
        }

        public int[] BatLocations()
        {
            // Returns an array of cave indexes where the bats are
            return new int[] { 2, 3 };
        }

        public int[] PitLocations()
        {
            // Returns an array of cave indexes where the pits are
            return new int[] { 4, 5 };
        }

        public void MoveWumpus(int i)
        {
            // "i" is the index of the cave to move the Wumpus to
            // Moves the Wumpus to cave "i"
        }
    }
}
