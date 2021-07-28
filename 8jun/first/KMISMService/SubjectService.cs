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
   public class SubjectService
    {
        
        public SubjectRepository SubjectRepository { get; set; }
                
        public SubjectService(SubjectRepository subjectRepository)
        {
            SubjectRepository = subjectRepository;
        }

        public List<Subject> GetAllSubjectsForDropDown()
        {
            var lstSubject = GetAllSubjects();
            lstSubject.Insert(0, new Subject
            {
                Id = KMIConstants.DropDownValue,
                Name = KMIConstants.DropDownText
            });
            return lstSubject;
        }


        public List<Subject> GetAllSubjects()
        {

            return SubjectRepository.GetAllSubjects();
        }

        
        public Subject GetSubjectById(int id)
        {
            Subject Subject = SubjectRepository.GetSubjectById(id);
            return  Subject;
        }

        //public List<Subject> GetSubjects(SubjectSearchModel SubjectSearch)
        //{
        //    var lstSubject= SubjectRepository.GetSubjects(SubjectSearch);
        //    SubjectRepository.BindSubject(lstSubject);
        //    return SubjectRepository.GetSubjects(SubjectSearch);
        //}
    }
}
