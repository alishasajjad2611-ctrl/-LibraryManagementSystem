using System;
using System.Windows.Forms;
using App.Core.Services;
using App.Core.Interfaces;
using App.Core.Models;
using System.Drawing;

namespace App.WindowsApp.Forms
{
    public partial class BooksForm : Form
    {
        private readonly IBookService _bookService = new BookService();

        public BooksForm()
        {
            InitializeComponent();
            this.txtSearch.GotFocus += new System.EventHandler(this.txtSearch_GotFocus);
            this.txtSearch.LostFocus += new System.EventHandler(this.txtSearch_LostFocus);
        }

        private void BooksForm_Load_1(object sender, EventArgs e)
        {
            txtSearch.Text = "Search...";
            txtSearch.ForeColor = Color.Gray;
            UpdateStatus("System Status: Ready", Color.DarkBlue);
            LoadDataIntoGrid();
        }

        private void LoadDataIntoGrid()
        {
            dgvBooks.DataSource = null;
            dgvBooks.Columns.Clear();
            dgvBooks.AutoGenerateColumns = false;


            dgvBooks.Columns.Add("BookID", "ID");
            dgvBooks.Columns["BookID"].DataPropertyName = "Id";
            dgvBooks.Columns["BookID"].Visible = false;


            dgvBooks.Columns.Add("Title", "Book Title");
            dgvBooks.Columns["Title"].DataPropertyName = "BookTitle";


            dgvBooks.Columns.Add("Author", "Author Name");
            dgvBooks.Columns["Author"].DataPropertyName = "AuthorName";

            dgvBooks.Columns.Add("Category", "Category");
            dgvBooks.Columns["Category"].DataPropertyName = "Category";


            dgvBooks.Columns.Add("Quantity", "Quantity");
            dgvBooks.Columns["Quantity"].DataPropertyName = "Quantity";

            dgvBooks.DataSource = _bookService.GetAllBooks();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            Book newBook = new Book
            {
                BookTitle = txtTitle.Text.Trim(),
                AuthorName = txtAuthor.Text.Trim(),
                Category = cmbCategory.Text.Trim(),
                Quantity = int.Parse(txtQuantity.Text)
            };

            _bookService.AddBook(newBook);
            LoadDataIntoGrid();
            ClearFields();
            MessageBox.Show("Book Added Successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow != null)
            {

                int id = Convert.ToInt32(dgvBooks.CurrentRow.Cells["BookID"].Value);

                Book updatedBook = new Book
                {
                    Id = id,
                    BookTitle = txtTitle.Text.Trim(),
                    AuthorName = txtAuthor.Text.Trim(),
                    Category = cmbCategory.Text.Trim(),
                    Quantity = int.Parse(txtQuantity.Text)
                };

                _bookService.UpdateBook(updatedBook);
                LoadDataIntoGrid();
                MessageBox.Show("Record Updated!");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvBooks.CurrentRow.Cells["BookID"].Value);
                if (MessageBox.Show("Delete this record?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _bookService.DeleteBook(id);
                    LoadDataIntoGrid();
                }
            }
        }
        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];


                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtAuthor.Text = row.Cells["Author"].Value.ToString();
                cmbCategory.Text = row.Cells["Category"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
            }
        }
        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search...";
                txtSearch.ForeColor = Color.Gray;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtSearch.Text) || txtSearch.Text == "Search...")
            {
                dgvBooks.DataSource = _bookService.GetAllBooks();
                return;
            }


            var allBooks = _bookService.GetAllBooks();
            var filtered = allBooks.Where(b => b.BookTitle.ToLower().Contains(txtSearch.Text.ToLower())
                                            || b.AuthorName.ToLower().Contains(txtSearch.Text.ToLower()))
                                   .ToList();

            dgvBooks.DataSource = filtered;
        }
        private void UpdateStatus(string statusMessage, Color statusColor)
        {
            lblStatusText.Text = statusMessage;
            lblStatusText.ForeColor = statusColor;
        }

        private void ClearFields()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtQuantity.Clear();
        }

        
    }
}