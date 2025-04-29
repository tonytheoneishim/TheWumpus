using System.Windows.Forms.VisualStyles;
using Trivia;

namespace MainTestForm
{
    public partial class Form1 : Form
    {
        TriviaQuestions trivia = new TriviaQuestions();
        string[,] Questions = {
    { "What year did the Berlin Wall fall?", "1986", "A) 1986", "B) 1990", "C) 1989", "D) 1991" },
    { "Who, in 1903, was the first woman to win a Nobel Prize?", "Marie Skłodowska-Curie", "A) Marie Skłodowska-Curie", "B) Jane Addams", "C) Rosalind Franklin", "D) Bertha Felicie" },
    { "Which famous play features a character named Romeo?", "Romeo and Juliet", "A) Romeo and Juliet", "B) Hamlet", "C) Macbeth", "D) Othello" },
    { "What is the largest mammal in the world?", "Blue whale", "A) Blue whale", "B) African elephant", "C) Giraffe", "D) Great white shark" },
    { "What is the main ingredient in guacamole?", "Avocado", "A) Avocado", "B) Tomato", "C) Onion", "D) Pepper" },
    { "Who is known as the 'Father of the United States' and the first President of the country?", "George Washington", "A) George Washington", "B) Thomas Jefferson", "C) Abraham Lincoln", "D) John Adams" },
    { "Who painted the Mona Lisa?", "Leonardo da Vinci", "A) Leonardo da Vinci", "B) Vincent van Gogh", "C) Pablo Picasso", "D) Michelangelo" },
    { "What popular ice cream flavor is typically made with crushed cookies?", "Cookies and Cream", "A) Cookies and Cream", "B) Chocolate", "C) Vanilla", "D) Mint" },
    { "What is the name of the largest ocean on Earth?", "Pacific Ocean", "A) Pacific Ocean", "B) Atlantic Ocean", "C) Indian Ocean", "D) Arctic Ocean" },
    { "What famous music group was John Lennon a part of before pursuing a solo career?", "The Beatles", "A) The Beatles", "B) The Rolling Stones", "C) Pink Floyd", "D) Led Zeppelin" },
    { "In the story of Snow White, how many dwarfs are there?", "Seven", "A) Seven", "B) Five", "C) Eight", "D) Six" },
    { "Who is the king of the gods in Greek mythology?", "Zeus", "A) Zeus", "B) Poseidon", "C) Hades", "D) Apollo" },
    { "What do bees collect to make honey?", "Nectar", "A) Nectar", "B) Pollen", "C) Water", "D) Sugar" },
    { "In what galaxy is our solar system located?", "Milky Way", "A) Milky Way", "B) Andromeda", "C) Triangulum", "D) Whirlpool" },
    { "Which planet is known as the 'Blue Planet'?", "Earth", "A) Earth", "B) Mars", "C) Venus", "D) Neptune" },
    { "Which geometric shape has four equal sides and four right angles?", "Square", "A) Square", "B) Rectangle", "C) Triangle", "D) Circle" },
    { "What is the main ingredient in the dish sushi?", "Rice", "A) Rice", "B) Noodles", "C) Fish", "D) Seaweed" }
      };

        RadioButton[] radios = new RadioButton[4];

        

        int RightRadioButton = 0;
        string Answer = string.Empty;
            
        public Form1()
        {
            
            InitializeComponent();

            radios[0] = radioButtonA;
            radios[1] = radioButtonB;
            radios[2] = radioButtonC;
            radios[3] = radioButtonD;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelQuestions.Text = trivia.Question;
            Random rnd = new Random();
            int index = rnd.Next(0, Questions.GetLength(0));
            labelQuestions.Text = Questions[index, 0];

            
                            
            RightRadioButton = rnd.Next(0,radios.Length);
            radios[RightRadioButton].Text = Questions[index,1].ToString();


            

            
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GiveAnswer_Click(object sender, EventArgs e)
        {
            try 
            {
                if (Answer == textBoxReponse.Text) { MessageBox.Show("You got it right!"); }
                else { MessageBox.Show("You got it wrong"); }

            }
            
            
            catch { }
        }
    }
}
