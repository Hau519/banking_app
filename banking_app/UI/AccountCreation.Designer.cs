namespace banking_app.UI
{
    partial class AccountCreation
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.comboBoxAccType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Type: ";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(358, 184);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(134, 44);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add user";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(547, 184);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(134, 44);
            this.btnCreateAccount.TabIndex = 5;
            this.btnCreateAccount.Text = "Create account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // comboBoxAccType
            // 
            this.comboBoxAccType.FormattingEnabled = true;
            this.comboBoxAccType.Items.AddRange(new object[] {
            "Checking",
            "Saving"});
            this.comboBoxAccType.Location = new System.Drawing.Point(451, 93);
            this.comboBoxAccType.Name = "comboBoxAccType";
            this.comboBoxAccType.Size = new System.Drawing.Size(254, 33);
            this.comboBoxAccType.TabIndex = 6;
            // 
            // AccountCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 733);
            this.Controls.Add(this.comboBoxAccType);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label2);
            this.Name = "AccountCreation";
            this.Text = "AccountCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Button btnAddUser;
        private Button btnCreateAccount;
        private ComboBox comboBoxAccType;
    }
}