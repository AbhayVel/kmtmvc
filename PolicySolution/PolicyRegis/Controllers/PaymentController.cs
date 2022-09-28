using Microsoft.AspNetCore.Mvc;
using PolicyModels;
using PolicyService;
using System.Collections.Generic;
using System.Linq;

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
