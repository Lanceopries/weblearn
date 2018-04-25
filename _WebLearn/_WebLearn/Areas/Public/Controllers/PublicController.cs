using System.Web.Mvc;

namespace _WebLearn.Areas.Public.Controllers
{
    public class PublicController : Controller
    {
        // GET: Public/Public
        public ActionResult Index()
        {
            ViewData["Status"] = "-";
            return View();
        }
    }
}