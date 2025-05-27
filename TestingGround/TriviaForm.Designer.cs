namespace GCUITest
{
    partial class TriviaForm
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
            richTextBoxQuestion = new RichTextBox();
            buttonAnswer1 = new Button();
            buttonAnswer2 = new Button();
            buttonAnswer3 = new Button();
            buttonAnswer4 = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Book Antiqua", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(116, 50);
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
            // richTextBoxQuestion
            // 
            richTextBoxQuestion.BackColor = Color.FromArgb(27, 27, 27);
            richTextBoxQuestion.BorderStyle = BorderStyle.None;
            richTextBoxQuestion.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxQuestion.ForeColor = SystemColors.Window;
            richTextBoxQuestion.Location = new Point(100, 178);
            richTextBoxQuestion.Name = "richTextBoxQuestion";
            richTextBoxQuestion.Size = new Size(327, 118);
            richTextBoxQuestion.TabIndex = 2;
            richTextBoxQuestion.Text = "Question Goes Here";
          
            // 
            // buttonAnswer1
            // 
            buttonAnswer1.BackColor = Color.FromArgb(27, 27, 27);
            buttonAnswer1.Font = new Font("Book Antiqua", 11.25F);
            buttonAnswer1.ForeColor = SystemColors.ControlLightLight;
            buttonAnswer1.Location = new Point(100, 302);
            buttonAnswer1.Name = "buttonAnswer1";
            buttonAnswer1.Size = new Size(155, 41);
            buttonAnswer1.TabIndex = 3;
            buttonAnswer1.Text = "1";
            buttonAnswer1.UseVisualStyleBackColor = false;
            buttonAnswer1.Click += buttonAnswer1_Click;
            // 
            // buttonAnswer2
            // 
            buttonAnswer2.BackColor = Color.FromArgb(27, 27, 27);
            buttonAnswer2.Font = new Font("Book Antiqua", 11.25F);
            buttonAnswer2.ForeColor = SystemColors.ControlLightLight;
            buttonAnswer2.Location = new Point(266, 302);
            buttonAnswer2.Name = "buttonAnswer2";
            buttonAnswer2.Size = new Size(155, 41);
            buttonAnswer2.TabIndex = 4;
            buttonAnswer2.Text = "2";
            buttonAnswer2.UseVisualStyleBackColor = false;
            buttonAnswer2.Click += buttonAnswer2_Click;
            // 
            // buttonAnswer3
            // 
            buttonAnswer3.BackColor = Color.FromArgb(27, 27, 27);
            buttonAnswer3.Font = new Font("Book Antiqua", 11.25F);
            buttonAnswer3.ForeColor = SystemColors.ControlLightLight;
            buttonAnswer3.Location = new Point(100, 349);
            buttonAnswer3.Name = "buttonAnswer3";
            buttonAnswer3.Size = new Size(155, 41);
            buttonAnswer3.TabIndex = 5;
            buttonAnswer3.Text = "3";
            buttonAnswer3.UseVisualStyleBackColor = false;
            buttonAnswer3.Click += buttonAnswer3_Click;
            // 
            // buttonAnswer4
            // 
            buttonAnswer4.BackColor = Color.FromArgb(27, 27, 27);
            buttonAnswer4.Font = new Font("Book Antiqua", 11.25F);
            buttonAnswer4.ForeColor = SystemColors.ControlLightLight;
            buttonAnswer4.Location = new Point(266, 349);
            buttonAnswer4.Name = "buttonAnswer4";
            buttonAnswer4.Size = new Size(155, 41);
            buttonAnswer4.TabIndex = 6;
            buttonAnswer4.Text = "4";
            buttonAnswer4.UseVisualStyleBackColor = false;
            buttonAnswer4.Click += buttonAnswer4_Click;
            // 
            // Trivia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.New_Piskel;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(534, 511);
            Controls.Add(buttonAnswer4);
            Controls.Add(buttonAnswer3);
            Controls.Add(buttonAnswer2);
            Controls.Add(buttonAnswer1);
            Controls.Add(richTextBoxQuestion);
            Controls.Add(buttonExit);
            Controls.Add(labelTitle);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Trivia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trivia";
            Load += Trivia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonExit;
        private RichTextBox richTextBoxQuestion;
        private Button buttonAnswer1;
        private Button buttonAnswer2;
        private Button buttonAnswer3;
        private Button buttonAnswer4;
    }
}