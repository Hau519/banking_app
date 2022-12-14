using banking_app.Business.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public Boolean checkInvalidChar(TextBox aInput)
        {
            char[] invalidChars = new char[] { ';', '?', '`' };
            if(aInput.Text.IndexOfAny(invalidChars) != -1)
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSIN.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtPass.Text))
                {
                    MessageBox.Show("Please fill out all the information!");
                }
                else if (!MainService.getInstance().GetUserService().CheckEmailExist(this.txtEmail.Text))
                {
                    MessageBox.Show("This email already exist!");
                } else if(checkInvalidChar(txtEmail) || checkInvalidChar(txtName) || checkInvalidChar(txtPhone)|| checkInvalidChar(txtPass))
                {
                    MessageBox.Show("Please check your input, no special character ? , ? ` allowed");
                }
                else
                {
                    string fullName = this.txtName.Text;
                    string email = this.txtEmail.Text;
                    int sin = int.Parse(txtSIN.Text);
                    this.txtSIN.ForeColor = SystemColors.WindowText;
                    string phone = this.txtPhone.Text;
                    string password = this.txtPass.Text;
                    MainService.getInstance().GetUserService().CreateNewUser(fullName, sin, password, email, phone);
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Only number is accepted for SIN");
                this.txtSIN.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainService.getInstance().GetUserService().CloseUserCreationForm();
            MainService.getInstance().GetUserService().OpenSignInForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSIN_TextChanged(object sender, EventArgs e)
        {
            Regex.IsMatch(this.txtSIN.Text, @"[\d]+$"); // just for reference
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            Regex.IsMatch(this.txtSIN.Text, @"^[\d]{3}-[\d]{3}-[\d]{4}$"); // just for reference
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

