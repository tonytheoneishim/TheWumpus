using Highscore___Testing___Dev;
using CaveTest;
using GCUITest;

namespace TestingGround

{
    public partial class Homepage : Form
    {
        Highscore highscore = new Highscore();
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

            HighScoreForm highScoreForm = new HighScoreForm();
            highScoreForm.ShowDialog();

            this.Close();
        }
    }
}
