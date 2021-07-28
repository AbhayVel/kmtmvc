using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSecond
{
    public partial class WrokDayContext
    {

        public virtual List<Subject> GetSubject(Nullable<int> id, string name)
        {
            var idParameter = id.HasValue ?
                new SqlParameter("id", id) :
                new SqlParameter("id", typeof(int));


            var nameParameter =
               new SqlParameter("name", name);
            return this.Database.SqlQuery<Subject>("GetSubject @id , @name", idParameter, nameParameter).ToList();
        }
    }
}
