namespace GCUITest
{
    partial class Trivia
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
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Book Antiqua", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(112, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(305, 35);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Wumpus Encountered!";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(447, 476);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // Trivia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.New_Piskel;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(534, 511);
            Controls.Add(buttonExit);
            Controls.Add(labelTitle);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Trivia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trivia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonExit;
    }
}