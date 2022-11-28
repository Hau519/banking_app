using banking_app.DataAccess.Contexts;
using banking_app.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_app.Business.Service
{
    public class MainService
    {
        //central point
        private ClientContext clientContext;
        private UserService userService;
        private static MainService INSTANCE = null;
        protected MainService()
        {

            this.clientContext = new ClientContext();
            this.userService = new UserService(this.clientContext);

        }

        public static MainService getInstance()
        {
            if (INSTANCE is null)
            {
                INSTANCE = new MainService();
            }
            return INSTANCE;

        }

        public UserService GetUserService()
        {
            return this.userService;
        }

        public void OpenMainWindow()
        {
            
            Application.Run(new homeForm());
        }

        public void ExitApplication()
        {
            Application.Exit();
        }


    }
}
