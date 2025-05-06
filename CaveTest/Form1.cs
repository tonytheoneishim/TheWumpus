using System;
using System.Drawing.Text;

namespace CaveTest
{
    // 
    //
    //
    //
    // Hey Eric, is there any way for you to make the paths 0-based?
    // It's screwing up with my code in Locations, so I want to make sure there won't be a problem in the future
    //
    // Thanks,
    // Changle (Locations & Player)
    //
    //
    //
    //
    //
    //
    //
    //
    //
    public partial class Form1 : Form
    {
        public Cave cave = new Cave();
        // Start position can be changed to test rooms and the doors that are open
        const int START_POSITION = 1;


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
            int[] connectedRooms = cave.caveLayouts[--currentRoom];
            // reflect the state of connected rooms (for each index in the array, update corresponding button)

            for (int i = 0; i < 6; i++)
            {
                buttons[i].Text = connectedRooms[i].ToString();
                if (connectedRooms[i] > -1) buttons[i].Visible = true;
            }

            comboBoxMapSelection.SelectedIndex = 0;// removing this makes errors go away
        }

        private int ShowCurrentRoom(int room)
        {
            //this function will display the current room
            int newRoom = room;
            return newRoom;
        }

        private void buttonRoom1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = -1;
            //MessageBox.Show(button.Text);

            index = int.Parse(button.Text);
            textBoxNum.Text = button.Text;
            currentRoom = index;

            //if (button.Name.ToString() == "buttonRoom1")
            //{
            //    index = int.Parse(buttonRoom1.Text);
            //    textBoxNum.Text = buttonRoom1.Text;
            //    currentRoom = index;
            //}

            //if (button.Name.ToString() == "buttonRoom2")
            //{
            //    index = int.Parse(buttonRoom2.Text);
            //    textBoxNum.Text = buttonRoom2.Text;
            //    currentRoom = index;
            //}
            //if (button.Name.ToString() == "buttonRoom3")
            //{
            //    index = int.Parse(buttonRoom3.Text);
            //    textBoxNum.Text = buttonRoom3.Text;
            //    currentRoom = index;
            //}
            //if (button.Name.ToString() == "buttonRoom4")
            //{
            //    index = int.Parse(buttonRoom4.Text);
            //    textBoxNum.Text = buttonRoom4.Text;
            //    currentRoom = index;
            //}
            //if (button.Name.ToString() == "buttonRoom5")
            //{
            //    index = int.Parse(buttonRoom5.Text);
            //    textBoxNum.Text = buttonRoom5.Text;
            //    currentRoom = index;
            //}
            //if (button.Name.ToString() == "buttonRoom6")
            //{
            //    index = int.Parse(buttonRoom6.Text);
            //    textBoxNum.Text = buttonRoom6.Text;
            //    currentRoom = index;
            //}

            //MessageBox.Show(index.ToString());

            updateButtons(index);
            //int[] connectedRooms = cave.caveLayouts[--index];
            //// reflect the state of connected rooms (for each index in the array, update corresponding button)

            //for (int i = 0; i < 6; i++)
            //{
            //    buttons[i].Visible = false;
            //}

            //for (int i = 0; i < 6; i++)
            //{
            //    buttons[i].Text = connectedRooms[i].ToString();
            //    if (connectedRooms[i] > -1) buttons[i].Visible = true;
            //}
            //updateRoom(index);
        }


        private void updateButtons(int index)
        {
            int[] connectedRooms = cave.caveLayouts[--index];
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
        }



        private void buttonConstructor_Click(object sender, EventArgs e)
        {
            cave = new Cave();
            int skibidi = ShowCurrentRoom(int.Parse(textBoxNum.Text));
            MessageBox.Show(skibidi.ToString());
        }

        private void comboBoxMapSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = comboBoxMapSelection.SelectedIndex;
                cave.caveSelect(index);
                updateButtons(1);
            }
            catch
            {
                MessageBox.Show("Please pick a map!");
                comboBoxMapSelection.SelectedIndex = 0;
            }

            
        }
    }
}
