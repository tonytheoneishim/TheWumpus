using Highscore___Testing___Dev;
using CaveTest;

namespace TestingGround

{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Hide();

            Game game = new Game();
            game.ShowDialog();

            this.Close();
        }

        private void buttonHighscores_Click(object sender, EventArgs e)
        {
            this.Hide();

            HighScoreForm highScoreForm = new HighScoreForm();
            highScoreForm.ShowDialog();

            this.Show();
        }
    }
}
