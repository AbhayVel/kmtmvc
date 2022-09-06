using Microsoft.AspNetCore.Mvc;
using PolicyModels;
using PolicyService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PolicyRegis.Controllers
{
	public class AddressController : Controller
	{

		[HttpPost]
		[HttpGet]
		public IActionResult Index(AddressSearch addressSearch)
		{
			var adService = new AddressService();
			IEnumerable<Address> lst = adService.GetList();
			lst = addressSearch.GetWhere(lst);
			lst = addressSearch.GetOrderBy(lst);
			lst = addressSearch.GetPagination(lst);
			ViewBag.addressSearch = addressSearch;
			

				return View(lst.ToList());
		}
	}
}
