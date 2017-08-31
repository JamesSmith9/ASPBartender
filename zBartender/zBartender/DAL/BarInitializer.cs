using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using zBartender.Models;

namespace zBartender.DAL
{
    public class BarInitializer : System.Data.Entity.CreateDatabaseIfNotExists<BarContext>
    {
        protected override void Seed (BarContext context)
        {
            var drinks = new List<Drink>
            {
            new Drink{ID=4,Name="Cosmopolitan",Price=8.50},
            new Drink{ID=1,Name="Martini",Price=9.00},
            new Drink{ID=2,Name="Margarita",Price=8.00},
            new Drink{ID=3,Name="Manhattan",Price=10.00}

            };

            drinks.ForEach(d => context.Drinks.Add(d));
            context.SaveChanges();

        }
    }
}