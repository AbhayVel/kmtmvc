using CheckDatabaseFromEF;
using KmiEntities;
using KMIService;
using Newtonsoft.Json;
using Sample_First.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Sample_First.Controllers
{
    public class UserController : Base
    {

        public UserService UserService { get; set; }
        public SubjectService SubjectService { get; set; }
        public UserController(UserService userService, SubjectService subjectService)
        {
            UserService = userService;

            SubjectService = subjectService;
        }



        public List<User> Call()
        {
            HttpClient httpClient = new HttpClient();

            var response = httpClient.GetAsync("https://localhost:44397/api/userapi/getdata");
            response.Wait();

            var output = response.Result;

            if (output.IsSuccessStatusCode)
            {

                var outPutTask = output.Content.ReadAsStringAsync();
                outPutTask.Wait();
                var data = outPutTask.Result;

                List<User> UserList = JsonConvert.DeserializeObject<List<User>>(data);

                return UserList;
            }


            return null;
            
        }

         

        // GET: User
        public ActionResult Index(UserSearch userSearch)
        {

         //var lstSubject=   SubjectService.GetAll();

          //  var subjectData = SubjectService.GetById(1);
            // ViewData
            ViewBag.Data2 = "Check";
            TempData["Data"] = 0;
            if (userSearch == null)
            {
                userSearch = new UserSearch();
            }

             
            var count = UserService.GetCount(userSearch);


            ViewBag.count = count;
            ViewBag.currentPage = 1;
            var userList = UserService.GetAll(userSearch);
            return View("Index", userList);
        }

        public ActionResult Search(UserSearch userSearch)
        {
            if (userSearch == null)
            {
                userSearch = new UserSearch();
            }
            
            return PartialView(userSearch);
        }

        [HttpPost]
        public ActionResult SearchListAjax(UserSearch userSearch)
        {

    
            var data2 = ViewBag.Data2;
            var data = TempData["Data"];

            if (Convert.ToInt32(data) < 2)
            {
                TempData["Data"] = Convert.ToInt32(data)+1;
            }
           

            if (userSearch == null)
            {
                userSearch = new UserSearch();
            }

            if (userSearch.PageNumber == 0)
            {
                userSearch.PageNumber = 1;
            }
            
            var count = UserService.GetCount(userSearch);

            Session["UserName"] = "aaa";

            ViewBag.count = count;

            ViewBag.currentPage = userSearch.PageNumber;

            var userList = UserService.GetAll(userSearch);
            return PartialView("SearchListAjax", userList);
        }


        [HttpPost]
        public ActionResult SearchList(UserSearch userSearch)
        {
            if (userSearch == null)
            {
                userSearch = new UserSearch();
            }
            userSearch.PageNumber = 1;
            var count = UserService.GetCount(userSearch);

            

            ViewBag.count = count;

            ViewBag.currentPage=  userSearch.PageNumber;

            var userList = UserService.GetAll(userSearch);
            return View("Index", userList);
        }


        [HttpGet]
        public ActionResult GetJSON()
        {
            var userList = UserService.GetAll().Select(X=> new
            {
                Id=X.Id,
                X.FirstName,
                X.LastName,
                X.Age,
                X.Dept_Id,
                DeptName=X.Department.Name

            });
            return Json(userList, JsonRequestBehavior.AllowGet);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5

        [AuthorizeAttributeFilter(Data = "Admin,Dept")]
        public ActionResult Add()
        {
            

            return View("Edit", new User());
        }

       



        [AuthorizeAttributeFilter(Data  ="Admin,Dept")]
        public ActionResult Edit(int id)
        {
            var user = UserService.GetById(id);

            return View(user);
        }


        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Submit(int id, CheckDatabaseFromEF.User user)
        {

            return View("Edit", user);
        }

            // POST: User/Edit/5
            [HttpPost]
        public ActionResult Save(int id)
        {

            string[] exclude;

            if (User.IsInRole("Admin"))
            {
                exclude = null;
            }else
            {
                exclude = new string[] { "FirstName" };
            }

            User user = UserService.GetById(id);
            if (user == null)
            {
                user = new User();
            }

           

           


            TryUpdateModel(user, null, null, exclude);

            var user2 = new User();
                user2.FirstName = "a";

             user2.LastName = "s";
         //   bool isValid = TryValidateModel(user2);

            if (ModelState.IsValid)
                {
                  
                    user = UserService.Save(id, user);
                  
                } else
                {
                    
                    return View("Edit",user);
                }

                return RedirectToAction("Index");
            
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
