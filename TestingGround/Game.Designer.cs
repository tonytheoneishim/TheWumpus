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
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoom).BeginInit();
            SuspendLayout();
            // 
            // buttonRoomN
            // 
            buttonRoomN.BackColor = SystemColors.ControlDark;
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
            buttonRoomS.Location = new Point(250, 275);
            buttonRoomS.Name = "buttonRoomS";
            buttonRoomS.Size = new Size(30, 30);
            buttonRoomS.TabIndex = 5;
            buttonRoomS.Text = "-";
            buttonRoomS.UseVisualStyleBackColor = false;
            // 
            // pictureBoxRoom
            // 
            pictureBoxRoom.Image = Properties.Resources.hex_ver_1_removebg_preview;
            pictureBoxRoom.Location = new Point(165, 65);
            pictureBoxRoom.Name = "pictureBoxRoom";
            pictureBoxRoom.Size = new Size(200, 200);
            pictureBoxRoom.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRoom.TabIndex = 6;
            pictureBoxRoom.TabStop = false;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(534, 511);
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
    }
}