namespace CaveTest
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
            buttonRoom1 = new Button();
            buttonRoom2 = new Button();
            buttonRoom3 = new Button();
            label1 = new Label();
            textBoxNum = new TextBox();
            buttonConstructor = new Button();
            buttonRoom4 = new Button();
            buttonRoom5 = new Button();
            buttonRoom6 = new Button();
            comboBoxMapSelection = new ComboBox();
            SuspendLayout();
            // 
            // buttonRoom1
            // 
            buttonRoom1.Location = new Point(223, 166);
            buttonRoom1.Name = "buttonRoom1";
            buttonRoom1.Size = new Size(106, 23);
            buttonRoom1.TabIndex = 0;
            buttonRoom1.Text = " Room Num1";
            buttonRoom1.UseVisualStyleBackColor = true;
            buttonRoom1.Click += buttonRoom1_Click;
            // 
            // buttonRoom2
            // 
            buttonRoom2.Location = new Point(335, 143);
            buttonRoom2.Name = "buttonRoom2";
            buttonRoom2.Size = new Size(106, 23);
            buttonRoom2.TabIndex = 1;
            buttonRoom2.Text = "Room Num2";
            buttonRoom2.UseVisualStyleBackColor = true;
            buttonRoom2.Click += buttonRoom1_Click;
            // 
            // buttonRoom3
            // 
            buttonRoom3.Location = new Point(447, 166);
            buttonRoom3.Name = "buttonRoom3";
            buttonRoom3.Size = new Size(106, 23);
            buttonRoom3.TabIndex = 2;
            buttonRoom3.Text = "Room Num3";
            buttonRoom3.UseVisualStyleBackColor = true;
            buttonRoom3.Click += buttonRoom1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 207);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 10;
            label1.Text = "Room^";
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(341, 181);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.ReadOnly = true;
            textBoxNum.Size = new Size(100, 23);
            textBoxNum.TabIndex = 11;
            // 
            // buttonConstructor
            // 
            buttonConstructor.Location = new Point(26, 12);
            buttonConstructor.Name = "buttonConstructor";
            buttonConstructor.Size = new Size(138, 72);
            buttonConstructor.TabIndex = 12;
            buttonConstructor.Text = "Constructor Button";
            buttonConstructor.UseVisualStyleBackColor = true;
            buttonConstructor.Click += buttonConstructor_Click;
            // 
            // buttonRoom4
            // 
            buttonRoom4.Location = new Point(447, 195);
            buttonRoom4.Name = "buttonRoom4";
            buttonRoom4.Size = new Size(106, 23);
            buttonRoom4.TabIndex = 3;
            buttonRoom4.Text = "Room Num4";
            buttonRoom4.UseVisualStyleBackColor = true;
            buttonRoom4.Click += buttonRoom1_Click;
            // 
            // buttonRoom5
            // 
            buttonRoom5.Location = new Point(335, 225);
            buttonRoom5.Name = "buttonRoom5";
            buttonRoom5.Size = new Size(106, 23);
            buttonRoom5.TabIndex = 4;
            buttonRoom5.Text = "Room Num5";
            buttonRoom5.UseVisualStyleBackColor = true;
            buttonRoom5.Click += buttonRoom1_Click;
            // 
            // buttonRoom6
            // 
            buttonRoom6.Location = new Point(223, 195);
            buttonRoom6.Name = "buttonRoom6";
            buttonRoom6.Size = new Size(106, 23);
            buttonRoom6.TabIndex = 5;
            buttonRoom6.Text = "Room Num6";
            buttonRoom6.UseVisualStyleBackColor = true;
            buttonRoom6.Click += buttonRoom1_Click;
            // 
            // comboBoxMapSelection
            // 
            comboBoxMapSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMapSelection.FormattingEnabled = true;
            comboBoxMapSelection.Items.AddRange(new object[] { "Cave 1 ", "Cave 2", "Cave 3", "Cave 4", "Cave 5" });
            comboBoxMapSelection.Location = new Point(582, 61);
            comboBoxMapSelection.Name = "comboBoxMapSelection";
            comboBoxMapSelection.Size = new Size(121, 23);
            comboBoxMapSelection.TabIndex = 13;
            comboBoxMapSelection.SelectedIndexChanged += comboBoxMapSelection_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxMapSelection);
            Controls.Add(buttonRoom6);
            Controls.Add(buttonRoom5);
            Controls.Add(buttonRoom4);
            Controls.Add(buttonConstructor);
            Controls.Add(textBoxNum);
            Controls.Add(label1);
            Controls.Add(buttonRoom3);
            Controls.Add(buttonRoom2);
            Controls.Add(buttonRoom1);
            Name = "Form1";
            Text = "Cave Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRoom1;
        private Button buttonRoom2;
        private Button buttonRoom3;
        private Label label1;
        private TextBox textBoxNum;
        private Button buttonConstructor;
        private Button buttonRoom4;
        private Button buttonRoom5;
        private Button buttonRoom6;
        private ComboBox comboBoxMapSelection;
    }
}
