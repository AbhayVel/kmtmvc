using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMISMEntities
{

    [Table("TblStudents")]
  public  class Student : ISubject
    {


        
        [Key]
        public Nullable<int> Id { get; set; }

       
        [Display(Name ="First Name")]
        [Required(ErrorMessage ="Please enter First Name")]
        public string FirstName { get; set; }


        [RegularExpression("[A-Za-z]{2,20}", ErrorMessage = "Please enter  proper Last Name")]
        public string LastName { get; set; }
        public Nullable<System.DateTime> Doj { get; set; }

        [Range(10,60)]
        public Nullable<decimal> Age { get; set; }



        [Display(Name ="Subject Name")]
       
        [ForeignKey("Subject")]
        public Nullable<int> SubjectID { get; set; }

        public virtual Subject Subject { get; set; }
    }


}
