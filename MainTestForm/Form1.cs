using TriviaLibrary; 

namespace MainTestForm
{
    public partial class Form1 : Form
    {
        int score = 0;
        TriviaGame trivia; //= new TriviaGame();

        //TriviaQuestions trivia = new TriviaQuestions();
    //    string[,] Questions = {
    //{ "What year did the Berlin Wall fall?", "1986", "1990", "1989", "1991" },
    //{ "Who, in 1903, was the first woman to win a Nobel Prize?", "Marie Skłodowska-Curie", "Jane Addams", "Rosalind Franklin", "Bertha Felicie" },
    //{ "Which famous play features a character named Romeo?", "Romeo and Juliet", "Hamlet", "Macbeth", "Othello" },
    //{ "What is the largest mammal in the world?", "Blue whale", "African elephant", "Giraffe", "Great white shark" },
    //{ "What is the main ingredient in guacamole?", "Avocado", "Tomato", "Onion", "Pepper" },
    //{ "Who is known as the 'Father of the United States' and the first President of the country?", "George Washington", "Thomas Jefferson", "Abraham Lincoln", "John Adams" },
    //{ "Who painted the Mona Lisa?", "Leonardo da Vinci", "Vincent van Gogh", "Pablo Picasso", "Michelangelo" },
    //{ "What popular ice cream flavor is typically made with crushed cookies?", "Cookies and Cream", "Chocolate", "Vanilla", "Mint" },
    //{ "What is the name of the largest ocean on Earth?", "Pacific Ocean", "Atlantic Ocean", "Indian Ocean", "Arctic Ocean" },
    //{ "What famous music group was John Lennon a part of before pursuing a solo career?", "The Beatles", "The Rolling Stones", "Pink Floyd", "Led Zeppelin" },
    //{ "In the story of Snow White, how many dwarfs are there?", "Seven", "Five", "Eight", "Six" },
    //{ "Who is the king of the gods in Greek mythology?", "Zeus", "Poseidon", "Hades", "Apollo" },
    //{ "What do bees collect to make honey?", "Nectar", "Pollen", "Water", "Sugar" },
    //{ "In what galaxy is our solar system located?", "Milky Way", "Andromeda", "Triangulum", "Whirlpool" },
    //{ "Which planet is known as the 'Blue Planet'?", "Earth", "Mars", "Venus", "Neptune" },
    //{ "Which geometric shape has four equal sides and four right angles?", "Square", "Rectangle", "Triangle", "Circle" },
    //{ "What is the main ingredient in the dish sushi?", "Rice", "Noodles", "Fish", "Seaweed" }

    //};


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

            trivia = new TriviaGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //labelQuestions.Text = trivia.Question;
            //Random rnd = new Random();
            //int index = rnd.Next(0, Questions.GetLength(0));
            //labelQuestions.Text = Questions[index, 0];



            //RightRadioButton = rnd.Next(0, radios.Length);
            //radios[RightRadioButton].Text = Questions[index, 1].ToString();


            //int NewIndex = 2;
            //foreach (RadioButton radioButton in radios)
            //{

            //    int WrongIndex = RightRadioButton;
            //    if (radioButton == radios[RightRadioButton])
            //    { 
                   
            //    }
            //    else
            //    {
            //        radioButton.Text = Questions[index, NewIndex];
            //        NewIndex += 1;
            //    }
            //}
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GiveAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                if (radios[RightRadioButton].Checked)
                {
                    MessageBox.Show("You got it right");
                    score += 1;
                }
                else { MessageBox.Show("Try again"); }

            }

            catch { }
            
        }
    }
}