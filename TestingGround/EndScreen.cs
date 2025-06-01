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
using WumpusPlayer;
using GCUITest;
using GCUITest.Properties;

namespace GCUITest
{
    public partial class EndScreen : Form
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }
        public string CaveType { get; set;  }
        public int Arrows { get; set; }
        public int Gold { get; set; }
        public int Turns { get; set; }
        public bool WumpusDead { get; set; }

        Highscore highscore;

        public EndScreen()
        {
            InitializeComponent();
            highscore = new Highscore(PlayerName, Score, CaveType, Turns, Arrows, Gold, WumpusDead);
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {            
            this.Hide();
            HighScoreForm highscoreform = new HighScoreForm();
            highscoreform.PlayerName = PlayerName;
            highscoreform.Score = Score;
            highscoreform.CaveType = CaveType;
            highscoreform.Arrows = Arrows;
            highscoreform.Gold = Gold;
            highscoreform.Turns = Turns;
            highscoreform.WumpusDead = WumpusDead;
            
            highscoreform.ShowDialog();
            this.Close();
        }

        private void EndScreen_Load(object sender, EventArgs e)
        {
            highscore = new Highscore(PlayerName, Score, CaveType, Arrows, Gold, Turns, WumpusDead);
            highscore.AddHighscore();

            if (WumpusDead)
            {
                this.BackgroundImage = Resources.endscreenbg;
                labelVictory.Visible = true;
                labelWumpKilled.Visible = true;
                labelDefeat.Visible = false;
                labelWumpLives.Visible = false;
            }
            else if (!WumpusDead || Arrows == 0)
            {
                this.BackgroundImage = Resources.Killed_By_Wumpus;
                labelDefeat.Visible = true;
                labelWumpLives.Visible = true;
                labelVictory.Visible = false;
                labelWumpKilled.Visible = false;
            }
            else if (!WumpusDead || Arrows > 0)
            {
                this.BackgroundImage = Resources.Died_by_Pit;
                labelDefeat.Visible = true;
                labelWumpLives.Visible = true;
                labelVictory.Visible = false;
                labelWumpKilled.Visible = false;
            }
            else
            {
                MessageBox.Show("Are people getting more dumb cuz like society needs to wake up", "error");
            }

            labelPlayerName.Text = PlayerName;
            labelCoinCount.Text = Gold.ToString();
            labelArrowCount.Text = Arrows.ToString();
            labelScore.Text = Score.ToString();
        }
    }
}
