using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Toystore.Models
{
    public class ToystoreDBContext:DbContext
    {
        public DbSet<Toy> Toys { set; get; }
        public DbSet<Order> Orders { set; get; }
    }
}