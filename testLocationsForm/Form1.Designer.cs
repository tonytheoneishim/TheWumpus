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
            hazardNearbyBox = new GroupBox();
            hazardsNearbyText = new TextBox();
            checkHazards = new Button();
            caveTypeBox = new GroupBox();
            caveTypeText = new TextBox();
            checkRoomType = new Button();
            shootArrowBox = new GroupBox();
            hitWumpusCheck = new CheckBox();
            shootArrow = new Button();
            wumpusLocationLabel = new Label();
            playerLocationLabel = new Label();
            moveWumpusBox.SuspendLayout();
            hazardNearbyBox.SuspendLayout();
            caveTypeBox.SuspendLayout();
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
            // hazardNearbyBox
            // 
            hazardNearbyBox.Controls.Add(hazardsNearbyText);
            hazardNearbyBox.Controls.Add(checkHazards);
            hazardNearbyBox.Location = new Point(12, 12);
            hazardNearbyBox.Name = "hazardNearbyBox";
            hazardNearbyBox.Size = new Size(136, 108);
            hazardNearbyBox.TabIndex = 5;
            hazardNearbyBox.TabStop = false;
            hazardNearbyBox.Text = "Hazards Nearby";
            // 
            // hazardsNearbyText
            // 
            hazardsNearbyText.Enabled = false;
            hazardsNearbyText.Location = new Point(6, 22);
            hazardsNearbyText.Name = "hazardsNearbyText";
            hazardsNearbyText.Size = new Size(114, 23);
            hazardsNearbyText.TabIndex = 2;
            // 
            // checkHazards
            // 
            checkHazards.Location = new Point(6, 51);
            checkHazards.Name = "checkHazards";
            checkHazards.Size = new Size(114, 46);
            checkHazards.TabIndex = 0;
            checkHazards.Text = "Check Hazards";
            checkHazards.UseVisualStyleBackColor = true;
            checkHazards.Click += checkHazards_Click;
            // 
            // caveTypeBox
            // 
            caveTypeBox.Controls.Add(caveTypeText);
            caveTypeBox.Controls.Add(checkRoomType);
            caveTypeBox.Location = new Point(12, 240);
            caveTypeBox.Name = "caveTypeBox";
            caveTypeBox.Size = new Size(136, 108);
            caveTypeBox.TabIndex = 5;
            caveTypeBox.TabStop = false;
            caveTypeBox.Text = "Cave Type";
            // 
            // caveTypeText
            // 
            caveTypeText.Enabled = false;
            caveTypeText.Location = new Point(6, 22);
            caveTypeText.Name = "caveTypeText";
            caveTypeText.Size = new Size(114, 23);
            caveTypeText.TabIndex = 1;
            // 
            // checkRoomType
            // 
            checkRoomType.Location = new Point(6, 51);
            checkRoomType.Name = "checkRoomType";
            checkRoomType.Size = new Size(114, 46);
            checkRoomType.TabIndex = 0;
            checkRoomType.Text = "Check Room Type";
            checkRoomType.UseVisualStyleBackColor = true;
            checkRoomType.Click += checkRoomType_Click;
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
            wumpusLocationLabel.Location = new Point(366, 204);
            wumpusLocationLabel.Name = "wumpusLocationLabel";
            wumpusLocationLabel.Size = new Size(0, 15);
            wumpusLocationLabel.TabIndex = 9;
            // 
            // playerLocationLabel
            // 
            playerLocationLabel.AutoSize = true;
            playerLocationLabel.Location = new Point(366, 152);
            playerLocationLabel.Name = "playerLocationLabel";
            playerLocationLabel.Size = new Size(0, 15);
            playerLocationLabel.TabIndex = 10;
            // 
            // caveLocationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 375);
            Controls.Add(playerLocationLabel);
            Controls.Add(wumpusLocationLabel);
            Controls.Add(shootArrowBox);
            Controls.Add(caveTypeBox);
            Controls.Add(hazardNearbyBox);
            Controls.Add(moveWumpusBox);
            Name = "caveLocationsForm";
            Text = "Cave Locations Form";
            moveWumpusBox.ResumeLayout(false);
            moveWumpusBox.PerformLayout();
            hazardNearbyBox.ResumeLayout(false);
            hazardNearbyBox.PerformLayout();
            caveTypeBox.ResumeLayout(false);
            caveTypeBox.PerformLayout();
            shootArrowBox.ResumeLayout(false);
            shootArrowBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button moveWumpus;
        private CheckBox wumpusMovedCheck;
        private GroupBox moveWumpusBox;
        private GroupBox hazardNearbyBox;
        private Button checkHazards;
        private GroupBox caveTypeBox;
        private CheckBox ifBatCheck;
        private Button checkRoomType;
        private GroupBox shootArrowBox;
        private CheckBox hitWumpusCheck;
        private Button shootArrow;
        private Label wumpusLocationLabel;
        private Label playerLocationLabel;
        private TextBox caveTypeText;
        private TextBox hazardsNearbyText;
    }
}
