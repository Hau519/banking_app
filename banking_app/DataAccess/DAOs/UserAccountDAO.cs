using banking_app.DataAccess.Contexts;
using banking_app.DataAccess.Dtos;
using banking_app.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app.DataAccess.DAOs
{
    public class UserAccountDAO : IDao
    {
        private ProjectContext context;

        public UserAccountDAO(ProjectContext context)
        {
            this.context = context;
        }

        public List<AccountDTO> GetAccountOfAnUser(int UserID)
        {
            List<UserAccountDTO> userAccounts = this.context.UserAccounts
                .Where(userAccount => userAccount.UserId == UserID)
                .Include(userAccount => userAccount.Account)
                .ToList();

            List<AccountDTO> accounts = new List<AccountDTO>();
            foreach (UserAccountDTO userAccount in userAccounts)
            {
                accounts.Add(userAccount.Account);
            }
            return accounts; 
        }

        public List<UserDTO> GetUserOfAnAccount(int accountNumber)
        {
            List<UserAccountDTO> userAccounts = this.context.UserAccounts
                .Where(userAccount => userAccount.AccountNumber == accountNumber)
                .Include(userAccount => userAccount.User)
                .ToList();

            List<UserDTO> users = new List<UserDTO>();
            foreach (UserAccountDTO userAccount in userAccounts)
            {
                users.Add(userAccount.User);
            }
            return users;
        }
        
    }
}
