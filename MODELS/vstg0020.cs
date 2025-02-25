using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace $safeprojectname$.Models
{
    public class kullanıcıNobet
    {
        [Key]
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string Bölümü { get; set; }
        public DateTime tarih { get; set; }
      

    }
}