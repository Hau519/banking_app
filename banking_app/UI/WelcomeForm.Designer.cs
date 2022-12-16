namespace banking_app.UI
{
    partial class WelcomeForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSIN = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.createNewAccount = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.accountCombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.movieIdValueLable = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.txtAccNumber = new System.Windows.Forms.TextBox();
            this.txtAccType = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome back!!!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(467, 512);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(229, 31);
            this.txtDate.TabIndex = 20;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(467, 450);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(229, 31);
            this.txtPhone.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(467, 397);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(229, 31);
            this.txtEmail.TabIndex = 18;
            // 
            // txtSIN
            // 
            this.txtSIN.Location = new System.Drawing.Point(467, 343);
            this.txtSIN.Name = "txtSIN";
            this.txtSIN.ReadOnly = true;
            this.txtSIN.Size = new System.Drawing.Size(229, 31);
            this.txtSIN.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(467, 282);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(229, 31);
            this.txtName.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Register date: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "SIN: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Phone number: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Full name: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 592);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 48);
            this.button3.TabIndex = 21;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // createNewAccount
            // 
            this.createNewAccount.Location = new System.Drawing.Point(1142, 489);
            this.createNewAccount.Name = "createNewAccount";
            this.createNewAccount.Size = new System.Drawing.Size(186, 48);
            this.createNewAccount.TabIndex = 22;
            this.createNewAccount.Text = "Create new account";
            this.createNewAccount.UseVisualStyleBackColor = true;
            this.createNewAccount.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(323, 592);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 48);
            this.button5.TabIndex = 23;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "ID: ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(467, 223);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(229, 31);
            this.txtID.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Your profile information";
            // 
            // accountCombo
            // 
            this.accountCombo.FormattingEnabled = true;
            this.accountCombo.Location = new System.Drawing.Point(1142, 157);
            this.accountCombo.Name = "accountCombo";
            this.accountCombo.Size = new System.Drawing.Size(182, 33);
            this.accountCombo.TabIndex = 27;
            this.accountCombo.SelectedIndexChanged += new System.EventHandler(this.accountCombo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(991, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Your accounts:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(949, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "ID: ";
            // 
            // movieIdValueLable
            // 
            this.movieIdValueLable.AutoSize = true;
            this.movieIdValueLable.Location = new System.Drawing.Point(1013, 223);
            this.movieIdValueLable.Name = "movieIdValueLable";
            this.movieIdValueLable.Size = new System.Drawing.Size(104, 25);
            this.movieIdValueLable.TabIndex = 29;
            this.movieIdValueLable.Text = "placeholder";
            this.movieIdValueLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(832, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Account Number: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(852, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 25);
            this.label12.TabIndex = 31;
            this.label12.Text = "Account Type:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(900, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Balance:";
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(886, 489);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(186, 48);
            this.btnTransaction.TabIndex = 33;
            this.btnTransaction.Text = "Transactions";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(1386, 489);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(186, 48);
            this.btnDeleteAccount.TabIndex = 34;
            this.btnDeleteAccount.Text = "Delete this account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.Location = new System.Drawing.Point(1012, 275);
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.Size = new System.Drawing.Size(216, 31);
            this.txtAccNumber.TabIndex = 35;
            // 
            // txtAccType
            // 
            this.txtAccType.Location = new System.Drawing.Point(1013, 343);
            this.txtAccType.Name = "txtAccType";
            this.txtAccType.Size = new System.Drawing.Size(216, 31);
            this.txtAccType.TabIndex = 36;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(1013, 413);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(216, 31);
            this.txtBalance.TabIndex = 37;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(528, 592);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 48);
            this.button4.TabIndex = 38;
            this.button4.Text = "Delete user account";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(675, 716);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(259, 58);
            this.btnLogOut.TabIndex = 39;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 825);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtAccType);
            this.Controls.Add(this.txtAccNumber);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.movieIdValueLable);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.accountCombo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.createNewAccount);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSIN);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtDate;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtSIN;
        private TextBox txtName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private Button button3;
        private Button createNewAccount;
        private Button button5;
        private Label label7;
        private TextBox txtID;
        private Label label8;
        private ComboBox accountCombo;
        private Label label9;
        private Label label10;
        private Label movieIdValueLable;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnTransaction;
        private Button btnDeleteAccount;
        private TextBox txtAccNumber;
        private TextBox txtAccType;
        private TextBox txtBalance;
        private Button button4;
        private Button btnLogOut;
    }
}