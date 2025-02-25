using $safeprojectname$.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace $safeprojectname$.Models
{
    public class Context:DbContext
    {
        public DbSet<giris>giris {  get; set; }
        public DbSet<asistan>asistans { get; set; }

        public DbSet<nobet> nobets { get; set; }
        public DbSet<randevu> randevus { get; set; }
        public DbSet<acildurum> acildurums { get; set; }
        public DbSet<bolmbilgileri> bolmbilgileris { get; set; }
        public DbSet<gorevli> gorevli { get; set; }
        public DbSet<anasayfa> anasayfa { get; set; }
        public DbSet<kullaniciAsistan>kullaniciAsistan { get; set; }
        public DbSet<kullanıcıHocalar> kullanıcıHocalar { get; set; }
        public DbSet<kullanıcıNobet> kullanıcıNobet { get; set; }
        public DbSet<kullanıcıBolumbilgileri> kullanıcıBolumbilgileri { get; set; }
        public DbSet<kullanıcıRandevu> kullanıcıRandevu { get; set; }
        public DbSet<acildurum2> acildurum2 { get; set; }

    }
}