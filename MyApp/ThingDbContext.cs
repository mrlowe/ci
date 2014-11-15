using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyApp
{
    public class ThingDbContext : DbContext
    {
        public ThingDbContext() : base("MyAppContext") { }

        public DbSet<Thing> Things { get; set; }
    }
}