using System;
using System.Collections.Generic;
using System.IO;

namespace Assignemnt6Gearhart
{
    public class QuizDA
    {
        private static string fileName = "StuQuizzes.txt";
        //Quizs from Database
        public static List<Quiz> GetQuizzes()
        {
            List<Quiz> allQuizs = new List<Quiz>();

            StreamReader textIn = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(',');
                int id = Convert.ToInt16(columns[0]);
                int quizNumber = Convert.ToInt16(columns[1]);
                int questionsTotal = Convert.ToInt16(columns[2]);
                int questionsCorrect= Convert.ToInt16(columns[3]);
                Quiz quiz = new Quiz(id, quizNumber, questionsTotal, questionsCorrect);
                allQuizs.Add(quiz);
            }
            textIn.Close();

            return allQuizs;
        }
    }
}