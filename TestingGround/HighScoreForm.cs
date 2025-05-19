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
using Highscore___Testing___Dev;

namespace TestingGround
{
    public partial class HighScoreForm : Form
    {
        Highscore highscore = new Highscore();
        public HighScoreForm()
        {
            InitializeComponent();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void listBoxHighScores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBoxNameList.SelectedIndex;
            string killed = string.Empty;
            if (highscore.PlayerList[i].KilledWumpus == true) killed = "DEAD";
            if (highscore.PlayerList[i].KilledWumpus == false) killed = "ALIVE";
            if (listBoxNameList.SelectedIndex != -1)
            {
                labelPlayerStat.Text = "";
                listBoxStatistics.Items.Clear();

                labelPlayerStat.Text = highscore.PlayerList[i].PlayerName;
                listBoxStatistics.Items.Add("Cave:\t" + highscore.PlayerList[i].CaveType);
                listBoxStatistics.Items.Add("Turns: \t" + highscore.PlayerList[i].Turns.ToString());
                listBoxStatistics.Items.Add("Arrows:\t" + highscore.PlayerList[i].ArrowsLeft.ToString());
                listBoxStatistics.Items.Add("Coins:\t" + highscore.PlayerList[i].GoldCoinsLeft.ToString());
                listBoxStatistics.Items.Add("Wumpus:\t" + killed);
            }
            else MessageBox.Show("elsed");
        }
        private void HighScoreForm_Load(object sender, EventArgs e)
        {
            highscore.TestAdding();
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
    }
}
