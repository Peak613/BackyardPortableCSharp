using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BackyardPortableCSharp.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        public ActionResult Customer()
        {
            return View();
        }
        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}
