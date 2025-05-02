using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CaveTest
{
    public class Cave
    {
        string caveFile = string.Empty;

        public List<int[]> caveLayouts = new List<int[]>();

        const int START_POSITION = 1;
        // Consts
        const int WALL = -1;
        //public static int[] createRoom(params int[] rooms)
        //{
        //    return rooms;
        //}
        private string[] caveNames = { "Cave1.CSV", "Cave2.CSV", "Cave3.CSV", "Cave4.CSV", "Cave5.CSV" };

        public void caveSelect(int index) 
        {
            caveFile = caveNames[index];
            caveLayouts.Clear();

            StreamReader streamReader = new StreamReader(caveFile);
            string line = streamReader.ReadLine();

            while (line != null)
            {
                string[] arr = line.Split(',');
                caveLayouts.Add(createRoom(int.Parse(arr[0]), 
                    int.Parse(arr[1]), 
                    int.Parse(arr[2]),
                    int.Parse(arr[3]),
                    int.Parse(arr[4]),
                    int.Parse(arr[5])
                    ));



                line = streamReader.ReadLine();
            }

            streamReader.Close();
        }



        public int[] createRoom(int a, int b, int c, int d, int e, int f) 
        {
            int[] conns = { a, b, c, d, e, f };
            return conns;
        }

        



        public Cave() {
            // make the below chart the room connections which correspond with the side so 6 values per group -1 means wall 
            // this eventually will most likely be an outside file
            caveSelect(0);








            //caveLayouts.Add(createRoom(30, -1, 26, 2, 7, -1));
            //caveLayouts.Add(createRoom(1, 26, -1, -1, 8, -1));
            //caveLayouts.Add(createRoom(26, 27, 28, 4, -1, -1));
            //caveLayouts.Add(createRoom(3,-1,-1,11,-1,9 ));
            //caveLayouts.Add(createRoom(28, 29, -1, 6, -1, -1));
            //caveLayouts.Add(createRoom(5,-1,-1,-1,12,11 ));
            //caveLayouts.Add(createRoom(-1,1,-1,8,13,-1 ));
            //caveLayouts.Add(createRoom(7, 2, -1, 15, -1, -1));
            //caveLayouts.Add(createRoom(-1, -1, 4, 10, 15, -1));
            //caveLayouts.Add(createRoom(9,-1,-1,-1,16,15 ));
            //caveLayouts.Add(createRoom(4, -1, 6, -1, 17, -1));
            //caveLayouts.Add(createRoom(-1,6,-1,13,-1,17));
            //caveLayouts.Add(createRoom(12, 7, -1, 14, -1, -1));
            //caveLayouts.Add(createRoom(13, -1, -1, 21, -1, 19));
            //caveLayouts.Add(createRoom(8, 9, 10, -1, -1, -1));
            //caveLayouts.Add(createRoom(-1,10,17,-1,-1,21 ));
            //caveLayouts.Add(createRoom(-1, 11,12,-1,-1,16 ));
            //caveLayouts.Add(createRoom(-1,-1,-1,19,24,23 ));
            //caveLayouts.Add(createRoom(18,-1,14,-1,25,-1 ));
            //caveLayouts.Add(createRoom(-1,-1,21,27,-1,25 ));
            //caveLayouts.Add(createRoom(14,-1,16,-1,-1,20 ));
            //caveLayouts.Add(createRoom(-1,-1,23,29,-1,27));
            //caveLayouts.Add(createRoom(-1,-1,18,24,-1,22 ));
            //caveLayouts.Add(createRoom(23,18,-1,-1,30,-1));
            //caveLayouts.Add(createRoom(-1,19,20,-1,-1,30 ));
            //caveLayouts.Add(createRoom(-1,-1,-1,3,2,1));
            //caveLayouts.Add(createRoom(20,-1,22,-1,3,-1 ));
            //caveLayouts.Add(createRoom(-1,-1,29,5,-1,3 ));
            //caveLayouts.Add(createRoom(22,-1,-1,-1,5,28 ));
            //caveLayouts.Add(createRoom(-1,24,25,1,-1,-1 ));
        }

        //public

    }


}
