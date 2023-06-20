using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Question
{
    abstract class Question
    {
        String question = "";
        List<String> questionAnswerList ;
        List<String> userAnswer; 
        static void Main(string[] args)
        {
            questionAnswerList = new List<String>() { "Fruit" };
          
        }
    }
}
