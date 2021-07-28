using KMISMEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using KMISMModels;
using KMISMDBContext;

namespace KMISMRepository
{
 public   class SubjectRepository
    {

        string _studentQuery = "SELECT   S.[id],[FirstName],[LastName],[Doj],[Age],[SubjectID],Ts.Id,TS.Name  FROM [students].[dbo].[TblStudents] s Left Join TblSubjects Ts  On s.SubjectID=Ts.Id";
        string _studentCountQuery = "SELECT  Count(1) as CountValue  FROM [students].[dbo].[TblStudents] s Left Join TblSubjects Ts  On s.SubjectID=Ts.Id";

        public StudentDBContext StudentDBContext { get; set; }
        public SubjectRepository()
        {
            StudentDBContext = new StudentDBContext();
        }

        public Subject GetSubjectById(int id)
        {
            var Subject = this.StudentDBContext.SubjectDbSet.FirstOrDefault(x => x.Id == id);
            return Subject;
        }

        public void BindSubject<T>(List<T> enitityList) where T : ISubject
        {

            var lstStbjectId = enitityList.Where(x => x.SubjectID.HasValue && x.SubjectID > 0).Select(x => x.SubjectID).ToList();
            var subList = GetAllSubjects();
            foreach (var item in enitityList)
            {
                item.Subject = subList.FirstOrDefault(x => x.Id == item.SubjectID.Value);
            }
        }

        public List<Subject> GetAllSubjects()
        {
            var lstSubject = this.StudentDBContext.SubjectDbSet.ToList();

            return lstSubject;

        }
         
         
    }
}
