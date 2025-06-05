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
        public string caveType { get; set;  }
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
            Homepage homepage = new Homepage();
            homepage.GLOBALHIGHSCOREINTPLEASEWORKLMAO = true;
            this.Hide();
            
            HighScoreForm highscoreform = new HighScoreForm();
            highscoreform.AddingBoolean = true;

            highscoreform.Name = Name;
            highscoreform.score = FinalScore;
            highscoreform.CaveType = caveType;
            highscoreform.Turns = turns;
            highscoreform.GoldCoinsLeft = gold;
            highscoreform.ArrowsLeft = arrows;
            highscoreform.KilledWumpus = wumpusDead;

            Highscore highscore = new Highscore();

            highscore.PlayerName = Name;
            highscore.PlayerFinalScore = FinalScore;
            highscore.CaveType = caveType;
            highscore.Turns = turns;
            highscore.ArrowsLeft = arrows;
            highscore.GoldCoinsLeft = gold;
            highscore.KilledWumpus = wumpusDead;

            highscore.AddHighscore(Name, FinalScore, caveType, turns, arrows, gold, wumpusDead);

            //idea, add an int,
            //if the int is 0, dont run the addhighscore, if it is 1, run the addhighscore. reset the number
            //idk, but set the number to wherever highscoreform is opened.

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
