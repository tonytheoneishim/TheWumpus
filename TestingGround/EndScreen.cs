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
        public string Name { get; set; }
        public string CaveType { get; set;  }
        public int arrows { get; set; }
        public int gold { get; set; }
        public int turns { get; set; }
        public bool wumpusDead { get; set; }
        public int FinalScore { get; set; }

        //Highscore highscore = new Highscore();
        Player player;
        Game game;

        public EndScreen()
        {
            InitializeComponent();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {            
            this.Hide();
            HighScoreForm highscoreform = new HighScoreForm();
            highscoreform.Name = Name;
            highscoreform.score = FinalScore;
            highscoreform.CaveType = CaveType;
            highscoreform.Turns = turns;
            highscoreform.GoldCoinsLeft = gold;
            highscoreform.ArrowsLeft = arrows;
            highscoreform.KilledWumpus = wumpusDead;
            highscoreform.ShowDialog();
            this.Close();
        }

        private void EndScreen_Load(object sender, EventArgs e)
        {
            player = new Player(arrows, gold, turns, wumpusDead);
            
            labelPlayerName.Text = Name;
            labelCoinCount.Text = gold.ToString();
            labelArrowCount.Text = arrows.ToString();
            labelScore.Text = FinalScore.ToString();

            //highscore = new Highscore(Name, score, CaveType, turns, arrows, gold, wumpusDead);
            //highscore.AddHighscore(Name, score, CaveType, turns, arrows, gold, wumpusDead);

            if (player.WumpusDead == true)
            {
                this.BackgroundImage = Resources.endscreenbg;
                labelVictory.Visible = true;
                labelWumpKilled.Visible = true;
                labelDefeat.Visible = false;
                labelWumpLives.Visible = false;
            }
            else if (player.WumpusDead == false && player.Arrows == 0)
            {
                this.BackgroundImage = Resources.Killed_By_Wumpus;
                labelDefeat.Visible = true;
                labelWumpLives.Visible = true;
                labelVictory.Visible = false;
                labelWumpKilled.Visible = false;
            }
            else if (player.WumpusDead == false && player.Arrows > 0)
            {
                this.BackgroundImage = Resources.Died_by_Pit;
                labelDefeat.Visible = true;
                labelWumpLives.Visible = true;
                labelVictory.Visible = false;
                labelWumpKilled.Visible = false;
            }
            else MessageBox.Show("are people getting more dumb cuz like society needs to wake up","error");

        }
    }
}
