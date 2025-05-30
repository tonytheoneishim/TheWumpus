namespace GCUITest
{
    partial class Shop
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
            buttonClose = new Button();
            labelArrowLabel = new Label();
            pictureBoxCoin = new PictureBox();
            labelCoinLabel = new Label();
            labelTitle = new Label();
            labelArrowCost = new Label();
            labelSecretPrice = new Label();
            pictureBoxArrowBuy = new PictureBox();
            pictureBoxSecretBuy = new PictureBox();
            labelArrowCount = new Label();
            labelCoinCount = new Label();
            pictureBox3 = new PictureBox();
            labelReciept = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArrowBuy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecretBuy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(308, 415);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Exit";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelArrowLabel
            // 
            labelArrowLabel.AutoSize = true;
            labelArrowLabel.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold);
            labelArrowLabel.ForeColor = SystemColors.ControlLightLight;
            labelArrowLabel.Location = new Point(85, 400);
            labelArrowLabel.Name = "labelArrowLabel";
            labelArrowLabel.Size = new Size(79, 23);
            labelArrowLabel.TabIndex = 16;
            labelArrowLabel.Text = "Arrows:";
            // 
            // pictureBoxCoin
            // 
            pictureBoxCoin.Image = Properties.Resources.Wumpus_Coin__1_;
            pictureBoxCoin.Location = new Point(33, 323);
            pictureBoxCoin.Name = "pictureBoxCoin";
            pictureBoxCoin.Size = new Size(48, 56);
            pictureBoxCoin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCoin.TabIndex = 15;
            pictureBoxCoin.TabStop = false;
            // 
            // labelCoinLabel
            // 
            labelCoinLabel.AutoSize = true;
            labelCoinLabel.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold);
            labelCoinLabel.ForeColor = SystemColors.ControlLightLight;
            labelCoinLabel.Location = new Point(87, 345);
            labelCoinLabel.Name = "labelCoinLabel";
            labelCoinLabel.Size = new Size(66, 23);
            labelCoinLabel.TabIndex = 13;
            labelCoinLabel.Text = "Coins:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Book Antiqua", 22F, FontStyle.Bold);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(79, 19);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(279, 35);
            labelTitle.TabIndex = 19;
            labelTitle.Text = "The Wumpus Shop";
            // 
            // labelArrowCost
            // 
            labelArrowCost.AutoSize = true;
            labelArrowCost.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold);
            labelArrowCost.ForeColor = SystemColors.ControlLightLight;
            labelArrowCost.Location = new Point(126, 88);
            labelArrowCost.Name = "labelArrowCost";
            labelArrowCost.Size = new Size(70, 23);
            labelArrowCost.TabIndex = 20;
            labelArrowCost.Text = "3 coins";
            // 
            // labelSecretPrice
            // 
            labelSecretPrice.AutoSize = true;
            labelSecretPrice.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold);
            labelSecretPrice.ForeColor = SystemColors.ControlLightLight;
            labelSecretPrice.Location = new Point(126, 148);
            labelSecretPrice.Name = "labelSecretPrice";
            labelSecretPrice.Size = new Size(70, 23);
            labelSecretPrice.TabIndex = 21;
            labelSecretPrice.Text = "5 coins";
            // 
            // pictureBoxArrowBuy
            // 
            pictureBoxArrowBuy.Image = Properties.Resources.Wumpus_Arrow;
            pictureBoxArrowBuy.Location = new Point(46, 70);
            pictureBoxArrowBuy.Name = "pictureBoxArrowBuy";
            pictureBoxArrowBuy.Size = new Size(55, 50);
            pictureBoxArrowBuy.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxArrowBuy.TabIndex = 22;
            pictureBoxArrowBuy.TabStop = false;
            pictureBoxArrowBuy.Click += pictureBoxArrowBuy_Click;
            // 
            // pictureBoxSecretBuy
            // 
            pictureBoxSecretBuy.Image = Properties.Resources.questiom;
            pictureBoxSecretBuy.Location = new Point(33, 134);
            pictureBoxSecretBuy.Name = "pictureBoxSecretBuy";
            pictureBoxSecretBuy.Size = new Size(73, 58);
            pictureBoxSecretBuy.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSecretBuy.TabIndex = 23;
            pictureBoxSecretBuy.TabStop = false;
            pictureBoxSecretBuy.Click += pictureBoxSecretBuy_Click;
            // 
            // labelArrowCount
            // 
            labelArrowCount.AutoSize = true;
            labelArrowCount.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold);
            labelArrowCount.ForeColor = SystemColors.ControlLightLight;
            labelArrowCount.Location = new Point(181, 400);
            labelArrowCount.Name = "labelArrowCount";
            labelArrowCount.Size = new Size(22, 23);
            labelArrowCount.TabIndex = 25;
            labelArrowCount.Text = "--";
            // 
            // labelCoinCount
            // 
            labelCoinCount.AutoSize = true;
            labelCoinCount.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold);
            labelCoinCount.ForeColor = SystemColors.ControlLightLight;
            labelCoinCount.Location = new Point(181, 345);
            labelCoinCount.Name = "labelCoinCount";
            labelCoinCount.Size = new Size(22, 23);
            labelCoinCount.TabIndex = 26;
            labelCoinCount.Text = "--";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Wumpus_Arrow;
            pictureBox3.Location = new Point(31, 383);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // labelReciept
            // 
            labelReciept.AutoSize = true;
            labelReciept.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold);
            labelReciept.ForeColor = SystemColors.ControlLightLight;
            labelReciept.Location = new Point(49, 220);
            labelReciept.Name = "labelReciept";
            labelReciept.Size = new Size(32, 23);
            labelReciept.TabIndex = 28;
            labelReciept.Text = "+1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(161, 290);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 29;
            label1.Text = "Inventory";
            // 
            // Shop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(432, 478);
            Controls.Add(label1);
            Controls.Add(labelReciept);
            Controls.Add(pictureBox3);
            Controls.Add(labelCoinCount);
            Controls.Add(labelArrowCount);
            Controls.Add(pictureBoxSecretBuy);
            Controls.Add(pictureBoxArrowBuy);
            Controls.Add(labelSecretPrice);
            Controls.Add(labelArrowCost);
            Controls.Add(labelTitle);
            Controls.Add(labelArrowLabel);
            Controls.Add(pictureBoxCoin);
            Controls.Add(labelCoinLabel);
            Controls.Add(buttonClose);
            Name = "Shop";
            Text = "Shop";
            Load += Shop_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArrowBuy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecretBuy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Label labelArrowLabel;
        private PictureBox pictureBoxCoin;
        private Label labelCoinLabel;
        private Label labelTitle;
        private Label labelArrowCost;
        private Label labelSecretPrice;
        private PictureBox pictureBoxArrowBuy;
        private PictureBox pictureBoxSecretBuy;
        private Label labelArrowCount;
        private Label labelCoinCount;
        private PictureBox pictureBox3;
        private Label labelReciept;
        private Label label1;
    }
}