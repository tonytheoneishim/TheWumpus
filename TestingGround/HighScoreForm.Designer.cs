namespace TestingGround
{
    partial class HighScoreForm
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
            label1 = new Label();
            listBoxHighScores = new ListBox();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 0;
            label1.Text = "High Scores";
            // 
            // listBoxHighScores
            // 
            listBoxHighScores.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxHighScores.FormattingEnabled = true;
            listBoxHighScores.ItemHeight = 20;
            listBoxHighScores.Location = new Point(87, 33);
            listBoxHighScores.Name = "listBoxHighScores";
            listBoxHighScores.Size = new Size(215, 184);
            listBoxHighScores.TabIndex = 1;
            listBoxHighScores.SelectedIndexChanged += listBoxHighScores_SelectedIndexChanged;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(294, 241);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // HighScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(381, 276);
            Controls.Add(buttonClose);
            Controls.Add(listBoxHighScores);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HighScoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HighScoreForm";
            Load += HighScoreForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxHighScores;
        private Button buttonClose;
    }
}