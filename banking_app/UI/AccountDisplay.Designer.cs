namespace banking_app.UI
{
    partial class AccountDisplay
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
            this.savingBtn = new System.Windows.Forms.Button();
            this.checkingbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // savingBtn
            // 
            this.savingBtn.Location = new System.Drawing.Point(174, 108);
            this.savingBtn.Name = "savingBtn";
            this.savingBtn.Size = new System.Drawing.Size(242, 120);
            this.savingBtn.TabIndex = 0;
            this.savingBtn.Text = "Saving Account";
            this.savingBtn.UseVisualStyleBackColor = true;
            this.savingBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkingbtn
            // 
            this.checkingbtn.Location = new System.Drawing.Point(477, 108);
            this.checkingbtn.Name = "checkingbtn";
            this.checkingbtn.Size = new System.Drawing.Size(242, 120);
            this.checkingbtn.TabIndex = 1;
            this.checkingbtn.Text = "Checking Account";
            this.checkingbtn.UseVisualStyleBackColor = true;
            // 
            // AccountDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 560);
            this.Controls.Add(this.checkingbtn);
            this.Controls.Add(this.savingBtn);
            this.Name = "AccountDisplay";
            this.Text = "AccountDisplay";
            this.ResumeLayout(false);

        }

        #endregion

        private Button savingBtn;
        private Button checkingbtn;
    }
}