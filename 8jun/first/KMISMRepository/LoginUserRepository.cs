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
 public   class LoginUserRepository
    {

        string _studentQuery = "SELECT   S.[id],[FirstName],[LastName],[Doj],[Age],[LoginUserID],Ts.Id,TS.Name  FROM [students].[dbo].[TblStudents] s Left Join TblLoginUsers Ts  On s.LoginUserID=Ts.Id";
        string _studentCountQuery = "SELECT  Count(1) as CountValue  FROM [students].[dbo].[TblStudents] s Left Join TblLoginUsers Ts  On s.LoginUserID=Ts.Id";

        public StudentDBContext StudentDBContext { get; set; }
        public LoginUserRepository()
        {
            StudentDBContext = new StudentDBContext();
        }

        public LoginUser GetLoginUserById(int id)
        {
            var LoginUser = this.StudentDBContext.LoginUserDbSet.FirstOrDefault(x => x.Id == id);
            return LoginUser;
        }

        public void BindLoginUser<T>(List<T> enitityList) where T : ILoginUser
        {

            var lstStbjectId = enitityList.Where(x => x.LoginUserID.HasValue && x.LoginUserID > 0).Select(x => x.LoginUserID).ToList();
            var subList = GetAllLoginUsers();
            foreach (var item in enitityList)
            {
                item.LoginUser = subList.FirstOrDefault(x => x.Id == item.LoginUserID.Value);
            }
        }

        public LoginUser GetLoginUserByName(string name)
        {
            var LoginUser = this.StudentDBContext.LoginUserDbSet.FirstOrDefault(x => x.Name.Equals(name));
            return LoginUser;
        }

        public List<LoginUser> GetAllLoginUsers()
        {
            var lstLoginUser = this.StudentDBContext.LoginUserDbSet.ToList();

            return lstLoginUser;

        }
         
         
    }
}
