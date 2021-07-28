using KMISMEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace KMISMModels
{
  public  class LoginUserModel : IPrincipal
    {
        LoginUser _loginUser;
        string _role;
        public IIdentity Identity { get
            {
                return _loginUser;
            }
            set
            {

                _loginUser = value as LoginUser;
                _role= _loginUser.Role.ToLower().Trim();

            }
        }

        public bool IsInRole(string role)
        {

           role=  role.ToLower();
         List<string> lst=   role.Split(new char[] { ',' }).Select(x => x.Trim()).ToList();
            if (lst.Contains(_role))
            {
                return true;
            } else
            {
                return false;
            }


            

        }
    }
}
