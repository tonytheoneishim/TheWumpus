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

        public TriviaGame()
        {
            score = 0;
            rnd = new Random();
            readFromFile();
        }

        public string GetQuestion()
        {
            currentQuestionIndex = rnd.Next(0, Questions.GetLength(0));
            correctAnswerIndex = 1; // Assuming the first answer is the correct one
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
            // Check against the original correct answer before shuffling
            string correctAnswer = Questions[currentQuestionIndex, correctAnswerIndex];
            if (answer == correctAnswer)
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