using $safeprojectname$.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    public class kullanıcıBolumbilgileriController : Controller
    {
        // GET: Defaul
        Context c = new Context();
        public ActionResult kullanıcıBolumbilgileri()
        {

            var deger = c.bolmbilgileris.ToList();
            return View(deger);
        }
    }
}