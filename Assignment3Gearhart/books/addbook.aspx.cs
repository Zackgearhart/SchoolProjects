using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3Gearhart.books
{
    public partial class addbook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string bookType = txtBookType.Text;
            int isbn = Convert.ToInt32(txtISBN.Text);
            decimal price = Convert.ToDecimal(txtPrice.Text);
            try
            {
                Book book = new Book(title, author, isbn, price, bookType);
                BookDA.InsertBook(book);
                lblMessage.Text = book.Title + " by " + book.Author +" has been added.";
            }
            catch(Exception ex)
            {
                lblMessage.Text = "Error, try again later";
            }


        }
    }
}