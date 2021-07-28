using CheckDatabaseFromEF;
using KmiEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMIRepository
{
    public class LoginUserRepository : ILoginUserRepository
    {

        public LoginUserRepository()
        {
            WorkdayContext = new WorkdayContext();
        }

        public WorkdayContext WorkdayContext { get; set; }

        public LoginUser GetLoginUser(string userName)
        {


            LoginUser loginUser = WorkdayContext.LoginUser.FirstOrDefault(x => x.UserName == userName);



            return loginUser;
        }

    }
}
