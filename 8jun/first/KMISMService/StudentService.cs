using KMISMEntities;
using KMISMModels;
using KMISMRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMISMService
{
   public class StudentService
    {
        
        public StudentRepository StudentRepository { get; set; }

        public SubjectRepository SubjectRepository { get; set; }
        public StudentService(StudentRepository studentRepository)
        {
            StudentRepository = studentRepository;
            SubjectRepository = new SubjectRepository();
        }
        public List<Student> GetStudents()
        {
            return StudentRepository.GetStudents();
        }
        public List<Student> GetStudents(string columnName, string orderBy)
        {
            if (string.IsNullOrWhiteSpace(columnName))
            {
                columnName = "Id";
            }

            if (string.IsNullOrWhiteSpace(orderBy))
            {
                orderBy = "asc";
            }

            return StudentRepository.GetStudents(columnName, orderBy);
        }

        public Student GetStudentById(int id)
        {
            Student Student = StudentRepository.GetStudentById(id);
            return  Student;
        }

        public List<Student> GetStudents(StudentSearchModel studentSearch)
        {
            var lstStudent= StudentRepository.GetStudents(studentSearch);
            SubjectRepository.BindSubject(lstStudent);
            return lstStudent;
        }

        public Student SaveStudent(Student student)
        {
            student = StudentRepository.SaveStudent(student);
            return student;
        }
        public void DeleteStudentById(int id)
        {
            this.StudentRepository.DeleteStudentById(id);
        }
    }
}
