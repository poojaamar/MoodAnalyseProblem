using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyseProblem
{
    public class MoodAnalyser

    {
        private string message;
        public MoodAnalyser(string message)         {
            this.message = message;
        }
        public string AnalyseMood()         {
            if (this.message.Contains("sad")) 
            {
                return "SAD";
            }
            else 
            {
                return "HAPPY";
            }
        }
    }
}

