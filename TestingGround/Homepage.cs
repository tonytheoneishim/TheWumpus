using Highscore___Testing___Dev;
using CaveTest;
using GCUITest;

namespace TestingGround

{
    public partial class Homepage : Form
    {
        public bool GLOBALHIGHSCOREINTPLEASEWORKLMAO = false;
        Highscore highscore = new Highscore();
        HighScoreForm hsf = new HighScoreForm();
        
        public Homepage()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();

            PlayernameScreen playernameScreen = new PlayernameScreen();
            playernameScreen.ShowDialog();

            this.Close();
        }

        private void buttonHighscores_Click(object sender, EventArgs e)
        {
            this.Hide();

            hsf.AddingBoolean = false;
            GLOBALHIGHSCOREINTPLEASEWORKLMAO = false;
            HighScoreForm highScoreForm = new HighScoreForm();
            highScoreForm.ShowDialog();

            this.Close();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            hsf.AddingBoolean = false;
            GLOBALHIGHSCOREINTPLEASEWORKLMAO = false;
        }
    }
}
