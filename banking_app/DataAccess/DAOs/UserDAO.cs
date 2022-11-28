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

        // dont need to getall list, or save new client or delete of clients (this is in the bank context which is not in the scope of our project)
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
