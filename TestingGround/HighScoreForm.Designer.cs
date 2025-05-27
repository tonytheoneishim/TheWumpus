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
            labelRunStatistics = new Label();
            listBoxStatistics = new ListBox();
            labelPlayerStat = new Label();
            buttonClose2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 22F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(49, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 35);
            label1.TabIndex = 0;
            label1.Text = "High Scores";
            // 
            // listBoxNameList
            // 
            listBoxNameList.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxNameList.FormattingEnabled = true;
            listBoxNameList.ItemHeight = 19;
            listBoxNameList.Location = new Point(25, 72);
            listBoxNameList.Name = "listBoxNameList";
            listBoxNameList.Size = new Size(227, 194);
            listBoxNameList.TabIndex = 1;
            listBoxNameList.SelectedIndexChanged += listBoxHighScores_SelectedIndexChanged;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose.Location = new Point(177, 438);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Visible = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.ControlLightLight;
            labelName.Location = new Point(25, 48);
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
            labelScore.Location = new Point(168, 48);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(50, 21);
            labelScore.TabIndex = 6;
            labelScore.Text = "Score";
            // 
            // labelRunStatistics
            // 
            labelRunStatistics.AutoSize = true;
            labelRunStatistics.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRunStatistics.ForeColor = SystemColors.ControlLightLight;
            labelRunStatistics.Location = new Point(87, 280);
            labelRunStatistics.Name = "labelRunStatistics";
            labelRunStatistics.Size = new Size(110, 21);
            labelRunStatistics.TabIndex = 9;
            labelRunStatistics.Text = "Run Statistics";
            labelRunStatistics.Visible = false;
            // 
            // listBoxStatistics
            // 
            listBoxStatistics.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxStatistics.FormattingEnabled = true;
            listBoxStatistics.ItemHeight = 19;
            listBoxStatistics.Location = new Point(25, 324);
            listBoxStatistics.Name = "listBoxStatistics";
            listBoxStatistics.Size = new Size(227, 99);
            listBoxStatistics.TabIndex = 10;
            listBoxStatistics.Visible = false;
            // 
            // labelPlayerStat
            // 
            labelPlayerStat.AutoSize = true;
            labelPlayerStat.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayerStat.ForeColor = SystemColors.ControlLightLight;
            labelPlayerStat.Location = new Point(26, 300);
            labelPlayerStat.Name = "labelPlayerStat";
            labelPlayerStat.Size = new Size(55, 21);
            labelPlayerStat.TabIndex = 11;
            labelPlayerStat.Text = "plsyer";
            labelPlayerStat.Visible = false;
            // 
            // buttonClose2
            // 
            buttonClose2.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose2.Location = new Point(177, 281);
            buttonClose2.Name = "buttonClose2";
            buttonClose2.Size = new Size(75, 23);
            buttonClose2.TabIndex = 12;
            buttonClose2.Text = "Close";
            buttonClose2.UseVisualStyleBackColor = true;
            buttonClose2.Click += buttonClose2_Click;
            // 
            // HighScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            CancelButton = buttonClose;
            ClientSize = new Size(277, 474);
            Controls.Add(buttonClose2);
            Controls.Add(labelPlayerStat);
            Controls.Add(listBoxStatistics);
            Controls.Add(labelRunStatistics);
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
        private Label labelRunStatistics;
        private ListBox listBoxStatistics;
        private Label labelPlayerStat;
        private Button buttonClose2;
    }
}