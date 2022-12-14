using banking_app.Business.Service;
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

namespace banking_app.UI
{
    public partial class AccountCreation : Form
    {
        public AccountCreation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string accountType = (string) comboBoxAccType.Text;
            int userId = SignInForm.USERID;
            AccountDTO newAccount = new AccountDTO(accountType, userId);
            MainService.getInstance().GetAccountService().saveNewAccount(newAccount);
            this.DialogResult = DialogResult.OK;
            
        }
    }
}
