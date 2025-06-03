using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingGround;
using WumpusPlayer;


namespace GCUITest
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        Player player;
        public int GetArrows { get; set; }
        public int GetGold { get; set; }
        public int GetTurns { get; set; }
        public bool GetLife { get; set; }
        public int WumpusLocation { get; set; }

        private void pictureBoxArrowBuy_Click(object sender, EventArgs e)
        {
            if (int.Parse(labelCoinCount.Text) >= 3)
            {
                player.Gold -= 3;
                player.Arrows++;
                labelCoinCount.Text = player.Gold.ToString();
                labelArrowCount.Text = player.Arrows.ToString();
                MessageBox.Show("You purchased an arrow!");
            }
            else
            {
                MessageBox.Show("Not enough gold coins!", "Transaction failed!");
            }
        }
        private void pictureBoxSecretBuy_Click(object sender, EventArgs e)
        {
            if (int.Parse(labelCoinCount.Text) >= 5)
            {
                player.Gold -= 5;
                labelCoinCount.Text = player.Gold.ToString();

                //Message box for the secret
                MessageBox.Show("The Wumpus is in room " + WumpusLocation.ToString(), "Shhhhhh...");
            }
            else
            {
                MessageBox.Show("Not enough gold coins!", "Transaction failed!");
            }
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            player = new Player(GetArrows, GetGold, GetTurns, GetLife);

            labelCoinCount.Text = GetGold.ToString();
            labelArrowCount.Text = GetArrows.ToString();
            labelReciept.Text = "";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            player.Gold = int.Parse(labelCoinCount.Text);
            player.Arrows = int.Parse(labelArrowCount.Text);
            this.Close();
        }
    }
}
