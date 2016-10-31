using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MongoWeb.Context
{
    public class campingContext: DbContext
    {
        public campingContext() : base("campingContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<campingContext> campingPlaces { get; set; }
    }
}