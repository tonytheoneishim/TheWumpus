namespace testPlayerForm
{
    public partial class testPlayerForm : Form
    {
        List<Player> players = new List<Player>();
        public testPlayerForm()
        {
            InitializeComponent();
        }

        private void addPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameText.Text;
                int arrows = int.Parse(arrowsText.Text);
                int coins = int.Parse(coinsText.Text);
                int turns = int.Parse(turnsText.Text);
                bool wumpusDead = wumpusDeadRadio.Checked;

                Player player = new Player(name, arrows, coins, turns, wumpusDead);
                players.Add(player);

                addArrows.Enabled = true;
                removeArrows.Enabled = true;
                addCoins.Enabled = true;
                removeCoins.Enabled = true;
                getScore.Enabled = true;
            }
            catch (FormatException)
            {
                if (string.IsNullOrWhiteSpace(nameText.Text) || string.IsNullOrWhiteSpace(arrowsText.Text) || string.IsNullOrWhiteSpace(coinsText.Text) || string.IsNullOrWhiteSpace(turnsText.Text))
                {
                    MessageBox.Show("One or more textboxes are empty");
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
            }
        }

        private void getScore_Click(object sender, EventArgs e)
        {
            Player player1 = players[0];
            MessageBox.Show(player1.calculateScore(player1.Turns, player1.Coins, player1.Arrows, player1.WumpusDead).ToString());
        }

        private void addArrows_Click(object sender, EventArgs e)
        {
            try
            {
                players[0].addArrow(true);
                arrowsText.Text = players[0].Arrows.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void removeArrows_Click(object sender, EventArgs e)
        {
            players[0].removeArrow();
            arrowsText.Text = players[0].Arrows.ToString();
        }

        private void addCoins_Click(object sender, EventArgs e)
        {
            players[0].addCoins(10);
            coinsText.Text = players[0].Coins.ToString();
        }

        private void removeCoins_Click(object sender, EventArgs e)
        {
            players[0].removeCoins(10);
            coinsText.Text = players[0].Coins.ToString();
        }

        private void testPlayerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
