using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetDemo.Web.Controllers
{
	public class WillController : Controller
	{
		// GET: Will
		public ActionResult Index()
		{
			var s = System.Configuration.ConfigurationManager.AppSettings.Get("TestAppSetting");
			ViewBag.Value = s;

			return View();
		}
	}
}