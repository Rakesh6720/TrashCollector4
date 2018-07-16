namespace TrashCollector4.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TrashCollector4.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TrashCollector4.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrashCollector4.Models.ApplicationDbContext context)
        {
            var customers = new List<Customers>
            {
                new Customers {FirstName = "Owen", LastName = "Wilson", Address = "19175 Still Point Trail", ZipCode = 53045, PickupDay = "Thursday", IsPickedUp = false, IsAdditionalPickedUp = false },
                new Customers {FirstName = "Drew", LastName = "Barrymore", Address = "5456 Elm Terrace", ZipCode = 53004, PickupDay = "Wednesday", IsPickedUp = false, IsAdditionalPickedUp = false}

            };

            customers.ForEach(s => context.Customers.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var employees = new List<Employees>
            {
                new Employees {FirstName = "Conrad", LastName = "Milquetoast", ZipCode = 53045, PickupDay = "Thursday" },
                new Employees {FirstName = "Michelle", LastName = "Rodriguez", ZipCode = 53004, PickupDay = "Wednesday"}
            };

            employees.ForEach(s => context.Employees.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
