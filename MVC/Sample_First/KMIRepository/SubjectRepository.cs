using CheckDatabaseFromEF;
using KmiEntities;
using KmIDbContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMIRepository
{
   public class SubjectRepository
    {

         public SubjectRepository()
        {
            WorkdayContext = new WorkdayContext();
        }

        public WorkdayContext WorkdayContext { get; set; }
        public List<Subject> GetAll()
        {
           
            var subjectList = WorkdayContext.GetSubject(0);
            return subjectList;
        }


        public List<Subject> GetById(int id)
        {

            var subjectList = WorkdayContext.GetSubject(id);
            return subjectList;
        }



    }
}
