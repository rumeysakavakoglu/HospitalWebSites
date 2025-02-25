using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace $safeprojectname$.Models
{
    public class acildurum
    {
        [Key]
        public int Id { get; set; }
        public string bildirim{ get; set; }
    }
}