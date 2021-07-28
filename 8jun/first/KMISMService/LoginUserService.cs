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
   public class LoginUserService
    {
        
        public LoginUserRepository LoginUserRepository { get; set; }
                
        public LoginUserService(LoginUserRepository loginUserRepository)
        {
            LoginUserRepository = loginUserRepository;
        }

        public List<LoginUser> GetAllLoginUsersForDropDown()
        {
            var lstLoginUser = GetAllLoginUsers();
            lstLoginUser.Insert(0, new LoginUser
            {
                Id = KMIConstants.DropDownValue,
                Name = KMIConstants.DropDownText
            });
            return lstLoginUser;
        }


        public List<LoginUser> GetAllLoginUsers()
        {

            return LoginUserRepository.GetAllLoginUsers();
        }


        public LoginUser GetLoginUserByName(string name)
        {
            LoginUser LoginUser = LoginUserRepository.GetLoginUserByName(name);
            return LoginUser;
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
