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
            caveLayouts.Add(createRoom(30, -1, 26, 2, 7, -1));
            caveLayouts.Add(createRoom(1, 24, -1, -1, 8, -1));
            caveLayouts.Add(createRoom(26, 27, 28, 4, -1, -1));
            caveLayouts.Add(createRoom(3, -1, -1, 11, -1, 9));
            caveLayouts.Add(createRoom(28, 29, -1, 6, -1, -1));
            caveLayouts.Add(createRoom(5, -1, -1, -1, 12, 11));
            caveLayouts.Add(createRoom(-1, 1, -1, 8, 13, -1));
            caveLayouts.Add(createRoom(7, 2, -1, 15, -1, -1));
            caveLayouts.Add(createRoom(-1, -1, 4, 10, 15, -1));
            caveLayouts.Add(createRoom(9, -1, -1, -1, 16, 15));
            caveLayouts.Add(createRoom(4, -1, 6, -1, 17, -1));
            caveLayouts.Add(createRoom(-1, 6, -1, 13, -1, 17));
            caveLayouts.Add(createRoom(12, 7, -1, 14, -1, -1));
            caveLayouts.Add(createRoom(13, -1, -1, 21, -1, 19));
            caveLayouts.Add(createRoom(8, 9, 10, -1, -1, -1));
            caveLayouts.Add(createRoom(-1, 10, 17, -1, -1, 21));
            caveLayouts.Add(createRoom(-1, 11, 12, -1, -1, 16));
            caveLayouts.Add(createRoom(-1, -1, -1, 19, 24, 23));
            caveLayouts.Add(createRoom(18, -1, 14, -1, 25, -1));
            caveLayouts.Add(createRoom(-1, -1, 21, 27, -1, 25));
            caveLayouts.Add(createRoom(14, -1, 16, -1, -1, 20));
            caveLayouts.Add(createRoom(-1, -1, 23, 29, -1, 27));
            caveLayouts.Add(createRoom(-1, -1, 18, 24, -1, 22));
            caveLayouts.Add(createRoom(23, 18, -1, -1, 30, -1));
            caveLayouts.Add(createRoom(-1, 19, 20, -1, -1, 30));
            caveLayouts.Add(createRoom(-1, -1, -1, 3, 2, 1));
            caveLayouts.Add(createRoom(20, -1, 22, -1, 3, -1));
            caveLayouts.Add(createRoom(-1, -1, 29, 5, -1, 3));
            caveLayouts.Add(createRoom(22, -1, -1, -1, 5, 28));
            caveLayouts.Add(createRoom(-1, 24, 25, 1, -1, -1));
            Locations cave = new Locations(caveLayouts);
            locations.Add(cave);
            playerText.Text = cave.Player.ToString();
        }

        private void moveWumpus_Click(object sender, EventArgs e)
        {
            bool wumpusLocation = locations[0].MoveWumpus();
            if (wumpusLocation)
            {
                wumpusLocationText.Text = locations[0].Wumpus.ToString();
            }
        }

        private void checkRoomType_Click(object sender, EventArgs e)
        {
            hazardTypeList.Items.Clear();
            List<string> hazards = locations[0].RoomType();
            foreach (string hazard in hazards)
            {
                hazardTypeList.Items.Add(hazard);
            }

        }

        private void checkHazards_Click(object sender, EventArgs e)
        {
            hazardsNearbyList.Items.Clear();
            List<string> hazards = locations[0].HazardNearby();
            foreach (string hazard in hazards)
            {
                hazardsNearbyList.Items.Add(hazard);
            }
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
            eventsList.Items.Clear();
            List<int[]> events = locations[0].SpawnEvents();
            foreach (int[] evt in events)
            {
                foreach (int i in evt)
                {
                    eventsList.Items.Add(i);
                }
            }
        }
    }
}
