namespace WumpusTest
{
    public partial class Form1 : Form
    {
        private Player player;
        private Locations locations;
        public Form1()
        {
            InitializeComponent();
        }

        private void playerConstructor_Click(object sender, EventArgs e)
        {
            player = new Player(3, 10, 0, false);

        }

        private void locationsConstructor_Click(object sender, EventArgs e)
        {
            locations = new Locations(0, new List<int> { 1, 2 }, new List<int> { 3, 4 }, new List<int> { 5, 6 });
        }
    }
}
