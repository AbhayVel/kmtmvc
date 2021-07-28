using KMISMEntities;
using KMISMService;
using KmiUtitlity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using System.Web.Security;

namespace Demo.Controllers
{

   
    public class LoginApiController : ApiController
    {

        public LoginUserService LoginUserService { get; set; }
        public  LoginApiController(LoginUserService loginUserService)
        {
            LoginUserService = loginUserService;

        }
        // GET: Login
         


   
        public IHttpActionResult Login(LoginUser loginUser)
        {


            if (ModelState.IsValid)
            {

                loginUser=     LoginUserService.GetLoginUserByName(loginUser.Name);
                loginUser.Password = "";               
                loginUser.IsAuthenticated = true;
                loginUser.ExpiryDateTime = DateTime.Now.AddMinutes(30);
                string loginUserString=     JsonConvert.SerializeObject(loginUser);
                string loginUserStringEncr = EncryptDecrypt.Encrypt(loginUserString, "1234567890123456");

                return Ok(loginUserStringEncr);




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


            return Content(System.Net.HttpStatusCode.NotFound, "User ot Found");
        }
    }
}