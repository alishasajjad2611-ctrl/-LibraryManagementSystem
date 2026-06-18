namespace App.WindowsApp.Forms
{
    partial class ManageLibraryMembers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            lblMemberDirectory = new Label();
            lblMemberName = new Label();
            txtMemberName = new TextBox();
            lblPhoneNumber = new Label();
            txtPhone = new TextBox();
            lblEmailAddress = new Label();
            txtEmail = new TextBox();
            lblSearchMember = new Label();
            txtSearchMember = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            dgvMembers = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            panelInput = new Panel();
            statusStrip1 = new StatusStrip();
            lblStatusMessage = new ToolStripStatusLabel();
            lblStatusCount = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            panelInput.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMemberDirectory
            // 
            lblMemberDirectory.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMemberDirectory.ForeColor = Color.FromArgb(28, 35, 49);
            lblMemberDirectory.Location = new Point(17, 25);
            lblMemberDirectory.Name = "lblMemberDirectory";
            lblMemberDirectory.Size = new Size(306, 69);
            lblMemberDirectory.TabIndex = 0;
            lblMemberDirectory.Text = "Library Members";
            // 
            // lblMemberName
            // 
            lblMemberName.AutoSize = true;
            lblMemberName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMemberName.ForeColor = Color.FromArgb(28, 35, 49);
            lblMemberName.Location = new Point(17, 100);
            lblMemberName.Name = "lblMemberName";
            lblMemberName.Size = new Size(158, 28);
            lblMemberName.TabIndex = 1;
            lblMemberName.Text = "Member Name:";
            // 
            // txtMemberName
            // 
            txtMemberName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMemberName.Location = new Point(17, 131);
            txtMemberName.Margin = new Padding(3, 4, 3, 4);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(305, 34);
            txtMemberName.TabIndex = 2;
            txtMemberName.TextChanged += txtMemberName_TextChanged;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(17, 188);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(160, 28);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(17, 219);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(305, 34);
            txtPhone.TabIndex = 4;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailAddress.Location = new Point(17, 288);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(150, 28);
            lblEmailAddress.TabIndex = 5;
            lblEmailAddress.Text = "Email Address:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(17, 319);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(305, 34);
            txtEmail.TabIndex = 6;
            // 
            // lblSearchMember
            // 
            lblSearchMember.AutoSize = true;
            lblSearchMember.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchMember.ForeColor = Color.FromArgb(28, 35, 49);
            lblSearchMember.Location = new Point(389, 25);
            lblSearchMember.Name = "lblSearchMember";
            lblSearchMember.Size = new Size(161, 28);
            lblSearchMember.TabIndex = 7;
            lblSearchMember.Text = "Search Member:";
            // 
            // txtSearchMember
            // 
            txtSearchMember.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchMember.Location = new Point(389, 56);
            txtSearchMember.Margin = new Padding(3, 4, 3, 4);
            txtSearchMember.Name = "txtSearchMember";
            txtSearchMember.Size = new Size(657, 34);
            txtSearchMember.TabIndex = 8;
            txtSearchMember.TextChanged += txtSearchMember_TextChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(17, 412);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 50);
            btnSave.TabIndex = 9;
            btnSave.Text = "SAVE";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Image = Properties.Resources.update;
            btnUpdate.Location = new Point(178, 412);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(144, 50);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = Properties.Resources.delete1;
            btnDelete.Location = new Point(17, 481);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 50);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.Gray;
            btnBack.FlatAppearance.BorderSize = 3;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Image = Properties.Resources.back_arrow;
            btnBack.ImageAlign = ContentAlignment.TopLeft;
            btnBack.Location = new Point(178, 481);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(144, 50);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back\r\n\r\n";
            btnBack.TextAlign = ContentAlignment.MiddleRight;
            btnBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 40, 51);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMembers.ColumnHeadersHeight = 35;
            dgvMembers.Columns.AddRange(new DataGridViewColumn[] { colName, colPhone, colEmail });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(28, 35, 49);
            dataGridViewCellStyle2.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMembers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.Location = new Point(389, 119);
            dgvMembers.Margin = new Padding(3, 4, 3, 4);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.RowHeadersWidth = 62;
            dgvMembers.RowTemplate.Height = 28;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(658, 556);
            dgvMembers.TabIndex = 13;
            dgvMembers.SelectionChanged += dgvMembers_SelectionChanged;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Member Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Phone Number";
            colPhone.MinimumWidth = 8;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email Address";
            colEmail.MinimumWidth = 100;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // panelInput
            // 
            panelInput.BackColor = Color.White;
            panelInput.Controls.Add(lblMemberDirectory);
            panelInput.Controls.Add(lblEmailAddress);
            panelInput.Controls.Add(btnBack);
            panelInput.Controls.Add(btnSave);
            panelInput.Controls.Add(btnUpdate);
            panelInput.Controls.Add(btnDelete);
            panelInput.Controls.Add(lblMemberName);
            panelInput.Controls.Add(lblPhoneNumber);
            panelInput.Controls.Add(txtMemberName);
            panelInput.Controls.Add(txtPhone);
            panelInput.Controls.Add(txtEmail);
            panelInput.Location = new Point(22, 25);
            panelInput.Margin = new Padding(3, 4, 3, 4);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(344, 650);
            panelInput.TabIndex = 14;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusMessage, lblStatusCount });
            statusStrip1.Location = new Point(0, 657);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1047, 32);
            statusStrip1.TabIndex = 16;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusMessage
            // 
            lblStatusMessage.Name = "lblStatusMessage";
            lblStatusMessage.Size = new Size(60, 25);
            lblStatusMessage.Text = "Ready";
            // 
            // lblStatusCount
            // 
            lblStatusCount.Name = "lblStatusCount";
            lblStatusCount.Size = new Size(148, 25);
            lblStatusCount.Text = "Total Members: 0";
            // 
            // ManageLibraryMembers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1047, 689);
            Controls.Add(statusStrip1);
            Controls.Add(panelInput);
            Controls.Add(dgvMembers);
            Controls.Add(txtSearchMember);
            Controls.Add(lblSearchMember);
            ForeColor = Color.FromArgb(28, 35, 49);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageLibraryMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Library Members";
            Load += ManageLibraryMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMemberDirectory;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSearchMember;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMessage;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusCount;
    }
}