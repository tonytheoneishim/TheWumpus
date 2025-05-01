namespace MainTestForm
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
            buttonQuestion = new Button();
            labelQuestions = new Label();
            textBoxReponse = new TextBox();
            ButtonAnswer = new Button();
            radioButtonA = new RadioButton();
            radioButtonB = new RadioButton();
            radioButtonC = new RadioButton();
            radioButtonD = new RadioButton();
            SuspendLayout();
            // 
            // buttonQuestion
            // 
            buttonQuestion.Location = new Point(40, 63);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(158, 39);
            buttonQuestion.TabIndex = 0;
            buttonQuestion.Text = "StartQuestion";
            buttonQuestion.UseVisualStyleBackColor = true;
            buttonQuestion.Click += button1_Click;
            // 
            // labelQuestions
            // 
            labelQuestions.AutoSize = true;
            labelQuestions.Location = new Point(248, 75);
            labelQuestions.Name = "labelQuestions";
            labelQuestions.Size = new Size(38, 15);
            labelQuestions.TabIndex = 1;
            labelQuestions.Text = "label1";
            // 
            // textBoxReponse
            // 
            textBoxReponse.Location = new Point(85, 199);
            textBoxReponse.Name = "textBoxReponse";
            textBoxReponse.Size = new Size(428, 23);
            textBoxReponse.TabIndex = 2;
            // 
            // ButtonAnswer
            // 
            ButtonAnswer.Location = new Point(556, 191);
            ButtonAnswer.Name = "ButtonAnswer";
            ButtonAnswer.Size = new Size(217, 37);
            ButtonAnswer.TabIndex = 3;
            ButtonAnswer.Text = "Give Answer";
            ButtonAnswer.UseVisualStyleBackColor = true;
            ButtonAnswer.Click += GiveAnswer_Click;
            // 
            // radioButtonA
            // 
            radioButtonA.AutoSize = true;
            radioButtonA.Location = new Point(55, 276);
            radioButtonA.Name = "radioButtonA";
            radioButtonA.Size = new Size(94, 19);
            radioButtonA.TabIndex = 4;
            radioButtonA.TabStop = true;
            radioButtonA.Text = "radioButton1";
            radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            radioButtonB.AutoSize = true;
            radioButtonB.Location = new Point(55, 301);
            radioButtonB.Name = "radioButtonB";
            radioButtonB.Size = new Size(94, 19);
            radioButtonB.TabIndex = 5;
            radioButtonB.TabStop = true;
            radioButtonB.Text = "radioButton2";
            radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            radioButtonC.AutoSize = true;
            radioButtonC.Location = new Point(55, 326);
            radioButtonC.Name = "radioButtonC";
            radioButtonC.Size = new Size(94, 19);
            radioButtonC.TabIndex = 6;
            radioButtonC.TabStop = true;
            radioButtonC.Text = "radioButton3";
            radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonD
            // 
            radioButtonD.AutoSize = true;
            radioButtonD.Location = new Point(55, 351);
            radioButtonD.Name = "radioButtonD";
            radioButtonD.Size = new Size(94, 19);
            radioButtonD.TabIndex = 7;
            radioButtonD.TabStop = true;
            radioButtonD.Text = "radioButton4";
            radioButtonD.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButtonD);
            Controls.Add(radioButtonC);
            Controls.Add(radioButtonB);
            Controls.Add(radioButtonA);
            Controls.Add(ButtonAnswer);
            Controls.Add(textBoxReponse);
            Controls.Add(labelQuestions);
            Controls.Add(buttonQuestion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonQuestion;
        private Label labelQuestions;
        private TextBox textBoxReponse;
        private Button ButtonAnswer;
        private RadioButton radioButtonA;
        private RadioButton radioButtonB;
        private RadioButton radioButtonC;
        private RadioButton radioButtonD;
    }
}
