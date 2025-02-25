using $safeprojectname$.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    public class nobetController : Controller
    {
        // Context nesnesi
        Context c = new Context();

        // GET: nobet
        public ActionResult nobet()
        {
            var deger = c.nobets.ToList();
            return View(deger);
        }

        [HttpPost]
        public ActionResult YeniNobetEkle(nobet yeniNobet)
        {
            if (ModelState.IsValid)
            {
                c.nobets.Add(yeniNobet); // Yeni nöbeti ekle
                c.SaveChanges();
                var deger = c.nobets.ToList(); // Güncellenmiş listeyi al
                return PartialView("_NobetListesi", deger); // Listeyi güncelle
            }
            return new HttpStatusCodeResult(400, "Geçersiz veri.");
        }


        // Nöbet Silme
        [HttpPost]
        public ActionResult SilNobet(int id)
        {
            var nobet = c.nobets.Find(id);
            if (nobet != null)
            {
                c.nobets.Remove(nobet);
                c.SaveChanges();
            }
            var deger = c.nobets.ToList();
            return PartialView("_NobetListesi", deger);
        }


    }
}
