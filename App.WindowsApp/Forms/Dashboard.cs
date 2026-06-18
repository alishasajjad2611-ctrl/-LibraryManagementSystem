using App.WindowsApp.Forms;
using Microsoft.Data.SqlClient; 
using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
{
    public partial class Dashboard : Form
    {

        private readonly string connectionString = @"Data Source=localhost;Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True";

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadLiveCounters();
        }

        public void LoadLiveCounters()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();


                    using (SqlCommand cmdBooks = new SqlCommand("SELECT COUNT(*) FROM Books", conn))
                    {
                        lblTotalBooksCount.Text = cmdBooks.ExecuteScalar().ToString();
                    }


                    using (SqlCommand cmdMembers = new SqlCommand("SELECT COUNT(*) FROM Members", conn))
                    {
                        lblTotalMembersCount.Text = cmdMembers.ExecuteScalar().ToString();
                    }


                    using (SqlCommand cmdIssued = new SqlCommand("SELECT COUNT(*) FROM IssueReturn", conn))
                    {
                        lblIssuedCount.Text = cmdIssued.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            BooksForm bForm = new BooksForm();
            bForm.ShowDialog();
            LoadLiveCounters();
        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {

            ManageLibraryMembers mForm = new ManageLibraryMembers();
            mForm.ShowDialog();
            LoadLiveCounters();
        }

        private void btnIssueReturn_Click(object sender, EventArgs e)
        {
            IssueReturnForm irForm = new IssueReturnForm();
            this.Hide();
            irForm.ShowDialog();
            this.Show();
            LoadLiveCounters();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Do you really want to Logout?",
                                                  "Logout Confirm",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
              
                LoginForm loginForm = new LoginForm();

             
                loginForm.Show();

                
                this.Close();
            }
        }
    }
}