using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace testPlayerform
{
    public class Locations
    {
        public int[] Bats { get; set; }
        public int[] Pits { get; set; }
        public int Wumpus { get; set; }
        public int Player { get; set; }

        public Locations(int[] bats, int[] pits, int wumpus, int player)
        {
            Bats = bats;
            Pits = pits;
            Wumpus = wumpus;
            Player = player;
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
