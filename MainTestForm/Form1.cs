using TriviaLibrary;

namespace MainTestForm
{
    public partial class Form1 : Form
    {
        int score = 0;
        TriviaGame trivia;
        RadioButton[] radios = new RadioButton[4];
        int rightRadioButtonIndex;

        public Form1()
        {
            InitializeComponent();
            radios[0] = radioButtonA;
            radios[1] = radioButtonB;
            radios[2] = radioButtonC;
            radios[3] = radioButtonD;

            trivia = new TriviaGame();
            LoadNewQuestion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadNewQuestion();
        }

        private void LoadNewQuestion()
        {

            string question = trivia.GetQuestion();
            labelQuestions.Text = question;

         
            string[] answerOptions = trivia.GetAnswerOptions();
            for (int i = 0; i < radios.Length; i++)
            {
                radios[i].Text = answerOptions[i];
            }

            //rightRadioButtonIndex = Array.IndexOf(answerOptions, trivia.GetCorrectAnswer());
            ClearRadioButtonSelections();
        }

        private void ClearRadioButtonSelections()
        {
            foreach (RadioButton radioButton in radios)
            {
                radioButton.Checked = false;
            }
        }

        private void GiveAnswer_Click(object sender, EventArgs e)
        {
            if (radios[rightRadioButtonIndex].Checked)
            {
                MessageBox.Show("You got it right!");
                score++;
            }
            else
            {
                MessageBox.Show("Try again!");
            }

           
            LoadNewQuestion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNewQuestion();
        }

        private void radioButtonD_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}