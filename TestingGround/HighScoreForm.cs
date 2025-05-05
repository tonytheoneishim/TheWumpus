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
            //would you rather be indian or a ..?
        }

        private void HighScoreForm_Load(object sender, EventArgs e)
        {
            Highscore highscore = new Highscore();


            FileInfo fileInfo = new FileInfo("highscore.csv");
            if (fileInfo.Exists)
            {
                highscore.PlayerList = Highscore.OpenFromFile("highscore.csv");

                foreach (Highscore player in highscore.PlayerList)
                {
                    listBoxHighScores.Items.Add(player.PlayerName);
                }
            }// how do we want to display the three types of information? (kellen) (trummer !! ) (hah) (what)
            // feel free to change :skull: idk how to do this 

            // Highscore.OpenFromFile("highscores.csv"); // datafile

        }
    }
}
