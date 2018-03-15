using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace AspNetDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AspNetDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}