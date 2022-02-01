/*
 * Author: Zack Gearhart
 * Date: 1/19/22
 * Desc: This is a calculator to find the area and perimeter using width and length.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentOneGearhart
{
    public partial class frmAreaAndPeirmeter : Form
    {
        public frmAreaAndPeirmeter()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal length;
            decimal width;
            decimal area;
            decimal perimeter;

            length = Convert.ToDecimal(txtLength.Text);
            width = Convert.ToDecimal(txtWidth.Text);

            area = length * width;
            perimeter = 2 * (length + width);

            txtArea.Text = area.ToString();
            txtPerimeter.Text = perimeter.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
