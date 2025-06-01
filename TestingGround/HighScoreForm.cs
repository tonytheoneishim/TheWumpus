using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GCUITest;
using Highscore___Testing___Dev;

namespace TestingGround
{
    public partial class HighScoreForm : Form
    {
        public string PlayerName { get; set; }
        public string CaveType { get; set; }
        public int ArrowsLeft { get; set; }
        public int GoldCoinsLeft { get; set; }
        public int Turns { get; set; }
        public bool KilledWumpus { get; set; }
        public int score { get; set; }

        Highscore highscore = new Highscore();
        public HighScoreForm()
        {
            InitializeComponent();
            //highscore = new Highscore(PlayerName, score, CaveType, Turns, ArrowsLeft, GoldCoinsLeft, KilledWumpus);
            //clearselected = false;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage homedlg = new Homepage();
            homedlg.ShowDialog();
            this.Close();
        }
        private void listBoxHighScores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buttonExitOptions.Visible == false)
            {
                Size = new Size(277, 474);
                buttonClose.Visible = true;
                buttonClose2.Visible = false;
                buttonOptions1.Visible = false;
                buttonOptions2.Visible = true;
                labelRunStatistics.Visible = true;
                labelPlayerStat.Visible = true;
                listBoxStatistics.Visible = true;

                int i = listBoxNameList.SelectedIndex;
                string killed = string.Empty;

                if (listBoxNameList.SelectedIndex != -1)
                {
                    if (highscore.PlayerList[i].KilledWumpus == true) killed = "DEAD";
                    if (highscore.PlayerList[i].KilledWumpus == false) killed = "ALIVE";

                    labelPlayerStat.Text = "";
                    listBoxStatistics.Items.Clear();

                    labelPlayerStat.Text = highscore.PlayerList[i].PlayerName;
                    listBoxStatistics.Items.Add("Cave:\t" + highscore.PlayerList[i].CaveType);
                    listBoxStatistics.Items.Add("Turns: \t" + highscore.PlayerList[i].Turns.ToString());
                    listBoxStatistics.Items.Add("Arrows:\t" + highscore.PlayerList[i].ArrowsLeft.ToString());
                    listBoxStatistics.Items.Add("Coins:\t" + highscore.PlayerList[i].GoldCoinsLeft.ToString());
                    listBoxStatistics.Items.Add("Wumpus:\t" + killed);
                }
                else return;
            }
            else return;
        }
        private void HighScoreForm_Load(object sender, EventArgs e)
        {
            Size = new Size(277, 316);
            //highscore.TestAdding();
            highscore.AddHighscore(Name, score, CaveType, Turns, ArrowsLeft, GoldCoinsLeft, KilledWumpus);
            Highscore.GetHighscores(highscore.PlayerList);
            highscore.SortHighs();
            int a = 0;
            foreach (Highscore player in highscore.PlayerList)
            {
                listBoxNameList.Items.Add(player.ToString());
                a++;
                if (a == 10) break;
            }
            labelPlayerStat.Text = "";
        }

        private void labelName_Click(object sender, EventArgs e)
        {
            //i misclicked sorry
        }

        private void buttonClose2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage homedlg = new Homepage();
            homedlg.ShowDialog();
            this.Close();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            //clear highscores, remove a highscore
        }

        private void buttonOptions1_Click_1(object sender, EventArgs e)
        {
            Size = new Size(277, 474);
            listBoxStatistics.SelectedIndex = -1;
            listBoxStatistics.Visible = false;
            buttonOptions1.Visible = false;
            buttonClose2.Visible = false;
            buttonClose.Visible = true;
            buttonExitOptions.Visible = true;
            labelRunStatistics.Visible = false;
            labelhighscoreoptions.Visible = true;
            labelPlayerStat.Text = "";
            buttonDeleteSelected.Visible = true;
            buttonEraseAll.Visible = true;
        }

        private void buttonOptions2_Click(object sender, EventArgs e)
        {
            Size = new Size(277, 474);
            listBoxStatistics.SelectedIndex = -1;
            listBoxStatistics.Visible = false;
            buttonOptions2.Visible = false;
            buttonExitOptions.Visible = true;
            labelRunStatistics.Visible = false;
            buttonClose2.Visible = false;
            buttonClose.Visible = true;
            labelhighscoreoptions.Visible = true;
            labelPlayerStat.Text = "";
            buttonDeleteSelected.Visible = true;
            buttonEraseAll.Visible = true;
        }

        private void buttonExitOptions_Click(object sender, EventArgs e)
        {
            Size = new Size(277, 316);
            listBoxStatistics.SelectedIndex = -1;
            listBoxStatistics.Visible = false;
            buttonOptions1.Visible = true;
            buttonClose2.Visible = true;
            buttonExitOptions.Visible = false;
            labelRunStatistics.Visible = true;
            labelhighscoreoptions.Visible = false;
            labelRunStatistics.Visible = false;
            buttonDeleteSelected.Visible = false;
            buttonEraseAll.Visible = false;
        }
        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {
            if (listBoxNameList.SelectedIndex != -1)
            {
                DialogResult yesno = MessageBox.Show("Are you sure you would like to delete this high-score?", "Warning!", MessageBoxButtons.YesNo);
                if (yesno == DialogResult.Yes)
                {
                    int i = listBoxNameList.SelectedIndex;
                    listBoxNameList.Items.RemoveAt(i);
                    highscore.PlayerList.RemoveAt(i);
                    Highscore.SavetoFile(highscore.PlayerList);
                    listBoxStatistics.Items.Clear();

                    Size = new Size(277, 316);
                    listBoxNameList.Items.Clear();
                    Highscore.GetHighscores(highscore.PlayerList);
                    highscore.SortHighs();
                    int a = 0;
                    foreach (Highscore player in highscore.PlayerList)
                    {
                        listBoxNameList.Items.Add(player.ToString());
                        a++;
                        if (a == 10) break;
                    }
                    listBoxStatistics.SelectedIndex = -1;
                    buttonOptions1.Visible = true;
                    buttonClose.Visible = false;
                    buttonExitOptions.Visible = false;
                    buttonOptions2.Visible = false;
                    buttonClose2.Visible = true;
                    labelhighscoreoptions.Visible = false;
                    listBoxStatistics.Visible = false;
                    buttonDeleteSelected.Visible = false;
                    buttonEraseAll.Visible = false;
                    labelPlayerStat.Text = "";
                }
                else return;
            }

        }
        private void buttonEraseAll_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Are you sure you would like to erase all data?", "Warning!", MessageBoxButtons.YesNo);
            if (yesno == DialogResult.Yes)
            {
                listBoxNameList.Items.Clear();
                highscore.PlayerList.Clear();
            }
            else return;
        }
    }
}