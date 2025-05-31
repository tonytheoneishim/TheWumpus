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
using WumpusPLayer;

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

        private void pictureBoxArrowBuy_Click(object sender, EventArgs e)
        {
            if (player.Gold >= 3)
            {
                player.Gold -= 3;
                player.Arrows++;
                labelCoinCount.Text = player.Gold.ToString();
                labelArrowCount.Text = player.Arrows.ToString();
                labelReciept.Text = "+ 1 arrow!";
                Thread.Sleep(500);
                labelReciept.Text = "";
            }
            else
            {
                MessageBox.Show("Not enough gold coins!", "Transaction failed!");
            }
        }
        private void pictureBoxSecretBuy_Click(object sender, EventArgs e)
        {
            if (player.Gold <= 5)
            {
                player.Gold -= 5;
                labelCoinCount.Text = player.Gold.ToString();
                labelReciept.Text = "+ 1 secret!";
                Thread.Sleep(500);
                labelReciept.Text = "";

                //Message box for the secret
                MessageBox.Show("Kellen could be freaky.", "Shhhhhh...");
            }
            else
            {
                MessageBox.Show("Not enough gold coins!", "Transaction failed!");
            }
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            player = new Player(GetArrows, GetGold, GetTurns, GetLife);

            labelCoinCount.Text = player.Gold.ToString();
            labelArrowCount.Text = player.Arrows.ToString();
            labelReciept.Text = "";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
