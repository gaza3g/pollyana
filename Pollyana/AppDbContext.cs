using Pollyana.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Pollyana
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext() : base("AppDbContext")
        { }

        public DbSet<Poll> Polls { get; set; }

        //public System.Data.Entity.DbSet<Pollyana.AppUser> AppUsers { get; set; }
        //public DbSet<AppUser> AppUsers { get; set; }
        //public DbSet<Question> Questions { get; set; }
        //public DbSet<Response> Responses { get; set; }

    }
}