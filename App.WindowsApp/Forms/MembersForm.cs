using System;
using System.Windows.Forms;
using App.Core.Services;
using App.Core.Models;

namespace App.WindowsApp.Forms
{
    public partial class ManageLibraryMembers : Form
    {
        private readonly MemberService _memberService = new MemberService();

        public ManageLibraryMembers()
        {
            InitializeComponent();
        }

        private void ManageLibraryMembers_Load(object sender, EventArgs e)
        {
            LoadMembersData();
        }

        private void LoadMembersData()
        {
            dgvMembers.DataSource = null;
            dgvMembers.DataSource = _memberService.GetAllMembers();
            lblStatusCount.Text = "Total Members: " + dgvMembers.Rows.Count.ToString();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMemberName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Name and Phone are required!");
                return;
            }

            Member newMember = new Member
            {
                Name = txtMemberName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            _memberService.AddMember(newMember);
            LoadMembersData();
            ClearFormInputs();
            MessageBox.Show("Member Added Successfully!");
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvMembers.CurrentRow.Cells["MemberID"].Value);

            Member updatedMember = new Member
            {
                MemberID = id,
                Name = txtMemberName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            _memberService.UpdateMember(updatedMember);
            LoadMembersData();
            ClearFormInputs();
            MessageBox.Show("Updated Successfully!");
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvMembers.CurrentRow.Cells["MemberID"].Value);

            if (MessageBox.Show("Delete this member?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _memberService.DeleteMember(id);
                LoadMembersData();
                ClearFormInputs();
            }
        }

        private void txtSearchMember_TextChanged(object sender, EventArgs e)
        {

            string keyword = txtSearchMember.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadMembersData();
            }
            else
            {
                dgvMembers.DataSource = null;
                dgvMembers.DataSource = _memberService.SearchMembers(keyword);
            }
        }
        private void dgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow != null && dgvMembers.CurrentRow.Selected)
            {

                txtMemberName.Text = dgvMembers.CurrentRow.Cells[1].Value?.ToString();
                txtPhone.Text = dgvMembers.CurrentRow.Cells[2].Value?.ToString();
                txtEmail.Text = dgvMembers.CurrentRow.Cells[3].Value?.ToString();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void ClearFormInputs()
        {
            txtMemberName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}