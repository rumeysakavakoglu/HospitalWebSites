using $safeprojectname$.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    public class kullanıcıHocalarController : Controller
    {
        // GET: kullanıcıHocalar
        Context c = new Context();
        public ActionResult kullanıcıHocalar()
        {
            var deger = c.gorevli.ToList();
            return View(deger);
        }
    }
}