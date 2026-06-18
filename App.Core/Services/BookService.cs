using App.Core.Interfaces;
using App.Core.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace App.Core.Services
{
    public class BookService : IBookService
    {
        private readonly string _conn = @"Data Source=localhost;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True";

        public List<Book> GetAllBooks()
        {
            List<Book> list = new List<Book>();
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Books", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Book { Id = (int)reader["Id"], BookTitle = reader["BookTitle"].ToString() ?? "", AuthorName = reader["AuthorName"].ToString() ?? "", Category = reader["Category"].ToString() ?? "", Quantity = (int)reader["Quantity"] });
                }
            }
            return list;
        }

        public void AddBook(Book book)
        {
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Books (BookTitle, AuthorName, Category, Quantity) VALUES (@T, @A, @C, @Q)", conn);
                cmd.Parameters.AddWithValue("@T", book.BookTitle);
                cmd.Parameters.AddWithValue("@A", book.AuthorName);
                cmd.Parameters.AddWithValue("@C", book.Category);
                cmd.Parameters.AddWithValue("@Q", book.Quantity);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateBook(Book book)
        {
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Books SET BookTitle = @T, AuthorName = @A, Category = @C, Quantity = @Q WHERE Id = @ID", conn);
                cmd.Parameters.AddWithValue("@T", book.BookTitle);
                cmd.Parameters.AddWithValue("@A", book.AuthorName);
                cmd.Parameters.AddWithValue("@C", book.Category);
                cmd.Parameters.AddWithValue("@Q", book.Quantity);
                cmd.Parameters.AddWithValue("@ID", book.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteBook(int id)
        {
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Books WHERE Id = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}