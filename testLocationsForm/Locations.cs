using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using GCUITest;

namespace WumpusLocations
{
    public class Locations
    {
        public List<int[]> CavePaths { get; set; }
        public int[] Bats { get; set; }
        public int[] Pits { get; set; }
        public int[] Shops { get; set; }
        public int Wumpus { get; set; }
        public int Player { get; set; }

        /// <summary>
        /// Constructs a Location that stores the current cave system, the locations of the bats, Wumpus, pits, shops, and the player
        /// </summary>
        /// <param name="cavePaths"> A list of caves and their connections, 0-based </param>
        /// <param name="bats"> A list of indexes where the bats are, 0-based </param>
        /// <param name="pits"> A list of indexes where the pits are, 0-based </param>
        /// <param name="wumpus"> The index where the Wumpus is, 0-based </param>
        /// <param name="player"> The index where the player is, 0-based </param>
        public Locations(List<int[]> cavePaths, int[] bats, int[] pits, int[] shops, int wumpus, int player)
        {
            CavePaths = cavePaths;
            Bats = bats;
            Pits = pits;
            Shops = shops;
            Wumpus = wumpus;
            Player = player;
        }
        
        /// <summary>
        /// Determines if there is a path in the given direction
        /// </summary>
        /// <param name="i"> The direction to move to </param>
        /// <returns> Returns true if the direction is a path and false otherwise </returns>
        public bool IsPath(int i)
        {
            foreach (int path in CavePaths[Player])
            {
                if (i == path)
                {
                    return true;
                }
            }

            return false;
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
            foreach (int path in CavePaths[Wumpus])
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
        /// Shoots an arrow at the given direction
        /// </summary>
        /// <param name="i"> The direction to shoot at </param>
        /// <returns> Returns true if you shot the Wumpus and false otherwise </returns>
        public bool ShootArrow(int i)
        {
            if (i == Wumpus)
            {
                foreach (int path in CavePaths[Player])
                {
                    if (path == i)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks the current room for special locations
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
        /// Checks the nearby CavePathss for special locations
        /// </summary>
        /// <returns> Returns W if there's a Wumpus, B if there's a bat, P if there's a pit, S if there's a shop, and N otherwise </returns>
        public char HazardNearby()
        {
            // Check each room connection one by one
            for (int i = 0; i < CavePaths[Player].Length; i++)
            {
                foreach (int bat in Bats)
                {
                    if (CavePaths[Player][i] == bat)
                    {
                        return 'B';

                    }
                }

                foreach (int pit in Pits)
                {
                    if (CavePaths[Player][i] == pit)
                    {
                        return 'P';
                    }
                }

                foreach (int shop in Shops)
                {
                    if (CavePaths[Player][i] == shop)
                    {
                        return 'S';
                    }
                }

                if (CavePaths[Player][i] == Wumpus)
                {
                    return 'W';
                }
            }

            return 'N';
        }
    }
}
