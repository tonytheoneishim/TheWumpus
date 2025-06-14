﻿using CaveTest;
using GCUITest;
using WumpusLocations;
using WumpusPlayer;
using Highscore___Testing___Dev;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography.X509Certificates;
using GCUITest.Properties;
using System.Xml;
using System.ComponentModel.Design;
using System.Reflection;
using WumpusPlayer;
using System.Diagnostics.PerformanceData;
using System.Windows.Forms.VisualStyles;
using System.DirectoryServices.ActiveDirectory;

namespace TestingGround
{
    public partial class Game : Form
    {
        public static Cave cave = new Cave();
        public Player player = new Player(5, 3, 0, false);
        public Locations location = new Locations(cave.caveLayouts);
        public List<int[]> locationList = new List<int[]>();
        double score = 100;

        Button[] buttons = new Button[6];
        Random rand = new Random();
        int START_POSITION = 1;

        public string PlayerName { get; set; }
        public static bool TriviaOutcome = false;
        public string CaveType;
        public Game()
        {
            InitializeComponent();
            locationList = location.SpawnEvents();
            pictureBoxRoom.SendToBack();

            buttons[0] = buttonRoomNW;
            buttons[1] = buttonRoomN;
            buttons[2] = buttonRoomNE;
            buttons[3] = buttonRoomSE;
            buttons[4] = buttonRoomS;
            buttons[5] = buttonRoomSW;
            for (int i = 0; i < 6; i++)
            {
                buttons[i].Visible = false;
            }

            location.Player = START_POSITION;
            int[] connectedRooms = cave.caveLayouts[location.Player - 1];

            for (int i = 0; i < 6; i++)
            {
                buttons[i].Text = connectedRooms[i].ToString();
                if (connectedRooms[i] > -1) buttons[i].Visible = true;
            }
        }
        /// <summary>
        /// Initializes the game and sets up the player name, coins, arrows, and score. It also sets up the buttons and background image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_Load(object sender, EventArgs e)
        {
            labelPlayerName.Text = PlayerName;
            labelCoins.Text = player.Gold.ToString();
            labelArrows.Text = player.Arrows.ToString();
            labelPoints.Text = score.ToString();
            labelWarnings.Text = "";

            checkBoxShootArrow.Visible = false;
            labelCaveNum.Visible = true; //for testings
            buttonRoomN.FlatAppearance.BorderSize = 0;
            buttonRoomNE.FlatAppearance.BorderSize = 0;
            buttonRoomNW.FlatAppearance.BorderSize = 0;
            buttonRoomS.FlatAppearance.BorderSize = 0;
            buttonRoomSW.FlatAppearance.BorderSize = 0;
            buttonRoomSE.FlatAppearance.BorderSize = 0;
            this.BackgroundImage = Resources.New_Piskel;
            pictureBoxRoom.Image = Resources.Wumpus_Room__1_;

            int index = rand.Next(0, 5);
            cave.caveSelect(index);
            CaveType = "Cave " + (index + 1).ToString();
            updateButtons(START_POSITION);
            labelRoomNum.Text = START_POSITION.ToString();
            labelCaveNum.Text = "Cave " + (index + 1).ToString();


            //everything below is for hazards around room 1
            bool wumpusDetected = false;
            bool batsDetected = false;
            bool pitDetected = false;
            bool shopDetected = false;

            labelWarnings.Text = "";
            string warnings = "";
            List<string> hazards = location.HazardNearby();
            foreach (string hazard in hazards)
            {
                if (hazard == "W")
                {
                    if (!wumpusDetected)
                    {
                        warnings += "You smell a Wumpus!\n";
                        wumpusDetected = true;
                    }

                }
                else if (hazard == "B")
                {
                    if (!batsDetected)
                    {
                        warnings += "You hear bats nearby!\n";
                        batsDetected = true;
                    }
                }
                else if (hazard == "P")
                {
                    if (!pitDetected)
                    {
                        warnings += "You feel a draft!\n";
                        pitDetected = true;
                    }
                }
                else if (hazard == "S")
                {
                    if (!shopDetected)
                    {
                        warnings += "You see the light of a shop nearby!\n";
                        shopDetected = true;
                    }
                }
                else
                {
                    // do nothing
                }
            }

            if (!wumpusDetected && !batsDetected && !pitDetected && !shopDetected)
            {
                this.BackgroundImage = Resources.New_Piskel;
                checkBoxShootArrow.Visible = false;
            }
            else if (wumpusDetected)
            {
                this.BackgroundImage = Resources.Piskel_Wumpus_Main;
                checkBoxShootArrow.Visible = true;
            }
            else if (batsDetected)
            {
                this.BackgroundImage = Resources.Piskel_Bats_Main;
            }
            else if (shopDetected)
            {
                this.BackgroundImage = Resources.Main_Piskel_Shop;
            }
            else if (pitDetected)
            {
                this.BackgroundImage = Resources.Main_Piskel_Draft;
            }

            labelWarnings.Text = warnings;
            labelCurrentRoomHazard.Text = "None"; // Initialize the label for current room hazards
        }

