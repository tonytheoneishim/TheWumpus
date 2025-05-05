using Highscore___Testing___Dev;
using CaveTest;

namespace TestingGround

{
    public partial class Form1 : Form
    {
        Highscore highscore = new Highscore();
        public Form1()
        {
            InitializeComponent();

            highscore.PlayerList.Add(new Highscore("Kellen1", 10, "Cave1"));
            highscore.PlayerList.Add(new Highscore("Derek2", 20, "Cave2"));
            highscore.PlayerList.Add(new Highscore("Maxim(3)", 30, "Cave3"));

            Highscore.SavetoFile(highscore.PlayerList);
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
