using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WumpusLocations
{
    public class Locations
    {
        public List<int[]> CavePaths { get; set; }
        public int[] Bats = { };
        public int[] Pits = { };
        public int[] Shops = { };
        public int Wumpus;
        public int Player;

        /// <summary>
        /// Constructs a Location that stores the current cave system, the locations of the bats, Wumpus, pits, shops, and the player
        /// </summary>
        /// <param name="cavePaths"> A list of caves and their connections, 1-based </param>
        public Locations(List<int[]> cavePaths)
        {
            CavePaths = cavePaths;
        }

        /// <summary>
        /// Spawns the bats into the cave system, ensuring they don't spawn on the player
        /// </summary>
        /// <returns> Returns an array of indexes where the bats are spawning </returns>
        public List<int[]> SpawnEvents()
        {
            int[] bats = new int[2];
            int[] pits = new int[2];
            int[] shops = new int[2];
            int wumpus;
            int player;
            List<int> indexes = new List<int>(30);
            List<int> events = new List<int>();
            for (int i = 1; i <= 30; i++)
            {
                indexes.Add(i);
            }

            Random rng = new Random();
            for (int i = 0; i <= 8; i++)
            {
                int x = rng.Next(30 - i);
                events.Add(indexes[x]);
                indexes.RemoveAt(x);
                indexes.Add(events[i]);
            }

            bats[0] = events[0];
            bats[1] = events[1];
            pits[0] = events[2];
            pits[1] = events[3];
            shops[0] = events[4];
            shops[1] = events[5];
            wumpus = events[6];
            player = events[7];

            List<int[]> locations = new List<int[]>();
            locations.Add(bats);
            locations.Add(pits);
            locations.Add(shops);
            locations.Add(new int[] { wumpus, player });

            return locations;
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
        /// <param name="i"> The direction to shoot at, 1-based </param>
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