        /// <summary>
        /// Check for button clicks and update the current room accordingly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRoomN_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int index = -1;
            //MessageBox.Show(button.Text);

            index = int.Parse(button.Text);

            if (!checkBoxShootArrow.Checked)
            {
                labelRoomNum.Text = button.Text;
                location.Player = index;

                player.Gold++;
                
                updateButtons(index);
                DoTurn();
            }
            else
            {
                if (location.ShootArrow(int.Parse(button.Text)))
                {
                    player.Arrows--;
                    MessageBox.Show("You shot the Wumpus! You win!");
                    player.WumpusDead = true;

                    this.Hide();

                    EndScreen gameend = new EndScreen();
                    gameend.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("You missed the Wumpus!");
                    player.Arrows--;
                    if (player.Arrows < 1)
                    {
                        MessageBox.Show("You have no arrows left! You lose!");

                        this.Hide();

                        Homepage start = new Homepage();
                        start.ShowDialog();

                        this.Close();
                    }
                    else
                    {
                        DoTurn();
                    }
                }
            }
        }

        /// <summary>
        /// Handles all events for every turn. Checks for hazards inside the current room and around, and updates the UI accordingly.
        /// Also enables shooting an arrow when wumpus is nearby.
        /// </summary>
        public void DoTurn()
        {
            player.Turns++;
            checkBoxShootArrow.Visible = false;

            //location.MoveWumpus();

            bool movedRoom = false;
            bool wumpusDetected = false;
            bool batsDetected = false;
            bool pitDetected = false;
            bool shopDetected = false;

            labelWarnings.Text = "";
            string warnings = "";
            List<string> hazards = location.HazardNearby();
            foreach (string hazard in hazards)
            {
                if (hazard == "W")
                {
                    if (!wumpusDetected)
                    {
                        warnings += "You smell a Wumpus!\n";
                        wumpusDetected = true;
                    }

                }
                else if (hazard == "B")
                {
                    if (!batsDetected)
                    {
                        warnings += "You hear bats nearby!\n";
                        batsDetected = true;
                    }
                }
                else if (hazard == "P")
                {
                    if (!pitDetected)
                    {
                        warnings += "You feel a draft!\n";
                        pitDetected = true;
                    }
                }
                else if (hazard == "S")
                {
                    if (!shopDetected)
                    {
                        warnings += "You see the light of a shop nearby!\n";
                        shopDetected = true;
                    }
                }
                else
                {
                    // do nothing
                }
            }

            if (!wumpusDetected && !batsDetected && !pitDetected && !shopDetected)
            {
                this.BackgroundImage = Resources.New_Piskel;
                checkBoxShootArrow.Visible = false;
            }
            else if (wumpusDetected)
            {
                this.BackgroundImage = Resources.Piskel_Wumpus_Main;
                checkBoxShootArrow.Visible = true;
            }
            else if (batsDetected)
            {
                this.BackgroundImage = Resources.Piskel_Bats_Main;
            }
            else if (shopDetected)
            {
                this.BackgroundImage = Resources.Main_Piskel_Shop;
            }
            else if (pitDetected)
            {
                this.BackgroundImage = Resources.Main_Piskel_Draft;
            }

            // check if the player is in a room with a hazard
            List<string> hazardsInRoom = location.RoomType();
            string roomHazards = "";
            foreach (string hazard in hazardsInRoom)
            {
                if (hazard == "W")
                {
                    DoTrivia(5);
                    //pictureBoxRoom.Image = Resources.Wumpus_Room_WumpusBad;
                    roomHazards += "Wumpus\n";
                    if (TriviaOutcome)
                    {
                        MessageBox.Show("You injured the Wumpus! It ran away!");
                        location.MoveWumpus(true);
                    }
                    else
                    {
                        MessageBox.Show("You failed to answer the trivia question! \nThe Wumpus attacks you!");
                        this.Hide();
                        EndScreen end = new EndScreen();
                        end.arrows = player.Arrows;
                        end.gold = player.Gold;
                        end.turns = player.Turns;
                        end.wumpusDead = player.WumpusDead;
                        end.PlayerName = PlayerName;
                        end.CaveType = CaveType;
                        end.ShowDialog();
                        this.Close();
                    }
                }
                else if (hazard == "B")
                {
                    pictureBoxRoom.Image = Resources.Wumpus_Room_Bats;
                    roomHazards += "Bats\n";
                    movedRoom = true;
                }
                else if (hazard == "P")
                {
                    DoTrivia(3);
                    pictureBoxRoom.Image = Resources.Wumpus_Room_Hole;
                    roomHazards += "Pit\n";
                    if (TriviaOutcome)
                    {
                        MessageBox.Show("You found a small opening and escaped \nout of the pit into room 1!");
                        int index = 1;
                        labelRoomNum.Text = index.ToString();
                        location.Player = index;
                        labelCurrentRoomHazard.Text = index.ToString();

                        updateButtons(index);
                        DoTurn();
                    }
                    else
                    {
                        MessageBox.Show("You failed to answer the trivia question! \nYou fell into the pit and starved!");
                        this.Hide();
                        EndScreen end = new EndScreen();
                        end.ShowDialog();
                        this.Close();
                    }
                }
                else if (hazard == "S")
                {
                    pictureBoxRoom.Image = Resources.Wumpus_Room_Shop__1_;
                    roomHazards += "Shop\n";
                    buttonShop.Visible = true;
                }
                else
                {
                    pictureBoxRoom.Image = Resources.Wumpus_Room__1_;
                    roomHazards += "None\n";
                    buttonShop.Visible = false;
                }
            }
            labelCurrentRoomHazard.Text = roomHazards;

            labelCoins.Text = player.Gold.ToString();
            labelArrows.Text = player.Arrows.ToString();
            labelPoints.Text = score.ToString();
            labelWarnings.Text = warnings;
            checkBoxShootArrow.Checked = false;
            score = player.CalculateScore();

            if (movedRoom)
            {
                BatAttack batattack = new BatAttack();
                batattack.ShowDialog();
                Random rand = new Random();
                int newRoom = rand.Next(2, 31);

                int index = newRoom;
                labelRoomNum.Text = index.ToString();
                location.Player = index;
                labelCurrentRoomHazard.Text = index.ToString();

                updateButtons(index);
                DoTurn();
            }
        }

        private void updateButtons(int index)
        {
            int[] connectedRooms = cave.caveLayouts[--index];
            // reflect the state of connected rooms (for each index in the array, update corresponding button)

            for (int i = 0; i < 6; i++)
            {
                buttons[i].Visible = false;
            }

            for (int i = 0; i < 6; i++)
            {
                buttons[i].Text = connectedRooms[i].ToString();
                if (connectedRooms[i] > -1) buttons[i].Visible = true;
            }
        }

        private void DoTrivia(int q)
        {
            TriviaOutcome = false; // Reset the outcome before showing the trivia form
            TriviaForm trivia = new TriviaForm();
            trivia.TotalQuestionsNeeded = q;
            trivia.ShowDialog();
        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shop shopDlg = new Shop();
            shopDlg.GetGold = player.Gold;
            shopDlg.GetArrows = player.Arrows;
            shopDlg.GetTurns = player.Turns;
            shopDlg.GetLife = player.WumpusDead;
            shopDlg.ShowDialog();
            this.Show();
        }
    }
}
