using CaveTest;

namespace WumpusLocations
{
    public partial class caveLocationsForm : Form
    {
        public List<int[]> caveLayouts = new List<int[]>();
        List<Locations> locations = new List<Locations>();
        public int[] createRoom(int a, int b, int c, int d, int e, int f)
        {
            int[] conns = { a, b, c, d, e, f };
            return conns;
        }

        public caveLocationsForm()
        {
            InitializeComponent();
            caveLayouts.Add(createRoom(29, -1, 25, 1, 6, -1));
            caveLayouts.Add(createRoom(0, 25, -1, -1, 7, -1));
            caveLayouts.Add(createRoom(25, 26, 27, 3, -1, -1));
            caveLayouts.Add(createRoom(2, -1, -1, 10, -1, 8));
            caveLayouts.Add(createRoom(27, 28, -1, 5, -1, -1));
            caveLayouts.Add(createRoom(4, -1, -1, -1, 11, 10));
            caveLayouts.Add(createRoom(-1, 0, -1, 7, 12, -1));
            caveLayouts.Add(createRoom(6, 1, -1, 14, -1, -1));
            caveLayouts.Add(createRoom(-1, -1, 3, 9, 14, -1));
            caveLayouts.Add(createRoom(8, -1, -1, -1, 15, 14));
            caveLayouts.Add(createRoom(3, -1, 5, -1, 16, -1));
            caveLayouts.Add(createRoom(-1, 5, -1, 12, -1, 16));
            caveLayouts.Add(createRoom(11, 6, -1, 13, -1, -1));
            caveLayouts.Add(createRoom(12, -1, -1, 20, -1, 18));
            caveLayouts.Add(createRoom(7, 8, 9, -1, -1, -1));
            caveLayouts.Add(createRoom(-1, 9, 16, -1, -1, 20));
            caveLayouts.Add(createRoom(-1, 10, 11, -1, -1, 15));
            caveLayouts.Add(createRoom(-1, -1, -1, 18, 23, 22));
            caveLayouts.Add(createRoom(17, -1, 13, -1, 24, -1));
            caveLayouts.Add(createRoom(-1, -1, 20, 26, -1, 24));
            caveLayouts.Add(createRoom(13, -1, 15, -1, -1, 19));
            caveLayouts.Add(createRoom(-1, -1, 22, 28, -1, 26));
            caveLayouts.Add(createRoom(-1, -1, 17, 23, -1, 21));
            caveLayouts.Add(createRoom(22, 17, -1, -1, 29, -1));
            caveLayouts.Add(createRoom(-1, 18, 19, -1, -1, 29));
            caveLayouts.Add(createRoom(-1, -1, -1, 2, 1, 0));
            caveLayouts.Add(createRoom(19, -1, 21, -1, 2, -1));
            caveLayouts.Add(createRoom(-1, -1, 28, 4, -1, 2));
            caveLayouts.Add(createRoom(21, -1, -1, -1, 4, 27));
            caveLayouts.Add(createRoom(-1, 23, 24, 0, -1, -1));
            Locations cave = new Locations(caveLayouts);
            locations.Add(cave);

            wumpusLocationLabel.Text = "Wumpus: " + cave.Wumpus.ToString();
            playerLocationLabel.Text = "Player: " + cave.Player.ToString();
        }

        private void moveWumpus_Click(object sender, EventArgs e)
        {
            if (locations[0].MoveWumpus())
            {
                wumpusMovedCheck.Checked = true;
                wumpusLocationLabel.Text = "Wumpus: " + locations[0].Wumpus.ToString();
            }
            else
            {
                wumpusMovedCheck.Checked = false;
            }
        }

        private void checkRoomType_Click(object sender, EventArgs e)
        {
            caveTypeText.Text = locations[0].RoomType().ToString();
        }

        private void checkHazards_Click(object sender, EventArgs e)
        {
            hazardsNearbyText.Text = locations[0].HazardNearby().ToString();
        }

        private void shootArrow_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(arrowDirectionText.Text);
                if (locations[0].ShootArrow(i))
                {
                    hitWumpusCheck.Checked = true;
                }
                else
                {
                    hitWumpusCheck.Checked = false;
                }
            }
            catch (FormatException)
            {
                if (arrowDirectionText.Text.Length == 0)
                {
                    MessageBox.Show("Textbox is empty");
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
            }
        }

        private void spawnEvents_Click(object sender, EventArgs e)
        {
            List<int[]> events = locations[0].SpawnEvents();
            foreach (int[] evt in events)
            {
                eventsList.Items.Add(evt[0]);
                eventsList.Items.Add(evt[1]);
            }
        }
    }
}
