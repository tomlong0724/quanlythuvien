namespace QLTV
{
    partial class BookManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvBook = new System.Windows.Forms.DataGridView();
            btnAdd = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            labelSearch = new System.Windows.Forms.Label();
            btnEdit = new System.Windows.Forms.Button();
            txtBookID = new System.Windows.Forms.TextBox();
            btnRefresh = new System.Windows.Forms.Button();
            dgvAuthor = new System.Windows.Forms.DataGridView();
            txtAuthorID = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            rdAuthor = new System.Windows.Forms.RadioButton();
            rdBook = new System.Windows.Forms.RadioButton();
            btnAddQuantity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuthor).BeginInit();
            SuspendLayout();
            // 
            // dgvBook
            // 
            dgvBook.AllowUserToAddRows = false;
            dgvBook.AllowUserToDeleteRows = false;
            dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dgvBook.Location = new System.Drawing.Point(146, 0);
            dgvBook.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dgvBook.MultiSelect = false;
            dgvBook.Name = "dgvBook";
            dgvBook.ReadOnly = true;
            dgvBook.RowHeadersWidth = 51;
            dgvBook.RowTemplate.Height = 25;
            dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvBook.Size = new System.Drawing.Size(625, 600);
            dgvBook.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(3, 297);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(140, 60);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm đầu sách";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(3, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(140, 23);
            txtSearch.TabIndex = 3;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new System.Drawing.Point(3, 3);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new System.Drawing.Size(56, 15);
            labelSearch.TabIndex = 4;
            labelSearch.Text = "Tìm kiếm";
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(3, 363);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(140, 60);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Sửa thông tin đầu sách";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtBookID
            // 
            txtBookID.Location = new System.Drawing.Point(3, 150);
            txtBookID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new System.Drawing.Size(140, 23);
            txtBookID.TabIndex = 8;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new System.Drawing.Point(3, 146);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(140, 60);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvAuthor
            // 
            dgvAuthor.AllowUserToAddRows = false;
            dgvAuthor.AllowUserToDeleteRows = false;
            dgvAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAuthor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dgvAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthor.Location = new System.Drawing.Point(771, 0);
            dgvAuthor.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            dgvAuthor.MultiSelect = false;
            dgvAuthor.Name = "dgvAuthor";
            dgvAuthor.ReadOnly = true;
            dgvAuthor.RowHeadersWidth = 51;
            dgvAuthor.RowTemplate.Height = 25;
            dgvAuthor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAuthor.Size = new System.Drawing.Size(275, 600);
            dgvAuthor.TabIndex = 10;
            // 
            // txtAuthorID
            // 
            txtAuthorID.Location = new System.Drawing.Point(3, 173);
            txtAuthorID.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            txtAuthorID.Name = "txtAuthorID";
            txtAuthorID.Size = new System.Drawing.Size(140, 23);
            txtAuthorID.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(3, 100);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(140, 40);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // rdAuthor
            // 
            rdAuthor.AutoSize = true;
            rdAuthor.Location = new System.Drawing.Point(3, 75);
            rdAuthor.Name = "rdAuthor";
            rdAuthor.Size = new System.Drawing.Size(83, 19);
            rdAuthor.TabIndex = 14;
            rdAuthor.TabStop = true;
            rdAuthor.Text = "Tìm tác giả";
            rdAuthor.UseVisualStyleBackColor = true;
            // 
            // rdBook
            // 
            rdBook.AutoSize = true;
            rdBook.Location = new System.Drawing.Point(3, 50);
            rdBook.Name = "rdBook";
            rdBook.Size = new System.Drawing.Size(95, 19);
            rdBook.TabIndex = 15;
            rdBook.TabStop = true;
            rdBook.Text = "Tìm đầu sách";
            rdBook.UseVisualStyleBackColor = true;
            // 
            // btnAddQuantity
            // 
            btnAddQuantity.Location = new System.Drawing.Point(3, 429);
            btnAddQuantity.Name = "btnAddQuantity";
            btnAddQuantity.Size = new System.Drawing.Size(140, 60);
            btnAddQuantity.TabIndex = 16;
            btnAddQuantity.Text = "Thêm sách vào kho";
            btnAddQuantity.UseVisualStyleBackColor = true;
            btnAddQuantity.Click += btnAddQuantity_Click;
            // 
            // BookManagement
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            Controls.Add(btnAddQuantity);
            Controls.Add(rdBook);
            Controls.Add(dgvBook);
            Controls.Add(rdAuthor);
            Controls.Add(dgvAuthor);
            Controls.Add(btnRefresh);
            Controls.Add(txtBookID);
            Controls.Add(btnEdit);
            Controls.Add(labelSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnAdd);
            Controls.Add(txtAuthorID);
            Controls.Add(btnSearch);
            MaximumSize = new System.Drawing.Size(1920, 1080);
            Name = "BookManagement";
            Size = new System.Drawing.Size(1050, 604);
            Load += BookManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuthor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvAuthor;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdAuthor;
        private System.Windows.Forms.RadioButton rdBook;
        private System.Windows.Forms.Button btnAddQuantity;
    }
}
