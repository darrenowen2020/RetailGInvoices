using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RGInvoices.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace RGInvoices.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ConnectionStringClass _db;

        public IndexModel(ConnectionStringClass db)
        {
            _db = db;
        }

        public IEnumerable<SiteClass> DisplayData { get; set; }
        public async Task OnGet()
        {
            DisplayData = await _db.Site.ToListAsync();
        }
    }
}
