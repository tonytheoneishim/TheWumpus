using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveTest
{
    public class Cave
    {
        const int START_POSITION = 1;
        // Consts
        const int WALL = -1;
        public static int[] createRoom(params int[] rooms)
        {
            return rooms;
        }

        public int[][] caveLayout = new int[][] {
                createRoom(30,-1,26, 7, 2,-1),
                createRoom( 1,26,-1,-1,8,-1 ),
                createRoom(26, 27, 28, 4,-1,-1 ),
                createRoom(3,-1,-1,11,-1,9 ),
                createRoom(28, 29, -1, 6, -1, -1),
                createRoom(5,-1,-1,-1,12,11 ),
                createRoom(-1,1,-1,8,7,-1 ),
                createRoom(7, 2, -1, 15, -1, -1),
                createRoom(-1, -1, 4, 10, 15, -1),
                createRoom(9,-1,-1,-1,16,15 ),
                createRoom(4, -1, 6, -1, 17, -1),
                createRoom(-1,6,-1,13,-1,17), //12th room
                createRoom(12, 7, -1, 14, -1, -1),
                createRoom(13, -1, -1, 21, -1, 19),
                createRoom(8, 9, 10, -1, -1, -1),
                createRoom(-1,10,17,-1,-1,21 ), //16th room
                createRoom(-1, 11,12,-1,-1,16 ),
                createRoom(-1,-1,-1,19,24,23 ),
                createRoom(18,-1,14,-1,25,-1 ),
                createRoom(-1,-1,21,27,-1,25 ),
                createRoom(14,-1,16,-1,-1,20 ),
                createRoom(-1,-1,23,29,-1,27), //22nd room
                createRoom(-1,-1,18,24,-1,22 ), //23rd room; will make 7 more and configure more things given the walls
                createRoom(23,18,-1,-1,30,-1),
                createRoom(-1,19,20,-1,-1,30 ),
                createRoom(-1,-1,-1,3,2,1),
                createRoom(20,-1,22,-1,3,-1 ),
                createRoom(-1,-1,29,5,-1,3 ),
                createRoom(22,-1,-1,-1,5,28 ),
                createRoom(-1,24,24,1,-1,-1 ), //30 roomss holy smokes this joint took me 2 class periods
            };

        public Cave() {
            // make the below chart the room connections which correspond with the side so 6 values per group -1 means wall 
            // this eventually will most likely be an outside file
            
        }


        //public static int[] getConnections(int index)
        //{
        //    index -= 1;
        //    int[] connections = { caveLayout[index,0 ],}
        //    return connections;
        //}
        // add a read from file method

        // get cave system to use

    }
        
    
}
