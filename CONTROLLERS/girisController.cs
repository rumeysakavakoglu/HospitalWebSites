using $safeprojectname$.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $safeprojectname$.Controllers
{
    public class girisController : Controller
    {
        // GET: giris
        Context c = new Context();
        public ActionResult giris()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Giris(string kullanıcıadı, string sifre)
        {
            var kullanici = c.giris.FirstOrDefault(x => x.kullanıcıadı == kullanıcıadı && x.sifre == sifre);
            if (kullanici != null)
            {
                if (kullanici.Roller == "hoca")
                {
                    return RedirectToAction("asistan", "asistans"); // Hocalar için sayfa
                }
                else if (kullanici.Roller == "stajyer")
                {
                    return RedirectToAction("anasayfa", "anasayfa"); // Stajyerler için sayfa
                }
            }
            ViewBag.Mesaj = "Kullanıcı adı veya şifre hatalı.";
            return View("Giris");
        }
    }
}