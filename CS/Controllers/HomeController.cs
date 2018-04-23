using System.Web.Mvc;

namespace CS.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
    }
}