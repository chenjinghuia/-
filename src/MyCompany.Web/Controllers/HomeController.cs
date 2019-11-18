using Microsoft.AspNetCore.Mvc;

namespace MyCompany.Web.Controllers
{
    public class HomeController : MyCompanyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}