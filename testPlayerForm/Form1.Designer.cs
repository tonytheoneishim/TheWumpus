namespace testPlayerForm
{
    partial class testPlayerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameLabel = new Label();
            arrowsLabel = new Label();
            coinsLabel = new Label();
            turnsLabel = new Label();
            nameText = new TextBox();
            arrowsText = new TextBox();
            coinsText = new TextBox();
            turnsText = new TextBox();
            wumpusDeadRadio = new RadioButton();
            wumpusAliveRadio = new RadioButton();
            getScore = new Button();
            addArrows = new Button();
            removeArrows = new Button();
            addCoins = new Button();
            removeCoins = new Button();
            addPlayer = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(63, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Username:";
            // 
            // arrowsLabel
            // 
            arrowsLabel.AutoSize = true;
            arrowsLabel.Location = new Point(12, 35);
            arrowsLabel.Name = "arrowsLabel";
            arrowsLabel.Size = new Size(47, 15);
            arrowsLabel.TabIndex = 1;
            arrowsLabel.Text = "Arrows:";
            // 
            // coinsLabel
            // 
            coinsLabel.AutoSize = true;
            coinsLabel.Location = new Point(12, 60);
            coinsLabel.Name = "coinsLabel";
            coinsLabel.Size = new Size(40, 15);
            coinsLabel.TabIndex = 2;
            coinsLabel.Text = "Coins:";
            // 
            // turnsLabel
            // 
            turnsLabel.AutoSize = true;
            turnsLabel.Location = new Point(12, 85);
            turnsLabel.Name = "turnsLabel";
            turnsLabel.Size = new Size(39, 15);
            turnsLabel.TabIndex = 3;
            turnsLabel.Text = "Turns:";
            // 
            // nameText
            // 
            nameText.Location = new Point(81, 6);
            nameText.Name = "nameText";
            nameText.Size = new Size(142, 23);
            nameText.TabIndex = 4;
            // 
            // arrowsText
            // 
            arrowsText.Location = new Point(81, 32);
            arrowsText.Name = "arrowsText";
            arrowsText.Size = new Size(142, 23);
            arrowsText.TabIndex = 5;
            // 
            // coinsText
            // 
            coinsText.Location = new Point(81, 57);
            coinsText.Name = "coinsText";
            coinsText.Size = new Size(142, 23);
            coinsText.TabIndex = 6;
            // 
            // turnsText
            // 
            turnsText.Location = new Point(81, 82);
            turnsText.Name = "turnsText";
            turnsText.Size = new Size(142, 23);
            turnsText.TabIndex = 7;
            // 
            // wumpusDeadRadio
            // 
            wumpusDeadRadio.AutoSize = true;
            wumpusDeadRadio.Location = new Point(12, 116);
            wumpusDeadRadio.Name = "wumpusDeadRadio";
            wumpusDeadRadio.Size = new Size(103, 19);
            wumpusDeadRadio.TabIndex = 8;
            wumpusDeadRadio.TabStop = true;
            wumpusDeadRadio.Text = "Wumpus Dead";
            wumpusDeadRadio.UseVisualStyleBackColor = true;
            // 
            // wumpusAliveRadio
            // 
            wumpusAliveRadio.AutoSize = true;
            wumpusAliveRadio.Location = new Point(121, 116);
            wumpusAliveRadio.Name = "wumpusAliveRadio";
            wumpusAliveRadio.Size = new Size(102, 19);
            wumpusAliveRadio.TabIndex = 9;
            wumpusAliveRadio.TabStop = true;
            wumpusAliveRadio.Text = "Wumpus Alive";
            wumpusAliveRadio.UseVisualStyleBackColor = true;
            // 
            // getScore
            // 
            getScore.Enabled = false;
            getScore.Location = new Point(12, 182);
            getScore.Name = "getScore";
            getScore.Size = new Size(102, 49);
            getScore.TabIndex = 10;
            getScore.Text = "Calculate Score";
            getScore.UseVisualStyleBackColor = true;
            getScore.Click += getScore_Click;
            // 
            // addArrows
            // 
            addArrows.Enabled = false;
            addArrows.Location = new Point(120, 182);
            addArrows.Name = "addArrows";
            addArrows.Size = new Size(102, 49);
            addArrows.TabIndex = 11;
            addArrows.Text = "Add Arrows";
            addArrows.UseVisualStyleBackColor = true;
            addArrows.Click += addArrows_Click;
            // 
            // removeArrows
            // 
            removeArrows.Enabled = false;
            removeArrows.Location = new Point(228, 182);
            removeArrows.Name = "removeArrows";
            removeArrows.Size = new Size(102, 49);
            removeArrows.TabIndex = 12;
            removeArrows.Text = "Remove Arrows";
            removeArrows.UseVisualStyleBackColor = true;
            removeArrows.Click += removeArrows_Click;
            // 
            // addCoins
            // 
            addCoins.Enabled = false;
            addCoins.Location = new Point(69, 237);
            addCoins.Name = "addCoins";
            addCoins.Size = new Size(102, 49);
            addCoins.TabIndex = 13;
            addCoins.Text = "Add Coins";
            addCoins.UseVisualStyleBackColor = true;
            addCoins.Click += addCoins_Click;
            // 
            // removeCoins
            // 
            removeCoins.Enabled = false;
            removeCoins.Location = new Point(177, 237);
            removeCoins.Name = "removeCoins";
            removeCoins.Size = new Size(102, 49);
            removeCoins.TabIndex = 14;
            removeCoins.Text = "Remove Coins";
            removeCoins.UseVisualStyleBackColor = true;
            removeCoins.Click += removeCoins_Click;
            // 
            // addPlayer
            // 
            addPlayer.Location = new Point(12, 141);
            addPlayer.Name = "addPlayer";
            addPlayer.Size = new Size(318, 35);
            addPlayer.TabIndex = 15;
            addPlayer.Text = "Add Player";
            addPlayer.UseVisualStyleBackColor = true;
            addPlayer.Click += addPlayer_Click;
            // 
            // testPlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 291);
            Controls.Add(addPlayer);
            Controls.Add(removeCoins);
            Controls.Add(addCoins);
            Controls.Add(removeArrows);
            Controls.Add(addArrows);
            Controls.Add(getScore);
            Controls.Add(wumpusAliveRadio);
            Controls.Add(wumpusDeadRadio);
            Controls.Add(turnsText);
            Controls.Add(coinsText);
            Controls.Add(arrowsText);
            Controls.Add(nameText);
            Controls.Add(turnsLabel);
            Controls.Add(coinsLabel);
            Controls.Add(arrowsLabel);
            Controls.Add(nameLabel);
            Name = "testPlayerForm";
            Text = "Player Test";
            Load += testPlayerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label arrowsLabel;
        private Label coinsLabel;
        private Label turnsLabel;
        private TextBox nameText;
        private TextBox arrowsText;
        private TextBox coinsText;
        private TextBox turnsText;
        private RadioButton wumpusDeadRadio;
        private RadioButton wumpusAliveRadio;
        private Button getScore;
        private Button addArrows;
        private Button removeArrows;
        private Button addCoins;
        private Button removeCoins;
        private Button addPlayer;
    }
}
