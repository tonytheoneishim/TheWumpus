using Trivia;

namespace Wumpas_Trivia_Consle_App
{
    internal class Program
    {
        
        TriviaQuestions  trivia = new TriviaQuestions();

        static void Main(string[] args)
        {

            Program app = new Program();

            Console.WriteLine(
            app.trivia.Question);
            static bool Question()
            {
                bool RightOrWrong = false;
                string[,] Questions = { { "What year did the Berlin Wall fall?","1986" },
                { "Who, in 1903, was the first woman to win a Nobel Prize?", "Marie Skłodowska-Curie" } };
                Random rnd = new Random();
                int index = rnd.Next(0, Questions.GetLength(0));

                Console.WriteLine(Questions[index, 0]);
                string input = Console.ReadLine();
                string answer = Questions[index, 1];
                if (input == answer)
                {
                    Console.WriteLine("You got it right");
                    RightOrWrong = true;

                }
                else { Console.WriteLine("You got it wrong"); RightOrWrong = false; }
                return RightOrWrong;
            }
            Console.WriteLine(Question());





        }
    }
}
