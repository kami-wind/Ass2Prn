namespace SalesWinApp
{
    partial class frmProduct
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
            lbProductID = new Label();
            lbCategoryID = new Label();
            lbProductName = new Label();
            lbWeight = new Label();
            lbUnitPrice = new Label();
            lbUnitsInStock = new Label();
            txtProductID = new TextBox();
            txtCategoryID = new TextBox();
            txtProductName = new TextBox();
            txtWeight = new TextBox();
            txtUnitPrice = new TextBox();
            txtUnitsInStock = new TextBox();
            dgvProductList = new DataGridView();
            btnLoad = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnClearText = new Button();
            btnReport = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(27, 22);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(78, 20);
            lbProductID.TabIndex = 0;
            lbProductID.Text = "ProductID:";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(27, 67);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(87, 20);
            lbCategoryID.TabIndex = 1;
            lbCategoryID.Text = "CategoryID:";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(27, 128);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(103, 20);
            lbProductName.TabIndex = 2;
            lbProductName.Text = "ProductName:";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(455, 22);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(59, 20);
            lbWeight.TabIndex = 3;
            lbWeight.Text = "Weight:";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(455, 67);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(71, 20);
            lbUnitPrice.TabIndex = 4;
            lbUnitPrice.Text = "UnitPrice:";
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new Point(455, 128);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new Size(93, 20);
            lbUnitsInStock.TabIndex = 5;
            lbUnitsInStock.Text = "UnitsInStock:";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(166, 22);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(219, 27);
            txtProductID.TabIndex = 6;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(166, 77);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(219, 27);
            txtCategoryID.TabIndex = 7;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(166, 128);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(219, 27);
            txtProductName.TabIndex = 8;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(561, 22);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(203, 27);
            txtWeight.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(561, 77);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(203, 27);
            txtUnitPrice.TabIndex = 10;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(561, 128);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(203, 27);
            txtUnitsInStock.TabIndex = 11;
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(12, 261);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 29;
            dgvProductList.Size = new Size(776, 146);
            dgvProductList.TabIndex = 12;
            dgvProductList.CellContentClick += dgvProductList_CellContentClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(48, 171);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(48, 226);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(348, 171);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(348, 226);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClearText
            // 
            btnClearText.Location = new Point(654, 171);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(94, 29);
            btnClearText.TabIndex = 17;
            btnClearText.Text = "ClearText";
            btnClearText.UseVisualStyleBackColor = true;
            btnClearText.Click += btnClearText_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(654, 226);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(94, 29);
            btnReport.TabIndex = 18;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(338, 413);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 19;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnReport);
            Controls.Add(btnClearText);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(dgvProductList);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtProductName);
            Controls.Add(txtCategoryID);
            Controls.Add(txtProductID);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbWeight);
            Controls.Add(lbProductName);
            Controls.Add(lbCategoryID);
            Controls.Add(lbProductID);
            Name = "frmProduct";
            Text = "frmProduct";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProductID;
        private Label lbCategoryID;
        private Label lbProductName;
        private Label lbWeight;
        private Label lbUnitPrice;
        private Label lbUnitsInStock;
        private TextBox txtProductID;
        private TextBox txtCategoryID;
        private TextBox txtProductName;
        private TextBox txtWeight;
        private TextBox txtUnitPrice;
        private TextBox txtUnitsInStock;
        private DataGridView dgvProductList;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnClearText;
        private Button btnReport;
        private Button btnBack;
    }
}