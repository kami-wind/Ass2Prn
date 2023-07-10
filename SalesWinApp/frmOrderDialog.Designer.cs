namespace SalesWinApp
{
    partial class frmOrderDialog
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
            lbOrderID = new Label();
            lbMemberID = new Label();
            lbOrderDate = new Label();
            lbRequiredDate = new Label();
            lbShippedDate = new Label();
            lbFreight = new Label();
            txtOrderID = new TextBox();
            txtMemberID = new TextBox();
            dtpOrderDate = new DateTimePicker();
            dtpRequiredDate = new DateTimePicker();
            dtpShippedDate = new DateTimePicker();
            txtFreight = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(168, 19);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(65, 20);
            lbOrderID.TabIndex = 0;
            lbOrderID.Text = "OrderID:";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(168, 59);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(83, 20);
            lbMemberID.TabIndex = 1;
            lbMemberID.Text = "MemberID:";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(168, 100);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(82, 20);
            lbOrderDate.TabIndex = 2;
            lbOrderDate.Text = "OrderDate:";
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new Point(168, 147);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new Size(104, 20);
            lbRequiredDate.TabIndex = 3;
            lbRequiredDate.Text = "RequiredDate:";
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(168, 193);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(99, 20);
            lbShippedDate.TabIndex = 4;
            lbShippedDate.Text = "ShippedDate:";
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new Point(168, 254);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new Size(58, 20);
            lbFreight.TabIndex = 5;
            lbFreight.Text = "Freight:";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(395, 19);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(310, 27);
            txtOrderID.TabIndex = 6;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(395, 59);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(310, 27);
            txtMemberID.TabIndex = 7;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(395, 100);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(310, 27);
            dtpOrderDate.TabIndex = 8;
            dtpOrderDate.ValueChanged += dtpOrderDate_ValueChanged;
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.Location = new Point(395, 147);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(310, 27);
            dtpRequiredDate.TabIndex = 9;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(395, 193);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(310, 27);
            dtpShippedDate.TabIndex = 10;
            dtpShippedDate.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(395, 254);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(310, 27);
            txtFreight.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(231, 376);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(442, 376);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmOrderDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtFreight);
            Controls.Add(dtpShippedDate);
            Controls.Add(dtpRequiredDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(txtMemberID);
            Controls.Add(txtOrderID);
            Controls.Add(lbFreight);
            Controls.Add(lbShippedDate);
            Controls.Add(lbRequiredDate);
            Controls.Add(lbOrderDate);
            Controls.Add(lbMemberID);
            Controls.Add(lbOrderID);
            Name = "frmOrderDialog";
            Text = "frmOrderDialog";
            Load += frmOrderDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbOrderID;
        private Label lbMemberID;
        private Label lbOrderDate;
        private Label lbRequiredDate;
        private Label lbShippedDate;
        private Label lbFreight;
        private TextBox txtOrderID;
        private TextBox txtMemberID;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpShippedDate;
        private TextBox txtFreight;
        private Button btnSave;
        private Button btnCancel;
    }
}