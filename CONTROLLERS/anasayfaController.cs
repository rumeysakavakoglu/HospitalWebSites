using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using $safeprojectname$.Models;
using Context = $safeprojectname$.Models.Context;

namespace $safeprojectname$.Controllers
{
    public class anasayfaController : Controller
    {
        // GET: anasayfa
        Context c = new Context();
        public ActionResult anasayfa()
        {

            var deger = c.anasayfa.ToList();
            return View(deger);
        }
    }
}