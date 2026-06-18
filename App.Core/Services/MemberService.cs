using App.Core.Interfaces;
using App.Core.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace App.Core.Services
{
    public class MemberService : IMemberService
    {
        private readonly string _connString = @"Data Source=.;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True";

        public List<Member> GetAllMembers()
        {
            List<Member> members = new List<Member>();
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Members", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    members.Add(new Member
                    {
                        MemberID = (int)reader["MemberID"],
                        Name = reader["Name"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Email = reader["Email"].ToString()
                    });
                }
            }
            return members;
        }
        public List<Member> SearchMembers(string keyword)
        {
            List<Member> members = new List<Member>();
            using (SqlConnection conn = new SqlConnection(_connString))
            {
              
                string query = "SELECT * FROM Members WHERE Name LIKE @k OR Phone LIKE @k";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@k", "%" + keyword + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    members.Add(new Member
                    {
                        MemberID = (int)reader["MemberID"],
                        Name = reader["Name"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Email = reader["Email"].ToString()
                    });
                }
            }
            return members;
        }

        public void AddMember(Member member)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
                string query = "INSERT INTO Members (Name, Phone, Email) VALUES (@Name, @Phone, @Email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", member.Name);
                cmd.Parameters.AddWithValue("@Phone", member.Phone);
                cmd.Parameters.AddWithValue("@Email", member.Email);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMember(Member member)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
                string query = "UPDATE Members SET Name = @Name, Phone = @Phone, Email = @Email WHERE MemberID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", member.MemberID);
                cmd.Parameters.AddWithValue("@Name", member.Name);
                cmd.Parameters.AddWithValue("@Phone", member.Phone);
                cmd.Parameters.AddWithValue("@Email", member.Email);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMember(int memberId)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Members WHERE MemberID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", memberId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}