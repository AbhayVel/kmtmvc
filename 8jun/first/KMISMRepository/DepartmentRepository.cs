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
 public   class DepartmentRepository
    {

        string _departmentQuery = "SELECT   S.[id],[FirstName],[LastName],[Doj],[Age],[DepartmentID],Ts.Id,TS.Name  FROM [students].[dbo].[TblStudents] s Left Join TblDepartments Ts  On s.DepartmentID=Ts.Id";
        string _departmentCountQuery = "SELECT  Count(1) as CountValue  FROM [students].[dbo].[TblStudents] s Left Join TblDepartments Ts  On s.DepartmentID=Ts.Id";

        public StudentDBContext StudentDBContext { get; set; }
        public DepartmentRepository()
        {
            StudentDBContext = new StudentDBContext();
        }

        public Department GetDepartmentById(int id)
        {
            var Department = this.StudentDBContext.DepartmentDbSet.FirstOrDefault(x => x.Id == id);
            return Department;
        }

        public void BindDepartment<T>(List<T> enitityList) where T : IDepartment
        {

            //var lstStbjectId = enitityList.Where(x => x.DepartmentID.HasValue && x.DepartmentID > 0).Select(x => x.DepartmentID).ToList();
            //var subList = GetAllDepartments();
            //foreach (var item in enitityList)
            //{
            //    item.Department = subList.FirstOrDefault(x => x.Id == item.DepartmentID.Value);
            //}
        }

        public List<Department> GetAllDepartments()
        {
            var lstDepartment = this.StudentDBContext.DepartmentDbSet.ToList();

            return lstDepartment;

        }
         
         
    }
}
