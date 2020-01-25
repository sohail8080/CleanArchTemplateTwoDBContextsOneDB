namespace CleanArchTemplate.BC.AccessControl.UOW.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ApplicationDbContextConfiguration : DbMigrationsConfiguration<CleanArchTemplate.BC.AccessControl.UOW.ApplicationDbContext>
    {
        public ApplicationDbContextConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"BC\AccessControl\UOW\Migrations";
        }

        protected override void Seed(CleanArchTemplate.BC.AccessControl.UOW.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
