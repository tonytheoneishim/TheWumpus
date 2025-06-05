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

        public void pictureBoxArrowBuy_Click(object sender, EventArgs e)
        {
            if (int.Parse(labelCoinCount.Text) >= 3)
            {
                GetGold -= 3;
                GetArrows++;

                labelCoinCount.Text = GetGold.ToString();
                labelArrowCount.Text = GetArrows.ToString();
                MessageBox.Show("You purchased an arrow!");
            }
            else
            {
                MessageBox.Show("Not enough gold coins!", "Transaction failed!");
            }
        }
        public void pictureBoxSecretBuy_Click(object sender, EventArgs e)
        {
            if (int.Parse(labelCoinCount.Text) >= 5)
            {
                GetGold -= 5;
                labelCoinCount.Text = GetGold.ToString();

                //Message box for the secret
                MessageBox.Show("The Wumpus is in room " + WumpusLocation.ToString(), "Shhhhhh...");
            }
            else
            {
                MessageBox.Show("Not enough gold coins!", "Transaction failed!");
            }
        }

        public void Shop_Load(object sender, EventArgs e)
        {
            player = new Player(GetArrows, GetGold, GetTurns, GetLife);

            labelCoinCount.Text = GetGold.ToString();
            labelArrowCount.Text = GetArrows.ToString();
            labelReciept.Text = "";
        }

        public void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
