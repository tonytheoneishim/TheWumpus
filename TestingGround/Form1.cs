using Highscore___Testing___Dev;

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
            Game game = new Game();
            game.ShowDialog();

            Close();
        }

        private void buttonHighscores_Click(object sender, EventArgs e)
        {
            //i think we need to talk :| :| :| :| :| lol ok.
        }
    }
}
