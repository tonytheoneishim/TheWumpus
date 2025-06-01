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
using GCUITest;
using GCUITest.Properties;

namespace GCUITest
{
    public partial class EndScreen : Form
    {
        public string PlayerName { get; set; }
        public string CaveType { get; set;  }
        public int arrows { get; set; }
        public int gold { get; set; }
        public int turns { get; set; }
        public bool wumpusDead { get; set; }

        Highscore highscore;
        Player player;

        int score = 100;
        public EndScreen()
        {
            InitializeComponent();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {            
            this.Hide();
            HighScoreForm highscoreform = new HighScoreForm();
            highscoreform.PlayerName = PlayerName;
            highscoreform.CaveType = CaveType;
            highscoreform.ArrowsLeft = arrows;
            highscoreform.GoldCoinsLeft = gold;
            highscoreform.Turns = turns;
            highscoreform.KilledWumpus = wumpusDead;
            highscoreform.score = score;

            highscoreform.ShowDialog();
            this.Close();
        }

        private void EndScreen_Load(object sender, EventArgs e)
        {
            player = new Player(arrows, gold, turns, wumpusDead);
            highscore = new Highscore(PlayerName, score, CaveType, player.Turns, player.Arrows, player.Gold, player.WumpusDead);
            highscore.AddHighscore(PlayerName, score, CaveType,
                player.Turns, player.Arrows, player.Gold, player.WumpusDead);
            score = player.CalculateScore();

            if (player.WumpusDead == true)
            {
                this.BackgroundImage = Resources.endscreenbg;
                labelVictory.Visible = true;
                labelWumpKilled.Visible = true;
                labelDefeat.Visible = false;
                labelWumpLives.Visible = false;
            }
            else if (player.WumpusDead == false || player.Arrows == 0)
            {
                this.BackgroundImage = Resources.Killed_By_Wumpus;
                labelDefeat.Visible = true;
                labelWumpLives.Visible = true;
                labelVictory.Visible = false;
                labelWumpKilled.Visible = false;
            }
            else if (player.WumpusDead == false || player.Arrows > 0)
            {
                this.BackgroundImage = Resources.Died_by_Pit;
                labelDefeat.Visible = true;
                labelWumpLives.Visible = true;
                labelVictory.Visible = false;
                labelWumpKilled.Visible = false;
            }
            else MessageBox.Show("are people getting more dumb cuz like society needs to wake up","error");

            labelPlayerName.Text = PlayerName;
            labelCoinCount.Text = player.Gold.ToString();
            labelArrowCount.Text = player.Arrows.ToString();
            labelScore.Text = score.ToString();
        }
    }
}
