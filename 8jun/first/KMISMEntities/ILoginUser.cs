using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMISMEntities
{
   public interface ILoginUser
    {
        Nullable<int> LoginUserID { get; set; }

        LoginUser LoginUser { get; set; }
    }
}
