using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt6Gearhart
{
    public class Quiz
    {
        public int Id { get; set; }
        public int QuizNumber { get; set; }
        public int QuestionsTotal { get; set; }
        public int QuestionsCorrect { get; set; }
        public Quiz() { }
        public Quiz(int id, int quizNumber, int questionsTotal, int questionsCorrect)
        {
            Id = id;
            QuizNumber = quizNumber;
            QuestionsCorrect = questionsCorrect;
            QuestionsTotal = questionsTotal;
        }
        public override string ToString()
        {
            return String.Format("Id {0} Quiz {1} Number of Questions {2} Number Correct {3}", Id, QuizNumber, QuestionsTotal, QuestionsCorrect);
        }
    }
}
