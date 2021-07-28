using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSecond
{
    [Table("User")]
    public partial class UserData
    {

        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<decimal> Age { get; set; }
        public Nullable<int> Dept_Id { get; set; }
        public string Gender { get; set; }
        public string address { get; set; }
    }
}
