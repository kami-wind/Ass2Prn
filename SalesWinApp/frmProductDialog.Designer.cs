namespace SalesWinApp
{
    partial class frmProductDialog
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
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(156, 9);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(78, 20);
            lbProductID.TabIndex = 0;
            lbProductID.Text = "ProductID:";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(156, 55);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(87, 20);
            lbCategoryID.TabIndex = 1;
            lbCategoryID.Text = "CategoryID:";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(156, 105);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(103, 20);
            lbProductName.TabIndex = 2;
            lbProductName.Text = "ProductName:";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(156, 152);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(59, 20);
            lbWeight.TabIndex = 3;
            lbWeight.Text = "Weight:";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(156, 209);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(71, 20);
            lbUnitPrice.TabIndex = 4;
            lbUnitPrice.Text = "UnitPrice:";
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new Point(156, 268);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new Size(93, 20);
            lbUnitsInStock.TabIndex = 5;
            lbUnitsInStock.Text = "UnitsInStock:";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(325, 12);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(283, 27);
            txtProductID.TabIndex = 6;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(325, 52);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(283, 27);
            txtCategoryID.TabIndex = 7;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(325, 98);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(283, 27);
            txtProductName.TabIndex = 8;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(325, 152);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(283, 27);
            txtWeight.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(325, 209);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(283, 27);
            txtUnitPrice.TabIndex = 10;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(325, 261);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(283, 27);
            txtUnitsInStock.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(197, 369);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(479, 369);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmProductDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
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
            Name = "frmProductDialog";
            Text = "frmProductDialog";
            Load += frmProductDialog_Load;
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
        private Button btnSave;
        private Button btnCancel;
    }
}