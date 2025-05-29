namespace GCUITest
{
    partial class BatAttack
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
            labelBatAttack = new Label();
            label1 = new Label();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // labelBatAttack
            // 
            labelBatAttack.AutoSize = true;
            labelBatAttack.Location = new Point(47, 78);
            labelBatAttack.Name = "labelBatAttack";
            labelBatAttack.Size = new Size(213, 32);
            labelBatAttack.TabIndex = 0;
            labelBatAttack.Text = "BAT ATTACK!!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(57, 142);
            label1.MaximumSize = new Size(200, 200);
            label1.Name = "label1";
            label1.Size = new Size(190, 63);
            label1.TabIndex = 1;
            label1.Text = "You are lifted away by a large cave bat into a different room.";
            // 
            // buttonOk
            // 
            buttonOk.BackColor = Color.FromArgb(64, 64, 64);
            buttonOk.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOk.ForeColor = Color.White;
            buttonOk.Location = new Point(235, 248);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(67, 31);
            buttonOk.TabIndex = 2;
            buttonOk.Text = "Okay";
            buttonOk.UseVisualStyleBackColor = false;
            buttonOk.Click += buttonOk_Click;
            // 
            // BatAttack
            // 
            AutoScaleDimensions = new SizeF(17F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(314, 291);
            Controls.Add(buttonOk);
            Controls.Add(label1);
            Controls.Add(labelBatAttack);
            Font = new Font("Book Antiqua", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 6, 7, 6);
            Name = "BatAttack";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BatAttack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBatAttack;
        private Label label1;
        private Button buttonOk;
    }
}