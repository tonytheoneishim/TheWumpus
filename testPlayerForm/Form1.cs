using WumpusPlayer;

namespace WumpusPlayer
{
    public partial class cavePlayerForm : Form
    {
        List<Player> players = new List<Player>();
        public cavePlayerForm()
        {
            InitializeComponent();
            Player player = new Player(3, 5, 0, false);
            players.Add(player);
            playerLocationText.Text = 6.ToString();
        }

        private void movePlayer_Click(object sender, EventArgs e)
        {
            if (players[0].PlayerMove(1, new int[] { 1, 2, 3, 4, 5, 6 }))
            {
                playerMovedCheck.Checked = true;
                playerLocationText.Text = 1.ToString();
            }
            else
            {
                playerMovedCheck.Checked = false;
            }
        }

        private void calculateScore_Click(object sender, EventArgs e)
        {
            scoreText.Text = players[0].CalculateScore().ToString();
        }
    }
}
