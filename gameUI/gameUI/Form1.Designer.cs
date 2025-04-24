namespace gameUI
{
    partial class gameUI
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
            getStudent = new Button();
            getStudentLabel = new Label();
            getStudentText = new TextBox();
            addressText = new TextBox();
            addressLabel = new Label();
            emailText = new TextBox();
            emailLabel = new Label();
            addStudent = new Button();
            SuspendLayout();
            // 
            // getStudent
            // 
            getStudent.Location = new Point(11, 93);
            getStudent.Name = "getStudent";
            getStudent.Size = new Size(158, 23);
            getStudent.TabIndex = 0;
            getStudent.Text = "Get Student";
            getStudent.UseVisualStyleBackColor = true;
            getStudent.Click += getStudent_Click;
            // 
            // getStudentLabel
            // 
            getStudentLabel.AutoSize = true;
            getStudentLabel.Location = new Point(12, 9);
            getStudentLabel.Name = "getStudentLabel";
            getStudentLabel.Size = new Size(51, 15);
            getStudentLabel.TabIndex = 1;
            getStudentLabel.Text = "Student:";
            // 
            // getStudentText
            // 
            getStudentText.Location = new Point(69, 6);
            getStudentText.Name = "getStudentText";
            getStudentText.Size = new Size(100, 23);
            getStudentText.TabIndex = 2;
            // 
            // addressText
            // 
            addressText.Location = new Point(70, 35);
            addressText.Name = "addressText";
            addressText.Size = new Size(100, 23);
            addressText.TabIndex = 4;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(12, 38);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(52, 15);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Address:";
            // 
            // emailText
            // 
            emailText.Location = new Point(69, 64);
            emailText.Name = "emailText";
            emailText.Size = new Size(100, 23);
            emailText.TabIndex = 6;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(11, 67);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 15);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // addStudent
            // 
            addStudent.Location = new Point(12, 122);
            addStudent.Name = "addStudent";
            addStudent.Size = new Size(158, 23);
            addStudent.TabIndex = 7;
            addStudent.Text = "Add Student";
            addStudent.UseVisualStyleBackColor = true;
            addStudent.Click += addStudent_Click;
            // 
            // gameUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(182, 166);
            Controls.Add(addStudent);
            Controls.Add(emailText);
            Controls.Add(emailLabel);
            Controls.Add(addressText);
            Controls.Add(addressLabel);
            Controls.Add(getStudentText);
            Controls.Add(getStudentLabel);
            Controls.Add(getStudent);
            Name = "gameUI";
            Text = "Game UI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button getStudent;
        private Label getStudentLabel;
        private TextBox getStudentText;
        private TextBox addressText;
        private Label addressLabel;
        private TextBox emailText;
        private Label emailLabel;
        private Button addStudent;
    }
}
