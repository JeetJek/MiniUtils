using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult DupeFinder()
        {
            return View("views/DupeFinder.cshtml");
        }

        [Route("/Dupes/find")]
        public IActionResult Dupes(string STR1,string STR2)
        {
            return Ok();
        }
    }
}