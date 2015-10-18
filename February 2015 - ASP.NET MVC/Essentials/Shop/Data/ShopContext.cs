using Shop.Areas.Shop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Shop.Migrations;

namespace Shop.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext()
            : base("ShopConnection")
        {
            Database.SetInitializer<ShopContext>(new MigrateDatabaseToLatestVersion<ShopContext, Configuration>());
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}