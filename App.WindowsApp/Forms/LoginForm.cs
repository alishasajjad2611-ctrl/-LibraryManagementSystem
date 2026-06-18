using App.WindowsApp.Forms;
using Microsoft.Data.SqlClient; 
using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
{
    public partial class LoginForm : Form
    {

        private string connectionString = @"Data Source=localhost;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter both Username and Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT COUNT(*) FROM Librarians WHERE Username = @User AND Password = @Pass";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@User", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Pass", txtPassword.Text.Trim());

                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();

                            // Dashboard open karein
                            Dashboard dash = new Dashboard();
                            dash.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void button1_Click(object sender, EventArgs e) { }
        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void lblHeaderTitle_Click(object sender, EventArgs e) { }
    }
}