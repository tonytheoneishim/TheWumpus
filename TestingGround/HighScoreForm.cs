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
            Highscore highscore = new Highscore();
            try
            {
                listBoxStatistics.Items.Clear();
                int i = listBoxNameList.SelectedIndex;

                for (int j = 0; j < i; j++)
                {
                    if (listBoxNameList.SelectedIndex == i)
                    {
                        listBoxStatistics.Items.Clear();
                        listBoxStatistics.Items.Add(highscore.PlayerList[i].ArrowsLeft);
                        listBoxStatistics.Items.Add(highscore.PlayerList[i].GoldCoinsLeft);
                        listBoxStatistics.Items.Add(highscore.PlayerList[i].KilledWumpus);
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Select a name to show run statistics!", "Info!");
                return;
            }
        }

        private void HighScoreForm_Load(object sender, EventArgs e)
        {
            Highscore highscore = new Highscore();
            highscore.TestAdding();
            Highscore.GetHighscores(highscore.PlayerList);
            highscore.SortHighs();
            foreach (Highscore player in highscore.PlayerList)
            {
                listBoxNameList.Items.Add(player.ToString());
            }
        }
    }
}
