using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace $safeprojectname$.Models
{
    public class kullanıcıBolumbilgileri
    {
        [Key]
        public int id { get; set; }
        public string ad { get; set; }
        public int yataksayısı { get; set; }
    }
}