using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_First.Controllers
{
    public class FileUploadController : Base
    {
        // GET: Sample
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DownLoad()
        {

            string serverFileName = Path.Combine(Server.MapPath("~/files"), "school.jpg");

           // System.IO.FileStream obj = System.IO.File.OpenRead(serverFileName);

            return File(serverFileName, "image/jpeg", "school.jpg");
        }

        public ActionResult Save(HttpPostedFileBase fileUpload)
        {
            if(fileUpload!=null && fileUpload.ContentLength > 0)
            {
                string serverPath = Path.Combine(Server.MapPath("~/files"), Path.GetFileName(fileUpload.FileName));
                fileUpload.SaveAs(serverPath);

                ViewBag.message = "FIle is Uploaded";

            }

            return View("Index");
        }


    }
}