using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace $safeprojectname$.Models
{
    public class asistan
    {
        [Key]
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telefon { get; set; }
        public string bölümü { get; set; }
        public string email{ get; set; }
        public string tarih { get; set; }
        public string güncelle { get; set; }
    }
}