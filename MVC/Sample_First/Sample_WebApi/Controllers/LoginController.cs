using KmiEntities;
using KMIRepository;
using KMIService;
using KmiUtitlity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static KmiUtitlity.EncryptDecrypt;

namespace Sample_WebApi.Controllers
{
    public class LoginController : ApiController
    {
        public LoginUserService LoginUserService { get; set; }
        public LoginController()
        {
            ILoginUserRepository loginUserRepository = new LoginUserRepository();

            ISendRepository sendRepository = new SendEmailRepository();
            LoginUserService = new LoginUserService(loginUserRepository, sendRepository);
        }

         


        [HttpPost]
        public IHttpActionResult Login(LoginUser loginUser)
        {
            var loginCheckUser = LoginUserService.GetLoginUser(loginUser.UserName);

            if (loginCheckUser == null || !loginCheckUser.Password.Equals(loginUser.Password))
            {

                return Unauthorized();
            }
            loginCheckUser.Password = "";
            loginCheckUser.LogginTime = DateTime.Now;
                var userstring = JsonConvert.SerializeObject(loginCheckUser);

           var userencstring= CryptoEngine.Encrypt(userstring, "sbab-3hn8-sqoy19");

            return Ok(userencstring);
        }
    }
}
