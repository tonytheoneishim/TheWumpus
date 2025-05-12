namespace WumpusPlayer
{
    partial class cavePlayerForm
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
            movePlayerBox = new GroupBox();
            movePlayer = new Button();
            playerLocationText = new TextBox();
            playerMovedCheck = new CheckBox();
            calculateScoreBox = new GroupBox();
            calculateScore = new Button();
            scoreText = new TextBox();
            movePlayerBox.SuspendLayout();
            calculateScoreBox.SuspendLayout();
            SuspendLayout();
            // 
            // movePlayerBox
            // 
            movePlayerBox.Controls.Add(movePlayer);
            movePlayerBox.Controls.Add(playerLocationText);
            movePlayerBox.Controls.Add(playerMovedCheck);
            movePlayerBox.Location = new Point(12, 12);
            movePlayerBox.Name = "movePlayerBox";
            movePlayerBox.Size = new Size(114, 114);
            movePlayerBox.TabIndex = 0;
            movePlayerBox.TabStop = false;
            movePlayerBox.Text = "Move Player";
            // 
            // movePlayer
            // 
            movePlayer.Location = new Point(6, 76);
            movePlayer.Name = "movePlayer";
            movePlayer.Size = new Size(100, 23);
            movePlayer.TabIndex = 2;
            movePlayer.Text = "Move Player";
            movePlayer.UseVisualStyleBackColor = true;
            movePlayer.Click += movePlayer_Click;
            // 
            // playerLocationText
            // 
            playerLocationText.Enabled = false;
            playerLocationText.Location = new Point(6, 47);
            playerLocationText.Name = "playerLocationText";
            playerLocationText.Size = new Size(100, 23);
            playerLocationText.TabIndex = 1;
            // 
            // playerMovedCheck
            // 
            playerMovedCheck.AutoSize = true;
            playerMovedCheck.Enabled = false;
            playerMovedCheck.Location = new Point(6, 22);
            playerMovedCheck.Name = "playerMovedCheck";
            playerMovedCheck.Size = new Size(98, 19);
            playerMovedCheck.TabIndex = 0;
            playerMovedCheck.Text = "Player Moved";
            playerMovedCheck.UseVisualStyleBackColor = true;
            // 
            // calculateScoreBox
            // 
            calculateScoreBox.Controls.Add(calculateScore);
            calculateScoreBox.Controls.Add(scoreText);
            calculateScoreBox.Location = new Point(132, 12);
            calculateScoreBox.Name = "calculateScoreBox";
            calculateScoreBox.Size = new Size(114, 83);
            calculateScoreBox.TabIndex = 3;
            calculateScoreBox.TabStop = false;
            calculateScoreBox.Text = "Calculate Score";
            // 
            // calculateScore
            // 
            calculateScore.Location = new Point(6, 51);
            calculateScore.Name = "calculateScore";
            calculateScore.Size = new Size(100, 23);
            calculateScore.TabIndex = 2;
            calculateScore.Text = "Calculate Score";
            calculateScore.UseVisualStyleBackColor = true;
            calculateScore.Click += calculateScore_Click;
            // 
            // scoreText
            // 
            scoreText.Enabled = false;
            scoreText.Location = new Point(6, 22);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(100, 23);
            scoreText.TabIndex = 1;
            // 
            // cavePlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 458);
            Controls.Add(calculateScoreBox);
            Controls.Add(movePlayerBox);
            Name = "cavePlayerForm";
            Text = "Cave Player Form";
            movePlayerBox.ResumeLayout(false);
            movePlayerBox.PerformLayout();
            calculateScoreBox.ResumeLayout(false);
            calculateScoreBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox movePlayerBox;
        private CheckBox playerMovedCheck;
        private TextBox playerLocationText;
        private Button movePlayer;
        private GroupBox calculateScoreBox;
        private Button calculateScore;
        private TextBox scoreText;
    }
}
