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
            labelTitle = new Label();
            pictureBox3 = new PictureBox();
            labelCoinCount = new Label();
            labelArrowCount = new Label();
            labelArrowLabel = new Label();
            pictureBoxCoin = new PictureBox();
            labelCoinLabel = new Label();
            buttonContinue = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoin).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Book Antiqua", 22F, FontStyle.Bold);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(-3, 34);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(598, 35);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Victory! / You Lost!  (get code here kellen!)";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Wumpus_Arrow;
            pictureBox3.Location = new Point(80, 197);
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
            labelCoinCount.Location = new Point(230, 159);
            labelCoinCount.Name = "labelCoinCount";
            labelCoinCount.Size = new Size(301, 23);
            labelCoinCount.TabIndex = 32;
            labelCoinCount.Text = "--    dont change the window size";
            // 
            // labelArrowCount
            // 
            labelArrowCount.AutoSize = true;
            labelArrowCount.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold);
            labelArrowCount.ForeColor = SystemColors.ControlLightLight;
            labelArrowCount.Location = new Point(230, 214);
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
            labelArrowLabel.Location = new Point(134, 214);
            labelArrowLabel.Name = "labelArrowLabel";
            labelArrowLabel.Size = new Size(79, 23);
            labelArrowLabel.TabIndex = 30;
            labelArrowLabel.Text = "Arrows:";
            // 
            // pictureBoxCoin
            // 
            pictureBoxCoin.Image = Properties.Resources.Wumpus_Coin__1_;
            pictureBoxCoin.Location = new Point(82, 137);
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
            labelCoinLabel.Location = new Point(136, 159);
            labelCoinLabel.Name = "labelCoinLabel";
            labelCoinLabel.Size = new Size(66, 23);
            labelCoinLabel.TabIndex = 28;
            labelCoinLabel.Text = "Coins:";
            // 
            // buttonContinue
            // 
            buttonContinue.Location = new Point(373, 283);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(75, 23);
            buttonContinue.TabIndex = 34;
            buttonContinue.Text = "Continue";
            buttonContinue.UseVisualStyleBackColor = true;
            // 
            // EndScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(584, 361);
            Controls.Add(buttonContinue);
            Controls.Add(pictureBox3);
            Controls.Add(labelCoinCount);
            Controls.Add(labelArrowCount);
            Controls.Add(labelArrowLabel);
            Controls.Add(pictureBoxCoin);
            Controls.Add(labelCoinLabel);
            Controls.Add(labelTitle);
            Name = "EndScreen";
            Text = "You won!";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private PictureBox pictureBox3;
        private Label labelCoinCount;
        private Label labelArrowCount;
        private Label labelArrowLabel;
        private PictureBox pictureBoxCoin;
        private Label labelCoinLabel;
        private Button buttonContinue;
    }
}