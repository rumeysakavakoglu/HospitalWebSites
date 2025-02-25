using $safeprojectname$.Models;
using System.Linq;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    public class AcilDurumController : Controller
    {
        Context c = new Context();

        // GET: acildurum
        public ActionResult acildurum()
        {
            var deger = c.acildurums.ToList();
            return View(deger);
        }

        // POST: Acil Durum Ekleme
        [HttpPost]
        public ActionResult EkleAcilDurum(string mesaj)
        {
            if (!string.IsNullOrEmpty(mesaj))
            {
                // Yeni acil durumu veritabanına ekle
                var acilDurum = new acildurum
                {
                    bildirim = mesaj
                };
                c.acildurums.Add(acilDurum);
                c.SaveChanges();

                // Listeyi güncelle ve döndür
                var durumlar = c.acildurums.ToList();
                return PartialView("_AcildurumListesi", durumlar);
            }

            return new HttpStatusCodeResult(400, "Geçersiz mesaj");
        }
    }
}
