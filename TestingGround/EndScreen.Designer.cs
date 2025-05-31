namespace GCUITest
{
    partial class EndScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelVictory = new Label();
            pictureBox3 = new PictureBox();
            labelCoinCount = new Label();
            labelArrowCount = new Label();
            labelArrowLabel = new Label();
            pictureBoxCoin = new PictureBox();
            labelCoinLabel = new Label();
            buttonContinue = new Button();
            labelDefeat = new Label();
            labelWumpKilled = new Label();
            labelWumpLives = new Label();
            label1 = new Label();
            labelScdisp = new Label();
            labelScore = new Label();
            labelPlayerName = new Label();
            labelpndispl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoin).BeginInit();
            SuspendLayout();
            // 
            // labelVictory
            // 
            labelVictory.AutoSize = true;
            labelVictory.Font = new Font("Book Antiqua", 22F, FontStyle.Bold);
            labelVictory.ForeColor = SystemColors.ControlLightLight;
            labelVictory.Location = new Point(237, 30);
            labelVictory.Name = "labelVictory";
            labelVictory.Size = new Size(125, 35);
            labelVictory.TabIndex = 1;
            labelVictory.Text = "Victory!";
            labelVictory.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Wumpus_Arrow;
            pictureBox3.Location = new Point(60, 264);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // labelCoinCount
            // 
            labelCoinCount.AutoSize = true;
            labelCoinCount.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold);
            labelCoinCount.ForeColor = SystemColors.ControlLightLight;
            labelCoinCount.Location = new Point(210, 226);
            labelCoinCount.Name = "labelCoinCount";
            labelCoinCount.Size = new Size(22, 23);
            labelCoinCount.TabIndex = 32;
            labelCoinCount.Text = "--";
            // 
            // labelArrowCount
            // 
            labelArrowCount.AutoSize = true;
            labelArrowCount.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold);
            labelArrowCount.ForeColor = SystemColors.ControlLightLight;
            labelArrowCount.Location = new Point(210, 281);
            labelArrowCount.Name = "labelArrowCount";
            labelArrowCount.Size = new Size(22, 23);
            labelArrowCount.TabIndex = 31;
            labelArrowCount.Text = "--";
            // 
            // labelArrowLabel
            // 
            labelArrowLabel.AutoSize = true;
            labelArrowLabel.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold);
            labelArrowLabel.ForeColor = SystemColors.ControlLightLight;
            labelArrowLabel.Location = new Point(114, 281);
            labelArrowLabel.Name = "labelArrowLabel";
            labelArrowLabel.Size = new Size(79, 23);
            labelArrowLabel.TabIndex = 30;
            labelArrowLabel.Text = "Arrows:";
            // 
            // pictureBoxCoin
            // 
            pictureBoxCoin.Image = Properties.Resources.Wumpus_Coin__1_;
            pictureBoxCoin.Location = new Point(62, 204);
            pictureBoxCoin.Name = "pictureBoxCoin";
            pictureBoxCoin.Size = new Size(48, 56);
            pictureBoxCoin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCoin.TabIndex = 29;
            pictureBoxCoin.TabStop = false;
            // 
            // labelCoinLabel
            // 
            labelCoinLabel.AutoSize = true;
            labelCoinLabel.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold);
            labelCoinLabel.ForeColor = SystemColors.ControlLightLight;
            labelCoinLabel.Location = new Point(116, 226);
            labelCoinLabel.Name = "labelCoinLabel";
            labelCoinLabel.Size = new Size(66, 23);
            labelCoinLabel.TabIndex = 28;
            labelCoinLabel.Text = "Coins:";
            // 
            // buttonContinue
            // 
            buttonContinue.Location = new Point(447, 291);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(75, 23);
            buttonContinue.TabIndex = 34;
            buttonContinue.Text = "Continue";
            buttonContinue.UseVisualStyleBackColor = true;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // labelDefeat
            // 
            labelDefeat.AutoSize = true;
            labelDefeat.Font = new Font("Book Antiqua", 22F, FontStyle.Bold);
            labelDefeat.ForeColor = SystemColors.ControlLightLight;
            labelDefeat.Location = new Point(243, 30);
            labelDefeat.Name = "labelDefeat";
            labelDefeat.Size = new Size(115, 35);
            labelDefeat.TabIndex = 35;
            labelDefeat.Text = "Defeat!";
            labelDefeat.Visible = false;
            // 
            // labelWumpKilled
            // 
            labelWumpKilled.AutoSize = true;
            labelWumpKilled.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWumpKilled.ForeColor = SystemColors.ControlLightLight;
            labelWumpKilled.Location = new Point(204, 84);
            labelWumpKilled.Name = "labelWumpKilled";
            labelWumpKilled.Size = new Size(191, 21);
            labelWumpKilled.TabIndex = 36;
            labelWumpKilled.Text = "You Killed the Wumpus!";
            labelWumpKilled.Visible = false;
            // 
            // labelWumpLives
            // 
            labelWumpLives.AutoSize = true;
            labelWumpLives.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWumpLives.ForeColor = SystemColors.ControlLightLight;
            labelWumpLives.Location = new Point(221, 84);
            labelWumpLives.Name = "labelWumpLives";
            labelWumpLives.Size = new Size(157, 21);
            labelWumpLives.TabIndex = 37;
            labelWumpLives.Text = "The Wumpus Lives!";
            labelWumpLives.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(62, 162);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 38;
            label1.Text = "Inventory";
            label1.Visible = false;
            // 
            // labelScdisp
            // 
            labelScdisp.AutoSize = true;
            labelScdisp.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelScdisp.ForeColor = SystemColors.ControlLightLight;
            labelScdisp.Location = new Point(333, 204);
            labelScdisp.Name = "labelScdisp";
            labelScdisp.Size = new Size(50, 21);
            labelScdisp.TabIndex = 39;
            labelScdisp.Text = "Score";
            labelScdisp.Visible = false;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold);
            labelScore.ForeColor = SystemColors.ControlLightLight;
            labelScore.Location = new Point(468, 202);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(54, 23);
            labelScore.TabIndex = 40;
            labelScore.Text = "score";
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold);
            labelPlayerName.ForeColor = SystemColors.ControlLightLight;
            labelPlayerName.Location = new Point(468, 160);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(59, 23);
            labelPlayerName.TabIndex = 42;
            labelPlayerName.Text = "name";
            // 
            // labelpndispl
            // 
            labelpndispl.AutoSize = true;
            labelpndispl.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelpndispl.ForeColor = SystemColors.ControlLightLight;
            labelpndispl.Location = new Point(333, 162);
            labelpndispl.Name = "labelpndispl";
            labelpndispl.Size = new Size(56, 21);
            labelpndispl.TabIndex = 41;
            labelpndispl.Text = "Player";
            labelpndispl.Visible = false;
            // 
            // EndScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Died_by_Pit;
            ClientSize = new Size(584, 361);
            Controls.Add(labelPlayerName);
            Controls.Add(labelpndispl);
            Controls.Add(labelScore);
            Controls.Add(labelScdisp);
            Controls.Add(label1);
            Controls.Add(labelWumpLives);
            Controls.Add(labelWumpKilled);
            Controls.Add(labelDefeat);
            Controls.Add(buttonContinue);
            Controls.Add(pictureBox3);
            Controls.Add(labelCoinCount);
            Controls.Add(labelArrowCount);
            Controls.Add(labelArrowLabel);
            Controls.Add(pictureBoxCoin);
            Controls.Add(labelCoinLabel);
            Controls.Add(labelVictory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EndScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "End screen";
            Load += EndScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVictory;
        private PictureBox pictureBox3;
        private Label labelCoinCount;
        private Label labelArrowCount;
        private Label labelArrowLabel;
        private PictureBox pictureBoxCoin;
        private Label labelCoinLabel;
        private Button buttonContinue;
        private Label labelDefeat;
        private Label labelWumpKilled;
        private Label labelWumpLives;
        private Label label1;
        private Label labelScdisp;
        private Label labelScore;
        private Label labelPlayerName;
        private Label labelpndispl;
    }
}