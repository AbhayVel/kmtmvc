using KMISMEntities;
using KMISMService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Demo.Controllers
{
    public class LoginController : Base
    {

        public LoginUserService LoginUserService { get; set; }
        public  LoginController(LoginUserService loginUserService)
        {
            LoginUserService = loginUserService;

        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(LoginUser loginUser, string keepmelogin)
        {


            if (ModelState.IsValid)
            {

                loginUser=     LoginUserService.GetLoginUserByName(loginUser.Name);
                loginUser.Password = "";
                Session["userName"] = loginUser;

                loginUser.IsAuthenticated = true;
               string loginUserString=     JsonConvert.SerializeObject(loginUser);

                var dateExpired = DateTime.Now.AddMinutes(30);
                bool isPersis = false;

                if(!string.IsNullOrWhiteSpace(keepmelogin) && "yes".Equals(keepmelogin))
                {
                    isPersis = true;
                    dateExpired = DateTime.Now.AddDays(100);
                }

                FormsAuthenticationTicket fa = new FormsAuthenticationTicket(1, "userdata", DateTime.Now, dateExpired, isPersis, loginUserString, "/");
               var loginUserStringEncrypt= FormsAuthentication.Encrypt(fa);
                var hc = new HttpCookie("SessionUser", loginUserStringEncrypt);
                hc.Expires = dateExpired;               
                Response.Cookies.Add(hc);
                FormsAuthentication.SetAuthCookie(loginUser.Name, isPersis);
                return RedirectToRoute(new
                {
                    Controller = "Student",
                    Action = "Index"
                });

            }



            //if("admin".Equals(userName) && "abc".Equals(password))
            //{
            //    Session["userName"] = userName;
            //    return RedirectToRoute(new
            //    {
            //        Controller = "Student",
            //        Action = "Index"
            //    });
            //}
            //else if ("sales".Equals(userName) && "abc".Equals(password))
            //{
            //    Session["userName"] = userName;
            //    return RedirectToRoute(new
            //    {
            //        Controller = "Student",
            //        Action = "Index"
            //    });
            //}


            return View("Index");
        }
    }
}