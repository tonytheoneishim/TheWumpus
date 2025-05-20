using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
   
    public class Prompt
    {
        private static readonly Random rnd = new Random();
        public string Question { get; private set; }
        public string[] Options { get; private set; }
        public string Answer { get; private set; }
        public Prompt(string UnParsed) 
        {

            string[] Line = UnParsed.Split(',');
            Question = Line[0];
            Answer = Line[1];
            Options = Line.Skip(1).ToArray();



            

        }
        public void Shuffle()
        {
            for (int i = Options.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(0, i + 1);
                string temp = Options[i];
                Options[i] = Options[j];
                Options[j] = temp;

            }
        }
    }
}
