using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt6Gearhart
{
    public class Quizzes
    {
        List<Quiz> quizList = new List<Quiz>();

        public List<Quiz> GetQuizzes()
        {
            quizList = QuizDA.GetQuizzes();
            return quizList;
        }
    }
}
