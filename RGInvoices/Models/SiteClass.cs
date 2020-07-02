using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RGInvoices.Models
{
    public class SiteClass
    {
        [Key]
        public string SiteKey { get; set; }

        public string SiteName { get; set; }
        public string  Address1 { get; set; }
        public string Addess2 { get; set; }
    }
}
