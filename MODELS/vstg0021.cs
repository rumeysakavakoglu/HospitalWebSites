using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace $safeprojectname$.Models
{
    public class kullanıcıRandevu
    {
        public int Id { get; set; }
        public string adı { get; set; }
        public string poliklinik { get; set; }
        public string islem { get; set; }
        public string randevuDurumu { get; set; }
    }
}