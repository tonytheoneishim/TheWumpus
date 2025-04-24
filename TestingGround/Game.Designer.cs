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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonRoomN
            // 
            buttonRoomN.BackColor = SystemColors.ControlDark;
            buttonRoomN.Location = new Point(251, 63);
            buttonRoomN.Name = "buttonRoomN";
            buttonRoomN.Size = new Size(29, 28);
            buttonRoomN.TabIndex = 0;
            buttonRoomN.Text = "-";
            buttonRoomN.UseVisualStyleBackColor = false;
            // 
            // buttonNE
            // 
            buttonNE.BackColor = SystemColors.ControlDark;
            buttonNE.Location = new Point(300, 91);
            buttonNE.Name = "buttonNE";
            buttonNE.Size = new Size(29, 28);
            buttonNE.TabIndex = 1;
            buttonNE.Text = "-";
            buttonNE.UseVisualStyleBackColor = false;
            // 
            // buttonRoomNW
            // 
            buttonRoomNW.BackColor = SystemColors.ControlDark;
            buttonRoomNW.Location = new Point(201, 91);
            buttonRoomNW.Name = "buttonRoomNW";
            buttonRoomNW.Size = new Size(29, 28);
            buttonRoomNW.TabIndex = 2;
            buttonRoomNW.Text = "-";
            buttonRoomNW.UseVisualStyleBackColor = false;
            // 
            // buttonRoomSW
            // 
            buttonRoomSW.BackColor = SystemColors.ControlDark;
            buttonRoomSW.Location = new Point(201, 139);
            buttonRoomSW.Name = "buttonRoomSW";
            buttonRoomSW.Size = new Size(29, 28);
            buttonRoomSW.TabIndex = 3;
            buttonRoomSW.Text = "-";
            buttonRoomSW.UseVisualStyleBackColor = false;
            // 
            // buttonRoomSE
            // 
            buttonRoomSE.BackColor = SystemColors.ControlDark;
            buttonRoomSE.Location = new Point(300, 139);
            buttonRoomSE.Name = "buttonRoomSE";
            buttonRoomSE.Size = new Size(29, 28);
            buttonRoomSE.TabIndex = 4;
            buttonRoomSE.Text = "-";
            buttonRoomSE.UseVisualStyleBackColor = false;
            // 
            // buttonRoomS
            // 
            buttonRoomS.BackColor = SystemColors.ControlDark;
            buttonRoomS.Location = new Point(251, 169);
            buttonRoomS.Name = "buttonRoomS";
            buttonRoomS.Size = new Size(29, 28);
            buttonRoomS.TabIndex = 5;
            buttonRoomS.Text = "-";
            buttonRoomS.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hex_ver_1_removebg_preview;
            pictureBox1.Location = new Point(236, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(530, 270);
            Controls.Add(pictureBox1);
            Controls.Add(buttonRoomS);
            Controls.Add(buttonRoomSE);
            Controls.Add(buttonRoomSW);
            Controls.Add(buttonRoomNW);
            Controls.Add(buttonNE);
            Controls.Add(buttonRoomN);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRoomN;
        private Button buttonNE;
        private Button buttonRoomNW;
        private Button buttonRoomSW;
        private Button buttonRoomSE;
        private Button buttonRoomS;
        private PictureBox pictureBox1;
    }
}