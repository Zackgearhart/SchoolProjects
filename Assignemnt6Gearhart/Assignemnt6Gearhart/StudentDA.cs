using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignemnt6Gearhart
{
    public class StudentDA
    {
        private static string fileName = "Students.txt";
        //Students from Database
        public static List<Student> GetStudents()
        {
            List<Student> allStudents = new List<Student>();

            StreamReader textIn = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(',');
                int id = Convert.ToInt16(columns[0]);
                string firstName = columns[1];
                string lastName = columns[2];
                Student student = new Student(id, firstName, lastName);
                allStudents.Add(student);
            }
            textIn.Close();

            return allStudents;
        }
        public static void AddStudent(Student stu)
        {
            SqlConnection conn = StudentDB.GetConnection();

            string insertStatment = "Insert CourseInfo (Instructor, StuId, FirstName, LastName, Score, Grade) values(@instructor, @stuId, @firstName, @lastName, @score, @grade)";
            SqlCommand insertCommand = new SqlCommand(insertStatment, conn);

            insertCommand.Parameters.AddWithValue("@instructor", "Zack");
            insertCommand.Parameters.AddWithValue("@stuId", stu.Id);
            insertCommand.Parameters.AddWithValue("@firstName", stu.FirstName);
            insertCommand.Parameters.AddWithValue("@lastName", stu.LastName);
            insertCommand.Parameters.AddWithValue("@score", stu.Average);
            insertCommand.Parameters.AddWithValue("@grade", stu.LetterGrade);

            try
            {
                conn.Open();
                int row = insertCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SqlError");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
