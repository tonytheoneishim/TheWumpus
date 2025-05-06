using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingGround;

namespace GCUITest
{
    public partial class PlayernameScreen : Form
    {
        string playername = string.Empty;
        public PlayernameScreen()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please enter a valid name.");
                return;
            }
            else
            {
                playername = textBoxName.Text;

                this.Hide();

                Game game = new Game();
                game.PlayerName = playername;
                game.ShowDialog();

                this.Close();
            }
        }
    }
}
