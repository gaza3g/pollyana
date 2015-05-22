namespace Pollyana.Migrations
{
    using Pollyana.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Pollyana.DAL.PollContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Pollyana.DAL.PollContext context)
        {
            var users = new List<User>
            {
                new User{
                    Puid="2AB3B11E-F591-4566-8F2B-13ED2CCD1A8B",
                    Username="farid",
                    Fullname="Farid Mohd Ismail",
                    LmsDomain="lms.wizlearn.com",
                    DbInstance="eduservice_asknlearn",
                    DateCreated=DateTime.Now,
                    DateModified=DateTime.Now
                },
                new User{
                    Puid="D8254C10-DD6F-45E6-A3AF-2E0F3630CC6F",
                    Username="ghazaly",
                    Fullname="Ghazaly H",
                    LmsDomain="lms.wizlearn.com",
                    DbInstance="eduservice_asknlearn",
                    DateCreated=DateTime.Now,
                    DateModified=DateTime.Now
                },
                new User{
                    Puid="A587EF4E-5FC2-44FB-882F-91E0EAAB8703",
                    Username="maideen",
                    Fullname="Maideen Abdul Aleem",
                    LmsDomain="lms.wizlearn.com",
                    DbInstance="eduservice_asknlearn",
                    DateCreated=DateTime.Now,
                    DateModified=DateTime.Now
                },
                new User{
                    Puid="41EE29CC-BE3E-4E6D-A08A-06C8680C9DE",
                    Username="tonychoo",
                    Fullname="Tony Choo",
                    LmsDomain="lms.wizlearn.com",
                    DbInstance="eduservice_asknlearn",
                    DateCreated=DateTime.Now,
                    DateModified=DateTime.Now
                }
            };

            users.ForEach(s => context.Users.AddOrUpdate(p => p.Fullname, s));
            context.SaveChanges();
        }
    }
}
