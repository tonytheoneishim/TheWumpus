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
        string directionClicked = string.Empty;

        int coins = 0;
        int arrows = 0;
        int turns = 0;
        double score = 0.0;
        public Game()
        {
            InitializeComponent();
            pictureBoxRoom.SendToBack();
        }

        private void MoveRooms(string direction)
        {

        }

        private void buttonRoomN_Click(object sender, EventArgs e)
        {
            directionClicked = "N";
            DoTurn();
        }

        private void buttonRoomNE_Click(object sender, EventArgs e)
        {
            directionClicked = "NE";
            DoTurn();
        }

        private void buttonRoomSE_Click(object sender, EventArgs e)
        {
            directionClicked = "SE";
            DoTurn();
        }

        private void buttonRoomS_Click(object sender, EventArgs e)
        {
            directionClicked = "S";
            DoTurn();
        }

        private void buttonRoomSW_Click(object sender, EventArgs e)
        {
            directionClicked = "SW";
            DoTurn();
        }

        private void buttonRoomNW_Click(object sender, EventArgs e)
        {
            directionClicked = "NW";
            DoTurn();
        }

        public void DoTurn()
        {
            if (directionClicked == "N")
            {
                // Move north
                labelRoomMoved.Text = "You moved north.";
            }
            else if (directionClicked == "NE")
            {
                // Move northeast
                labelRoomMoved.Text = "You moved northeast.";
            }
            else if (directionClicked == "SE")
            {
                // Move southeast
                labelRoomMoved.Text = "You moved southeast.";
            }
            else if (directionClicked == "S")
            {
                // Move south
                labelRoomMoved.Text = "You moved south.";
            }
            else if (directionClicked == "SW")
            {
                // Move southwest
                labelRoomMoved.Text = "You moved southwest.";
            }
            else if (directionClicked == "NW")
            {
                // Move northwest
                labelRoomMoved.Text = "You moved northwest.";
            }

            coins++;
            arrows++;
            turns++;
            score = 100 - turns + coins + (arrows * 5);

            labelCoins.Text = coins.ToString();
            labelArrows.Text = arrows.ToString();
            labelPoints.Text = score.ToString();
        }
    }
}
