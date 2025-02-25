using $safeprojectname$.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    public class asistansController : Controller
    {
        // GET: asistans
        Context c = new Context();
        public ActionResult asistan()
        {
            var deger = c.asistans.ToList();
            return View(deger);
        }

       [HttpPost]


        public ActionResult YeniAsistanEkle(asistan yeniAsistan)
        {
            if (ModelState.IsValid)
            {
                // Yeni asistan ekleme işlemi
                c.asistans.Add(yeniAsistan);
                c.SaveChanges();

                // Listeyi tekrar al ve PartialView olarak geri gönder
                var deger = c.asistans.ToList();
                return PartialView("_AsistanListesi", deger); // Güncellenmiş listeyi geri gönder
            }

            return View(); // Hata durumunda
        }


        [HttpPost]
        public ActionResult SilAsistan(int id)
        {
            var asistan = c.asistans.Find(id);
            if (asistan != null)
            {
                c.asistans.Remove(asistan);  // Veritabanından asistanı sil
                c.SaveChanges();  // Değişiklikleri kaydet
            }

            var deger = c.asistans.ToList(); // Güncellenmiş listeyi al
            return PartialView("_AsistanListesi", deger); // Güncellenmiş listeyi geri gönder
        }

    }
}