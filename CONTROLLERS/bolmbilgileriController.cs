using $safeprojectname$.Models;
using System.Linq;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    public class bolmbilgileriController : Controller
    {
        Context c = new Context();

        // GET: Bölüm Bilgileri Listesi
        public ActionResult bolmbilgileri()
        {
            var deger = c.bolmbilgileris.ToList();
            return View(deger);
        }

        // GET: Bölüm Güncelleme Formu
        public ActionResult Guncelle(int id)
        {
            var bolum = c.bolmbilgileris.Find(id);
            if (bolum == null)
            {
                return HttpNotFound();
            }
            return View(bolum);
        }

        // POST: Güncelleme İşlemi
        [HttpPost]
        public ActionResult Guncelle(bolmbilgileri bolum)
        {
            var guncellenecekBolum = c.bolmbilgileris.Find(bolum.id);
            if (guncellenecekBolum != null)
            {
                guncellenecekBolum.ad = bolum.ad;
                guncellenecekBolum.yataksayısı = bolum.yataksayısı;
                guncellenecekBolum.Ayaktahastagiris = bolum.Ayaktahastagiris;
                c.SaveChanges();
            }
            return RedirectToAction("bolmbilgileri");
        }
    }
}
