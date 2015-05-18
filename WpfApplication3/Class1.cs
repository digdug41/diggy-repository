using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diggyCards
{
    class card
    {
        public string cardQuestion;
        public string cardAnswer1;
        public string cardAnswer2;
        public string cardAnswer3;
        public string cardAnswer4;
        public int cardCorrectAnswerNo;


        public card(string question, string answer1, string answer2, string answer3, string answer4, int correctAnswerNo)
        {
            cardQuestion = question;
            cardAnswer1 = answer1;
            cardAnswer2 = answer2;
            cardAnswer3 = answer3;
            cardAnswer4 = answer4;
            cardCorrectAnswerNo = correctAnswerNo;

        }
    }
}
