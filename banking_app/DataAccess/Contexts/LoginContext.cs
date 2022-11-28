using banking_app.DataAccess.Dtos;
using banking_app.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app.DataAccess.Contexts
{
    public class LoginContext: DbContext
    {
        public DbSet<UserDTO> Users { get; set; }

        public DbSet<StatusDTO> Statuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQL2019EXPRESS;Database=banking_db;Integrated security=true;TrustServerCertificate=true;");
        }

       /* DbSet<UserDTO> IContext<UserDTO>.GetDbSet()
        {
            return this.Users;
        }

        DbSet<StatusDTO> IContext<StatusDTO>.GetDbSet()
        {
            return this.Statuses;
        }*/
   

     
    }
}
