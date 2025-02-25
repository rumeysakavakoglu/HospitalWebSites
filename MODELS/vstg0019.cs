using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace $safeprojectname$.Models
{
    public class kullanıcıHocalar
    {
        [Key]
        public int id { get; set; }
        public string ad { get; set; }
        public string bölüm { get; set; }
        public string email { get; set; }
        public int tarih { get; set; }
        public string güncelle { get; set; }
    }
}