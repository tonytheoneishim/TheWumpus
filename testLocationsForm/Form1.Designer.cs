namespace WumpusLocations
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
            moveWumpusBox = new GroupBox();
            wumpusLocationText = new TextBox();
            hazardNearbyBox = new GroupBox();
            hazardsNearbyList = new ListBox();
            checkHazards = new Button();
            caveTypeBox = new GroupBox();
            hazardTypeList = new ListBox();
            checkRoomType = new Button();
            shootArrowBox = new GroupBox();
            arrowDirectionText = new TextBox();
            hitWumpusCheck = new CheckBox();
            shootArrow = new Button();
            wumpusLocationLabel = new Label();
            playerLocationLabel = new Label();
            spawnEvents = new Button();
            eventsList = new ListBox();
            playerText = new TextBox();
            moveWumpusBox.SuspendLayout();
            hazardNearbyBox.SuspendLayout();
            caveTypeBox.SuspendLayout();
            shootArrowBox.SuspendLayout();
            SuspendLayout();
            // 
            // moveWumpus
            // 
            moveWumpus.Location = new Point(6, 51);
            moveWumpus.Name = "moveWumpus";
            moveWumpus.Size = new Size(117, 46);
            moveWumpus.TabIndex = 0;
            moveWumpus.Text = "Move the Wumpus";
            moveWumpus.UseVisualStyleBackColor = true;
            moveWumpus.Click += moveWumpus_Click;
            // 
            // moveWumpusBox
            // 
            moveWumpusBox.Controls.Add(wumpusLocationText);
            moveWumpusBox.Controls.Add(moveWumpus);
            moveWumpusBox.Location = new Point(321, 233);
            moveWumpusBox.Name = "moveWumpusBox";
            moveWumpusBox.Size = new Size(129, 108);
            moveWumpusBox.TabIndex = 4;
            moveWumpusBox.TabStop = false;
            moveWumpusBox.Text = "Move the Wumpus";
            // 
            // wumpusLocationText
            // 
            wumpusLocationText.Location = new Point(6, 22);
            wumpusLocationText.Name = "wumpusLocationText";
            wumpusLocationText.Size = new Size(117, 23);
            wumpusLocationText.TabIndex = 1;
            // 
            // hazardNearbyBox
            // 
            hazardNearbyBox.Controls.Add(hazardsNearbyList);
            hazardNearbyBox.Controls.Add(checkHazards);
            hazardNearbyBox.Location = new Point(188, 12);
            hazardNearbyBox.Name = "hazardNearbyBox";
            hazardNearbyBox.Size = new Size(136, 215);
            hazardNearbyBox.TabIndex = 5;
            hazardNearbyBox.TabStop = false;
            hazardNearbyBox.Text = "Hazards Nearby";
            // 
            // hazardsNearbyList
            // 
            hazardsNearbyList.FormattingEnabled = true;
            hazardsNearbyList.ItemHeight = 15;
            hazardsNearbyList.Location = new Point(6, 22);
            hazardsNearbyList.Name = "hazardsNearbyList";
            hazardsNearbyList.Size = new Size(124, 139);
            hazardsNearbyList.TabIndex = 1;
            // 
            // checkHazards
            // 
            checkHazards.Location = new Point(6, 163);
            checkHazards.Name = "checkHazards";
            checkHazards.Size = new Size(124, 46);
            checkHazards.TabIndex = 0;
            checkHazards.Text = "Check Hazards";
            checkHazards.UseVisualStyleBackColor = true;
            checkHazards.Click += checkHazards_Click;
            // 
            // caveTypeBox
            // 
            caveTypeBox.Controls.Add(hazardTypeList);
            caveTypeBox.Controls.Add(checkRoomType);
            caveTypeBox.Location = new Point(46, 151);
            caveTypeBox.Name = "caveTypeBox";
            caveTypeBox.Size = new Size(136, 179);
            caveTypeBox.TabIndex = 5;
            caveTypeBox.TabStop = false;
            caveTypeBox.Text = "Cave Type";
            // 
            // hazardTypeList
            // 
            hazardTypeList.FormattingEnabled = true;
            hazardTypeList.ItemHeight = 15;
            hazardTypeList.Location = new Point(6, 22);
            hazardTypeList.Name = "hazardTypeList";
            hazardTypeList.Size = new Size(124, 94);
            hazardTypeList.TabIndex = 1;
            // 
            // checkRoomType
            // 
            checkRoomType.Location = new Point(6, 127);
            checkRoomType.Name = "checkRoomType";
            checkRoomType.Size = new Size(124, 46);
            checkRoomType.TabIndex = 0;
            checkRoomType.Text = "Check Room Type";
            checkRoomType.UseVisualStyleBackColor = true;
            checkRoomType.Click += checkRoomType_Click;
            // 
            // shootArrowBox
            // 
            shootArrowBox.Controls.Add(arrowDirectionText);
            shootArrowBox.Controls.Add(hitWumpusCheck);
            shootArrowBox.Controls.Add(shootArrow);
            shootArrowBox.Location = new Point(46, 12);
            shootArrowBox.Name = "shootArrowBox";
            shootArrowBox.Size = new Size(136, 133);
            shootArrowBox.TabIndex = 5;
            shootArrowBox.TabStop = false;
            shootArrowBox.Text = "Shoot Arrow";
            // 
            // arrowDirectionText
            // 
            arrowDirectionText.Location = new Point(6, 47);
            arrowDirectionText.Name = "arrowDirectionText";
            arrowDirectionText.Size = new Size(124, 23);
            arrowDirectionText.TabIndex = 4;
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
            shootArrow.Location = new Point(6, 76);
            shootArrow.Name = "shootArrow";
            shootArrow.Size = new Size(124, 51);
            shootArrow.TabIndex = 0;
            shootArrow.Text = "Shoot Arrow";
            shootArrow.UseVisualStyleBackColor = true;
            shootArrow.Click += shootArrow_Click;
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
            // spawnEvents
            // 
            spawnEvents.Location = new Point(330, 12);
            spawnEvents.Name = "spawnEvents";
            spawnEvents.Size = new Size(120, 70);
            spawnEvents.TabIndex = 11;
            spawnEvents.Text = "Spawn";
            spawnEvents.UseVisualStyleBackColor = true;
            spawnEvents.Click += spawnEvents_Click;
            // 
            // eventsList
            // 
            eventsList.FormattingEnabled = true;
            eventsList.ItemHeight = 15;
            eventsList.Location = new Point(330, 88);
            eventsList.Name = "eventsList";
            eventsList.Size = new Size(120, 139);
            eventsList.TabIndex = 12;
            // 
            // playerText
            // 
            playerText.Location = new Point(188, 233);
            playerText.Name = "playerText";
            playerText.Size = new Size(127, 23);
            playerText.TabIndex = 13;
            // 
            // caveLocationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 375);
            Controls.Add(playerText);
            Controls.Add(eventsList);
            Controls.Add(spawnEvents);
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
            caveTypeBox.ResumeLayout(false);
            shootArrowBox.ResumeLayout(false);
            shootArrowBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button moveWumpus;
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
        private TextBox arrowDirectionText;
        private Button spawnEvents;
        private ListBox eventsList;
        private ListBox hazardsNearbyList;
        private ListBox hazardTypeList;
        private TextBox wumpusLocationText;
        private TextBox playerText;
    }
}
