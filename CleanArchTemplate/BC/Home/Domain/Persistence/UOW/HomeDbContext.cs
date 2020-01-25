using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using CleanArchTemplate.BC.AccessControl.Account.Domain.Models;
using CleanArchTemplate.BC.Home.Domain.Models;
//using CleanArchTemplate.BC.AccessControl.Manage.Domain.Models;

namespace CleanArchTemplate.BC.Home.Domain.Persistence.UOW
{
    // This DBContext will add 1 Table to the CleanArchTemplateTwoDBContextsOneDB
    // As there is one DB, Migratins sould be stored in One Folder.
    // But one Migration Folder did not work. that is why sotred in 2 folders
    // One Conn Streing in web.config.
    // Two DBContexts ==> One Conn String ==> One DB
    // Two DB Context ==> Two Migration Folder ==> Two DContextConfig.cs files

    // This Class will extend form DBContext only

    // Two DBContext Means we have 2 light weight UOW classes
    // we virtually divide the EF Repos and Custom Repo in two virtual groupts
    // two light weight UOWs are better than one heavy wieght UOW
    // we should always keep in mind what UOW has what DBSets/EF Repos
    // Domain Model also divided in two halves with respect to Persistence
    // One set of Dom Objecs persisted by one UOW
    // Another by other UOW. so remember this

    public class HomeDbContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }

        public HomeDbContext()
            : base("CleanArchTemplateTwoDBContextsOneDB")
        {
        }

        public static HomeDbContext Create()
        {
            return new HomeDbContext();
        }
    }
}