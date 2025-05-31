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
using Highscore___Testing___Dev;
using WumpusPlayer;
using WumpusPLayer;
using GCUITest;

namespace GCUITest
{
    public partial class EndScreen : Form
    {
        Highscore highscore;
        Player player;
        Game game;

        int score;
        public EndScreen()
        {
            InitializeComponent();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            highscore.AddHighscore(game.PlayerName, score, "kellen help cave (set as string currently)", 
                player.Turns, player.Arrows, player.Gold, player.WumpusDead);

            this.Hide();
            HighScoreForm highscoreform = new HighScoreForm();
            highscoreform.ShowDialog();
            this.Close();
        }

        private void EndScreen_Load(object sender, EventArgs e)
        {
            score =  player.CalculateScore();

            if (player.WumpusDead == true)
            {
                labelVictory.Visible = true;
                labelWumpKilled.Visible = true;
                labelDefeat.Visible = false;
                labelWumpLives.Visible = false;
            }
            else if (player.WumpusDead == false)
            {
                labelDefeat.Visible = true;
                labelWumpLives.Visible = true;
                labelVictory.Visible = false;
                labelWumpKilled.Visible = false;
            }
            else MessageBox.Show("are people getting more dumb cuz like society needs to wake up","error");

            labelPlayerName.Text = game.PlayerName;
            labelCoinCount.Text = player.Gold.ToString();
            labelArrowCount.Text = player.Arrows.ToString();
            labelScore.Text = score.ToString();
        }
    }
}
