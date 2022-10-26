using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Gearhartr.calculator
{
    public partial class calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(Convert.ToDouble(txtRadius.Text));
            lblArea.Text = Convert.ToString(Math.Round(circle.GetArea(), 2));
            lblCirc.Text = Convert.ToString(Math.Round(circle.GetCircumferance(), 2));
            
        }
    }
}