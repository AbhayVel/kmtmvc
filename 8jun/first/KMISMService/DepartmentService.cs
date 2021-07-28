using KMISMEntities;
using KMISMModels;
using KMISMRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMISMService
{
   public class Department
    {
        
        public LoginUserRepository LoginUserRepository { get; set; }

        
        public Department(LoginUserRepository LoginUserRepository)
        {
            LoginUserRepository = LoginUserRepository;
        }
        public List<LoginUser> GetAllLoginUsers()
        {

            return LoginUserRepository.GetAllLoginUsers();
        }

        
        public LoginUser GetLoginUserById(int id)
        {
            LoginUser LoginUser = LoginUserRepository.GetLoginUserById(id);
            return  LoginUser;
        }

        //public List<LoginUser> GetLoginUsers(LoginUserSearchModel LoginUserSearch)
        //{
        //    var lstLoginUser= LoginUserRepository.GetLoginUsers(LoginUserSearch);
        //    LoginUserRepository.BindLoginUser(lstLoginUser);
        //    return LoginUserRepository.GetLoginUsers(LoginUserSearch);
        //}
    }
}
