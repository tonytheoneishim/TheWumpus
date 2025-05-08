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
        public List<int[]> RoomPaths { get; set; } // The cave system
        public int[] Bats { get; set; } // The indexes of the bats, 0-based
        public int[] Pits { get; set; } // The indexes of the pits, 0-based
        public int[] Shops { get; set; } // The indexes of the shops, 0-based
        public int Wumpus { get; set; } // The index of the Wumpus, 0-based
        public int Player { get; set; } // The index of the player, 0-based

        public Locations(List<int[]> roomPaths, int[] bats, int[] pits, int wumpus, int player)
        {
            RoomPaths = roomPaths;
            Bats = bats;
            Pits = pits;
            Wumpus = wumpus;

            Player = player;
        }

        public bool MoveWumpus()
        { // Randomly decide if the Wumpus is moving
            Random rng = new Random();
            if (rng.Next(0, 2) == 0)
            {
                return false;
            }

            // Randomly decide which direction the Wumpus will move towards
            int count = 0;
            List<int> paths = new List<int>();
            foreach (int path in RoomPaths[Wumpus])
            {
                if (path != -1)
                {
                    count++;
                    paths.Add(path);
                }
            }

            Wumpus = paths[rng.Next(0, count)];
            return true;
        } // Returns true if the Wumpus moved and false if it didn't

        public char RoomType()
        { // Checks the type of room at index "i"
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
        } // Returns W if it's the Wumpus, B if it's a bat, P if it's a pit, S if it's a shop, and N if it's a normal room
        public bool ShootArrow(int cave)
        { // Shoots an arrow at "cave"
            if (cave == Wumpus)
            {
                return true;
            }

            return false;
        } // Returns true if the arrow hit the Wumpus and false if it didn't

        public char HazardNearby()
        { // Checks for hazards in the caves around the player
            for (int i = 0; i < RoomPaths[Player].Length; i++)
            {
                foreach (int bat in Bats)
                {
                    if (RoomPaths[Player][i] == bat)
                    {
                        return 'B';

                    }
                }

                foreach (int pit in Pits)
                {
                    if (RoomPaths[Player][i] == pit)
                    {
                        return 'P';
                    }
                }

                foreach (int shop in Shops)
                {
                    if (RoomPaths[Player][i] == shop)
                    {
                        return 'S';
                    }
                }

                if (RoomPaths[Player][i] == Wumpus)
                {
                    return 'W';
                }
            }

            return 'N';
        } // Returns B if there's a bat nearby, P if there's a pit nearby, S if there's a shop nearby, W is there's a Wumpus nearby, and N otherwise
    }
}
