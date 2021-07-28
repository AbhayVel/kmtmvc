using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace KMISMEntities
{

    [Table("TblLoginUser")]
    public class LoginUser : IIdentity
    {


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }



        [Required]
        [Column("UserName")]
        public string Name { get; set; }


        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Role { get; set; }


        [NotMapped]
        public string AuthenticationType { get; set; }


        [NotMapped]
        public bool IsAuthenticated { get; set; }


        [NotMapped]
        public DateTime ExpiryDateTime { get; set; }
    }
}
