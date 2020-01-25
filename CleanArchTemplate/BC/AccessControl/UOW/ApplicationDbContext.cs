using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using CleanArchTemplate.BC.AccessControl.Account.Domain.Models;

namespace CleanArchTemplate.BC.AccessControl.UOW
{
    //this class contain the Indentity Dommain Model classes
    // this class will extend the IdentityDbContext<ApplicationUser>

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        // This DBContext will add 5 Tables to the CleanArchTemplateTwoDBContextsOneDB
        // As there is one DB, Migratins sould be stored in One Folder.
        // But one Migration Folder did not work. that is why sotred in 2 folders
        // One Conn Streing in web.config.
        // Two DBContexts ==> One Conn String ==> One DB
        // Two DB Context ==> Two Migration Folder ==> Two DContextConfig.cs files

        // Two DBContext Means we have 2 light weight UOW classes
        // we virtually divide the EF Repos and Custom Repo in two virtual groupts
        // two light weight UOWs are better than one heavy wieght UOW
        // we should always keep in mind what UOW has what DBSets/EF Repos
        // Domain Model also divided in two halves with respect to Persistence
        // One set of Dom Objecs persisted by one UOW
        // Another by other UOW. so remember this
        public ApplicationDbContext()
            : base("CleanArchTemplateTwoDBContextsOneDB", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}