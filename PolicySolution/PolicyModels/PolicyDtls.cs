using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PolicyModels
{
	public   class PolicyDtls
    {

		[Required]
		[Range(4,500)]
		

        public int RecID { get; set; }

		[Required]
		[MinLength(3)]
		public string CustID { get; set; }
		[Required]
		[RegularExpression("[A-Z a-z ]{3,10}")]
		public string Policyname{ get; set; }
		public string PolicyStatus { get; set; }
		
	}
}
