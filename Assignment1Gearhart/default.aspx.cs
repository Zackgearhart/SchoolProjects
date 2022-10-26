using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1Gearhart
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnToInch_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                decimal number;
                number = Convert.ToDecimal(txtNumber.Text);
            
                ConvertToInch(number);
            }

        }

        private void ConvertToInch(decimal number)
        {
            lblOutput.Text = "";
            number = Math.Round(number / 25.40m, 2);
            lblOutput.Text = Convert.ToString(number) + " Inch(es)";
        }

        protected void btnToMillimeter_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                decimal number;
                number = Convert.ToDecimal(txtNumber.Text);
            
                ConvertToMillimeter(number);
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            errorMessage += IsDecimal(txtNumber.Text, "Number");

            if (errorMessage != "")
            {
                success = false;
                lblOutput.Text=errorMessage;
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

        private void ConvertToMillimeter(decimal number)
        {
            lblOutput.Text = "";
            number = Math.Round(number * 25.40m, 2);
            lblOutput.Text = Convert.ToString(number) + " Millimeter(s)";
        }
    }
}