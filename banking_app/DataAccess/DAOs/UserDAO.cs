using banking_app.DataAccess.Contexts;
using banking_app.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app.DataAccess.DAOs
{
    public class UserDAO
    {
        private ClientContext clientContext;
        public UserDAO(ClientContext clientContext)
        {
            clientContext ??= new ClientContext();
            this.clientContext = clientContext;
        }

        
        public UserDTO GetById(int id)
        {
            return this.clientContext.Users.Where(user => user.ID == id).Single();
        }

        public List<UserDTO> GetAll(string email)
        {
            return this.clientContext.Users.Where(user => user.Email == email).ToList();
        }

        public UserDTO? GetLogIn(string email, string PasswordHash)
        {
            List<UserDTO> userList = GetAll(email);
            foreach (UserDTO user in userList)
            {
                if(user.PasswordHash == PasswordHash)
                {
                    return user;
                }
            }
            return null;
            
        }

      
        public void SaveNewUser(UserDTO newUser)
        { 
            this.clientContext.Users.Add(newUser);
            this.clientContext.SaveChanges();
        }

        public void DeleteUser(UserDTO user)
        {
            this.clientContext.Users.Add(user);
            this.clientContext.SaveChanges();
        }

    }
}
