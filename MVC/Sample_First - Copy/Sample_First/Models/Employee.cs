using ConsoleAppFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sample_First.Models
{
    public class Employee
    {

        [Display(Name = "Employee Id")]
        public int Id { get; set; }


        
        [Required]
        [MinLength(5, ErrorMessage ="User Name should have at least 5 alphabets")]
        [MaxLength(10, ErrorMessage = "User Name should have max 10 alphabets")]
        public string Name { get; set; }


        public int Age { get; set; }

    }
}