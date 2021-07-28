using CheckDatabaseFromEF;
using KMIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Sample_WebApi.Controllers
{

   // [AuthAPiFilter]
    public class UserApiController : ApiController
    {
        // GET: api/UserApi

      //  [DataContract]
        public IHttpActionResult GetData()
        {

            UserService userService = new UserService();

            var data = userService.GetAll();

            return Json(data);
        }





        [Route("user/data")]
        public  IHttpActionResult Get()
        {

            UserService userService = new UserService();
            var data= userService.GetAll();
            return Ok( data);
        }


        [HttpPost]
        public IHttpActionResult Save([FromBody] User user)
        {

          UserService userService = new UserService();

            var dbUser = userService.GetById(user.Id);
            if (dbUser == null)
            {
                return NotFound();
            }
            //User u2 = new CheckDatabaseFromEF.User();
            //bool v = ActionContext.TryBindStrongModel<User>(Modelu2);
            dbUser.Age = user.Age;
            userService.Save(user.Id, dbUser);
            return Ok(dbUser);
        }


        // GET: api/UserApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UserApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UserApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserApi/5

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {

            UserService userService = new UserService();
            var user = userService.GetById(id);
            if (user == null)
            {
                return NotFound();
            }

            var isDeleted = userService.Delete(user);

            return Ok(isDeleted) ;
        }
    }
}
