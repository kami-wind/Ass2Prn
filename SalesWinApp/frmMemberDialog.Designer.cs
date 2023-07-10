namespace SalesWinApp
{
    partial class frmMemberDialog
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
            lbMemberDetail = new Label();
            lbMemberID = new Label();
            lbEmail = new Label();
            lbCompanyName = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            label7 = new Label();
            txtMemberID = new TextBox();
            txtEmail = new TextBox();
            txtCompanyName = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbMemberDetail
            // 
            lbMemberDetail.AutoSize = true;
            lbMemberDetail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMemberDetail.Location = new Point(362, 20);
            lbMemberDetail.Name = "lbMemberDetail";
            lbMemberDetail.Size = new Size(120, 20);
            lbMemberDetail.TabIndex = 0;
            lbMemberDetail.Text = "Member Details";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(160, 54);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(83, 20);
            lbMemberID.TabIndex = 1;
            lbMemberID.Text = "MemberID:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(160, 104);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(49, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email:";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(160, 157);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(115, 20);
            lbCompanyName.TabIndex = 3;
            lbCompanyName.Text = "CompanyName:";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(160, 209);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(37, 20);
            lbCity.TabIndex = 4;
            lbCity.Text = "City:";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(160, 255);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(63, 20);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(160, 301);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 6;
            label7.Text = "Password:";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(455, 54);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(242, 27);
            txtMemberID.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(455, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(242, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(455, 150);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(242, 27);
            txtCompanyName.TabIndex = 9;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(455, 209);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(242, 27);
            txtCity.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(455, 255);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(242, 27);
            txtCountry.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(455, 301);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(242, 27);
            txtPassword.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(230, 385);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(497, 385);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmMemberDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompanyName);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberID);
            Controls.Add(label7);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbCompanyName);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberID);
            Controls.Add(lbMemberDetail);
            Name = "frmMemberDialog";
            Text = "frmMemberDialog";
            Load += frmMemberDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberDetail;
        private Label lbMemberID;
        private Label lbEmail;
        private Label lbCompanyName;
        private Label lbCity;
        private Label lbCountry;
        private Label label7;
        private TextBox txtMemberID;
        private TextBox txtEmail;
        private TextBox txtCompanyName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPassword;
        private Button btnSave;
        private Button btnCancel;
    }
}