namespace testLocationsForm
{
    partial class caveLocationsForm
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
            moveWumpus = new Button();
            wumpusMovedCheck = new CheckBox();
            moveWumpusBox = new GroupBox();
            batNearbyBox = new GroupBox();
            batNearbyCheck = new CheckBox();
            checkForBat = new Button();
            pitNearbyBox = new GroupBox();
            pitNearbyCheck = new CheckBox();
            checkForPit = new Button();
            wumpusNearbyBox = new GroupBox();
            wumpusNearbyCheck = new CheckBox();
            checkForWumpus = new Button();
            ifBatBox = new GroupBox();
            ifBatCheck = new CheckBox();
            withBat = new Button();
            ifPitBox = new GroupBox();
            ifPitCheck = new CheckBox();
            withPit = new Button();
            ifWumpusBox = new GroupBox();
            ifWumpusCheck = new CheckBox();
            withWumpus = new Button();
            shootArrowBox = new GroupBox();
            hitWumpusCheck = new CheckBox();
            shootArrow = new Button();
            wumpusLocationLabel = new Label();
            moveWumpusBox.SuspendLayout();
            batNearbyBox.SuspendLayout();
            pitNearbyBox.SuspendLayout();
            wumpusNearbyBox.SuspendLayout();
            ifBatBox.SuspendLayout();
            ifPitBox.SuspendLayout();
            ifWumpusBox.SuspendLayout();
            shootArrowBox.SuspendLayout();
            SuspendLayout();
            // 
            // moveWumpus
            // 
            moveWumpus.Location = new Point(6, 47);
            moveWumpus.Name = "moveWumpus";
            moveWumpus.Size = new Size(114, 46);
            moveWumpus.TabIndex = 0;
            moveWumpus.Text = "Move the Wumpus";
            moveWumpus.UseVisualStyleBackColor = true;
            moveWumpus.Click += moveWumpus_Click;
            // 
            // wumpusMovedCheck
            // 
            wumpusMovedCheck.AutoSize = true;
            wumpusMovedCheck.Enabled = false;
            wumpusMovedCheck.Location = new Point(6, 22);
            wumpusMovedCheck.Name = "wumpusMovedCheck";
            wumpusMovedCheck.Size = new Size(114, 19);
            wumpusMovedCheck.TabIndex = 3;
            wumpusMovedCheck.Text = "Wumpus Moved";
            wumpusMovedCheck.UseVisualStyleBackColor = true;
            // 
            // moveWumpusBox
            // 
            moveWumpusBox.Controls.Add(wumpusMovedCheck);
            moveWumpusBox.Controls.Add(moveWumpus);
            moveWumpusBox.Location = new Point(12, 126);
            moveWumpusBox.Name = "moveWumpusBox";
            moveWumpusBox.Size = new Size(136, 108);
            moveWumpusBox.TabIndex = 4;
            moveWumpusBox.TabStop = false;
            moveWumpusBox.Text = "Move the Wumpus";
            // 
            // batNearbyBox
            // 
            batNearbyBox.Controls.Add(batNearbyCheck);
            batNearbyBox.Controls.Add(checkForBat);
            batNearbyBox.Location = new Point(12, 12);
            batNearbyBox.Name = "batNearbyBox";
            batNearbyBox.Size = new Size(136, 108);
            batNearbyBox.TabIndex = 5;
            batNearbyBox.TabStop = false;
            batNearbyBox.Text = "If Bat Nearby";
            // 
            // batNearbyCheck
            // 
            batNearbyCheck.AutoSize = true;
            batNearbyCheck.Enabled = false;
            batNearbyCheck.Location = new Point(6, 22);
            batNearbyCheck.Name = "batNearbyCheck";
            batNearbyCheck.Size = new Size(94, 19);
            batNearbyCheck.TabIndex = 3;
            batNearbyCheck.Text = "If Bat Nearby";
            batNearbyCheck.UseVisualStyleBackColor = true;
            // 
            // checkForBat
            // 
            checkForBat.Location = new Point(6, 47);
            checkForBat.Name = "checkForBat";
            checkForBat.Size = new Size(114, 46);
            checkForBat.TabIndex = 0;
            checkForBat.Text = "Check for Bats";
            checkForBat.UseVisualStyleBackColor = true;
            checkForBat.Click += checkForBat_Click;
            // 
            // pitNearbyBox
            // 
            pitNearbyBox.Controls.Add(pitNearbyCheck);
            pitNearbyBox.Controls.Add(checkForPit);
            pitNearbyBox.Location = new Point(154, 12);
            pitNearbyBox.Name = "pitNearbyBox";
            pitNearbyBox.Size = new Size(136, 108);
            pitNearbyBox.TabIndex = 6;
            pitNearbyBox.TabStop = false;
            pitNearbyBox.Text = "If Pit Nearby";
            // 
            // pitNearbyCheck
            // 
            pitNearbyCheck.AutoSize = true;
            pitNearbyCheck.Enabled = false;
            pitNearbyCheck.Location = new Point(6, 22);
            pitNearbyCheck.Name = "pitNearbyCheck";
            pitNearbyCheck.Size = new Size(91, 19);
            pitNearbyCheck.TabIndex = 3;
            pitNearbyCheck.Text = "If Pit Nearby";
            pitNearbyCheck.UseVisualStyleBackColor = true;
            // 
            // checkForPit
            // 
            checkForPit.Location = new Point(6, 47);
            checkForPit.Name = "checkForPit";
            checkForPit.Size = new Size(114, 46);
            checkForPit.TabIndex = 0;
            checkForPit.Text = "Check for Pit";
            checkForPit.UseVisualStyleBackColor = true;
            checkForPit.Click += checkForPit_Click;
            // 
            // wumpusNearbyBox
            // 
            wumpusNearbyBox.Controls.Add(wumpusNearbyCheck);
            wumpusNearbyBox.Controls.Add(checkForWumpus);
            wumpusNearbyBox.Location = new Point(296, 12);
            wumpusNearbyBox.Name = "wumpusNearbyBox";
            wumpusNearbyBox.Size = new Size(136, 108);
            wumpusNearbyBox.TabIndex = 7;
            wumpusNearbyBox.TabStop = false;
            wumpusNearbyBox.Text = "If Wumpus Nearby";
            // 
            // wumpusNearbyCheck
            // 
            wumpusNearbyCheck.AutoSize = true;
            wumpusNearbyCheck.Enabled = false;
            wumpusNearbyCheck.Location = new Point(6, 22);
            wumpusNearbyCheck.Name = "wumpusNearbyCheck";
            wumpusNearbyCheck.Size = new Size(125, 19);
            wumpusNearbyCheck.TabIndex = 3;
            wumpusNearbyCheck.Text = "If Wumpus Nearby";
            wumpusNearbyCheck.UseVisualStyleBackColor = true;
            // 
            // checkForWumpus
            // 
            checkForWumpus.Location = new Point(6, 47);
            checkForWumpus.Name = "checkForWumpus";
            checkForWumpus.Size = new Size(114, 46);
            checkForWumpus.TabIndex = 0;
            checkForWumpus.Text = "Check for Wumpus";
            checkForWumpus.UseVisualStyleBackColor = true;
            checkForWumpus.Click += checkForWumpus_Click;
            // 
            // ifBatBox
            // 
            ifBatBox.Controls.Add(ifBatCheck);
            ifBatBox.Controls.Add(withBat);
            ifBatBox.Location = new Point(12, 240);
            ifBatBox.Name = "ifBatBox";
            ifBatBox.Size = new Size(136, 108);
            ifBatBox.TabIndex = 5;
            ifBatBox.TabStop = false;
            ifBatBox.Text = "If Bat";
            // 
            // ifBatCheck
            // 
            ifBatCheck.AutoSize = true;
            ifBatCheck.Enabled = false;
            ifBatCheck.Location = new Point(6, 22);
            ifBatCheck.Name = "ifBatCheck";
            ifBatCheck.Size = new Size(53, 19);
            ifBatCheck.TabIndex = 3;
            ifBatCheck.Text = "If Bat";
            ifBatCheck.UseVisualStyleBackColor = true;
            // 
            // withBat
            // 
            withBat.Location = new Point(6, 47);
            withBat.Name = "withBat";
            withBat.Size = new Size(114, 46);
            withBat.TabIndex = 0;
            withBat.Text = "Player with Bat";
            withBat.UseVisualStyleBackColor = true;
            withBat.Click += withBat_Click;
            // 
            // ifPitBox
            // 
            ifPitBox.Controls.Add(ifPitCheck);
            ifPitBox.Controls.Add(withPit);
            ifPitBox.Location = new Point(154, 240);
            ifPitBox.Name = "ifPitBox";
            ifPitBox.Size = new Size(136, 108);
            ifPitBox.TabIndex = 6;
            ifPitBox.TabStop = false;
            ifPitBox.Text = "If Pit";
            // 
            // ifPitCheck
            // 
            ifPitCheck.AutoSize = true;
            ifPitCheck.Enabled = false;
            ifPitCheck.Location = new Point(6, 22);
            ifPitCheck.Name = "ifPitCheck";
            ifPitCheck.Size = new Size(50, 19);
            ifPitCheck.TabIndex = 3;
            ifPitCheck.Text = "If Pit";
            ifPitCheck.UseVisualStyleBackColor = true;
            // 
            // withPit
            // 
            withPit.Location = new Point(6, 47);
            withPit.Name = "withPit";
            withPit.Size = new Size(114, 46);
            withPit.TabIndex = 0;
            withPit.Text = "Player with Pit";
            withPit.UseVisualStyleBackColor = true;
            withPit.Click += withPit_Click;
            // 
            // ifWumpusBox
            // 
            ifWumpusBox.Controls.Add(ifWumpusCheck);
            ifWumpusBox.Controls.Add(withWumpus);
            ifWumpusBox.Location = new Point(296, 240);
            ifWumpusBox.Name = "ifWumpusBox";
            ifWumpusBox.Size = new Size(136, 108);
            ifWumpusBox.TabIndex = 8;
            ifWumpusBox.TabStop = false;
            ifWumpusBox.Text = "If Wumpus";
            // 
            // ifWumpusCheck
            // 
            ifWumpusCheck.AutoSize = true;
            ifWumpusCheck.Enabled = false;
            ifWumpusCheck.Location = new Point(6, 22);
            ifWumpusCheck.Name = "ifWumpusCheck";
            ifWumpusCheck.Size = new Size(84, 19);
            ifWumpusCheck.TabIndex = 3;
            ifWumpusCheck.Text = "If Wumpus";
            ifWumpusCheck.UseVisualStyleBackColor = true;
            // 
            // withWumpus
            // 
            withWumpus.Location = new Point(6, 47);
            withWumpus.Name = "withWumpus";
            withWumpus.Size = new Size(114, 46);
            withWumpus.TabIndex = 0;
            withWumpus.Text = "Player with Wumpus";
            withWumpus.UseVisualStyleBackColor = true;
            withWumpus.Click += withWumpus_Click;
            // 
            // shootArrowBox
            // 
            shootArrowBox.Controls.Add(hitWumpusCheck);
            shootArrowBox.Controls.Add(shootArrow);
            shootArrowBox.Location = new Point(154, 126);
            shootArrowBox.Name = "shootArrowBox";
            shootArrowBox.Size = new Size(136, 108);
            shootArrowBox.TabIndex = 5;
            shootArrowBox.TabStop = false;
            shootArrowBox.Text = "Shoot Arrow";
            // 
            // hitWumpusCheck
            // 
            hitWumpusCheck.AutoSize = true;
            hitWumpusCheck.Enabled = false;
            hitWumpusCheck.Location = new Point(6, 22);
            hitWumpusCheck.Name = "hitWumpusCheck";
            hitWumpusCheck.Size = new Size(128, 19);
            hitWumpusCheck.TabIndex = 3;
            hitWumpusCheck.Text = "Arrow Hit Wumpus";
            hitWumpusCheck.UseVisualStyleBackColor = true;
            // 
            // shootArrow
            // 
            shootArrow.Location = new Point(6, 47);
            shootArrow.Name = "shootArrow";
            shootArrow.Size = new Size(114, 46);
            shootArrow.TabIndex = 0;
            shootArrow.Text = "Shoot Arrow";
            shootArrow.UseVisualStyleBackColor = true;
            // 
            // wumpusLocationLabel
            // 
            wumpusLocationLabel.AutoSize = true;
            wumpusLocationLabel.Location = new Point(357, 175);
            wumpusLocationLabel.Name = "wumpusLocationLabel";
            wumpusLocationLabel.Size = new Size(0, 15);
            wumpusLocationLabel.TabIndex = 9;
            // 
            // caveLocationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 375);
            Controls.Add(wumpusLocationLabel);
            Controls.Add(shootArrowBox);
            Controls.Add(ifWumpusBox);
            Controls.Add(ifPitBox);
            Controls.Add(ifBatBox);
            Controls.Add(wumpusNearbyBox);
            Controls.Add(pitNearbyBox);
            Controls.Add(batNearbyBox);
            Controls.Add(moveWumpusBox);
            Name = "caveLocationsForm";
            Text = "Cave Locations Form";
            moveWumpusBox.ResumeLayout(false);
            moveWumpusBox.PerformLayout();
            batNearbyBox.ResumeLayout(false);
            batNearbyBox.PerformLayout();
            pitNearbyBox.ResumeLayout(false);
            pitNearbyBox.PerformLayout();
            wumpusNearbyBox.ResumeLayout(false);
            wumpusNearbyBox.PerformLayout();
            ifBatBox.ResumeLayout(false);
            ifBatBox.PerformLayout();
            ifPitBox.ResumeLayout(false);
            ifPitBox.PerformLayout();
            ifWumpusBox.ResumeLayout(false);
            ifWumpusBox.PerformLayout();
            shootArrowBox.ResumeLayout(false);
            shootArrowBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button moveWumpus;
        private CheckBox wumpusMovedCheck;
        private GroupBox moveWumpusBox;
        private GroupBox batNearbyBox;
        private CheckBox batNearbyCheck;
        private Button checkForBat;
        private GroupBox pitNearbyBox;
        private CheckBox pitNearbyCheck;
        private Button checkForPit;
        private GroupBox wumpusNearbyBox;
        private CheckBox wumpusNearbyCheck;
        private Button checkForWumpus;
        private GroupBox ifBatBox;
        private CheckBox ifBatCheck;
        private Button withBat;
        private GroupBox ifPitBox;
        private CheckBox ifPitCheck;
        private Button withPit;
        private GroupBox ifWumpusBox;
        private CheckBox ifWumpusCheck;
        private Button withWumpus;
        private GroupBox shootArrowBox;
        private CheckBox hitWumpusCheck;
        private Button shootArrow;
        private Label wumpusLocationLabel;
    }
}
