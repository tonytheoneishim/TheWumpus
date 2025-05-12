using CaveTest;
using GCUITest;
using Highscore___Testing___Dev;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestingGround
{
    public partial class Game : Form
    {
        public Cave cave = new Cave();

        string directionClicked = string.Empty;

        int coins = 0;
        int arrows = 0;
        int turns = 0;
        double score = 100;
        int currentRoom = 0; // current room the player is in

        Button[] buttons = new Button[6];
        Random rand = new Random();
        int START_POSITION = 1;

        public string PlayerName { get; set; }
        public Game()
        {
            InitializeComponent();

            pictureBoxRoom.SendToBack();

            buttons[0] = buttonRoomNW;
            buttons[1] = buttonRoomN;
            buttons[2] = buttonRoomNE;
            buttons[3] = buttonRoomSE;
            buttons[4] = buttonRoomS;
            buttons[5] = buttonRoomSW;

            for (int i = 0; i < 6; i++)
            {
                buttons[i].Visible = false;
            }

            int currentRoom = START_POSITION;
            int[] connectedRooms = cave.caveLayouts[--currentRoom];

            for (int i = 0; i < 6; i++)
            {
                buttons[i].Text = connectedRooms[i].ToString();
                if (connectedRooms[i] > -1) buttons[i].Visible = true;
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            labelPlayerName.Text = PlayerName;
            labelCoins.Text = coins.ToString();
            labelArrows.Text = arrows.ToString();
            labelPoints.Text = score.ToString();

            int index = rand.Next(0, 3);
            cave.caveSelect(index);
            updateButtons(START_POSITION);
            labelRoomNum.Text = START_POSITION.ToString();
            labelCaveNum.Text = "Cave " + (index + 1).ToString();
        }

        private void buttonRoomN_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = -1;
            //MessageBox.Show(button.Text);

            index = int.Parse(button.Text);
            labelRoomNum.Text = button.Text;
            currentRoom = index;
            
            updateButtons(index);
            DoTurn();
        }

        public void DoTurn()
        {
            coins++;
            arrows++;
            turns++;
            score = 100 - turns + coins + (arrows * 5);

            labelCoins.Text = coins.ToString();
            labelArrows.Text = arrows.ToString();
            labelPoints.Text = score.ToString();
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
    }
}
