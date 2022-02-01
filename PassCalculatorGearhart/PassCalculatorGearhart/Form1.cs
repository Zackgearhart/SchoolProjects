//Zack Gearhart
//1/26/22
//Score Calculator using a few scores.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassCalculatorGearhart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            string today;
            today = DateTime.Today.ToLongDateString();
            lblDate.Text = today;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string studentName;
            decimal scoreOne, scoreTwo, scoreThree;
            decimal testAverage;
            decimal totalTest = 0.0m;

            if (IsValidData())
            {
                // get the values from the form
                GetInput(out studentName, out scoreOne, out scoreTwo, out scoreThree);
                // calculate
                testAverage = CalculateAverage(scoreOne, scoreTwo, scoreThree);
                // output
                DisplayOutput(studentName, scoreOne, scoreTwo, scoreThree, testAverage);

            }
            else
            {
                // kickback
            }

        }

        private void DisplayOutput(string studentName, decimal scoreOne, decimal scoreTwo, decimal scoreThree, decimal testAverage)
        {
            string outputString = "";

            outputString += studentName + "\n";
            outputString += "\t Score One: " + scoreOne + "\n";
            outputString += "\t Score Two: " + scoreTwo + "\n";
            outputString += "\t Score Three: " + scoreThree + "\n";
            outputString += "\n\t Average Score: " + testAverage.ToString("f3");

            MessageBox.Show(outputString, "Students Scores");

        }

        private decimal CalculateAverage(decimal scoreOne, decimal scoreTwo, decimal scoreThree)
        {
            decimal totalTests = 0.0m;
            decimal average;
            totalTests = scoreOne + scoreTwo + scoreThree;
            average = totalTests / 3;
            return average;
        }


        private void GetInput(out string studentName, out decimal scoreOne, out decimal scoreTwo, out decimal scoreThree)
        {
            studentName = txtStuName.Text;
            scoreOne = Convert.ToDecimal(txtScore1.Text);
            scoreTwo = Convert.ToDecimal(txtScore2.Text);
            scoreThree = Convert.ToDecimal(txtScore3.Text);

        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            //testing 
            errorMessage += IsString(txtStuName.Text, "Student Name");
            errorMessage += IsDecimal(txtScore1.Text, "Score 1");
            errorMessage += IsDecimal(txtScore2.Text, "Score 2");
            errorMessage += IsDecimal(txtScore3.Text, "Score 3");

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }

            return success;
        }

        private string IsString(string value, string name)
        {
            string msg = "";
            if(value == "")
            {
                msg += name + " must be entered. \n";
            }
            return msg;
        }

        private string IsDecimal(string value, string name)
        {
            string msg = "";
            if(!Decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value. \n";
            }
            return msg;
        }
    }
}
