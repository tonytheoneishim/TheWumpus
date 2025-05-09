using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using GCUITest;

namespace testLocationsForm
{
    public class Locations
    {
        public List<int[]> Cave { get; set; } // The current cave system
        public int[] Bats { get; set; } // The indexes of the bats, 0-based
        public int[] Pits { get; set; } // The indexes of the pits, 0-based
        public int[] Shops { get; set; } // The indexes of the shops, 0-based
        public int Wumpus { get; set; } // The index of the Wumpus, 0-based
        public int Player { get; set; } // The index of the player, 0-based

        /// <summary>
        /// Constructs a Location that stores the current cave system, the locations of the hazards, and the player's location
        /// </summary>
        /// <param name="Cave"> A list of caves and their connections </param>
        /// <param name="bats"> A list of indexes where the bats are </param>
        /// <param name="pits"> A list of indexes where the pits are </param>
        /// <param name="wumpus"> The index where the Wumpus is </param>
        /// <param name="player"> The index where the player is </param>
        public Locations(List<int[]> cave, int[] bats, int[] pits, int wumpus, int player)
        {
            Cave = cave;
            Bats = bats;
            Pits = pits;
            Wumpus = wumpus;
            Player = player;
        }

        /// <summary>
        /// Randomly moves the Wumpus to the nearest room, if moving at all
        /// </summary>
        /// <returns> Returns true if the Wumpus has moved and false otherwise </returns>
        public bool MoveWumpus()
        {
            // Randomly decide if the Wumpus is moving
            Random rng = new Random();
            if (rng.Next(0, 2) == 0)
            {
                return false;
            }

            // Randomly decide which direction the Wumpus will move towards
            int count = 0;
            List<int> paths = new List<int>();
            foreach (int path in Cave[Wumpus])
            {
                if (path != -1)
                {
                    count++;
                    paths.Add(path);
                }
            }

            Wumpus = paths[rng.Next(0, count)];
            return true;
        }

        /// <summary>
        /// Shoots an arrow at the selected cave
        /// </summary>
        /// <param name="cave"> The index of the cave to shoot at </param>
        /// <returns> Returns true if you shot the Wumpus and false otherwise </returns>
        public bool ShootArrow(int i)
        {
            if (i == Wumpus)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks the current room for hazards or a shop
        /// </summary>
        /// <returns> Returns W if there's a Wumpus, B if there's a bat, P if there's a pit, S if there's a shop, and N otherwise </returns>
        public char RoomType()
        {
            if (Player == Wumpus)
            {
                return 'W';
            }

            foreach (int bat in Bats)
            {
                if (Player == bat)
                {
                    return 'B';
                }
            }

            foreach (int pit in Pits)
            {
                if (Player == pit)
                {
                    return 'P';
                }
            }

            foreach (int shop in Shops)
            {
                if (Player == shop)
                {
                    return 'S';
                }
            }

            return 'N';
        }

        /// <summary>
        /// Checks the nearby caves for hazards or a shop
        /// </summary>
        /// <returns> Returns W if there's a Wumpus, B if there's a bat, P if there's a pit, S if there's a shop, and N otherwise </returns>
        public char HazardNearby()
        {
            // Check each room connection one by one
            for (int i = 0; i < Cave[Player].Length; i++)
            {
                foreach (int bat in Bats)
                {
                    if (Cave[Player][i] == bat)
                    {
                        return 'B';

                    }
                }

                foreach (int pit in Pits)
                {
                    if (Cave[Player][i] == pit)
                    {
                        return 'P';
                    }
                }

                foreach (int shop in Shops)
                {
                    if (Cave[Player][i] == shop)
                    {
                        return 'S';
                    }
                }

                if (Cave[Player][i] == Wumpus)
                {
                    return 'W';
                }
            }

            return 'N';
        }
    }
}
