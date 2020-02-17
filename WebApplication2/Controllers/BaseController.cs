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
        public IActionResult Dupe()
        {
            return View("views/DupeFinder.cshtml");
        }

        [Route("/Dupes/find")]
        [HttpPost]
        public string Dupes(string STR1,string STR2,string delim)
        {
            return DupeFinder.Find(STR1, STR2, delim);
            
        }
    }
}