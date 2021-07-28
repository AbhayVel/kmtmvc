using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace KmiEntities
{


   public class UserPrinsiple : IPrincipal
    {
        private LoginUser _loginUser;

        public LoginUser LoginUser
        {
            get {
                
                if(_loginUser == null)
                {
                    _loginUser= Identity as LoginUser;
                }
                return _loginUser;
              }
            
        }

        public IIdentity Identity { get; set; }

        public bool IsInRole(string role)
        {
            var strArray = role.Split(',').Select(x=>x.Trim().ToLower()).ToArray();


           return strArray.Contains(LoginUser.Role.Trim().ToLower());
             
        }
    }

    [Table("LoginUser")]
  public  class LoginUser : IIdentity    {

        public int Id { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string Name
        {
            get { return UserName; }
            set { UserName = value; }
        }


        public string UserName { get; set; }

        
        public string Password { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string AuthenticationType { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public bool IsAuthenticated { get; set; }


        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public DateTime LogginTime { get; set; }


    }
}
