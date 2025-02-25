using $safeprojectname$.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    public class randevuController : Controller
    {
        // Context nesnesi
        Context c = new Context();

        // GET: randevu
        public ActionResult randevu()
        {
            var deger = c.randevus.ToList();
            return View(deger);
        }

        // Onayla işlemi
        [HttpPost]
        public ActionResult Onayla(int id)
        {
            var randevu = c.randevus.Find(id);
            if (randevu != null)
            {
                randevu.randevuDurumu = "Onaylandı"; // Randevu durumu onaylandı olarak güncellenir
                c.SaveChanges();
            }

            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }

        // Reddet işlemi
        [HttpPost]
        public ActionResult Reddet(int id)
        {
            var randevu = c.randevus.Find(id);
            if (randevu != null)
            {
                randevu.randevuDurumu = "Reddedildi"; // Randevu durumu reddedildi olarak güncellenir
                c.SaveChanges();
            }

            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
    }
}
