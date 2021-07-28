using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSecond
{

    [Table("Department")]
  public  class Department
    {

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
