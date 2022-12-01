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
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSIN.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtPass.Text))
                {
                    MessageBox.Show("Please fill out all the information!");
                } else if (!MainService.getInstance().GetUserService().CheckEmailExist(this.txtEmail.Text))
                {
                    MessageBox.Show("This email already exist!");
                }else 
                {
                    string fullName = this.txtName.Text;
                    string email = this.txtEmail.Text;
                    int sin = Convert.ToInt32(txtSIN.Text);
                    string phone = this.txtPhone.Text;
                    string password = this.txtPass.Text;
                    MainService.getInstance().GetUserService().CreateNewUser(fullName, sin, password, email, phone);
                }
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

