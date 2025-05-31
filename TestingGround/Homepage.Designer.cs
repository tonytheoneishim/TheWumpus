namespace TestingGround
{
    partial class Homepage
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
            buttonStart = new Button();
            buttonHighscores = new Button();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(27, 27, 27);
            buttonStart.FlatAppearance.BorderSize = 0;
            buttonStart.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonStart.FlatAppearance.MouseOverBackColor = Color.DimGray;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.Font = new Font("Book Antiqua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStart.ForeColor = Color.WhiteSmoke;
            buttonStart.Location = new Point(176, 106);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(147, 43);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start Game";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonHighscores
            // 
            buttonHighscores.BackColor = Color.FromArgb(27, 27, 27);
            buttonHighscores.FlatAppearance.BorderSize = 0;
            buttonHighscores.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonHighscores.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonHighscores.FlatStyle = FlatStyle.Flat;
            buttonHighscores.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold);
            buttonHighscores.ForeColor = Color.WhiteSmoke;
            buttonHighscores.Location = new Point(344, 12);
            buttonHighscores.Name = "buttonHighscores";
            buttonHighscores.Size = new Size(128, 30);
            buttonHighscores.TabIndex = 1;
            buttonHighscores.Text = "High-Scores";
            buttonHighscores.UseVisualStyleBackColor = false;
            buttonHighscores.Click += buttonHighscores_Click;
            // 
            // Homepage
            // 
            AcceptButton = buttonStart;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = GCUITest.Properties.Resources.Playername_Form_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(484, 261);
            Controls.Add(buttonHighscores);
            Controls.Add(buttonStart);
            DoubleBuffered = true;
            ForeColor = Color.WhiteSmoke;
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hunt the Wumpus! (GCUI Test)";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStart;
        private Button buttonHighscores;
    }
}
