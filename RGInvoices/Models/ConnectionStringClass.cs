﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RGInvoices.Models
{
    public class ConnectionStringClass: DbContext
    {
        public ConnectionStringClass(DbContextOptions<ConnectionStringClass> options):base(options)
        {

        }

        public DbSet<SiteClass> Site { get; set; }
    }
}
