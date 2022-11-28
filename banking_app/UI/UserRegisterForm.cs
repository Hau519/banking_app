using banking_app.Business.Service;
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
    public partial class UserRegisterForm : Form
    {
        public UserRegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = this.txtName.Text;
            string email = this.txtEmail.Text;
            int sin = Convert.ToInt32(txtSIN.Text);
            string phone = this.txtPhone.Text;
            string password = this.txtPass.Text;
            MainService.getInstance().GetUserService().CreateNewUser(fullName, sin, password, email, phone);
        }
    }
}

