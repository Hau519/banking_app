using banking_app.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banking_app.Business.Service;

namespace banking_app.UI
{
    
    public partial class WelcomeForm : Form
    {
        private AccountCreation accountCreation;
        private AccountDTO currentWorkingAccount;
        public WelcomeForm()
        {
            if (SignInForm.USERID == 0)
            {
                MessageBox.Show("You have to sign in to access this page!");
            }
            InitializeComponent();
            Init();
        }

        public void FillData(UserDTO userDTO)
        {
            txtID.Text = userDTO.ID.ToString();
            txtName.Text = userDTO.FullName;
            txtEmail.Text = userDTO.Email;
            txtSIN.Text = userDTO.SIN.ToString();
            txtPhone.Text = userDTO.PhoneNumber;
            txtDate.Text = userDTO.RegistrationDate.ToString();
        }

        private void Init()
        {
            this.accountCreation = new AccountCreation();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSIN.ReadOnly = false;
            txtPhone.ReadOnly = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtSIN.ReadOnly = true;
            txtPhone.ReadOnly = true;

            int id = int.Parse(this.txtID.Text);
            string fullName = this.txtName.Text;
            string email = this.txtEmail.Text;
            int sin = int.Parse(txtSIN.Text);
            string phone = this.txtPhone.Text;
            UserDTO user = MainService.getInstance().GetUserService().getUserById(id);
            MainService.getInstance().GetUserService().UpdateUser(user, fullName, sin, email, phone);
        }

       
        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            List<AccountDTO> accountList = MainService.getInstance().GetAccountService().getAccountByUserId(SignInForm.USERID);
            foreach (AccountDTO account in accountList)
            {
                accountCombo.Items.Add(account.AccountNumber);
            }
            
        }

        private void LoadAccountFields(AccountDTO account)
        {
            this.txtAccNumber.Text = account.AccountNumber.ToString();
            this.txtAccType.Text = account.AccountType.ToString();
            this.txtBalance.Text = account.Balance.ToString();
           // List<TransactionDTO> transaction = MainService.GetInstance().GetMovieActorService().GetMovieActors(movie);
           // this.LoadMovieActorList(actors);
        }

        private void accountCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentWorkingAccount = MainService.getInstance().GetAccountService().getAccountByAccountNumber((int)accountCombo.SelectedItem);
            LoadAccountFields(this.currentWorkingAccount);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.accountCreation.ShowDialog();
            if(this.accountCreation.DialogResult == DialogResult.OK)
            {

            }
        }
    }
}
