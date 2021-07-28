using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class TESTController : Controller
    {
        // GET: TEST
        public ActionResult Index()
        {
            return View();
        }

        // GET: TEST/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TEST/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TEST/Create
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

        // GET: TEST/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TEST/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TEST/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TEST/Delete/5
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
