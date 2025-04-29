using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class TriviaQuestions
    {

        public String Question  { get; set; }
        //bool RightOrWrong = false;
        //string[,] Questions = { { "What year did the Berlin Wall fall?","1986" },
        //{ "Who, in 1903, was the first woman to win a Nobel Prize?", "Marie Skłodowska-Curie" } };
        //Random rnd = new Random();
        //int index = rnd.Next(0, Questions.GetLength(0));

        //Console.WriteLine(Questions[index, 0]);

        //    string input = Console.ReadLine();

        public TriviaQuestions() {
            Question = "What color is the sky?";
        }

        //string answer = Questions[index, 1];
        //    if (input == answer)
        //    {
        //        Console.WriteLine("You got it right");
        //        RightOrWrong = true;

        //    }
        //    else { Console.WriteLine("You got it wrong"); RightOrWrong = false; }
        //    return RightOrWrong;


    }
}
