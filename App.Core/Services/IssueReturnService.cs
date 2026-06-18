using App.Core.Interfaces;
using App.Core.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace App.Core.Services
{
    public class IssueReturnService : IIssueReturnService
    {
       
        private readonly string _conn = @"Data Source=localhost;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True";

       
        public List<IssueReturn> GetPendingIssues()
        {
            List<IssueReturn> list = new List<IssueReturn>();
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                string query = @"SELECT ir.IssueID, b.BookTitle, m.Name AS MemberName, ir.IssueDate, ir.ReturnDate 
                                 FROM IssueReturn ir 
                                 JOIN Books b ON ir.BookID = b.Id 
                                 JOIN Members m ON ir.MemberID = m.MemberID";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new IssueReturn
                    {
                        IssueID = Convert.ToInt32(reader["IssueID"]),
                        BookTitle = reader["BookTitle"].ToString(),
                        MemberName = reader["MemberName"].ToString(),
                        IssueDate = Convert.ToDateTime(reader["IssueDate"]),
                        ReturnDate = reader["ReturnDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["ReturnDate"])
                    });
                }
            }
            return list;
        }

        // 2. Search transactions (Ab List<IssueReturn> return karega)
        public List<IssueReturn> SearchTransactions(string keyword)
        {
            List<IssueReturn> list = new List<IssueReturn>();
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                string query = @"SELECT ir.IssueID, b.BookTitle, m.Name AS MemberName, ir.IssueDate, ir.ReturnDate 
                                 FROM IssueReturn ir 
                                 JOIN Books b ON ir.BookID = b.Id 
                                 JOIN Members m ON ir.MemberID = m.MemberID 
                                 WHERE b.BookTitle LIKE @k OR m.Name LIKE @k";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@k", "%" + keyword + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new IssueReturn
                    {
                        IssueID = Convert.ToInt32(reader["IssueID"]),
                        BookTitle = reader["BookTitle"].ToString(),
                        MemberName = reader["MemberName"].ToString(),
                        IssueDate = Convert.ToDateTime(reader["IssueDate"]),
                        ReturnDate = reader["ReturnDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["ReturnDate"])
                    });
                }
            }
            return list;
        }

      
        public void IssueBook(IssueReturn transaction)
        {
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO IssueReturn (BookID, MemberID, IssueDate) VALUES (@B, @M, GETDATE())", conn);
                cmd.Parameters.AddWithValue("@B", transaction.BookID);
                cmd.Parameters.AddWithValue("@M", transaction.MemberID);
                cmd.ExecuteNonQuery();
            }
        }

      
        public void ReturnBook(int bookId, int memberId)
        {
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE IssueReturn SET ReturnDate = GETDATE() WHERE BookID = @B AND MemberID = @M AND ReturnDate IS NULL", conn);
                cmd.Parameters.AddWithValue("@B", bookId);
                cmd.Parameters.AddWithValue("@M", memberId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}