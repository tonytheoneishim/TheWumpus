namespace WumpusTest
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
            playerConstructor = new Button();
            locationsConstructor = new Button();
            movePlayerRadio = new RadioButton();
            playerBox = new GroupBox();
            playerBox.SuspendLayout();
            SuspendLayout();
            // 
            // playerConstructor
            // 
            playerConstructor.Location = new Point(12, 12);
            playerConstructor.Name = "playerConstructor";
            playerConstructor.Size = new Size(134, 63);
            playerConstructor.TabIndex = 0;
            playerConstructor.Text = "Player Constructor";
            playerConstructor.UseVisualStyleBackColor = true;
            playerConstructor.Click += playerConstructor_Click;
            // 
            // locationsConstructor
            // 
            locationsConstructor.Location = new Point(654, 12);
            locationsConstructor.Name = "locationsConstructor";
            locationsConstructor.Size = new Size(134, 63);
            locationsConstructor.TabIndex = 1;
            locationsConstructor.Text = "Locations Constructor";
            locationsConstructor.UseVisualStyleBackColor = true;
            locationsConstructor.Click += locationsConstructor_Click;
            // 
            // movePlayerRadio
            // 
            movePlayerRadio.AutoSize = true;
            movePlayerRadio.Location = new Point(6, 22);
            movePlayerRadio.Name = "movePlayerRadio";
            movePlayerRadio.Size = new Size(90, 19);
            movePlayerRadio.TabIndex = 2;
            movePlayerRadio.TabStop = true;
            movePlayerRadio.Text = "Move Player";
            movePlayerRadio.UseVisualStyleBackColor = true;
            // 
            // playerBox
            // 
            playerBox.Controls.Add(movePlayerRadio);
            playerBox.Location = new Point(12, 81);
            playerBox.Name = "playerBox";
            playerBox.Size = new Size(160, 179);
            playerBox.TabIndex = 3;
            playerBox.TabStop = false;
            playerBox.Text = "Player Options:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(playerBox);
            Controls.Add(locationsConstructor);
            Controls.Add(playerConstructor);
            Name = "Form1";
            Text = "Form1";
            playerBox.ResumeLayout(false);
            playerBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button playerConstructor;
        private Button locationsConstructor;
        private RadioButton movePlayerRadio;
        private GroupBox playerBox;
    }
}
