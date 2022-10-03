using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PolicyModels
{
    public class CustomerDetails
    {
		public int RecID { get; set; }
        public string CustID { get; set; }
		[Required]
		[RegularExpression("[A-Za-z']")]
		public string FName { get; set; }
		[Required]
		public string Mname { get; set; }
		[Required]
		public string Lname { get; set; }
		[RegularExpression("[]")]
		public string DOB { get; set; }
        [RegularExpression("^(987)[0-9]")]
        public string MobNo { get; set; }
		public string TelNo { get; set; }

		[EmailAddress]
		[RegularExpression("[]")]
		public string EmailId1 { get; set; }
		public string EmailId2 { get; set; }
		public string PanNo { get; set; }
		public string MotherName { get; set; }
		public string QualificationDetails { get; set; }
		public string MaritalStatus { get; set; }
		public string NomineeName { get; set; }
		public string NomineeAge { get; set; }
		public string NomineeContNo { get; set; }
		public string CreatedBy { get; set; }
		public string CreatedDt { get; set; }
		public string UpdatedBy { get; set; }
		public string UpdatedDt { get; set; }
		public string Status { get; set; }
    }
	public enum Gender
	{
		Male,
		Female
	}
}
