using System;

using System.Windows.Forms;
using TriviaLibrary;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingGround;


namespace GCUITest
{
    public partial class TriviaForm : Form
    {
        Game game = new Game();
        TriviaGame trivia = new TriviaGame();
        public int TotalQuestionsNeeded { get; set; }
        int questionsRight = 0;
        int questionsIndex = 0;

        public TriviaForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Trivia_Load(object sender, EventArgs e)
        {
            LoadNewQuestion();
        }

        private void LoadNewQuestion()
        {
            questionsIndex++;
            richTextBoxQuestion.Text = trivia.GetQuestion();
            string[] options = trivia.GetAnswerOptions();

            buttonAnswer1.Text = options[0];
            buttonAnswer2.Text = options[1];
            buttonAnswer3.Text = options[2];
            buttonAnswer4.Text = options[3];
        }

        private void buttonAnswer1_Click(object sender, EventArgs e)
        {
            CheckAnswer(buttonAnswer1.Text);
        }

        private void buttonAnswer2_Click(object sender, EventArgs e)
        {
            CheckAnswer(buttonAnswer2.Text);
        }

        private void buttonAnswer3_Click(object sender, EventArgs e)
        {
            CheckAnswer(buttonAnswer3.Text);
        }

        private void buttonAnswer4_Click(object sender, EventArgs e)
        {
            CheckAnswer(buttonAnswer4.Text);
    }

        private void CheckAnswer(string selectedAnswer)
        {
            if (trivia.CheckAnswer(selectedAnswer))
            {
                MessageBox.Show("Correct!", "Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                questionsRight++;
            }
            else
            {
                MessageBox.Show("Incorrect. Try again!", "Answer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (questionsIndex < 5 && questionsRight < 3 && TotalQuestionsNeeded == 5)
            {
                LoadNewQuestion();
            }
            else if (questionsIndex < 3 && questionsIndex < 2 && TotalQuestionsNeeded == 3)
            {
                LoadNewQuestion();
            }
            else
            {
                if (questionsRight == 3 && TotalQuestionsNeeded == 5)
                {
                    game.TriviaOutcome = true;
                    this.Close();
                }
                else if (questionsIndex == 2 && TotalQuestionsNeeded == 3)
                {
                    game.TriviaOutcome = true;
                    this.Close();
                }
                else
                {
                    game.TriviaOutcome = false;
                    this.Close();
                }
            }
        }
    }
}


   
