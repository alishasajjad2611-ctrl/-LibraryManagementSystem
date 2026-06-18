namespace App.WindowsApp.Forms
{
    partial class IssueReturnForm
    {

        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblBookIssue = new Label();
            pnlGridArea = new Panel();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            dgvRecords = new DataGridView();
            colIssueID = new DataGridViewTextBoxColumn();
            colBookTitle = new DataGridViewTextBoxColumn();
            colMemberName = new DataGridViewTextBoxColumn();
            colIssueDate = new DataGridViewTextBoxColumn();
            colReturnDate = new DataGridViewTextBoxColumn();
            txtSearchLog = new TextBox();
            lblSearchRecord = new Label();
            pnlInput = new Panel();
            cmbMembers = new ComboBox();
            btnBack = new Button();
            btnReturn = new Button();
            dtpTransactionDate = new DateTimePicker();
            lblOperationDate = new Label();
            btnIssue = new Button();
            lblSelectMember = new Label();
            cmbBooks = new ComboBox();
            lblSelectBooks = new Label();
            pnlHeader.SuspendLayout();
            pnlGridArea.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            pnlInput.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblBookIssue);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1066, 81);
            pnlHeader.TabIndex = 0;
            // 
            // lblBookIssue
            // 
            lblBookIssue.AutoSize = true;
            lblBookIssue.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookIssue.ForeColor = Color.FromArgb(28, 35, 49);
            lblBookIssue.Location = new Point(48, 11);
            lblBookIssue.Name = "lblBookIssue";
            lblBookIssue.Size = new Size(500, 38);
            lblBookIssue.TabIndex = 0;
            lblBookIssue.Text = "BOOK ISSUE & RETURN MANAGEMENT";
            // 
            // pnlGridArea
            // 
            pnlGridArea.Controls.Add(statusStrip);
            pnlGridArea.Controls.Add(dgvRecords);
            pnlGridArea.Controls.Add(txtSearchLog);
            pnlGridArea.Controls.Add(lblSearchRecord);
            pnlGridArea.ForeColor = Color.FromArgb(28, 35, 49);
            pnlGridArea.Location = new Point(350, 89);
            pnlGridArea.Margin = new Padding(3, 4, 3, 4);
            pnlGridArea.Name = "pnlGridArea";
            pnlGridArea.Size = new Size(706, 556);
            pnlGridArea.TabIndex = 2;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip.Location = new Point(0, 524);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(706, 32);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.Text = "Ready";
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecords.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 40, 51);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Columns.AddRange(new DataGridViewColumn[] { colIssueID, colBookTitle, colMemberName, colIssueDate, colReturnDate });
            dgvRecords.EnableHeadersVisualStyles = false;
            dgvRecords.Location = new Point(17, 100);
            dgvRecords.Margin = new Padding(3, 4, 3, 4);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.RowHeadersVisible = false;
            dgvRecords.RowHeadersWidth = 62;
            dgvRecords.RowTemplate.Height = 28;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecords.Size = new Size(672, 412);
            dgvRecords.TabIndex = 2;
            // 
            // colIssueID
            // 
            colIssueID.DataPropertyName = "IssueID";
            dataGridViewCellStyle2.BackColor = Color.White;
            colIssueID.DefaultCellStyle = dataGridViewCellStyle2;
            colIssueID.HeaderText = "ID";
            colIssueID.MinimumWidth = 8;
            colIssueID.Name = "colIssueID";
            // 
            // colBookTitle
            // 
            colBookTitle.DataPropertyName = "BookTitle";
            colBookTitle.HeaderText = "Book Title";
            colBookTitle.MinimumWidth = 8;
            colBookTitle.Name = "colBookTitle";
            // 
            // colMemberName
            // 
            colMemberName.DataPropertyName = "MemberName";
            colMemberName.HeaderText = "Member Name";
            colMemberName.MinimumWidth = 8;
            colMemberName.Name = "colMemberName";
            // 
            // colIssueDate
            // 
            colIssueDate.DataPropertyName = "IssueDate";
            colIssueDate.HeaderText = "Issue Date";
            colIssueDate.MinimumWidth = 8;
            colIssueDate.Name = "colIssueDate";
            // 
            // colReturnDate
            // 
            colReturnDate.DataPropertyName = "ReturnDate";
            colReturnDate.HeaderText = "Return Date";
            colReturnDate.MinimumWidth = 8;
            colReturnDate.Name = "colReturnDate";
            // 
            // txtSearchLog
            // 
            txtSearchLog.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchLog.Location = new Point(17, 50);
            txtSearchLog.Margin = new Padding(3, 4, 3, 4);
            txtSearchLog.Name = "txtSearchLog";
            txtSearchLog.Size = new Size(672, 34);
            txtSearchLog.TabIndex = 1;
            txtSearchLog.TextChanged += txtSearchLog_TextChanged;
            // 
            // lblSearchRecord
            // 
            lblSearchRecord.AutoSize = true;
            lblSearchRecord.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchRecord.ForeColor = Color.FromArgb(28, 35, 49);
            lblSearchRecord.Location = new Point(17, 19);
            lblSearchRecord.Name = "lblSearchRecord";
            lblSearchRecord.Size = new Size(270, 25);
            lblSearchRecord.TabIndex = 0;
            lblSearchRecord.Text = "Search Record (Member/Book):";
            // 
            // pnlInput
            // 
            pnlInput.BackColor = Color.White;
            pnlInput.Controls.Add(cmbMembers);
            pnlInput.Controls.Add(btnBack);
            pnlInput.Controls.Add(btnReturn);
            pnlInput.Controls.Add(dtpTransactionDate);
            pnlInput.Controls.Add(lblOperationDate);
            pnlInput.Controls.Add(btnIssue);
            pnlInput.Controls.Add(lblSelectMember);
            pnlInput.Controls.Add(cmbBooks);
            pnlInput.Controls.Add(lblSelectBooks);
            pnlInput.Location = new Point(13, 89);
            pnlInput.Margin = new Padding(3, 4, 3, 4);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(330, 552);
            pnlInput.TabIndex = 3;
            // 
            // cmbMembers
            // 
            cmbMembers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMembers.FormattingEnabled = true;
            cmbMembers.Location = new Point(17, 141);
            cmbMembers.Margin = new Padding(3, 4, 3, 4);
            cmbMembers.Name = "cmbMembers";
            cmbMembers.Size = new Size(288, 33);
            cmbMembers.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Teal;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Image = Properties.Resources.back_button;
            btnBack.Location = new Point(94, 400);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(133, 48);
            btnBack.TabIndex = 8;
            btnBack.Text = "BACK";
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Teal;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.White;
            btnReturn.Image = Properties.Resources._return;
            btnReturn.Location = new Point(172, 325);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(133, 48);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "RETURN";
            btnReturn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // dtpTransactionDate
            // 
            dtpTransactionDate.Format = DateTimePickerFormat.Short;
            dtpTransactionDate.Location = new Point(17, 235);
            dtpTransactionDate.Margin = new Padding(3, 4, 3, 4);
            dtpTransactionDate.Name = "dtpTransactionDate";
            dtpTransactionDate.Size = new Size(290, 31);
            dtpTransactionDate.TabIndex = 5;
            // 
            // lblOperationDate
            // 
            lblOperationDate.AutoSize = true;
            lblOperationDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOperationDate.ForeColor = Color.FromArgb(28, 35, 49);
            lblOperationDate.Location = new Point(17, 206);
            lblOperationDate.Name = "lblOperationDate";
            lblOperationDate.Size = new Size(145, 25);
            lblOperationDate.TabIndex = 4;
            lblOperationDate.Text = "Operation Date:";
            // 
            // btnIssue
            // 
            btnIssue.BackColor = Color.Teal;
            btnIssue.FlatStyle = FlatStyle.Flat;
            btnIssue.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssue.ForeColor = Color.White;
            btnIssue.Image = Properties.Resources.issue;
            btnIssue.Location = new Point(17, 325);
            btnIssue.Margin = new Padding(3, 4, 3, 4);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(133, 48);
            btnIssue.TabIndex = 6;
            btnIssue.Text = "ISSUE";
            btnIssue.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIssue.UseVisualStyleBackColor = false;
            btnIssue.Click += btnIssue_Click;
            // 
            // lblSelectMember
            // 
            lblSelectMember.AutoSize = true;
            lblSelectMember.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectMember.ForeColor = Color.FromArgb(28, 35, 49);
            lblSelectMember.Location = new Point(17, 112);
            lblSelectMember.Name = "lblSelectMember";
            lblSelectMember.Size = new Size(143, 25);
            lblSelectMember.TabIndex = 2;
            lblSelectMember.Text = "Select Member:";
            // 
            // cmbBooks
            // 
            cmbBooks.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(17, 48);
            cmbBooks.Margin = new Padding(3, 4, 3, 4);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(288, 33);
            cmbBooks.TabIndex = 1;
            // 
            // lblSelectBooks
            // 
            lblSelectBooks.AutoSize = true;
            lblSelectBooks.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectBooks.ForeColor = Color.FromArgb(28, 35, 49);
            lblSelectBooks.Location = new Point(17, 19);
            lblSelectBooks.Name = "lblSelectBooks";
            lblSelectBooks.Size = new Size(114, 25);
            lblSelectBooks.TabIndex = 0;
            lblSelectBooks.Text = "Select Book:";
            // 
            // IssueReturnForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1066, 646);
            Controls.Add(pnlInput);
            Controls.Add(pnlGridArea);
            Controls.Add(pnlHeader);
            ForeColor = Color.FromArgb(28, 35, 49);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "IssueReturnForm";
            Text = "Book Issue & Return Workspace";
            Load += IssueReturnForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlGridArea.ResumeLayout(false);
            pnlGridArea.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBookIssue;
        private System.Windows.Forms.Panel pnlGridArea;
        private System.Windows.Forms.TextBox txtSearchLog;
        private System.Windows.Forms.Label lblSearchRecord;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.ComboBox cmbMembers;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.Label lblOperationDate;
        private System.Windows.Forms.Label lblSelectMember;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Label lblSelectBooks;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private DataGridViewTextBoxColumn colIssueID;
        private DataGridViewTextBoxColumn colBookTitle;
        private DataGridViewTextBoxColumn colMemberName;
        private DataGridViewTextBoxColumn colIssueDate;
        private DataGridViewTextBoxColumn colReturnDate;
    }
}