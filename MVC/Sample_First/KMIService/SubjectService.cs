using CheckDatabaseFromEF;
using KmiEntities;
using KMIRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMIService
{
  public   class SubjectService
    {

        public SubjectRepository SubjectRepository { get; set; }
        public SubjectService()
        {
            SubjectRepository = new SubjectRepository();
        }
        public List<Subject> GetAll()
        {
            var subjectList = SubjectRepository.GetAll();
            return subjectList;
        }

        public List<Subject> GetById(int id)
        {
            var subjectList = SubjectRepository.GetById(id);
            return subjectList;
        }

    }
}
