using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BackyardPortableCSharp.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        public ActionResult OrderHome()
        {
            return View();
        }

        public ActionResult OrderPending()
        {
            return View();
        }
    }
}
