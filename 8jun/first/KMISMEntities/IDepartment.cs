using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMISMEntities
{
   public interface IDepartment
    {
        Nullable<int> DepartmentID { get; set; }

        LoginUser Department { get; set; }
    }
}
