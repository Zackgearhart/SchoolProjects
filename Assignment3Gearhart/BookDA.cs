using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Assignment3Gearhart
{
    public class BookDA
    {
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["BooksConnectionString"].ConnectionString;
        }
        public static void InsertBook(Book book)
        {
            string sql = "Insert into Books (Title, BookType, Authors, ISBN, Price, DatePurchased) Values (@title, @bookType, @authors, @isbn, @price, @datePurchased)";
            SqlConnection con = new SqlConnection(GetConnectionString());
            SqlCommand insertCommand = new SqlCommand(sql, con);
            insertCommand.Parameters.AddWithValue("@title", book.Title);
            insertCommand.Parameters.AddWithValue("@bookType", book.BookType);
            insertCommand.Parameters.AddWithValue("@authors", book.Author);
            insertCommand.Parameters.AddWithValue("@isbn", book.ISBN);
            insertCommand.Parameters.AddWithValue("@price", book.Price);
            insertCommand.Parameters.AddWithValue("@datePurchased", book.Date);

            try
            {
                con.Open();
                insertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}