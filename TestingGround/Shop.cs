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



        private void pictureBoxArrowBuy_Click(object sender, EventArgs e)
        {
            if (player.Gold >= 3)
            {
                player.Gold -= 3;
                player.Arrows++;
                labelReciept.Text = "+ 1 arrow!";
                labelCoinCount.Text = player.Gold.ToString();
                labelArrowCount.Text = player.Arrows.ToString();
            }
            else
            {
                MessageBox.Show("Not enough gold coins!", "Transaction failed!");
            }
        }
        private void pictureBoxSecretBuy_Click(object sender, EventArgs e)
        {

        }

        private void Shop_Load(object sender, EventArgs e)
        {
            labelCoinCount.Text = player.Gold.ToString();
            labelArrowCount.Text = player.Arrows.ToString();
        }
    }
}
