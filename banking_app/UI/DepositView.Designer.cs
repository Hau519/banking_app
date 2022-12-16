namespace banking_app.UI
{
    partial class DepositView
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
            this.comboCurrencyDepo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmounDepo = new System.Windows.Forms.TextBox();
            this.btnCreateDepo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction currency: ";
            // 
            // comboCurrencyDepo
            // 
            this.comboCurrencyDepo.FormattingEnabled = true;
            this.comboCurrencyDepo.Items.AddRange(new object[] {
            "CAD",
            "USD"});
            this.comboCurrencyDepo.Location = new System.Drawing.Point(357, 117);
            this.comboCurrencyDepo.Name = "comboCurrencyDepo";
            this.comboCurrencyDepo.Size = new System.Drawing.Size(344, 33);
            this.comboCurrencyDepo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount: ";
            // 
            // txtAmounDepo
            // 
            this.txtAmounDepo.Location = new System.Drawing.Point(356, 209);
            this.txtAmounDepo.Name = "txtAmounDepo";
            this.txtAmounDepo.Size = new System.Drawing.Size(297, 31);
            this.txtAmounDepo.TabIndex = 3;
            // 
            // btnCreateDepo
            // 
            this.btnCreateDepo.Location = new System.Drawing.Point(231, 323);
            this.btnCreateDepo.Name = "btnCreateDepo";
            this.btnCreateDepo.Size = new System.Drawing.Size(276, 51);
            this.btnCreateDepo.TabIndex = 4;
            this.btnCreateDepo.Text = "Create";
            this.btnCreateDepo.UseVisualStyleBackColor = true;
            this.btnCreateDepo.Click += new System.EventHandler(this.btnCreateDepo_Click);
            // 
            // DepositView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 641);
            this.Controls.Add(this.btnCreateDepo);
            this.Controls.Add(this.txtAmounDepo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboCurrencyDepo);
            this.Controls.Add(this.label1);
            this.Name = "DepositView";
            this.Text = "DepositView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboCurrencyDepo;
        private Label label2;
        private TextBox txtAmounDepo;
        private Button btnCreateDepo;
    }
}