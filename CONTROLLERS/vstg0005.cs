using $safeprojectname$.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    public class kullanıcıRandevuController : Controller
    {
        // GET: kullanıcıRandevu
        Context c = new Context();
        public ActionResult kullanıcıRandevu()
        {
            var deger = c.randevus.ToList();
            return View(deger);
        }


        public ActionResult randevuAl(int id)
        {
            var randevu = c.randevus.FirstOrDefault(x => x.Id == id);
            if (randevu != null)
            {
                randevu.randevuDurumu = "Alındı";
                c.SaveChanges();
                return Json(new { success = true, message = "Randevu başarıyla alındı." }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { success = false, message = "Randevu bulunamadı." }, JsonRequestBehavior.AllowGet);
        }

    }
}