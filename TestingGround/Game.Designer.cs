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
            buttonNE = new Button();
            buttonRoomNW = new Button();
            buttonRoomSW = new Button();
            buttonRoomSE = new Button();
            buttonRoomS = new Button();
            pictureBoxRoom = new PictureBox();
            groupBox1 = new GroupBox();
            labelPoints = new Label();
            labelCoins = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoom).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRoomN
            // 
            buttonRoomN.BackColor = SystemColors.ControlDark;
            buttonRoomN.Cursor = Cursors.PanNorth;
            buttonRoomN.FlatStyle = FlatStyle.Popup;
            buttonRoomN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonRoomN.ForeColor = SystemColors.ControlText;
            buttonRoomN.Location = new Point(250, 25);
            buttonRoomN.Name = "buttonRoomN";
            buttonRoomN.Size = new Size(30, 30);
            buttonRoomN.TabIndex = 0;
            buttonRoomN.Text = "-";
            buttonRoomN.UseVisualStyleBackColor = false;
            // 
            // buttonNE
            // 
            buttonNE.BackColor = SystemColors.ControlDark;
            buttonNE.Cursor = Cursors.PanNE;
            buttonNE.FlatStyle = FlatStyle.Popup;
            buttonNE.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonNE.ForeColor = SystemColors.ControlText;
            buttonNE.Location = new Point(371, 76);
            buttonNE.Name = "buttonNE";
            buttonNE.Size = new Size(30, 30);
            buttonNE.TabIndex = 1;
            buttonNE.Text = "-";
            buttonNE.UseVisualStyleBackColor = false;
            // 
            // buttonRoomNW
            // 
            buttonRoomNW.BackColor = SystemColors.ControlDark;
            buttonRoomNW.Cursor = Cursors.PanNW;
            buttonRoomNW.FlatStyle = FlatStyle.Popup;
            buttonRoomNW.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonRoomNW.ForeColor = SystemColors.ControlText;
            buttonRoomNW.Location = new Point(129, 76);
            buttonRoomNW.Name = "buttonRoomNW";
            buttonRoomNW.Size = new Size(30, 30);
            buttonRoomNW.TabIndex = 2;
            buttonRoomNW.Text = "-";
            buttonRoomNW.UseVisualStyleBackColor = false;
            // 
            // buttonRoomSW
            // 
            buttonRoomSW.BackColor = SystemColors.ControlDark;
            buttonRoomSW.Cursor = Cursors.PanSW;
            buttonRoomSW.FlatStyle = FlatStyle.Popup;
            buttonRoomSW.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonRoomSW.ForeColor = SystemColors.ControlText;
            buttonRoomSW.Location = new Point(129, 222);
            buttonRoomSW.Name = "buttonRoomSW";
            buttonRoomSW.Size = new Size(30, 30);
            buttonRoomSW.TabIndex = 3;
            buttonRoomSW.Text = "-";
            buttonRoomSW.UseVisualStyleBackColor = false;
            // 
            // buttonRoomSE
            // 
            buttonRoomSE.BackColor = SystemColors.ControlDark;
            buttonRoomSE.Cursor = Cursors.PanSE;
            buttonRoomSE.FlatStyle = FlatStyle.Popup;
            buttonRoomSE.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonRoomSE.ForeColor = SystemColors.ControlText;
            buttonRoomSE.Location = new Point(371, 222);
            buttonRoomSE.Name = "buttonRoomSE";
            buttonRoomSE.Size = new Size(30, 30);
            buttonRoomSE.TabIndex = 4;
            buttonRoomSE.Text = "-";
            buttonRoomSE.UseVisualStyleBackColor = false;
            // 
            // buttonRoomS
            // 
            buttonRoomS.BackColor = SystemColors.ControlDark;
            buttonRoomS.Cursor = Cursors.PanSouth;
            buttonRoomS.FlatStyle = FlatStyle.Popup;
            buttonRoomS.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonRoomS.ForeColor = SystemColors.ControlText;
            buttonRoomS.Location = new Point(250, 275);
            buttonRoomS.Name = "buttonRoomS";
            buttonRoomS.Size = new Size(30, 30);
            buttonRoomS.TabIndex = 5;
            buttonRoomS.Text = "-";
            buttonRoomS.UseVisualStyleBackColor = false;
            // 
            // pictureBoxRoom
            // 
            pictureBoxRoom.BackColor = Color.Transparent;
            pictureBoxRoom.Image = GCUITest.Properties.Resources.hex_ver_1_removebg_preview;
            pictureBoxRoom.Location = new Point(129, 37);
            pictureBoxRoom.Name = "pictureBoxRoom";
            pictureBoxRoom.Size = new Size(272, 268);
            pictureBoxRoom.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRoom.TabIndex = 6;
            pictureBoxRoom.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelPoints);
            groupBox1.Controls.Add(labelCoins);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(10, 353);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 146);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hunt the Wumpus!";
            // 
            // labelPoints
            // 
            labelPoints.AutoSize = true;
            labelPoints.Location = new Point(119, 68);
            labelPoints.Name = "labelPoints";
            labelPoints.Size = new Size(21, 20);
            labelPoints.TabIndex = 3;
            labelPoints.Text = "--";
            // 
            // labelCoins
            // 
            labelCoins.AutoSize = true;
            labelCoins.Location = new Point(119, 36);
            labelCoins.Name = "labelCoins";
            labelCoins.Size = new Size(21, 20);
            labelCoins.TabIndex = 2;
            labelCoins.Text = "--";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 68);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Points";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Coins";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(534, 511);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxRoom);
            Controls.Add(buttonRoomS);
            Controls.Add(buttonRoomSE);
            Controls.Add(buttonRoomSW);
            Controls.Add(buttonRoomNW);
            Controls.Add(buttonNE);
            Controls.Add(buttonRoomN);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hunt the Wumpus!";
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoom).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRoomN;
        private Button buttonNE;
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
    }
}