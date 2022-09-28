using PolicyModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolicyService
{
    public class PolicyDtlsService
    {
        public List<PolicyDtls> GetList()
        {
            List<PolicyDtls> list = new List<PolicyDtls>();
            list.Add(new PolicyDtls()
            {
                RecID = 1,
                CustID = "12",
                Policyname = "Raj",
                PolicyStatus = "bbb"
               

            }); list.Add(new PolicyDtls()
            {
                RecID = 2,
                CustID = "12",
                Policyname = "Raja",
                PolicyStatus = "bbb"
            }); list.Add(new PolicyDtls()
            {
                RecID = 3,
                CustID = "12",
                Policyname = "Ramesh",
                PolicyStatus = "bbb"

            });

            return list;
        }
    }
}

