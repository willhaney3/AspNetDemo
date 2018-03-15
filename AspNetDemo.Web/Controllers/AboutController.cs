using System.Web.Mvc;

namespace AspNetDemo.Web.Controllers
{
    public class AboutController : AspNetDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}