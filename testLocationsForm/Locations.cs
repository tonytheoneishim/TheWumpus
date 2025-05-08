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

        public bool ShootArrow(int cave)
        { // Shoots an arrow at "cave"
            if (cave == Wumpus)
            {
                return true;
            }

            return false;
        } // Returns true if the arrow hit the Wumpus and false if it didn't

        public bool IfBat()
        { // Checks if there's a bat in the room with the player
            foreach (int bat in Bats)
            {
                if (Player == bat)
                {
                    return true;
                }
            }

            return false;
        } // Returns true if there's a bat with the player and false if there isn't

        public bool IfPit()
        { // Checks if there's a pit in the room with the player
            foreach (int pit in Pits)
            {
                if (Player == pit)
                {
                    return true;
                }
            }

            return false;
        } // Returns true if there's a pit in the room with the player and false if there isn't

        public bool IfWumpus()
        { // Checks if the Wumpus is in the room with the player
            if (Player == Wumpus)
            {
                return true;
            }

            return false;
        } // Returns true if the Wumpus is with the player and false if it isn't

        public bool BatsNearby()
        { // Checks the nearby caves for bats
            foreach (int bat in Bats)
            {
                for (int i = 0; i < RoomPaths[Player].Length; i++)
                {
                    if (RoomPaths[Player][i] == bat)
                    {
                        return true;
                    }
                }
            }

            return false;
        } // Returns true if there's a bat in the nearby caves and false if there isn't

        public bool PitsNearby()
        { // Checks the nearby caves for pits
            foreach (int pit in Pits)
            {
                for (int i = 0; i < RoomPaths[Player].Length; i++)
                {
                    if (RoomPaths[Player][i] == pit)
                    {
                        return true;
                    }
                }
            }

            return false;
        } // Returns true if there's a pit in the nearby caves and false if there isn't

        public bool WumpusNearby()
        { // Checks for the Wumpus in the nearby caves
            for (int i = 0; i < RoomPaths[Player].Length; i++)
            {
                if (RoomPaths[Player][i] == Wumpus)
                {
                    return true;
                }
            }

            return false;
        } // Returns true if the Wumpus is nearby and false if there isn't
    }
}
