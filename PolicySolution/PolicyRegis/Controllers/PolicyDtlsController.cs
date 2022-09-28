using Microsoft.AspNetCore.Mvc;
using PolicyModels;
using PolicyService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PolicyRegis.Controllers
{
    public class PolicyDtlsController : Controller
    {
        [HttpPost]
        [HttpGet]
        public IActionResult Index(PolicySearch policySearch)
        {
            var PolService = new PolicyDtlsService();
            IEnumerable<PolicyDtls> lst = PolService.GetList();
            lst = policySearch.GetWhere(lst);
            lst = policySearch.GetOrderBy(lst);
            lst = policySearch.GetPagination(lst);
            ViewBag.policySearch = policySearch;
            return View(lst.ToList());
        }
    }
}
