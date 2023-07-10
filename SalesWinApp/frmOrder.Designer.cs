namespace SalesWinApp
{
    partial class frmOrder
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
            txtOrderDate = new TextBox();
            txtRequiredDate = new TextBox();
            txtShippedDate = new TextBox();
            txtFreight = new TextBox();
            dgvOrderList = new DataGridView();
            btnBack = new Button();
            btnLoad = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClearText = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(36, 9);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(65, 20);
            lbOrderID.TabIndex = 0;
            lbOrderID.Text = "OrderID:";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(35, 44);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(83, 20);
            lbMemberID.TabIndex = 1;
            lbMemberID.Text = "MemberID:";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(36, 79);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(82, 20);
            lbOrderDate.TabIndex = 2;
            lbOrderDate.Text = "OrderDate:";
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new Point(464, 9);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new Size(104, 20);
            lbRequiredDate.TabIndex = 3;
            lbRequiredDate.Text = "RequiredDate:";
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(464, 44);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(99, 20);
            lbShippedDate.TabIndex = 4;
            lbShippedDate.Text = "ShippedDate:";
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new Point(464, 82);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new Size(58, 20);
            lbFreight.TabIndex = 5;
            lbFreight.Text = "Freight:";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(178, 6);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(193, 27);
            txtOrderID.TabIndex = 7;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(178, 44);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(193, 27);
            txtMemberID.TabIndex = 8;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(178, 79);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(193, 27);
            txtOrderDate.TabIndex = 9;
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new Point(610, 9);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new Size(178, 27);
            txtRequiredDate.TabIndex = 10;
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new Point(610, 44);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new Size(178, 27);
            txtShippedDate.TabIndex = 11;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(610, 82);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(178, 27);
            txtFreight.TabIndex = 12;
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(25, 226);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 29;
            dgvOrderList.Size = new Size(743, 163);
            dgvOrderList.TabIndex = 13;
            dgvOrderList.CellContentClick += dgvOrderList_CellContentClick;
            dgvOrderList.CellDoubleClick += DgvOrderList_CellDoubleClick;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(366, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(88, 131);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 15;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(204, 181);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(514, 181);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClearText
            // 
            btnClearText.Location = new Point(645, 131);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(94, 29);
            btnClearText.TabIndex = 19;
            btnClearText.Text = "Clear Text";
            btnClearText.UseVisualStyleBackColor = true;
            btnClearText.Click += btnClearText_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(352, 131);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(btnClearText);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(btnBack);
            Controls.Add(dgvOrderList);
            Controls.Add(txtFreight);
            Controls.Add(txtShippedDate);
            Controls.Add(txtRequiredDate);
            Controls.Add(txtOrderDate);
            Controls.Add(txtMemberID);
            Controls.Add(txtOrderID);
            Controls.Add(lbFreight);
            Controls.Add(lbShippedDate);
            Controls.Add(lbRequiredDate);
            Controls.Add(lbOrderDate);
            Controls.Add(lbMemberID);
            Controls.Add(lbOrderID);
            Name = "frmOrder";
            Text = "frmOrder";
            Load += frmOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
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
        private TextBox txtOrderDate;
        private TextBox txtRequiredDate;
        private TextBox txtShippedDate;
        private TextBox txtFreight;
        private DataGridView dgvOrderList;
        private Button btnBack;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClearText;
        private Button btnSearch;
    }
}