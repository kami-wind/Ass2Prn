namespace SalesWinApp
{
    partial class frmMember
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
            lbMemberID = new Label();
            lbEmail = new Label();
            lbCompanyName = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            lbPassword = new Label();
            txtMemberID = new TextBox();
            txtEmail = new TextBox();
            txtCompanyName = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPassword = new TextBox();
            dgvMemberList = new DataGridView();
            btnLoad = new Button();
            btnBack = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            btnClearText = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(26, 18);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(83, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "MemberID:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(26, 59);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(49, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email:";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(26, 101);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(115, 20);
            lbCompanyName.TabIndex = 2;
            lbCompanyName.Text = "CompanyName:";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(437, 15);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(37, 20);
            lbCity.TabIndex = 3;
            lbCity.Text = "City:";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(437, 59);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(63, 20);
            lbCountry.TabIndex = 4;
            lbCountry.Text = "Country:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(437, 108);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(73, 20);
            lbPassword.TabIndex = 5;
            lbPassword.Text = "Password:";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(167, 15);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(180, 27);
            txtMemberID.TabIndex = 6;
            txtMemberID.TextChanged += txtMemberID_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(167, 59);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(167, 101);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(180, 27);
            txtCompanyName.TabIndex = 8;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(545, 11);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(169, 27);
            txtCity.TabIndex = 9;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(545, 56);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(169, 27);
            txtCountry.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(545, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(169, 27);
            txtPassword.TabIndex = 11;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(12, 235);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.Size = new Size(776, 152);
            dgvMemberList.TabIndex = 12;
            dgvMemberList.CellContentClick += dgvMemberList_CellContentClick;
            dgvMemberList.CellDoubleClick += DgvMemberList_CellDoubleClick;
            dgvMemberList.CellEndEdit += dgvMemberList_CellEndEdit;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(97, 149);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(341, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(503, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(211, 200);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(341, 149);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClearText
            // 
            btnClearText.Location = new Point(620, 149);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(94, 29);
            btnClearText.TabIndex = 21;
            btnClearText.Text = "Clear Text";
            btnClearText.UseVisualStyleBackColor = true;
            btnClearText.Click += btnClearText_Click;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClearText);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(btnLoad);
            Controls.Add(dgvMemberList);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompanyName);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberID);
            Controls.Add(lbPassword);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCompanyName);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberID);
            Name = "frmMember";
            Text = "frmMember";
            Load += frmMember_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberID;
        private Label lbEmail;
        private Label lbCompanyName;
        private Label lbCity;
        private Label lbCountry;
        private Label lbPassword;
        private TextBox txtMemberID;
        private TextBox txtEmail;
        private TextBox txtCompanyName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPassword;
        private DataGridView dgvMemberList;
        private Button btnLoad;
        private Button btnBack;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnClearText;
    }
}