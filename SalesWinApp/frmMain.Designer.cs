namespace SalesWinApp
{
    partial class frmMain
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
            label1 = new Label();
            btnMember = new Button();
            btnOrder = new Button();
            btnProduct = new Button();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(295, 34);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 0;
            label1.Text = "FSTORE Management";
            // 
            // btnMember
            // 
            btnMember.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMember.Location = new Point(48, 135);
            btnMember.Name = "btnMember";
            btnMember.Size = new Size(94, 29);
            btnMember.TabIndex = 1;
            btnMember.Text = "Member";
            btnMember.UseVisualStyleBackColor = true;
            btnMember.Click += btnMember_Click;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrder.Location = new Point(337, 135);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 29);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnProduct
            // 
            btnProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduct.Location = new Point(634, 135);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(94, 29);
            btnProduct.TabIndex = 3;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.Location = new Point(337, 364);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogOut);
            Controls.Add(btnProduct);
            Controls.Add(btnOrder);
            Controls.Add(btnMember);
            Controls.Add(label1);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMember;
        private Button btnOrder;
        private Button btnProduct;
        private Button btnLogOut;
    }
}