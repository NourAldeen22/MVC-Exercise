namespace MVC_Exercise.Migrations
{
    using MVC_Exercise.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_Exercise.DataAccessLayer.StorageCotext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC_Exercise.DataAccessLayer.StorageCotext context)
        {

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Product pro = new Product()
            {
                Name = "nour",
                Price = 154,
                Category = "gfgfg",
                Shelf = "dsfd",
                Count = 45,
                Description = "dsds",
            };

            context.products.AddOrUpdate(b=>b.Name ,pro);


        }
    }
}
