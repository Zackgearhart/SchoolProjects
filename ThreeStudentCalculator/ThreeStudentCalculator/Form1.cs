using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeStudentCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numStudents = 4;
        int numQuizzes = 2;
        string[] stuNames;
        decimal[] stuAvg;
        int currentStudent = 0;
        int currentQuiz = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            stuNames = new string[numStudents];
            stuAvg = new decimal[numStudents];
            UpdateForm();
        }

        private void UpdateForm()
        {
            lblStudentNumber.Text = "Student Number " + (currentStudent + 1);
            lblScoreNumber.Text = "Score Number " + (currentQuiz + 1);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //declare variables
            string name;
            decimal score;

            if (IsDataValid())
            {
                if (currentStudent < numStudents)
                {
                    if(currentQuiz < numQuizzes)
                    {
                        //get data
                        GetInput(out name, out score);

                        stuNames[currentStudent] = name;

                        stuAvg[currentStudent] = CalculateAverage(score);

                        currentQuiz++;
                        txtScore.Clear();
                        txtScore.Focus();

                        if(currentQuiz >= numQuizzes)
                        {
                            currentQuiz = 0;
                            currentStudent++;
                            txtStuName.Clear();
                            txtStuName.Focus();
                            txtScore.Clear();

                        }
                        UpdateForm();
                    }

                    if (currentStudent >= numStudents)
                    {
                        ShowResults();
                        MessageBox.Show("No More input", " Finished");
                        btnSubmit.Enabled = false;
                        currentStudent = 0;

                    }
                }
            }
        }

        private void ShowResults()
        {
            for (int x = 0; x <= stuNames.GetUpperBound(0); x++)
            {
                lstStuOutput.Items.Add(stuNames[x] + "'s average is " + stuAvg[x]/numQuizzes);
            }
        }

        private decimal CalculateAverage(decimal score)
        {
            decimal currentAverage;
            decimal average;
            currentAverage = stuAvg[currentStudent];
            //average = (currentAverage + score) / (currentQuiz + 1);
            average = currentAverage + score;

            return average;
        }

        private void GetInput(out string name, out decimal score)
        {
            name = txtStuName.Text;
            score = Convert.ToDecimal(txtScore.Text);
        }

        private bool IsDataValid()
        {
            return true;

        }
    }
}
