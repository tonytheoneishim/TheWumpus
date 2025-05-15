using System;
using System.Collections.Generic;
using System.IO;


namespace TriviaLibrary
{
    public class TriviaGame
    {
        
        private int score;
        private Random rnd;
        private string[,] Questions;
        private List<string[]> QuestionsList = new List<string[]>();
        private int currentQuestionIndex;
        private int correctAnswerIndex;
        private bool GotRight;

        public TriviaGame()
        {
            GotRight = false;
            score = 0;
            rnd = new Random();
            readFromFile();

            //Questions = new string[,]
            //{
            //    { "What year did the Berlin Wall fall?", "1986", "1990", "1989", "1991" },
            //    { "Who, in 1903, was the first woman to win a Nobel Prize?", "Marie Skłodowska-Curie", "Jane Addams", "Rosalind Franklin", "Bertha Felicie" },
            //    { "Which famous play features a character named Romeo?", "Romeo and Juliet", "Hamlet", "Macbeth", "Othello" },
            //    { "What is the largest mammal in the world?", "Blue whale", "African elephant", "Giraffe", "Great white shark" },
            //    { "What is the main ingredient in guacamole?", "Avocado", "Tomato", "Onion", "Pepper" },
            //    { "Who is known as the 'Father of the United States' and the first President of the country?", "George Washington", "Thomas Jefferson", "Abraham Lincoln", "John Adams" },
            //    { "Who painted the Mona Lisa?", "Leonardo da Vinci", "Vincent van Gogh", "Pablo Picasso", "Michelangelo" },
            //    { "What popular ice cream flavor is typically made with crushed cookies?", "Cookies and Cream", "Chocolate", "Vanilla", "Mint" },
            //    { "What is the name of the largest ocean on Earth?", "Pacific Ocean", "Atlantic Ocean", "Indian Ocean", "Arctic Ocean" },
            //    { "What famous music group was John Lennon a part of before pursuing a solo career?", "The Beatles", "The Rolling Stones", "Pink Floyd", "Led Zeppelin" },
            //    { "In the story of Snow White, how many dwarfs are there?", "Seven", "Five", "Eight", "Six" },
            //    { "Who is the king of the gods in Greek mythology?", "Zeus", "Poseidon", "Hades", "Apollo" },
            //    { "What do bees collect to make honey?", "Nectar", "Pollen", "Water", "Sugar" },
            //    { "In what galaxy is our solar system located?", "Milky Way", "Andromeda", "Triangulum", "Whirlpool" },
            //    { "Which planet is known as the 'Blue Planet'?", "Earth", "Mars", "Venus", "Neptune" },
            //    { "Which geometric shape has four equal sides and four right angles?", "Square", "Rectangle", "Triangle", "Circle" },
            //    { "What is the main ingredient in the dish sushi?", "Rice", "Noodles", "Fish", "Seaweed" }
            //};
            
        }

        public string GetQuestion()
        {
            currentQuestionIndex = rnd.Next(0, Questions.GetLength(0));
            correctAnswerIndex = 1;
            return Questions[currentQuestionIndex, 0];
        }

        public string[] GetAnswerOptions()
        {
            string[] options = new string[4];
            for (int i = 0; i < 4; i++)
            {
                options[i] = Questions[currentQuestionIndex, i + 1];
            }
            ShuffleArray(options);
            return options;
        }

        public bool CheckAnswer(string answer)
        {
            if (answer == Questions[currentQuestionIndex, correctAnswerIndex])
            {
                
                score++;
                
                return true;
            }
            return false;
        }

        public int GetScore()
        {
            return score;
            
            
        }

        private void ShuffleArray(string[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(0, i + 1);
                string temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                
            }
        }

        private void readFromFile()
        {
            if (!File.Exists("Questions.txt")) { return; }

            StreamReader sr = new StreamReader("Questions.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] array = line.Split(',');
                QuestionsList.Add(array);
            }
            sr.Close();

            // Initialize the Questions array based on the loaded QuestionsList
            if (QuestionsList.Count > 0)
            {
                Questions = new string[QuestionsList.Count, 5]; // Assuming each question has 4 options + 1 question text
                for (int i = 0; i < QuestionsList.Count; i++)
                {
                    for (int j = 0; j < QuestionsList[i].Length; j++)
                    {
                        Questions[i, j] = QuestionsList[i][j];
                    }
                }
            }
        }
    }
}
