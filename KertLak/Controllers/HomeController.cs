using System.Web.Mvc;

namespace KertLak.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Home");
        }
    }
}