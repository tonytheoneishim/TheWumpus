using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class Prompt
    {
        public string Question { get; set; }
        public string[] Options { get; set; }
        public string Answer { get; set; }
        public Prompt(string UnParsed) 
        {

            string[] Line = UnParsed.Split(',');
            Question = Line[0];
            Answer = Line[1];
            Options = Line.Skip(1).ToArray();

            

        }
     
    }
}
