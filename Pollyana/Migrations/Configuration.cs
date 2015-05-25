namespace Pollyana.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Web.Mvc;
    using System.Security.Claims;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Pollyana.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Pollyana.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            if (!(context.Users.Any(u => u.UserName == "farid@wizlearn.com")))
            {
                var userStore = new UserStore<AppUser>(context);
                var userManager = new UserManager<AppUser>(userStore);
                var userToInsert = new AppUser { UserName = "farid@wizlearn.com", Country = "Singapore" };
                userManager.Create(userToInsert, "password");
            }


        }
    }
}
