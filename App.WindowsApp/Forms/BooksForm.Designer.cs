namespace App.WindowsApp.Forms
{
    partial class BooksForm
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panelInput = new Panel();
            btnSearch = new Button();
            tblBooks = new TableLayoutPanel();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblQuantity = new Label();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            pnlButtons = new Panel();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtQuantity = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvBooks = new DataGridView();
            colTitle = new DataGridViewTextBoxColumn();
            colAuthor = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            lblStatusText = new ToolStripStatusLabel();
            panelInput.SuspendLayout();
            tblBooks.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelInput
            // 
            panelInput.BackColor = Color.White;
            panelInput.Controls.Add(btnSearch);
            panelInput.Controls.Add(tblBooks);
            panelInput.Controls.Add(txtSearch);
            panelInput.Controls.Add(lblSearch);
            panelInput.Dock = DockStyle.Left;
            panelInput.Location = new Point(10, 10);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(304, 528);
            panelInput.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(28, 35, 49);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(225, 40);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // tblBooks
            // 
            tblBooks.ColumnCount = 1;
            tblBooks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblBooks.Controls.Add(lblTitle, 0, 0);
            tblBooks.Controls.Add(txtTitle, 0, 1);
            tblBooks.Controls.Add(lblQuantity, 0, 4);
            tblBooks.Controls.Add(lblAuthor, 0, 2);
            tblBooks.Controls.Add(txtAuthor, 0, 3);
            tblBooks.Controls.Add(pnlButtons, 0, 9);
            tblBooks.Controls.Add(txtQuantity, 0, 5);
            tblBooks.Controls.Add(lblCategory, 0, 7);
            tblBooks.Controls.Add(cmbCategory, 0, 8);
            tblBooks.Location = new Point(3, 77);
            tblBooks.Margin = new Padding(0, 0, 15, 0);
            tblBooks.Name = "tblBooks";
            tblBooks.Padding = new Padding(10);
            tblBooks.RowCount = 9;
            tblBooks.RowStyles.Add(new RowStyle());
            tblBooks.RowStyles.Add(new RowStyle());
            tblBooks.RowStyles.Add(new RowStyle());
            tblBooks.RowStyles.Add(new RowStyle());
            tblBooks.RowStyles.Add(new RowStyle());
            tblBooks.RowStyles.Add(new RowStyle());
            tblBooks.RowStyles.Add(new RowStyle());
            tblBooks.RowStyles.Add(new RowStyle());
            tblBooks.RowStyles.Add(new RowStyle());
            tblBooks.RowStyles.Add(new RowStyle());
            tblBooks.Size = new Size(296, 450);
            tblBooks.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(13, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(99, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Book Title";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(13, 45);
            txtTitle.Margin = new Padding(3, 10, 3, 15);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(262, 37);
            txtTitle.TabIndex = 4;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(13, 184);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(87, 25);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(13, 97);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(127, 25);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Author Name";
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = Color.White;
            txtAuthor.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAuthor.Location = new Point(13, 132);
            txtAuthor.Margin = new Padding(3, 10, 3, 15);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(262, 37);
            txtAuthor.TabIndex = 5;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Location = new Point(13, 343);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(5);
            pnlButtons.Size = new Size(244, 102);
            pnlButtons.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Image = Properties.Resources.update;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(127, 8);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 38);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "UPDATE";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 35, 51);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 6, 44);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = Properties.Resources.delete1;
            btnDelete.Location = new Point(12, 56);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(220, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(28, 35, 49);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 25, 35);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 54, 73);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = Properties.Resources.add;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(12, 8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 38);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "ADD";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.White;
            txtQuantity.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(13, 219);
            txtQuantity.Margin = new Padding(3, 10, 3, 15);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(262, 37);
            txtQuantity.TabIndex = 6;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.FlatStyle = FlatStyle.Flat;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(13, 271);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(90, 25);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Programming", "Mathematics", "Science", "Novel", "History" });
            cmbCategory.Location = new Point(13, 299);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(262, 38);
            cmbCategory.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(0, 37);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(219, 37);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(5, 9);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(118, 25);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Book";
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 35, 49);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { colTitle, colAuthor, colCategory, colQuantity });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(28, 35, 49);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle6;
            dgvBooks.Dock = DockStyle.Fill;
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.GridColor = Color.LightGray;
            dgvBooks.Location = new Point(314, 10);
            dgvBooks.Margin = new Padding(3, 10, 3, 15);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 62;
            dgvBooks.RowTemplate.Height = 28;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(595, 528);
            dgvBooks.TabIndex = 1;
            dgvBooks.CellClick += dgvBooks_CellClick;
            // 
            // colTitle
            // 
            colTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTitle.DataPropertyName = "BookTitle";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colTitle.DefaultCellStyle = dataGridViewCellStyle3;
            colTitle.FillWeight = 200F;
            colTitle.HeaderText = "Book Title";
            colTitle.MinimumWidth = 8;
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colAuthor
            // 
            colAuthor.DataPropertyName = "AuthorName";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colAuthor.DefaultCellStyle = dataGridViewCellStyle4;
            colAuthor.HeaderText = "Author Name";
            colAuthor.MinimumWidth = 160;
            colAuthor.Name = "colAuthor";
            colAuthor.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 130;
            colCategory.Name = "colCategory";
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colQuantity.DefaultCellStyle = dataGridViewCellStyle5;
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 120;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusText });
            statusStrip1.Location = new Point(314, 506);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(595, 32);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusText
            // 
            lblStatusText.Name = "lblStatusText";
            lblStatusText.Size = new Size(60, 25);
            lblStatusText.Text = "Ready";
            // 
            // BooksForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(919, 548);
            Controls.Add(statusStrip1);
            Controls.Add(dgvBooks);
            Controls.Add(panelInput);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(28, 35, 49);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BooksForm";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Inventory Management";
            Load += BooksForm_Load_1;
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            tblBooks.ResumeLayout(false);
            tblBooks.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }


        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TableLayoutPanel tblBooks;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusText;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnUpdate;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colAuthor;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colQuantity;
    }
}
    #endregion