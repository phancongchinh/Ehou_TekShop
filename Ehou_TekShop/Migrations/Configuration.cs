namespace Ehou_TekShop.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Ehou_TekShop.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Ehou_TekShop.Models.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Categories.AddOrUpdate(
                new Models.Category
                {
                    Name = "Laptop"
                },
                new Models.Category
                {
                    Name = "Smartphone"
                },
                new Models.Category
                {
                    Name = "Smartwatch"
                });

            context.SaveChanges();
        }
    }
}
