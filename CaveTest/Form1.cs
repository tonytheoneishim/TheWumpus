using System.Drawing.Text;

namespace CaveTest
{
    public partial class Form1 : Form
    {
        private Cave _Cave = new Cave();
        // Start position can be changed to test rooms and the doors that are open
        const int START_POSITION = 1;
        //// Consts
        //const int WALL = -1;
        //private static int[] createRoom(params int[] rooms) 
        //{
        //    return rooms;
        //}
        //// make the below chart the room connections which correspond with the side so 6 values per group -1 means wall 
        //// this eventually will most likely be an outside file
        //int[][] caveLayout = new int[][] {
        //    createRoom(30,-1,26, 7, 2,-1),
        //    createRoom( 1,26,-1,-1,8,-1 ),
        //    createRoom(3, 27, 28, 4,-1,-1 ),
        //    createRoom(3,-1,-1,11,-1,9 ),
        //    createRoom(28, 29, -1, 6, -1, -1),
        //    createRoom(5,-1,-1,-1,12,11 ),
        //    createRoom(-1,1,-1,8,7,-1 ),
        //    createRoom(7, 2, -1, 15, -1, -1),
        //    createRoom(-1, -1, 4, 10, 15, -1),
        //    createRoom(9,-1,-1,-1,16,15 ),
        //    createRoom(4, -1, 6, -1, 17, -1),
        //    createRoom(-1,6,-1,13,-1,17), //12th room
        //    createRoom(12, 7, -1, 14, -1, -1),
        //    createRoom(13, -1, -1, 21, -1, 19),
        //    createRoom(8, 9, 10, -1, -1, -1),
        //    createRoom(-1,10,17,-1,-1,21 ), //16th room
        //    createRoom(-1, 11,12,-1,-1,16 ),
        //    createRoom(-1,-1,-1,19,24,23 ),
        //    createRoom(18,-1,14,-1,25,-1 ),
        //    createRoom(-1,-1,21,27,-1,25 ),
        //    createRoom(14,-1,16,-1,-1,20 ),
        //    createRoom(-1,-1,23,29,-1,27), //22nd room
        //    createRoom(-1,-1,18,24,-1,22 ), //23rd room; will make 7 more and configure more things given the walls
        //    createRoom(23,18,-1,-1,30,-1),
        //    createRoom(-1,19,20,-1,-1,30 ),
        //    createRoom(-1,-1,-1,3,2,1),
        //    createRoom(20,-1,22,-1,3,-1 ),
        //    createRoom(-1,-1,29,5,-1,3 ),
        //    createRoom(22,-1,-1,-1,5,28 ),
        //    createRoom(-1,24,24,1,-1,-1 ), //30 roomss holy smokes this joint took me 2 class periods
        //};

        Button[] buttons = new Button[6];

        //room storage
        int currentRoom = 0;

        public Form1()
        {
            InitializeComponent();

            textBoxNum.Text = START_POSITION.ToString();

            buttons[0] = buttonRoom1;
            buttons[1] = buttonRoom2;
            buttons[2] = buttonRoom3;
            buttons[3] = buttonRoom4;
            buttons[4] = buttonRoom5;
            buttons[5] = buttonRoom6;

            for (int i = 0; i < 6; i++)
            {
                buttons[i].Visible = false;
            }

            // I want buttons to appear where connections are.
            // what room im in: Room 1: START_POSITION
            int currentRoom = START_POSITION;
            // rooms connected: Go to caveLayout to get connected rooms (will be an array of ints)
            int[] connectedRooms = _Cave.caveLayout[--currentRoom];
            // reflect the state of connected rooms (for each index in the array, update corresponding button)

            for (int i = 0;i < 6; i++)
            {
                buttons[i].Text = connectedRooms[i].ToString();
                if (connectedRooms[i] > -1) buttons[i].Visible = true;
            }
        }

        private int[] updateRoom(int room)
        {
            //this function will allow for the room to change to the desired room

            // allows me to find the index
            int index = room--;

            // places index in list to retrieve array
            int[] newRoom = _Cave.caveLayout[index];

            return newRoom;
        }

        private void buttonRoom1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = -1;
            //MessageBox.Show(button.Text);

            if(button.Name.ToString() == "buttonRoom1")
            {
                index = int.Parse(buttonRoom1.Text);
                textBoxNum.Text = buttonRoom1.Text;
            }

            if (button.Name.ToString() == "buttonRoom2")
            {
                index = int.Parse(buttonRoom2.Text);
                textBoxNum.Text = buttonRoom2.Text;
            }
            if (button.Name.ToString() == "buttonRoom3")
            { 
                index = int.Parse(buttonRoom3.Text);
                textBoxNum.Text = buttonRoom3.Text;
            }
            if (button.Name.ToString() == "buttonRoom4")
            {
                index = int.Parse(buttonRoom4.Text);
                textBoxNum.Text = buttonRoom4.Text;
            }
            if (button.Name.ToString() == "buttonRoom5")
            {
                index = int.Parse(buttonRoom5.Text);
                textBoxNum.Text = buttonRoom5.Text;
            }
            if (button.Name.ToString() == "buttonRoom6")
            {
                index = int.Parse(buttonRoom6.Text);
                textBoxNum.Text = buttonRoom6.Text;
            }

            //MessageBox.Show(index.ToString());

            int[] connectedRooms = _Cave.caveLayout[--index];
            // reflect the state of connected rooms (for each index in the array, update corresponding button)

            for (int i = 0; i < 6; i++)
            {
                buttons[i].Visible = false;
            }

            for (int i = 0; i < 6; i++)
            {
                buttons[i].Text = connectedRooms[i].ToString();
                if (connectedRooms[i] > -1) buttons[i].Visible = true;
            }
            //updateRoom(index);
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
