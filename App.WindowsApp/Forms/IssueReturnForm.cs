using System;
using System.Windows.Forms;
using App.Core.Services;
using App.Core.Interfaces;
using App.Core.Models;

namespace App.WindowsApp.Forms
{
    public partial class IssueReturnForm : Form
    {
        private readonly IIssueReturnService _issueService = new IssueReturnService();
        private readonly IBookService _bookService = new BookService();
        private readonly IMemberService _memberService = new MemberService();

        public IssueReturnForm()
        {
            InitializeComponent();
        }

        private void IssueReturnForm_Load(object sender, EventArgs e)
        {
            LoadDropdowns();
            LoadTransactionRecords();
        }

        private void LoadDropdowns()
        {
            var books = _bookService.GetAllBooks();
            cmbBooks.DataSource = books;
            cmbBooks.DisplayMember = "BookTitle";
            cmbBooks.ValueMember = "Id";
            // cmbBooks.SelectedIndex = -1;

            var members = _memberService.GetAllMembers();
            cmbMembers.DataSource = members;
            cmbMembers.DisplayMember = "Name";
            cmbMembers.ValueMember = "MemberID";
            // cmbMembers.SelectedIndex = -1; 
        }

        private void LoadTransactionRecords()
        {
            dgvRecords.AutoGenerateColumns = false;
            dgvRecords.DataSource = _issueService.GetPendingIssues();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (cmbBooks.SelectedValue == null || cmbMembers.SelectedValue == null) return;
            _issueService.IssueBook(new IssueReturn { BookID = (int)cmbBooks.SelectedValue, MemberID = (int)cmbMembers.SelectedValue });
            LoadTransactionRecords();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (cmbBooks.SelectedValue == null || cmbMembers.SelectedValue == null) return;
            _issueService.ReturnBook((int)cmbBooks.SelectedValue, (int)cmbMembers.SelectedValue);
            LoadTransactionRecords();
        }

        private void txtSearchLog_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchLog.Text))
            {
                LoadTransactionRecords();
            }
            else
            {

                dgvRecords.DataSource = _issueService.SearchTransactions(txtSearchLog.Text);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}