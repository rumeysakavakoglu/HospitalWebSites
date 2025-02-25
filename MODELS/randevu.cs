using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace $safeprojectname$.Models
{
    public class randevu
    {
        [Key]
        public int Id { get; set; }
        public string adı { get; set; }
        public string sorumluhoca { get; set; }
        public string islem { get; set; }
        public string tarih { get; set; }
        public string randevuDurumu { get; internal set; }
    }
}