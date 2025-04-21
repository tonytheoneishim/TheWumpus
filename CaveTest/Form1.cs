using System.Drawing.Text;

namespace CaveTest
{
    public partial class Form1 : Form
    {
        private Cave _Cave;
        // Start position can be changed to test rooms and the doors that are open
        const int START_POSITION = 1;
        // Consts
        const int WALL = -1;
        // make the below chart the room connections which correspond with the side so 6 values per group -1 means wall 
        // this eventually will most likely be an outside file
        int[,] roomLayoutSkibidi = {
            { 30,-1,-1, 7, 2,-1 }
            , { 1,26,-1,-1,8,-1 }
            , {-1, 27, 28, 4,-1,-1 }
            , {3,-1,-1,11,-1,9 }
            , {28,29,-1,6,-1,-1 }
            , {5,-1,-1,-1,12,11 }
            , {-1,1,-1,8,7,-1 }
            , {7,2,-1,15,-1,-1}
            , {-1,-1,4,10,15,-1 }
            , {9,-1,-1,-1,16,15 }
            , {4,-1,6,-1,17,-1 }
            , {-1,6,-1,13,-1,17 } //12th room
            , {12,7,-1,14,-1,-1 }
            , {13,-1,-1,21,-1,19 }
            , {8,9,10,-1,-1,-1 }
            , {-1,10,17,-1,-1,21 } //16th room
            , {-1, 11,12,-1,-1,16 }
            , {-1,-1,-1,19,24,23 }
            , {18,-1,14,-1,25,-1 }
            , {-1,-1,21,27,-1,25 }
            , {14,-1,16,-1,-1,20 }
            , {-1,-1,23,29,-1,27} //22nd room
            , {-1,-1,18,24,-1,22 } //23rd room will make 7 more and configure more things given the walls
        };
        int currentRoom = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void updateRoom()
        {
            //this function will allow for the room to change to the desired room
        }

        private void buttonRoom1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRoom2_Click(object sender, EventArgs e)
        {

        }

        private void buttonRoom3_Click(object sender, EventArgs e)
        {

        }

        private void buttonRoom4_Click(object sender, EventArgs e)
        {

        }

        private void buttonRoom5_Click(object sender, EventArgs e)
        {

        }

        private void buttonRoom6_Click(object sender, EventArgs e)
        {

        }
        private void buttonConstructor_Click(object sender, EventArgs e)
        {
            _Cave = new Cave();
        }
    }
}
