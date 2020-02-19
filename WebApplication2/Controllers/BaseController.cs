using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class BaseController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View("Views/Index.cshtml");
        }
        [Route("Dupes")]
        public IActionResult Dupe()
        {
            return View("views/DupeFinder.cshtml");
        }

        [Route("/Dupes/find")]
        public ViewResult Dupes(string STR1,string STR2,string delim)
        {
            ViewBag.Head = DupeFinder.Find(STR1, STR2, delim);
            return View("~/Views/DupeFinderResult.cshtml");
        }
    }
}