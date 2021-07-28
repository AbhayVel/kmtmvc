using Demo.filters;
using KMISMEntities;
using KMISMModels;
using KMISMService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using System.Web.Security;
namespace Demo.Controllers
{

    
    
    [EnableCors("*","*","*")]
    public class StudentsController : ApiController
    {
        public StudentService StudentService { get; set; }
        public SubjectService SubjectService { get; set; }
        public StudentsController(StudentService studentService, SubjectService subjectService)
        {
            StudentService = studentService;
            SubjectService = subjectService;
        }
        // GET: Student

        int i = 0;



        [QdnAuthrizedApiFilter(Role = "Admin,Sales,Trainer")]
        public IHttpActionResult Index(StudentSearchModel studentSearch)
        {

          
            if (studentSearch == null)
            {
                studentSearch = new StudentSearchModel();
            }
                //var k = 1 / i;
                List<Student> lstStudent = StudentService.GetStudents(studentSearch);

            studentSearch.StudentList = lstStudent;
               
                return Ok(studentSearch);         
        }




        [QdnAuthrizedApiFilter(Role = "Admin,Sales")]
        public IHttpActionResult Save(Student student)
        {
            if (ModelState.IsValid)
            {
               student= StudentService.SaveStudent(student);
               return BadRequest();
            }
            
            return Ok(student);
        }

         
        public IHttpActionResult Add()
        {
            Student student = new Student();
            setSubject(student);
            return Ok(student);
        }


         
     
        public IHttpActionResult Edit(int id)
        {
            Student student = StudentService.GetStudentById(id);
            if (student == null)
            {
                student = new Student();
            }           
            setSubject(student);
            return Ok(student);
        }
        private void setSubject(Student student)
        {
            List<Subject> lstSubject = SubjectService.GetAllSubjectsForDropDown();
            
            
        }


        
        public IHttpActionResult Delete(int id)
        {
            this.StudentService.DeleteStudentById(id);
            return Ok();
        }
    }
}