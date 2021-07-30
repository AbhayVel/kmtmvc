using Demo.filters;
using KMISMEntities;
using KMISMModels;
using KMISMService;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Demo.Controllers
{

    [QdnAuthenticationFilter]
    [QDNREsultFilter]
    [QDNActionFilterAttribute]
    public class StudentController : AuthenticateController
    {
        public StudentService StudentService { get; set; }
        public SubjectService SubjectService { get; set; }
        public StudentController(StudentService studentService, SubjectService subjectService)
        {
            StudentService = studentService;
            SubjectService = subjectService;
        }
        // GET: Student

        int i = 0;

        [QdnAuthrizedFilter(Role = "Admin,Sales,Trainer")]
        public ActionResult Index(StudentSearchModel studentSearch)
        {
            
                //var k = 1 / i;
                List<Student> lstStudent = StudentService.GetStudents(studentSearch);
                ViewBag.search = studentSearch;
                return View(lstStudent);         
        }


        [QdnAuthrizedFilter(Role = "Admin,Sales")]
        [HttpPost]
        public ActionResult Save(Student student)
        {
            if (ModelState.IsValid)
            {
               student= StudentService.SaveStudent(student);
               return Redirect("/student/index");
            }
            setSubject(student);
            return View("Edit" ,student);
        }

        [QdnAuthrizedFilter(Role = "Admin,Sales")]
        public ActionResult Add()
        {
            Student student = new Student();
            setSubject(student);
            return View("Edit",student);
        }


        [QdnAuthrizedFilter(Role="Admin,Sales")]
        public ActionResult Edit(int id)
        {
            Student student = StudentService.GetStudentById(id);
            if (student == null)
            {
                student = new Student();
            }           
            setSubject(student);
            return View(student);
        }
        private void setSubject(Student student)
        {
            List<Subject> lstSubject = SubjectService.GetAllSubjectsForDropDown();
            var SelectedList = new SelectList(lstSubject, "Id", "Name", student.SubjectID);
            ViewBag.SubjectList = SelectedList.ToList();
        }


        [QdnAuthrizedFilter(Role = "Admin")]
        public ActionResult Delete(int id)
        {
            this.StudentService.DeleteStudentById(id);
            return Redirect("/student/index");
        }
    }
}