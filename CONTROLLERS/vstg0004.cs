using $safeprojectname$.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    public class kullanıcıNobetController : Controller
    {
        // GET: kullanıcıNobet
        Context c = new Context();
        public ActionResult kullanıcıNobet()
        {
            var deger = c.asistans.ToList();
            return View(deger);
        }
    }
}