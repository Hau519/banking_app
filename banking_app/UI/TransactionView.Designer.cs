namespace banking_app.UI
{
    partial class TransactionView
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridViewTransactions = new System.Windows.Forms.DataGridView();
            this.btnCreateTrans = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Previous Transactions";
            // 
            // gridViewTransactions
            // 
            this.gridViewTransactions.AllowUserToDeleteRows = false;
            this.gridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTransactions.Location = new System.Drawing.Point(163, 125);
            this.gridViewTransactions.Name = "gridViewTransactions";
            this.gridViewTransactions.ReadOnly = true;
            this.gridViewTransactions.RowHeadersWidth = 62;
            this.gridViewTransactions.RowTemplate.Height = 33;
            this.gridViewTransactions.Size = new System.Drawing.Size(1294, 475);
            this.gridViewTransactions.TabIndex = 1;
            // 
            // btnCreateTrans
            // 
            this.btnCreateTrans.Location = new System.Drawing.Point(85, 677);
            this.btnCreateTrans.Name = "btnCreateTrans";
            this.btnCreateTrans.Size = new System.Drawing.Size(266, 57);
            this.btnCreateTrans.TabIndex = 2;
            this.btnCreateTrans.Text = "Deposit cash";
            this.btnCreateTrans.UseVisualStyleBackColor = true;
            this.btnCreateTrans.Click += new System.EventHandler(this.btnCreateTrans_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(459, 677);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(266, 57);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw cash";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(831, 677);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(266, 57);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1201, 677);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(266, 57);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TransactionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 915);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnCreateTrans);
            this.Controls.Add(this.gridViewTransactions);
            this.Controls.Add(this.label1);
            this.Name = "TransactionView";
            this.Text = "TransactionView";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView gridViewTransactions;
        private Button btnCreateTrans;
        private Button btnWithdraw;
        private Button btnTransfer;
        private Button btnClose;
    }
}