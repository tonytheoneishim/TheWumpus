using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
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

        public int Arrows { get; set; }
        public int Gold { get; set; }
        public int Turns { get; set; }
        public bool WumpusDead { get; set; }
        public int Wumpus { get; set; }

        private void Shop_Load(object sender, EventArgs e)
        {
            labelCoinCount.Text = Gold.ToString();
            labelArrowCount.Text = Arrows.ToString();
            labelReciept.Text = "";
        }

        public Tuple<int, int> UpdateValues(int previousGold)
        {
            if (previousGold - Gold == 3)
            {
                return new Tuple<int, int>(Gold, Arrows + 1);
            }

            return new Tuple<int, int>(Gold, Arrows);
        }

        private void pictureBoxArrowBuy_Click(object sender, EventArgs e)
        {
            if (Gold >= 3)
            {
                labelCoinCount.Text = (Gold - 3).ToString();
                labelArrowCount.Text = (Arrows + 1).ToString();
                MessageBox.Show("You purchased an arrow!");
            }
            else
            {
                MessageBox.Show("Not enough gold coins!", "Transaction failed!");
            }
        }
        private void pictureBoxSecretBuy_Click(object sender, EventArgs e)
        {
            if (Gold >= 5)
            {
                labelCoinCount.Text = (Gold - 5).ToString();
                MessageBox.Show("The Wumpus is currently located in Room " + Wumpus.ToString());
            }
            else
            {
                MessageBox.Show("Not enough gold coins!", "Transaction failed!");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
