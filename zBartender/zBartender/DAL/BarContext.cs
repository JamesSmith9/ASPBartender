using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using zBartender.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace zBartender.DAL
{
    public class BarContext : DbContext
    {

        public BarContext() : base("BarContext")
        {
        }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Queue> Queue { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        
        }
    }
}