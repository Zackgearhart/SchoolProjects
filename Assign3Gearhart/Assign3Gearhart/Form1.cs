//Zack Gearhart
//Assign 3
//2/5/22
//Calculate hourly rate of specific days


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign3Gearhart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dayCounter = 0;
        int numDays = 5;
        decimal[] hours;
        decimal[] pay;

        private void Form1_Load(object sender, EventArgs e)
        {
            hours = new decimal[numDays];
            pay = new decimal[numDays];
            UpdateForm();
        }

        private void UpdateForm()
        {
            txtHours.Focus();
            lblDayCounter.Text = "Day " + Convert.ToString(dayCounter + 1);
            txtDaysEntered.Text = Convert.ToString(dayCounter);
            if (dayCounter > 0)
            {
                txtHourlyRate.Text = "$" + Convert.ToString(Math.Round(CalculateHourlyRate(),2));
                txtAverageRate.Text = "$" + Convert.ToString(Math.Round(CalculateAverage(), 2));
            }
            else
            {
                txtHourlyRate.Text = "$0";
                txtAverageRate.Text = "$0";
            }

        }

        private decimal CalculateHourlyRate()
        {
            decimal hourlyRate = pay[dayCounter - 1] / hours[dayCounter - 1];
            return hourlyRate;
        }

        private decimal CalculateAverage()
        {
            decimal sumPay = 0;
            decimal sumHours = 0;
            decimal average = 0;
            for (int x = 0; x < dayCounter; x++)
            {
                sumHours += hours[x];
                sumPay += pay[x];
            }
            average = sumPay / sumHours;
            return average;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            GetStats();
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal inputHours;
            decimal inputPay;

            if (IsValidData())
            {
                if(dayCounter < numDays)
                {
                    GetInput(out inputHours, out inputPay);
                    hours[dayCounter] = inputHours;
                    pay[dayCounter] = inputPay;
                    dayCounter++;
                }
                UpdateForm();
            }
            if(dayCounter>= numDays)
            {
                PassedNumDays();
            }
        }

        private void PassedNumDays()
        {
            MessageBox.Show("No More Days Can Be Entered.", "Finished");
            btnCalculate.Enabled = false;
        }

        private void GetInput(out decimal hours, out decimal pay)
        {
            hours = Convert.ToDecimal(txtHours.Text);
            pay = Convert.ToDecimal(txtPay.Text);
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            errorMessage += IsDecimal(txtHours.Text, "Hours");
            errorMessage += IsDecimal(txtPay.Text, "Pay");

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }
        private string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value. \n";
            }
            return msg;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            hours = new decimal[numDays];
            pay = new decimal[numDays];
            dayCounter = 0;
            txtAverageRate.Clear();
            txtDaysEntered.Clear();
            txtHourlyRate.Clear();
            txtHours.Clear();
            txtPay.Clear();
            btnCalculate.Enabled = true;
            txtHours.Focus();
            UpdateForm();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            GetStats();
        }

        private void GetStats()
        {
            string msg = "";
            string currentMsg;
            if (dayCounter > 0)
            {
                for (int x = 0; x < dayCounter; x++)
                {
                    currentMsg = "Day " + (x + 1) + " Hours: " + hours[x] + " Pay: $" + pay[x] + "\n";
                    msg += currentMsg;
                }
            }
            else
            {
                msg = "No Days Entered.";
            }
            MessageBox.Show(msg, "Entered Values");
        }
    }
}
