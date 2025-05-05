using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace testLocationsForm
{
    public class Locations
    {
        public List<int[]> RoomPaths { get; set; }
        public int[] Bats { get; set; }
        public int[] Pits { get; set; }
        public int Wumpus { get; set; }
        public int Player { get; set; }

        public Locations(List<int[]> roomPaths, int[] bats, int[] pits, int wumpus, int player)
        {
            RoomPaths = roomPaths;
            Bats = bats;
            Pits = pits;
            Wumpus = wumpus;
            Player = player;
        }

        public bool MoveWumpus()
        {
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

            Wumpus = paths[rng.Next(0, count + 1)];
            return true;
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

        public bool BatsNearby(int[] roomConnect)
        {
            foreach (int bat in Bats)
            {
                for (int i = 0; i < roomConnect.Length; i++)
                {
                    if (roomConnect[i] == bat)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool PitsNearby(int[] roomConnect)
        {
            foreach (int pit in Pits)
            {
                for (int i = 0; i < roomConnect.Length; i++)
                {
                    if (roomConnect[i] == pit)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool WumpusNearby(int[] roomConnect)
        {
            for (int i = 0; i < roomConnect.Length; i++)
            {
                if (roomConnect[i] == Wumpus)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
