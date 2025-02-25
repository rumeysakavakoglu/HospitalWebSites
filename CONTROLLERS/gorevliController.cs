using $safeprojectname$.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    public class gorevliController : Controller
    {
        // GET: gorevli
        Context c = new Context();
        public ActionResult gorevli()
        {
          
                var deger = c.gorevli.ToList();
                return View(deger);
            }



        [HttpPost]
        public ActionResult YeniGorevliEkle(gorevli yeniGorevli)
        {
            if (ModelState.IsValid)
            {
                // Yeni asistan ekleme işlemi
                c.gorevli.Add(yeniGorevli);
                c.SaveChanges();

                // Listeyi tekrar al ve PartialView olarak geri gönder
                var deger = c.gorevli.ToList();
                return PartialView("_GuncellenenListesi", deger); // Güncellenmiş listeyi geri gönder
            }

            return View(); // Hata durumunda
        }


        [HttpPost]
        public ActionResult SilGorevli(int id)
        {
            var gorevli = c.gorevli.Find(id);
            if (gorevli != null)
            {
                c.gorevli.Remove(gorevli);  // Veritabanından asistanı sil
                c.SaveChanges();  // Değişiklikleri kaydet
            }

            var deger = c.gorevli.ToList(); // Güncellenmiş listeyi al
            return PartialView("_GuncellenenListesi", deger); // Güncellenmiş listeyi geri gönder
        }
    }
}
        
    
