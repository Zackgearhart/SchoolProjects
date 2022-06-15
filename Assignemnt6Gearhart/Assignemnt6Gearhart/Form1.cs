using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignemnt6Gearhart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Students studentList = null;
        List<Student> ourStudents = new List<Student>();
        Quizzes quizList = null;
        List<Quiz> ourQuizzes = new List<Quiz>();
        Student currentStudent = null;
        List<Quiz> currentQuizzes = new List<Quiz>();
        private void btnGetStudents_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();
            lstQuizzes.Items.Clear();
            foreach(Student s in ourStudents)
            {
                lstStudents.Items.Add(s);
            }
            btnGetStudents.Enabled = false;
            btnGetQuizzes.Enabled = true;

        }

        private void btnGetQuizzes_Click(object sender, EventArgs e)
        {
            lstQuizzes.Items.Add("Select a Student to see their Grades.");
            foreach (Quiz q in ourQuizzes)
            {
                foreach(Student s in ourStudents) 
                {
                    if(s.Id == q.Id)
                    {
                        s.AddQuiz(q);
                        s.GetAverage();
                        s.GetGrade();
                        break;
                    }
                }
            }
            btnUpload.Enabled = true;
            lstStudents.Enabled = true;
            btnGetQuizzes.Enabled = false;

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            foreach(Student s in ourStudents)
            {
                StudentDA.AddStudent(s);
            }
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentStudent = (Student)lstStudents.SelectedItem;
            lstQuizzes.Items.Clear();
            foreach (Quiz q in currentStudent.GetQuizzes())
            {
                lstQuizzes.Items.Add(q);
            }
            currentStudent.GetAverage();
            currentStudent.GetGrade();
            lstQuizzes.Items.Add("Average Score\t" + currentStudent.Average.ToString("N3"));
            lstQuizzes.Items.Add("Course Grade\t" + currentStudent.LetterGrade);
            btnUpload.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentList = new Students();
            ourStudents = studentList.GetStudents();
            quizList = new Quizzes();
            ourQuizzes = quizList.GetQuizzes();

            btnGetQuizzes.Enabled = false;
            btnUpload.Enabled = false;


        }
    }
}
