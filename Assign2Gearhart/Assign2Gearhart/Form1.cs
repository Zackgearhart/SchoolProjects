//Zack Gearhart
//01/31/22
//Assignment 2
//Calculator for car shop

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign2Gearhart
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        decimal totalSales = 0;
        decimal totalTransactions = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            string msg;
            msg = "$" + Math.Round(totalSales, 2) + " is the total sales amount.\n" + totalTransactions + " is the amount of transactions.";
            MessageBox.Show(msg, "Total Amount of Sales");
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string today;
            today = DateTime.Today.ToLongDateString();
            lblDate.Text = today;
            ResetValues();
        }

        private void ResetValues()
        {
            rdoStandard.Checked = true;
            chkGPS.Checked = false;
            chkLeather.Checked = false;
            chkStereo.Checked = false;
            txtAccessoriesFinish.Clear();
            txtAmountDue.Clear();
            txtSalePrice.Clear();
            txtSalesTax.Clear();
            txtSubtotal.Clear();
            txtTotal.Clear();
            txtTradeIn.Text = "0";
            txtSalePrice.Focus();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            decimal salePrice = 0;
            decimal accessoriesPrice;
            decimal subtotalPrice;
            decimal taxPrice;
            decimal totalPrice;
            decimal tradeinPrice = 0;
            decimal duePrice;
            if (IsValidData(salePrice))
            {
                salePrice = GetSalesPrice();
                tradeinPrice += Convert.ToDecimal(txtTradeIn.Text);
                accessoriesPrice = Math.Round(GetAccessoryPrice(), 2);
                txtAccessoriesFinish.Text = "$" + Convert.ToString(Math.Round(accessoriesPrice,2));
                subtotalPrice = salePrice + accessoriesPrice;
                txtSubtotal.Text = "$" + Convert.ToString(Math.Round(subtotalPrice,2));
                taxPrice = subtotalPrice * .08m;
                txtSalesTax.Text = "$" + Convert.ToString(Math.Round(taxPrice,2));
                totalPrice = taxPrice + subtotalPrice;
                txtTotal.Text = "$" + Convert.ToString(Math.Round(totalPrice, 2));
                duePrice = totalPrice - tradeinPrice;
                txtAmountDue.Text = "$" + Convert.ToString(Math.Round(duePrice, 2));
                totalTransactions += 1;
                totalSales += duePrice;
            }
        }

        private decimal GetSalesPrice()
        {
            decimal salePrice = Convert.ToDecimal(txtSalePrice.Text);
            return salePrice;
        }

        private decimal GetAccessoryPrice()
        {
            decimal price = 0;
            if (chkGPS.Checked)
            {
                price += 1741.23m;
            }
            if (chkLeather.Checked)
            {
                price += 987.41m;
            }
            if (chkStereo.Checked)
            {
                price += 425.76m;
            }
            if (rdoPearl.Checked)
            {
                price += 345.72m;
            }
            else if (rdoCustomized.Checked)
            {
                price += 599.99m;
            }
            return price;
        }

        private bool IsValidData(decimal salePrice)
        {
            bool success = true;
            string errorMessage = "";
            errorMessage += IsDecimal(txtSalePrice.Text, "Sale Price");
            errorMessage += IsDecimal(txtTradeIn.Text, "Trade in");

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            } else{
                salePrice += Convert.ToDecimal(txtSalePrice.Text);
                if (salePrice < 500 || salePrice > 30000)
                {
                    errorMessage += "Sale Price must be between 500 and 30000";
                    success = false;
                    MessageBox.Show(errorMessage, "Entry Error");
                }
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
    }
}
