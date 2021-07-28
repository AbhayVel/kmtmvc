using KMISMEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Subject
        public ActionResult Index()
        {
            List<Subject> lstSubject = new List<Subject>();

            lstSubject.Add(new Subject
            {
                Id = 1,
                Name = "Angular"
            });

            lstSubject.Add(new Subject
            {
                Id = 2,
                Name = "React"
            });

            lstSubject.Add(new Subject
            {
                Id = 3,
                Name = "MVC"
            });
            return View(lstSubject);
        }
    }
}