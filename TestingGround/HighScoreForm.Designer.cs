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
            labelTitle = new Label();
            listBoxNameList = new ListBox();
            buttonClose = new Button();
            labelName = new Label();
            labelScore = new Label();
            labelRunStatistics = new Label();
            listBoxStatistics = new ListBox();
            labelPlayerStat = new Label();
            buttonClose2 = new Button();
            buttonOptions2 = new Button();
            buttonOptions1 = new Button();
            buttonExitOptions = new Button();
            buttonDeleteSelected = new Button();
            buttonEraseAll = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Book Antiqua", 22F, FontStyle.Bold);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(47, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(183, 35);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "High-Scores";
            labelTitle.Click += labelTitle_Click;
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
            // buttonOptions2
            // 
            buttonOptions2.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOptions2.Location = new Point(26, 438);
            buttonOptions2.Name = "buttonOptions2";
            buttonOptions2.Size = new Size(75, 23);
            buttonOptions2.TabIndex = 14;
            buttonOptions2.Text = "Options";
            buttonOptions2.UseVisualStyleBackColor = true;
            buttonOptions2.Visible = false;
            buttonOptions2.Click += buttonOptions2_Click;
            // 
            // buttonOptions1
            // 
            buttonOptions1.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOptions1.Location = new Point(25, 281);
            buttonOptions1.Name = "buttonOptions1";
            buttonOptions1.Size = new Size(75, 23);
            buttonOptions1.TabIndex = 13;
            buttonOptions1.Text = "Options";
            buttonOptions1.UseVisualStyleBackColor = true;
            buttonOptions1.Click += buttonOptions1_Click_1;
            // 
            // buttonExitOptions
            // 
            buttonExitOptions.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExitOptions.Location = new Point(26, 439);
            buttonExitOptions.Name = "buttonExitOptions";
            buttonExitOptions.Size = new Size(97, 23);
            buttonExitOptions.TabIndex = 15;
            buttonExitOptions.Text = "Exit options";
            buttonExitOptions.UseVisualStyleBackColor = true;
            buttonExitOptions.Visible = false;
            buttonExitOptions.Click += buttonExitOptions_Click;
            // 
            // buttonDeleteSelected
            // 
            buttonDeleteSelected.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteSelected.Location = new Point(29, 346);
            buttonDeleteSelected.Name = "buttonDeleteSelected";
            buttonDeleteSelected.Size = new Size(97, 65);
            buttonDeleteSelected.TabIndex = 16;
            buttonDeleteSelected.Text = "Delete selected score";
            buttonDeleteSelected.UseVisualStyleBackColor = true;
            buttonDeleteSelected.Visible = false;
            buttonDeleteSelected.Click += buttonDeleteSelected_Click;
            // 
            // buttonEraseAll
            // 
            buttonEraseAll.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEraseAll.Location = new Point(152, 346);
            buttonEraseAll.Name = "buttonEraseAll";
            buttonEraseAll.Size = new Size(97, 65);
            buttonEraseAll.TabIndex = 17;
            buttonEraseAll.Text = "Erase all high-scores";
            buttonEraseAll.UseVisualStyleBackColor = true;
            buttonEraseAll.Visible = false;
            buttonEraseAll.Click += buttonEraseAll_Click;
            // 
            // HighScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            CancelButton = buttonClose;
            ClientSize = new Size(277, 474);
            Controls.Add(buttonEraseAll);
            Controls.Add(buttonDeleteSelected);
            Controls.Add(buttonExitOptions);
            Controls.Add(buttonOptions2);
            Controls.Add(buttonOptions1);
            Controls.Add(buttonClose2);
            Controls.Add(labelPlayerStat);
            Controls.Add(listBoxStatistics);
            Controls.Add(labelRunStatistics);
            Controls.Add(labelScore);
            Controls.Add(labelName);
            Controls.Add(buttonClose);
            Controls.Add(listBoxNameList);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HighScoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HighScoreForm";
            Load += HighScoreForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private ListBox listBoxNameList;
        private Button buttonClose;
        private Label labelName;
        private Label labelScore;
        private Label label2;
        private Label labelRunStatistics;
        private ListBox listBoxStatistics;
        private Label labelPlayerStat;
        private Button buttonClose2;
        private Button buttonOptions2;
        private Button buttonOptions1;
        private Button buttonExitOptions;
        private Button buttonDeleteSelected;
        private Button buttonEraseAll;
    }
}