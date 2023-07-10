namespace SalesWinApp
{
    partial class frmReportSetDate
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
            lbStartDate = new Label();
            lbEndDate = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbStartDate
            // 
            lbStartDate.AutoSize = true;
            lbStartDate.Location = new Point(146, 89);
            lbStartDate.Name = "lbStartDate";
            lbStartDate.Size = new Size(75, 20);
            lbStartDate.TabIndex = 0;
            lbStartDate.Text = "StartDate:";
            // 
            // lbEndDate
            // 
            lbEndDate.AutoSize = true;
            lbEndDate.Location = new Point(146, 152);
            lbEndDate.Name = "lbEndDate";
            lbEndDate.Size = new Size(69, 20);
            lbEndDate.TabIndex = 1;
            lbEndDate.Text = "EndDate:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(350, 89);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(342, 27);
            dtpStartDate.TabIndex = 2;
            dtpStartDate.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(350, 152);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(342, 27);
            dtpEndDate.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(243, 283);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(468, 283);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmReportSetDate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lbEndDate);
            Controls.Add(lbStartDate);
            Name = "frmReportSetDate";
            Text = "frmReportSetDate";
            Load += frmReportSetDate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStartDate;
        private Label lbEndDate;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btnSave;
        private Button btnCancel;
    }
}