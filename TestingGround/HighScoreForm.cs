﻿using System;
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

        }

        private void HighScoreForm_Load(object sender, EventArgs e)
        {
            Highscore highscore = new Highscore();
            highscore.TestAdding();
            Highscore.GetHighscores(highscore.PlayerList);

            foreach (Highscore player in highscore.PlayerList)
            {
                listBoxNameList.Items.Add(player.PlayerName);
                listBoxScoreList.Items.Add(player.PlayerFinalScore);
                listBoxCaveNumList.Items.Add(player.CaveType);
            }

            //FileInfo fileInfo = new FileInfo("highscores.csv");
            //if (fileInfo.Exists)
            //{
            //    highscore.PlayerList = Highscore.OpenFromFile("highscores.csv");


            //}

            // how do we want to display the three types of information? (kellen) (trummer !! ) (hah) (what)
            // feel free to change :skull: idk how to do this 

            // Highscore.OpenFromFile("highscores.csv"); // datafile

        }
    }
}
