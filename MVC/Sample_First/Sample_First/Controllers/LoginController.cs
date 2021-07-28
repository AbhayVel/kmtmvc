using KmiEntities;
using KMIRepository;
using KMIService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Sample_First.Controllers
{
    public class LoginController : Controller
    {

        public LoginUserService LoginUserService { get; set; }
        public LoginController(LoginUserService loginUserService)
        {
            LoginUserService = loginUserService;
        }
        // GET: Login
        public ActionResult Index()
        {

            //Asscation can achive  3 ways. 
            //Asscation +Interface => DI Dependency Inversion 
            //Asscation +Abstract Class => DI Dependency Inversion 
            // Dependecy Injection  -> Compile TIme
            //Service locator --> Run time 
            //DI Dependency Inversion  + Third party system to create Object= IOC
            //LoginUser2Repository lur2 = new LoginUser2Repository();
            //LoginUserRepository lur = new LoginUserRepository();

            //SendEmailRepository ser = new SendEmailRepository();

            //SendSmsRepository ssr = new SendSmsRepository();
            //LoginUserService ls1 = new LoginUserService(null,null);
            //ls1.LoginUserRepository = lur;  //property based 
            //LoginUserService ls2 = new LoginUserService(lur, ssr);  //constroctor based 
            //if (User.hasMobile)
            //{
            //    ls2 = new LoginUserService(lur, ssr);
            //} else
            //{
            //    ls2 = new LoginUserService(lur, ser);
            //}
            //LoginUserService ls3 = new LoginUserService(null, ser);
            //ls3.SetLoginUserRepository(lur2);  //method based

            return View(new LoginUser());
        }


        public void Test()
        {
            //LoginUser2Repository lur2 = new LoginUser2Repository();
            //LoginUserRepository lur = new LoginUserRepository();

            //SendEmailRepository ser = new SendEmailRepository();

            //SendSmsRepository ssr = new SendSmsRepository();
            //LoginUserService ls1 = new LoginUserService(null, null);
            //ls1.LoginUserRepository = lur;  //property based 
            //LoginUserService ls2 = new LoginUserService(lur, ssr);  //constroctor based 
            //if (User.hasMobile)
            //{
            //    ls2 = new LoginUserService(lur, ssr);
            //}
            //else
            //{
            //    ls2 = new LoginUserService(lur, ser);
            //}
            //LoginUserService ls3 = new LoginUserService(null, ser);
            //ls3.SetLoginUserRepository(lur2);  //method based
        }

         

            public ActionResult Logout()
        {
            Response.Cookies.Clear();
            Session["userDetail"] = null;
            FormsAuthentication.SignOut();
            return View("Index",new LoginUser());
        }

            [HttpPost]
        public ActionResult Login(LoginUser loginUser)
        {
        var loginCheckUser=    LoginUserService.GetLoginUser(loginUser.UserName);

            if (loginCheckUser!= null && loginCheckUser.Password.Equals(loginUser.Password))
            {
                loginCheckUser.IsAuthenticated = true;

                var userstring=     JsonConvert.SerializeObject(loginCheckUser);

                FormsAuthenticationTicket fa = new FormsAuthenticationTicket(1, "userRole", DateTime.Now, DateTime.Now.AddMinutes(30), false, userstring);

                var encrypt = FormsAuthentication.Encrypt(fa);

                Response.Cookies.Add(new HttpCookie("userRole", encrypt));

                FormsAuthentication.SetAuthCookie(loginUser.UserName, false);
                Session["userDetail"] = loginCheckUser;

                return Redirect("/user/index");
            }
            else
            {
                ViewBag.message = "User Name or Passowrd does not match";
            }

            loginUser.Password = "";
            return View("index",loginUser);
        }



    }
}