namespace TestingGround
{
    partial class Form1
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
            buttonStart.Location = new Point(176, 106);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(147, 43);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start Game";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonHighscores
            // 
            buttonHighscores.Location = new Point(351, 12);
            buttonHighscores.Name = "buttonHighscores";
            buttonHighscores.Size = new Size(128, 30);
            buttonHighscores.TabIndex = 1;
            buttonHighscores.Text = "High Scores";
            buttonHighscores.UseVisualStyleBackColor = true;
            buttonHighscores.Click += buttonHighscores_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 258);
            Controls.Add(buttonHighscores);
            Controls.Add(buttonStart);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GCUI Test";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStart;
        private Button buttonHighscores;
    }
}
