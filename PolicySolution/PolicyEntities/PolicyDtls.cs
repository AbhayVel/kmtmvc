using System;
using System.Collections.Generic;
using System.Text;

namespace PolicyEntities
{
  public  class PolicyDtls
    {
		public int RecID { get; set; }
		public string CustID { get; set; }
		public string PolicyNo { get; set; }
		public string PolicyStatus { get; set; }
		public string ProductCode { get; set; }
		public string ProductType { get; set; }
		public string ProductName { get; set; }
		public string PolicyTerm { get; set; }
		public string StartDt { get; set; }
		public string EndDt { get; set; }
		public string LOB { get; set; }
		public string PremiumAmt { get; set; }
		public string SumInsured { get; set; }
		public string AgtCode { get; set; }
		public string ModeOfPremium { get; set; }
		public string PolIssuedt { get; set; }
		public string CurrentStatus { get; set; }
		public string AnnualPremium { get; set; }
		public string LastPremiumdt { get; set; }
		public string PremDueDt { get; set; }
		public string PREMIUM_PAYING_TERM { get; set; }
		public string Manager_Code { get; set; }
		public string OFFICE_CD { get; set; }
		public string CHANNEL_ID { get; set; }
		public string CreatedBy { get; set; }
		public string CreatedDt { get; set; }
		public string UpdatedBy { get; set; }
		public string UpdatedDt { get; set; }
	}
}
