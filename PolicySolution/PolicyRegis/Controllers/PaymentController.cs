using Microsoft.AspNetCore.Mvc;
using PolicyModels;
using System.Collections.Generic;
using System.Linq;
using PolicyService;

namespace PolicyRegis.Controllers
{
	public class PaymentController : Controller
	{
		public IActionResult Index(PymntDtlsSearch pymntDtlsSearch)
		{

			var adService = new PaymentService();
			IEnumerable<Payment> lst = adService.GetPaymentList();
			lst = pymntDtlsSearch.GetWhere(lst);
			lst = pymntDtlsSearch.GetOrderBy(lst);
			lst = pymntDtlsSearch.GetPagination(lst);
			ViewBag.PymntDtlsSearch = pymntDtlsSearch;

			return View(lst.ToList());
		}

		public IActionResult Add()
		{
			return View();
		}


	}
}
