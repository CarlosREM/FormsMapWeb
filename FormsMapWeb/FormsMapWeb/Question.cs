using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsMapWeb
{
    public class Question
    {
        public List<String> hints { get; set; }
        public String question { get; set; }
        public String type { get; set; }

        public String toString()
        {
            String stringQuestion = "";
            stringQuestion += "Question : " + question + "\n";
            stringQuestion += "Question type : " + type + "\n";
            foreach (String hint in hints)
            {
                stringQuestion += hint;
            }
            return stringQuestion;

        }
    }
}