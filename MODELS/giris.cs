using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace $safeprojectname$.Models
{
    public class giris
    {
        [Key]
        public int Id { get; set; }
        public string kullanıcıadı {  get; set; }
        public string sifre { get; set; }
        public string Roller { get; set; } // Yeni rol özelliği
    }
}