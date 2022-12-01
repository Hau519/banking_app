using banking_app.DataAccess.Contexts;
using banking_app.DataAccess.DAOs;
using banking_app.DataAccess.Dtos;
using banking_app.Service.Interfaces;
using banking_app.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app.Business.Service
{
    public class UserService: IService
    {
        private UserDAO userDAO;
        private UserRegisterForm userForm;
        private SignInForm signInForm;
        private WelcomeForm welcomeForm;
        public UserService(ClientContext clientContext)
        {
            this.userDAO = new UserDAO(clientContext);
            this.userForm = new UserRegisterForm();
            this.signInForm = new SignInForm();
            this.welcomeForm = new WelcomeForm();
        }

        public UserDTO CreateNewUser(string fullName,int sin, string passwordHash, string email, string phoneNumber)
        {
            UserDTO newUser = new UserDTO(fullName, sin, passwordHash, email, phoneNumber);
            this.userDAO.SaveNewUser(newUser);
            CloseUserCreationForm();
            MessageBox.Show("you have successully register!");
            return newUser;

        }

        public Boolean CheckEmailExist(string email)
        {
            if (this.userDAO.GetAll(email).Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CheckLogIn(string Email, string Password)
        {

            if (this.userDAO.GetLogIn(email: Email, PasswordHash: Password) == null)
            {
                MessageBox.Show("Email or password is not correct!");
            } else
            {
                CloseSignInForm();
                OpenWelcomeForm();
            }
        }

        public void OpenUserCreationForm()
        {
            this.userForm.ShowDialog();
        }

        public void CloseUserCreationForm()
        {
            this.userForm.DialogResult = DialogResult.Cancel;
        }

        public void OpenSignInForm()
        {
            this.signInForm.ShowDialog();
        }

        public void CloseSignInForm()
        {
            this.signInForm.DialogResult = DialogResult.Cancel;
        }

        public void OpenWelcomeForm()
        {
            this.welcomeForm.ShowDialog();
        }

        public void CloseWelcomeForm()
        {
            this.welcomeForm.DialogResult = DialogResult.Cancel;
        }
    }
}
