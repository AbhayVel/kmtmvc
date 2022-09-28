using Microsoft.AspNetCore.Mvc;
using PolicyModels;
using PolicyService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PolicyRegis.Controllers
{
    public class CustomerDtlsController : Controller
    {
        [HttpPost]
        [HttpGet]
        public IActionResult Index(CustomerSearch customerSearch)
        {
            var CustService = new CustomerDtlsService();
            IEnumerable<CustomerDetails> lst = CustService.GetList();
            lst = customerSearch.GetWhere(lst);
            lst = customerSearch.GetOrderBy(lst);
            lst = customerSearch.GetPagination(lst);
            ViewBag.customerSearch = customerSearch;
            return View(lst.ToList());
        }
    }
}
