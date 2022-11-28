using banking_app.DataAccess.Contexts;
using banking_app.DataAccess.DAOs;
using banking_app.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app.Business.Service
{
    public class AccountService : IService
    {
        private AccountDAO accountDAO;
        public AccountService(ClientContext dbContext)
        {
            this.accountDAO = new AccountDAO(dbContext);
        }
    }
}
