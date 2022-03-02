//Zack Gearhart
// 3/1/2022
// Scc Airlines

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Flight piper = new Flight("Piper Mirage", "2:00pm", "Kansas City", 3, 2);
        Flight cessna = new Flight("Cessna Citation X", "10:00am", "Denver", 4, 3);

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void FlightChange(object sender, EventArgs e)
        {
            if (rdoCessna.Checked == true)
            {
                LoadFlight(cessna);
            }
            else if (rdoPiper.Checked == true)
            {
                LoadFlight(piper);
            }
        }

        private void LoadFlight(Flight flight)
        {
            if (flight.IsFull() == false)
            {
                lblAirlineName.Text = flight.PlaneType + " leaves at "+ flight.DepatureTime + " for " + flight.Destination + ".";
                lblSeatNumber.Text = "Enter a number that is between 1 and " + (flight.SeatChart.GetUpperBound(0) + 1);
                txtPassenger.ReadOnly = false;
                txtSeatNumber.ReadOnly = false;
                btnSubmit.Visible = true;
                btnReset.Visible = true;
                txtPassenger.Focus();
                PrintSeatChart(flight);
            }
            else
            {
                PrintSeatChart(flight);
                txtPassenger.ReadOnly = true;
                txtSeatNumber.ReadOnly = true;
                btnSubmit.Visible = false;
                lblSeatNumber.Text = "Flight is Full";
            }
        }


        private void PrintSeatChart(Flight flight)
        {
            lstPassengerList.Items.Clear();
            for (int x = 0; x <= flight.SeatChart.GetUpperBound(0); x++)
            {
                lstPassengerList.Items.Add("Seat: " + (x + 1) + "\t\t" + flight.SeatChart[x]);
            }
        }

        private void MakeFlightReservation(Flight flight)
        {
            string passanger = "";
            int seat = 0;
            GetData(out passanger, out seat);
            flight.MakeReservation(seat, passanger);
            LoadFlight(flight);
            txtPassenger.Clear();
            txtSeatNumber.Clear();
            txtPassenger.Focus();
        }

        private void GetData(out string passanger, out int seat)
        {
            seat = Convert.ToInt32(txtSeatNumber.Text);
            passanger = txtPassenger.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rdoCessna.Checked == true)
            {
                if (IsValidData() == true)
                {
                    MakeFlightReservation(cessna);
                }
            }
            else if (rdoPiper.Checked == true)
            {
                if (IsValidData() == true)
                {
                    MakeFlightReservation(piper);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (rdoCessna.Checked == true)
            {
                cessna.FlightReset();
                LoadFlight(cessna);
            }
            else if (rdoPiper.Checked == true)
            {
                piper.FlightReset();
                LoadFlight(piper);
            }
        }



        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            errorMessage += IsString(txtPassenger.Text, "Passanger");
            errorMessage += IsInt(txtSeatNumber.Text, "Seat");

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }
        private static string IsInt(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg += name + " must be a valid Interger value. \n";
            }
            return msg;
        }
        private static string IsString(string value, string name)
        {
            string msg = "";
            if (String.IsNullOrEmpty(value))
            {
                msg += name + " must be a valid String value. \n";
            }
            return msg;
        }
    }
}
