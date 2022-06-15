using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt6Gearhart
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        List<Quiz> CurrentQuizzes = new List<Quiz>();
        public decimal Average { get; set; }
        public string LetterGrade { get; set; }
        public Student() { }
        public Student(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", Id, FirstName, LastName);
        }
        public void AddQuiz(Quiz quiz)
        {
            CurrentQuizzes.Add(quiz);
        }
        public void GetAverage()
        {
            List<Quiz> quizzes = new List<Quiz>();
            quizzes = CurrentQuizzes;
            decimal quizTotalCorrect = 0;
            decimal quizTotalQuestions = 0;
            decimal average = 0;
            foreach (Quiz q in quizzes)
            {
                quizTotalCorrect += q.QuestionsCorrect;
                quizTotalQuestions += q.QuestionsTotal;
            }
            average = (quizTotalCorrect / quizTotalQuestions) * 100;
            Average = average;
        }
        public void GetGrade()
        {
            decimal average = Average;
            string letterGrade = null;
            if (average >= 90)
            {
                letterGrade = "A";
            }
            else if (average >= 80)
            {
                letterGrade = "B";
            }
            else if (average >= 70)
            {
                letterGrade = "C";
            }
            else if (average >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
            LetterGrade = letterGrade;
        }
        public List<Quiz> GetQuizzes()
        {
            return CurrentQuizzes;
        }
    }
}
