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
        { // Randomly decide if the Wumpus is moving and where it's moving to   
            Random rng = new Random();
            if (rng.Next(0, 2) == 0)
            {
                return false;
            }

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
        }

        public bool ShootArrow(int cave)
        {
            if (cave == Wumpus)
            {
                return true;
            }

            return false;
        }

        public bool IfBat()
        {
            foreach (int bat in Bats)
            {
                if (Player == bat)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IfPit()
        {
            foreach (int pit in Pits)
            {
                if (Player == pit)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IfWumpus()
        {
            if (Player == Wumpus)
            {
                return true;
            }

            return false;
        }

        public bool BatsNearby()
        {
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
        }

        public bool PitsNearby()
        {
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
        }

        public bool WumpusNearby()
        {
            for (int i = 0; i < RoomPaths[Player].Length; i++)
            {
                if (RoomPaths[Player][i] == Wumpus)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
