using $safeprojectname$.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    public class kullaniciAsistanController : Controller
    {
        // GET: kullaniciAsistan
        Context c = new Context();
        public ActionResult kullaniciAsistan()
        {
            {
                var deger = c.asistans.ToList();
                return View(deger);
            }
        }
    }
}