using App.Core.Interfaces;
using App.Core.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace App.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly string _conn = @"Data Source=localhost;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True";

        public List<Category> GetAllCategories()
        {
            List<Category> list = new List<Category>();
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Categories", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Category { CategoryID = (int)reader["CategoryID"], CategoryName = reader["CategoryName"].ToString() ?? "" });
                }
            }
            return list;
        }

        public void AddCategory(Category category)
        {
            using (SqlConnection conn = new SqlConnection(_conn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Categories (CategoryName) VALUES (@Name)", conn);
                cmd.Parameters.AddWithValue("@Name", category.CategoryName);
                cmd.ExecuteNonQuery();
            }
        }
    }
}