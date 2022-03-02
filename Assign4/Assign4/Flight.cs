//Zack Gearhart
// 3/1/2022
// Scc Airlines flight class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign4
{
    class Flight
    {
        public string PlaneType { get; set; }
        public string DepatureTime { get; set; }
        public string Destination { get; set; }
        public int NumberRows { get; set; }
        public int SeatsPerRow { get; set; }

        public string[] SeatChart { get; set; }

        public Flight() { }

        public Flight(string planeType, string depatureTime, string destinatnion, int numberRows, int seatsPerRow)
        {
            PlaneType = planeType;
            DepatureTime = depatureTime;
            Destination = destinatnion;
            NumberRows = numberRows;
            SeatsPerRow = seatsPerRow;
            FlightReset();
        }
        public void MakeReservation(int theSeat, string passanger)
        {
            if (theSeat > 0 && theSeat <= SeatChart.GetUpperBound(0)+1)
            {
                if (SeatChart[theSeat -1] == "Open")
                {
                    SeatChart[theSeat - 1] = passanger;
                }
                else
                {
                    BadSeat(passanger);
                }
            }
            else
            {
                BadSeat(passanger);
            }
        }

        private void BadSeat(string passanger)
        {
            MessageBox.Show(passanger + " was not added, that seat is not avaible.", "Entry Error");
        }

        public void FlightReset()
        {
            SeatChart = new string[NumberRows * SeatsPerRow];
            for (int x = 0; x <= SeatChart.GetUpperBound(0); x++)
            {
                SeatChart[x] = "Open";
            }
        }

        public bool IsFull()
        {
            bool full = true;
            for(int x =0; x <= SeatChart.GetUpperBound(0); x++)
            {
                if(SeatChart[x] == "Open")
                {
                    full = false;
                    x = SeatChart.GetUpperBound(0);
                }
            }
            return full;
        }
    }
}
