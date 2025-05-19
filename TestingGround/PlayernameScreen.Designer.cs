namespace GCUITest
{
    partial class PlayernameScreen
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
            textBoxName = new TextBox();
            buttonDone = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(174, 83);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Player Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(174, 106);
            textBoxName.MaxLength = 12;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(144, 27);
            textBoxName.TabIndex = 1;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(46, 46, 46);
            buttonDone.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            buttonDone.FlatAppearance.BorderSize = 0;
            buttonDone.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonDone.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Font = new Font("Book Antiqua", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDone.ForeColor = SystemColors.ControlLightLight;
            buttonDone.Location = new Point(397, 221);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 28);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Done";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // PlayernameScreen
            // 
            AcceptButton = buttonDone;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = Properties.Resources.Playername_Form_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(484, 261);
            Controls.Add(buttonDone);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PlayernameScreen";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private Button buttonDone;
    }
}