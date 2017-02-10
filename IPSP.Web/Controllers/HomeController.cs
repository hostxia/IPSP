using System.Web.Mvc;

namespace IPSP.Web.Controllers
{
    public class HomeController : IPSPControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}