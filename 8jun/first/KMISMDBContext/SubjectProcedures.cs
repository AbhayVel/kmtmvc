using KMISMEntities;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace KMISMDBContext
{
   public static  class LoginUserProcedures
    {

        public static LoginUser AddUpdateLoginUser(this StudentDBContext studentDBContext,Nullable<int> id, string name)
        {
            var idParameter = id.HasValue ?
                new  SqlParameter("Id", id) :
                new  SqlParameter("Id", typeof(int));

            var nameParameter = name != null ?
                new SqlParameter("name", name) :
                new SqlParameter("name", typeof(string));

            
         var LoginUser= studentDBContext.LoginUserDbSet.SqlQuery("AddUpdateLoginUser @Id, @name", idParameter, nameParameter).Select(x=>new LoginUser
            {
                Id=x.Id,
                Name=x.Name

            }).FirstOrDefault();

            return LoginUser;
        }
    }
}
