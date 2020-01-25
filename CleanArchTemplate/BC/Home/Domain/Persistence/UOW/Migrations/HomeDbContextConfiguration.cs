namespace CleanArchTemplate.BC.Home.Domain.Persistence.UOW.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class HomeDbContextConfiguration : DbMigrationsConfiguration<CleanArchTemplate.BC.Home.Domain.Persistence.UOW.HomeDbContext>
    {
        public HomeDbContextConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"BC\Home\Domain\Persistence\UOW\Migrations";
        }

        protected override void Seed(CleanArchTemplate.BC.Home.Domain.Persistence.UOW.HomeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
