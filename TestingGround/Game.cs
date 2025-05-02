using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingGround
{
    public partial class Game : Form
    {
        string directionClicked = string.Empty;

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
            labelRoomMoved.Text = "You moved North";
        }

        private void buttonRoomNE_Click(object sender, EventArgs e)
        {
            directionClicked = "NE";
            labelRoomMoved.Text = "You moved North-East";
        }

        private void buttonRoomSE_Click(object sender, EventArgs e)
        {
            directionClicked = "SE";
            labelRoomMoved.Text = "You moved South-East";
        }

        private void buttonRoomS_Click(object sender, EventArgs e)
        {
            directionClicked = "S";
            labelRoomMoved.Text = "You moved South";
        }

        private void buttonRoomSW_Click(object sender, EventArgs e)
        {
            directionClicked = "SW";
            labelRoomMoved.Text = "You moved South-West";
        }

        private void buttonRoomNW_Click(object sender, EventArgs e)
        {
            directionClicked = "NW";
            labelRoomMoved.Text = "You moved North-West";
        }
    }
}
