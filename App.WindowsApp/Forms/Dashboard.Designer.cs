namespace App.WindowsApp.Forms
{
    partial class Dashboard
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
            pnlSidebar = new Panel();
            btnManageBooks = new Button();
            btnLogout = new Button();
            btnIssueReturn = new Button();
            btnManageMembers = new Button();
            lblHeaderTitle = new Label();
            pnlCardBooks = new Panel();
            lblTotalBooksCount = new Label();
            lblTotalBooksTitle = new Label();
            pnlCardMembers = new Panel();
            lblTotalMembersCount = new Label();
            lblTotalMembersTitle = new Label();
            pnlCardIssued = new Panel();
            lblIssuedCount = new Label();
            lblIssuedTitle = new Label();
            pnlWelcomeBanner = new Panel();
            lblWelcomeDesc = new Label();
            lblWelcomeHeading = new Label();
            pnlSidebar.SuspendLayout();
            pnlCardBooks.SuspendLayout();
            pnlCardMembers.SuspendLayout();
            pnlCardIssued.SuspendLayout();
            pnlWelcomeBanner.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(28, 35, 49);
            pnlSidebar.Controls.Add(btnManageBooks);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnIssueReturn);
            pnlSidebar.Controls.Add(btnManageMembers);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(230, 518);
            pnlSidebar.TabIndex = 0;
            // 
            // btnManageBooks
            // 
            btnManageBooks.Cursor = Cursors.Hand;
            btnManageBooks.FlatAppearance.BorderSize = 0;
            btnManageBooks.FlatStyle = FlatStyle.Flat;
            btnManageBooks.Font = new Font("Segoe UI Semibold", 11F);
            btnManageBooks.ForeColor = Color.White;
            btnManageBooks.Image = Properties.Resources.manage_books;
            btnManageBooks.Location = new Point(0, 60);
            btnManageBooks.Margin = new Padding(0);
            btnManageBooks.Name = "btnManageBooks";
            btnManageBooks.Padding = new Padding(20, 0, 0, 0);
            btnManageBooks.Size = new Size(220, 55);
            btnManageBooks.TabIndex = 1;
            btnManageBooks.Text = "Manage Books";
            btnManageBooks.TextAlign = ContentAlignment.MiddleLeft;
            btnManageBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManageBooks.UseVisualStyleBackColor = true;
            btnManageBooks.Click += btnManageBooks_Click;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 11F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.Location = new Point(0, 380);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.Size = new Size(220, 55);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnIssueReturn
            // 
            btnIssueReturn.Cursor = Cursors.Hand;
            btnIssueReturn.FlatAppearance.BorderSize = 0;
            btnIssueReturn.FlatStyle = FlatStyle.Flat;
            btnIssueReturn.Font = new Font("Segoe UI Semibold", 11F);
            btnIssueReturn.ForeColor = Color.White;
            btnIssueReturn.Image = Properties.Resources.issue_return;
            btnIssueReturn.Location = new Point(0, 190);
            btnIssueReturn.Margin = new Padding(0);
            btnIssueReturn.Name = "btnIssueReturn";
            btnIssueReturn.Padding = new Padding(20, 0, 0, 0);
            btnIssueReturn.Size = new Size(229, 55);
            btnIssueReturn.TabIndex = 2;
            btnIssueReturn.Text = "Issue / Return";
            btnIssueReturn.TextAlign = ContentAlignment.MiddleLeft;
            btnIssueReturn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIssueReturn.UseVisualStyleBackColor = true;
            btnIssueReturn.Click += btnIssueReturn_Click;
            // 
            // btnManageMembers
            // 
            btnManageMembers.Cursor = Cursors.Hand;
            btnManageMembers.FlatAppearance.BorderSize = 0;
            btnManageMembers.FlatStyle = FlatStyle.Flat;
            btnManageMembers.Font = new Font("Segoe UI Semibold", 11F);
            btnManageMembers.ForeColor = Color.White;
            btnManageMembers.Image = Properties.Resources.manage_members;
            btnManageMembers.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageMembers.Location = new Point(0, 125);
            btnManageMembers.Margin = new Padding(0);
            btnManageMembers.Name = "btnManageMembers";
            btnManageMembers.Padding = new Padding(5, 0, 0, 0);
            btnManageMembers.Size = new Size(220, 55);
            btnManageMembers.TabIndex = 3;
            btnManageMembers.Text = "Manage Member";
            btnManageMembers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManageMembers.UseVisualStyleBackColor = true;
            btnManageMembers.Click += btnManageMembers_Click;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeaderTitle.ForeColor = Color.FromArgb(28, 35, 49);
            lblHeaderTitle.Location = new Point(250, 30);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(505, 54);
            lblHeaderTitle.TabIndex = 1;
            lblHeaderTitle.Text = "Library Analytics Overview";
            // 
            // pnlCardBooks
            // 
            pnlCardBooks.BackColor = Color.White;
            pnlCardBooks.Controls.Add(lblTotalBooksCount);
            pnlCardBooks.Controls.Add(lblTotalBooksTitle);
            pnlCardBooks.Location = new Point(250, 90);
            pnlCardBooks.Name = "pnlCardBooks";
            pnlCardBooks.Size = new Size(210, 110);
            pnlCardBooks.TabIndex = 2;
            // 
            // lblTotalBooksCount
            // 
            lblTotalBooksCount.AutoSize = true;
            lblTotalBooksCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBooksCount.ForeColor = Color.FromArgb(28, 35, 49);
            lblTotalBooksCount.Location = new Point(15, 45);
            lblTotalBooksCount.Name = "lblTotalBooksCount";
            lblTotalBooksCount.Size = new Size(50, 60);
            lblTotalBooksCount.TabIndex = 1;
            lblTotalBooksCount.Text = "0";
            // 
            // lblTotalBooksTitle
            // 
            lblTotalBooksTitle.AutoSize = true;
            lblTotalBooksTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBooksTitle.ForeColor = Color.FromArgb(41, 128, 185);
            lblTotalBooksTitle.Location = new Point(15, 15);
            lblTotalBooksTitle.Name = "lblTotalBooksTitle";
            lblTotalBooksTitle.Size = new Size(134, 25);
            lblTotalBooksTitle.TabIndex = 0;
            lblTotalBooksTitle.Text = "TOTAL BOOKS";
            // 
            // pnlCardMembers
            // 
            pnlCardMembers.BackColor = Color.White;
            pnlCardMembers.Controls.Add(lblTotalMembersCount);
            pnlCardMembers.Controls.Add(lblTotalMembersTitle);
            pnlCardMembers.Location = new Point(480, 90);
            pnlCardMembers.Name = "pnlCardMembers";
            pnlCardMembers.Size = new Size(210, 110);
            pnlCardMembers.TabIndex = 3;
            // 
            // lblTotalMembersCount
            // 
            lblTotalMembersCount.AutoSize = true;
            lblTotalMembersCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalMembersCount.ForeColor = Color.FromArgb(46, 117, 89);
            lblTotalMembersCount.Location = new Point(15, 45);
            lblTotalMembersCount.Name = "lblTotalMembersCount";
            lblTotalMembersCount.Size = new Size(50, 60);
            lblTotalMembersCount.TabIndex = 1;
            lblTotalMembersCount.Text = "0";
            // 
            // lblTotalMembersTitle
            // 
            lblTotalMembersTitle.AutoSize = true;
            lblTotalMembersTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalMembersTitle.ForeColor = Color.FromArgb(41, 128, 185);
            lblTotalMembersTitle.Location = new Point(15, 15);
            lblTotalMembersTitle.Name = "lblTotalMembersTitle";
            lblTotalMembersTitle.Size = new Size(160, 25);
            lblTotalMembersTitle.TabIndex = 0;
            lblTotalMembersTitle.Text = "TOTAL MEMBERS";
            // 
            // pnlCardIssued
            // 
            pnlCardIssued.BackColor = Color.White;
            pnlCardIssued.Controls.Add(lblIssuedCount);
            pnlCardIssued.Controls.Add(lblIssuedTitle);
            pnlCardIssued.Location = new Point(710, 90);
            pnlCardIssued.Name = "pnlCardIssued";
            pnlCardIssued.Size = new Size(210, 110);
            pnlCardIssued.TabIndex = 4;
            // 
            // lblIssuedCount
            // 
            lblIssuedCount.AutoSize = true;
            lblIssuedCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIssuedCount.ForeColor = Color.FromArgb(192, 57, 43);
            lblIssuedCount.Location = new Point(15, 45);
            lblIssuedCount.Name = "lblIssuedCount";
            lblIssuedCount.Size = new Size(50, 60);
            lblIssuedCount.TabIndex = 1;
            lblIssuedCount.Text = "0";
            // 
            // lblIssuedTitle
            // 
            lblIssuedTitle.AutoSize = true;
            lblIssuedTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIssuedTitle.ForeColor = Color.FromArgb(41, 128, 185);
            lblIssuedTitle.Location = new Point(15, 15);
            lblIssuedTitle.Name = "lblIssuedTitle";
            lblIssuedTitle.Size = new Size(141, 25);
            lblIssuedTitle.TabIndex = 0;
            lblIssuedTitle.Text = "BOOKS ISSUED";
            // 
            // pnlWelcomeBanner
            // 
            pnlWelcomeBanner.BackColor = Color.White;
            pnlWelcomeBanner.Controls.Add(lblWelcomeDesc);
            pnlWelcomeBanner.Controls.Add(lblWelcomeHeading);
            pnlWelcomeBanner.Location = new Point(250, 220);
            pnlWelcomeBanner.Name = "pnlWelcomeBanner";
            pnlWelcomeBanner.Size = new Size(670, 200);
            pnlWelcomeBanner.TabIndex = 5;
            // 
            // lblWelcomeDesc
            // 
            lblWelcomeDesc.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeDesc.ForeColor = Color.FromArgb(100, 110, 120);
            lblWelcomeDesc.Location = new Point(20, 60);
            lblWelcomeDesc.Name = "lblWelcomeDesc";
            lblWelcomeDesc.Size = new Size(600, 112);
            lblWelcomeDesc.TabIndex = 1;
            lblWelcomeDesc.Text = "Use the navigation sidebar on the left to manage the library database. You can quickly add new books, update member records, or track current book checkouts and returns.";
            // 
            // lblWelcomeHeading
            // 
            lblWelcomeHeading.AutoSize = true;
            lblWelcomeHeading.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeHeading.ForeColor = Color.FromArgb(28, 35, 49);
            lblWelcomeHeading.Location = new Point(20, 22);
            lblWelcomeHeading.Name = "lblWelcomeHeading";
            lblWelcomeHeading.Size = new Size(403, 38);
            lblWelcomeHeading.TabIndex = 0;
            lblWelcomeHeading.Text = "Welcome Back, Administrator!";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(926, 518);
            Controls.Add(pnlWelcomeBanner);
            Controls.Add(pnlCardIssued);
            Controls.Add(pnlCardMembers);
            Controls.Add(pnlCardBooks);
            Controls.Add(lblHeaderTitle);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management System | Admin Dashboard";
            Load += Dashboard_Load;
            pnlSidebar.ResumeLayout(false);
            pnlCardBooks.ResumeLayout(false);
            pnlCardBooks.PerformLayout();
            pnlCardMembers.ResumeLayout(false);
            pnlCardMembers.PerformLayout();
            pnlCardIssued.ResumeLayout(false);
            pnlCardIssued.PerformLayout();
            pnlWelcomeBanner.ResumeLayout(false);
            pnlWelcomeBanner.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnIssueReturn;
        private System.Windows.Forms.Button btnManageMembers;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlCardBooks;
        private System.Windows.Forms.Panel pnlCardMembers;
        private System.Windows.Forms.Panel pnlCardIssued;
        private System.Windows.Forms.Label lblTotalBooksTitle;
        private System.Windows.Forms.Label lblTotalBooksCount;
        private System.Windows.Forms.Label lblTotalMembersCount;
        private System.Windows.Forms.Label lblTotalMembersTitle;
        private System.Windows.Forms.Label lblIssuedCount;
        private System.Windows.Forms.Label lblIssuedTitle;
        private System.Windows.Forms.Panel pnlWelcomeBanner;
        private System.Windows.Forms.Label lblWelcomeDesc;
        private System.Windows.Forms.Label lblWelcomeHeading;
    }
}