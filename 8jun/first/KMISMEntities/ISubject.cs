using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMISMEntities
{
   public interface ISubject
    {
        Nullable<int> SubjectID { get; set; }

        Subject Subject { get; set; }
    }
}
