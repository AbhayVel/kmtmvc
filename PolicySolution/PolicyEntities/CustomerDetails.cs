using System;
using System.Collections.Generic;
using System.Text;

namespace PolicyEntities
{
	public class CustomerDetails
    {
		public int  RecID { get; set; }
		public string  CustID { get; set; }
		public string FName { get; set; }
		public string Mname{ get; set; }
		public string Lname { get; set; }
		public string DOB { get; set; }
		public string MobNo{ get; set; }
		public string TelNo { get; set; }
		public string EmailId1{ get; set; }
		public string EmailId2 { get; set; }
		public string PanNo { get; set; }
		public string MotherName { get; set; }
		public string QualificationDetails { get; set; }
		public string MaritalStatus { get; set; }
		public string NomineeName { get; set; }
		public string NomineeAge { get; set; }
		public string NomineeContNo { get; set; }
		public string CreatedBy{ get; set; }
		public string CreatedDt{ get; set; }
		public string UpdatedBy{ get; set; }
		public string UpdatedDt { get; set; }
		public string Status { get; set; }
	}
}
