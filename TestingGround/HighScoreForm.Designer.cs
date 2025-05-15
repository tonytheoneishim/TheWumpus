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
            listBoxNameList = new ListBox();
            buttonClose = new Button();
            labelName = new Label();
            labelScore = new Label();
            label3 = new Label();
            listBoxStatistics = new ListBox();
            labelPlayerStat = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(75, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 0;
            label1.Text = "High Scores";
            // 
            // listBoxNameList
            // 
            listBoxNameList.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxNameList.FormattingEnabled = true;
            listBoxNameList.ItemHeight = 19;
            listBoxNameList.Location = new Point(12, 61);
            listBoxNameList.Name = "listBoxNameList";
            listBoxNameList.Size = new Size(227, 175);
            listBoxNameList.TabIndex = 1;
            listBoxNameList.SelectedIndexChanged += listBoxHighScores_SelectedIndexChanged;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose.Location = new Point(364, 213);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.ControlLightLight;
            labelName.Location = new Point(12, 37);
            labelName.Name = "labelName";
            labelName.Size = new Size(56, 21);
            labelName.TabIndex = 5;
            labelName.Text = "Player";
            labelName.Click += labelName_Click;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelScore.ForeColor = SystemColors.ControlLightLight;
            labelScore.Location = new Point(155, 37);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(50, 21);
            labelScore.TabIndex = 6;
            labelScore.Text = "Score";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(300, 9);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 9;
            label3.Text = "Run Statistics";
            // 
            // listBoxStatistics
            // 
            listBoxStatistics.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxStatistics.FormattingEnabled = true;
            listBoxStatistics.ItemHeight = 19;
            listBoxStatistics.Location = new Point(272, 61);
            listBoxStatistics.Name = "listBoxStatistics";
            listBoxStatistics.Size = new Size(167, 80);
            listBoxStatistics.TabIndex = 10;
            // 
            // labelPlayerStat
            // 
            labelPlayerStat.AutoSize = true;
            labelPlayerStat.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayerStat.ForeColor = SystemColors.ControlLightLight;
            labelPlayerStat.Location = new Point(272, 37);
            labelPlayerStat.Name = "labelPlayerStat";
            labelPlayerStat.Size = new Size(55, 21);
            labelPlayerStat.TabIndex = 11;
            labelPlayerStat.Text = "plsyer";
            // 
            // HighScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            CancelButton = buttonClose;
            ClientSize = new Size(453, 258);
            Controls.Add(labelPlayerStat);
            Controls.Add(listBoxStatistics);
            Controls.Add(label3);
            Controls.Add(labelScore);
            Controls.Add(labelName);
            Controls.Add(buttonClose);
            Controls.Add(listBoxNameList);
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
        private ListBox listBoxNameList;
        private Button buttonClose;
        private Label labelName;
        private Label labelScore;
        private Label label2;
        private Label label3;
        private ListBox listBoxStatistics;
        private Label labelPlayerStat;
    }
}