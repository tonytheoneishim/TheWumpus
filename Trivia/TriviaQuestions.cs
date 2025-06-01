using System;
using System.Collections.Generic;
using System.IO;

namespace TriviaLibrary
{
    public class TriviaGame
    {
        public int score = 0;
        private Random rnd = new Random();
        private string[,] Questions;
        private List<string[]> QuestionsList = new List<string[]>();
        private int currentQuestionIndex;
        private int correctAnswerIndex;

        public TriviaGame()
        {
            readFromFile();
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
       
            string correctAnswer = Questions[currentQuestionIndex, correctAnswerIndex];
            if (answer == correctAnswer)
            {
                score++;
                return true;
            }
            return false;
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
            if (!File.Exists("Questions.txt"))
            {
                return;
            }

            StreamReader sr = new StreamReader("Questions.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] array = line.Split(',');
                QuestionsList.Add(array);
            }
            sr.Close();

            if (QuestionsList.Count > 0)
            {
                Questions = new string[QuestionsList.Count, 5];
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