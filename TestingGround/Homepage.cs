using Highscore___Testing___Dev;
using CaveTest;
using GCUITest;

namespace TestingGround

{
    public partial class Homepage : Form
    {

        HighScoreForm highScoreForm;
        PlayernameScreen playerNameScreen = new PlayernameScreen();
        public Homepage()
        {
            InitializeComponent();
            highScoreForm = new HighScoreForm();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();

            playerNameScreen.ShowDialog();
            this.Close();
        }

        private void buttonHighscores_Click(object sender, EventArgs e)
        {
            this.Hide();

            highScoreForm.ShowDialog();
            this.Close();
        }
    }
}
