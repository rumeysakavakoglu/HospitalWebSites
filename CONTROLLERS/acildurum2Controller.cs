using $safeprojectname$.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    public class acildurum2Controller : Controller
    {
        // GET: acildurum2
        Context c = new Context();
        public ActionResult acildurum2()
        {
            var deger = c.acildurums.ToList();
            return View(deger);
        }
    }
}