using Microsoft.AspNetCore.Mvc;
using PolicyModels;
using System.Collections.Generic;
using System.Linq;
using PolicyService;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

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
			var pymnt =new	Payment();	
			return View(pymnt);
		}
		[HttpPost]
		public async Task<IActionResult> Save(Payment payment)
		{
			Payment pymntry =new Payment();
			await TryUpdateModelAsync(pymntry);
			if (ModelState.IsValid)
			{
				return Redirect("Payment/Index");
			}
			else
			{
				return Redirect("Add");
			}

			
		}


	}
}
