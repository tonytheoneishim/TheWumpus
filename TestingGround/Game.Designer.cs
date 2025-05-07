namespace TestingGround
{
    partial class Game
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
            buttonRoomN = new Button();
            buttonRoomNE = new Button();
            buttonRoomNW = new Button();
            buttonRoomSW = new Button();
            buttonRoomSE = new Button();
            buttonRoomS = new Button();
            pictureBoxRoom = new PictureBox();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            labelArrows = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            labelPoints = new Label();
            labelCoins = new Label();
            label2 = new Label();
            label1 = new Label();
            labelPlayerName = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoom).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonRoomN
            // 
            buttonRoomN.BackColor = SystemColors.ControlDark;
            buttonRoomN.Cursor = Cursors.PanNorth;
            buttonRoomN.FlatStyle = FlatStyle.Popup;
            buttonRoomN.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            buttonRoomN.ForeColor = SystemColors.ControlText;
            buttonRoomN.Location = new Point(241, 17);
            buttonRoomN.Name = "buttonRoomN";
            buttonRoomN.Size = new Size(50, 50);
            buttonRoomN.TabIndex = 0;
            buttonRoomN.Text = "N";
            buttonRoomN.UseVisualStyleBackColor = false;
            buttonRoomN.Click += buttonRoomN_Click;
            // 
            // buttonRoomNE
            // 
            buttonRoomNE.BackColor = SystemColors.ControlDark;
            buttonRoomNE.Cursor = Cursors.PanNE;
            buttonRoomNE.FlatStyle = FlatStyle.Popup;
            buttonRoomNE.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            buttonRoomNE.ForeColor = SystemColors.ControlText;
            buttonRoomNE.Location = new Point(362, 73);
            buttonRoomNE.Name = "buttonRoomNE";
            buttonRoomNE.Size = new Size(50, 50);
            buttonRoomNE.TabIndex = 1;
            buttonRoomNE.Text = "NE";
            buttonRoomNE.UseVisualStyleBackColor = false;
            buttonRoomNE.Click += buttonRoomN_Click;
            // 
            // buttonRoomNW
            // 
            buttonRoomNW.BackColor = SystemColors.ControlDark;
            buttonRoomNW.Cursor = Cursors.PanNW;
            buttonRoomNW.FlatStyle = FlatStyle.Popup;
            buttonRoomNW.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            buttonRoomNW.ForeColor = SystemColors.ControlText;
            buttonRoomNW.Location = new Point(120, 73);
            buttonRoomNW.Name = "buttonRoomNW";
            buttonRoomNW.Size = new Size(50, 50);
            buttonRoomNW.TabIndex = 2;
            buttonRoomNW.Text = "NW";
            buttonRoomNW.UseVisualStyleBackColor = false;
            buttonRoomNW.Click += buttonRoomN_Click;
            // 
            // buttonRoomSW
            // 
            buttonRoomSW.BackColor = SystemColors.ControlDark;
            buttonRoomSW.Cursor = Cursors.PanSW;
            buttonRoomSW.FlatStyle = FlatStyle.Popup;
            buttonRoomSW.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            buttonRoomSW.ForeColor = SystemColors.ControlText;
            buttonRoomSW.Location = new Point(120, 219);
            buttonRoomSW.Name = "buttonRoomSW";
            buttonRoomSW.Size = new Size(50, 50);
            buttonRoomSW.TabIndex = 3;
            buttonRoomSW.Text = "SW";
            buttonRoomSW.UseVisualStyleBackColor = false;
            buttonRoomSW.Click += buttonRoomN_Click;
            // 
            // buttonRoomSE
            // 
            buttonRoomSE.BackColor = SystemColors.ControlDark;
            buttonRoomSE.Cursor = Cursors.PanSE;
            buttonRoomSE.FlatStyle = FlatStyle.Popup;
            buttonRoomSE.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            buttonRoomSE.ForeColor = SystemColors.ControlText;
            buttonRoomSE.Location = new Point(362, 219);
            buttonRoomSE.Name = "buttonRoomSE";
            buttonRoomSE.Size = new Size(50, 50);
            buttonRoomSE.TabIndex = 4;
            buttonRoomSE.Text = "SE";
            buttonRoomSE.UseVisualStyleBackColor = false;
            buttonRoomSE.Click += buttonRoomN_Click;
            // 
            // buttonRoomS
            // 
            buttonRoomS.BackColor = SystemColors.ControlDark;
            buttonRoomS.Cursor = Cursors.PanSouth;
            buttonRoomS.FlatStyle = FlatStyle.Popup;
            buttonRoomS.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            buttonRoomS.ForeColor = SystemColors.ControlText;
            buttonRoomS.Location = new Point(241, 277);
            buttonRoomS.Name = "buttonRoomS";
            buttonRoomS.Size = new Size(50, 50);
            buttonRoomS.TabIndex = 5;
            buttonRoomS.Text = "S";
            buttonRoomS.UseVisualStyleBackColor = false;
            buttonRoomS.Click += buttonRoomN_Click;
            // 
            // pictureBoxRoom
            // 
            pictureBoxRoom.BackColor = Color.Transparent;
            pictureBoxRoom.Image = GCUITest.Properties.Resources.hex_ver_1_removebg_preview;
            pictureBoxRoom.Location = new Point(130, 43);
            pictureBoxRoom.Name = "pictureBoxRoom";
            pictureBoxRoom.Size = new Size(272, 268);
            pictureBoxRoom.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRoom.TabIndex = 6;
            pictureBoxRoom.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(labelArrows);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(labelPoints);
            groupBox1.Controls.Add(labelCoins);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(10, 353);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 146);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hunt the Wumpus!";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = GCUITest.Properties.Resources.Arrow_removebg_preview;
            pictureBox2.Location = new Point(12, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // labelArrows
            // 
            labelArrows.AutoSize = true;
            labelArrows.Location = new Point(119, 80);
            labelArrows.Name = "labelArrows";
            labelArrows.Size = new Size(19, 19);
            labelArrows.TabIndex = 11;
            labelArrows.Text = "--";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 80);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 10;
            label4.Text = "Arrows:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GCUITest.Properties.Resources.Coin_removebg_preview;
            pictureBox1.Location = new Point(21, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // labelPoints
            // 
            labelPoints.AutoSize = true;
            labelPoints.Location = new Point(469, 23);
            labelPoints.Name = "labelPoints";
            labelPoints.Size = new Size(19, 19);
            labelPoints.TabIndex = 3;
            labelPoints.Text = "--";
            // 
            // labelCoins
            // 
            labelCoins.AutoSize = true;
            labelCoins.Location = new Point(119, 36);
            labelCoins.Name = "labelCoins";
            labelCoins.Size = new Size(19, 19);
            labelCoins.TabIndex = 2;
            labelCoins.Text = "--";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 23);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 1;
            label2.Text = "Points";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 36);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 0;
            label1.Text = "Coins:";
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayerName.ForeColor = SystemColors.ControlLightLight;
            labelPlayerName.Location = new Point(6, 9);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(60, 21);
            labelPlayerName.TabIndex = 8;
            labelPlayerName.Text = "Player:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(6, 31);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 9;
            label3.Text = "Cave: ";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(534, 511);
            Controls.Add(label3);
            Controls.Add(labelPlayerName);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxRoom);
            Controls.Add(buttonRoomS);
            Controls.Add(buttonRoomSE);
            Controls.Add(buttonRoomSW);
            Controls.Add(buttonRoomNW);
            Controls.Add(buttonRoomNE);
            Controls.Add(buttonRoomN);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hunt the Wumpus!";
            Load += Game_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoom).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRoomN;
        private Button buttonRoomNE;
        private Button buttonRoomNW;
        private Button buttonRoomSW;
        private Button buttonRoomSE;
        private Button buttonRoomS;
        private PictureBox pictureBoxRoom;
        private GroupBox groupBox1;
        private Label labelPoints;
        private Label labelCoins;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label labelArrows;
        private Label label4;
        private PictureBox pictureBox2;
        private Label labelPlayerName;
        private Label label3;
    }
}