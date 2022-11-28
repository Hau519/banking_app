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
        public UserService(ClientContext clientContext)
        {
            this.userDAO = new UserDAO(clientContext);
            this.userForm = new UserRegisterForm();
        }



        public UserDTO CreateNewUser(string fullName, string passwordHash, string email, string phoneNumber, string sin)
        {
            UserDTO newUser = new UserDTO(fullName, passwordHash, email, phoneNumber, sin);
            this.userDAO.SaveNewUser(newUser);
            CloseUserCreationForm();
            return newUser;

        }

        public void OpenUserCreationForm()
        {
            this.userForm.ShowDialog();
        }

        public void CloseUserCreationForm()
        {
            this.userForm.DialogResult = DialogResult.Cancel;
        }
    }
}
