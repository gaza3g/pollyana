using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Pollyana.Models;

namespace Pollyana.DAL
{
    public class PollInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PollContext>
    {
        protected override void Seed(PollContext context)
        { 
            /*
             *  public Guid Puid { get; set; }
                public string Username { get; set; }
                public string Fullname { get; set; }
                public string LmsDomain { get; set; }
                public string DbInstance { get;set; }
                public DateTime DateCreated { get; set; }
                public DateTime DateModified { get; set; }
            */

            /*
             *  2AB3B11E-F591-4566-8F2B-13ED2CCD1A8B	farid                                                                                               	Farid Mohd Ismail
                D8254C10-DD6F-45E6-A3AF-2E0F3630CC6F	ghazaly                                                                                             	ghazaly
                A587EF4E-5FC2-44FB-882F-91E0EAAB8703	maideen                                                                                             	Maideen Bin Abdul Aleem
                41EE29CC-BE3E-4E6D-A08A-06C8680C9DEB	tonychoo                                                                                            	Tony Choo
             */ 
            //var users = new List<User>
            //{
            //    new User{
            //        Puid="2AB3B11E-F591-4566-8F2B-13ED2CCD1A8B",
            //        Username="farid",
            //        Fullname="Farid Mohd Ismail",
            //        LmsDomain="lms.wizlearn.com",
            //        DbInstance="eduservice_asknlearn",
            //        DateCreated=DateTime.Now,
            //        DateModified=DateTime.Now
            //    },
            //    new User{
            //        Puid="D8254C10-DD6F-45E6-A3AF-2E0F3630CC6F",
            //        Username="ghazaly",
            //        Fullname="Ghazaly H",
            //        LmsDomain="lms.wizlearn.com",
            //        DbInstance="eduservice_asknlearn",
            //        DateCreated=DateTime.Now,
            //        DateModified=DateTime.Now
            //    },
            //    new User{
            //        Puid="A587EF4E-5FC2-44FB-882F-91E0EAAB8703",
            //        Username="maideen",
            //        Fullname="Maideen Abdul Aleem",
            //        LmsDomain="lms.wizlearn.com",
            //        DbInstance="eduservice_asknlearn",
            //        DateCreated=DateTime.Now,
            //        DateModified=DateTime.Now
            //    },
            //    new User{
            //        Puid="41EE29CC-BE3E-4E6D-A08A-06C8680C9DE",
            //        Username="tonychoo",
            //        Fullname="Tony Choo",
            //        LmsDomain="lms.wizlearn.com",
            //        DbInstance="eduservice_asknlearn",
            //        DateCreated=DateTime.Now,
            //        DateModified=DateTime.Now
            //    }
            //};

            //users.ForEach(u => context.AppUsers.Add(u));
            //context.SaveChanges();


            /*
             *  public int PollID { get; set; }
                public int UserID { get; set; }
                public DateTime DateCreated { get; set; }
                public DateTime DateModified { get; set; }
                public bool isOpen { get; set; }
                public string AccessCode { get; set; }

                public virtual User User { get; set; }
            */

            var polls = new List<Poll>
            {
                new Poll{
                    UserID = 1,
                    Title = "fdsa dsa dsa dsa",
                    DateCreated=DateTime.Now,
                    DateModified=DateTime.Now,
                    isOpen=true,
                    AccessCode="1234"
                }
                //new Poll{
                //    UserID = 1,
                //    Title = "fdsa dsa dsa dsa",
                //    DateCreated=DateTime.Now,
                //    DateModified=DateTime.Now,
                //    isOpen=true,
                //    AccessCode="1234"
                //},
                //new Poll{
                //    UserID = 2,
                //    Title = "fdsa dsa dsa dsa",
                //    DateCreated=DateTime.Now,
                //    DateModified=DateTime.Now,
                //    isOpen=true,
                //    AccessCode="1234"
                //},
                //new Poll{
                //    UserID = 2,
                //    Title = "fdsa dsa dsa dsa",
                //    DateCreated=DateTime.Now,
                //    DateModified=DateTime.Now,
                //    isOpen=true,
                //    AccessCode="1234"
                //},
                //new Poll{
                //    UserID = 3,
                //    Title = "fdsa dsa dsa dsa",
                //    DateCreated=DateTime.Now,
                //    DateModified=DateTime.Now,
                //    isOpen=true,
                //    AccessCode="1234"
                //},
                //new Poll{
                //    UserID = 3,
                //    Title = "fdsa dsa dsa dsa",
                //    DateCreated=DateTime.Now,
                //    DateModified=DateTime.Now,
                //    isOpen=true,
                //    AccessCode="1234"
                //},
                //new Poll{
                //    UserID = 4,
                //    Title = "fdsa dsa dsa dsa",
                //    DateCreated=DateTime.Now,
                //    DateModified=DateTime.Now,
                //    isOpen=true,
                //    AccessCode="1234"
                //},
                //new Poll{
                //    UserID = 4,
                //    Title = "fdsa dsa dsa dsa",
                //    DateCreated=DateTime.Now,
                //    DateModified=DateTime.Now,
                //    isOpen=true,
                //    AccessCode="1234"
                //}
            };

            polls.ForEach(p => context.Polls.Add(p));
            context.SaveChanges();

            //public int QuestionID { get; set; }
            //public DateTime DateCreated { get; set; }
            //public DateTime DateModified { get; set; }
            //public int PollID { get; set; }
            //public QuestionType QuesType { get; set; }
            //public string Title { get; set; }
            //public string Description { get; set; }
            var questions = new List<Question>
            {
                new Question{
                    PollID = 1,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    QuesType = QuestionType.OpenEnded,
                    Title = "This is a question",
                    Description = "This is a descripton"
                }
            };

            questions.ForEach(q => context.Questions.Add(q));
            context.SaveChanges();


            //public int ResponseID { get; set; }
            //public int QuestionID { get; set; }
            //public int UserID { get; set; }
            //public DateTime DateCreated { get; set; }
            //public DateTime DateModified { get; set; }

            //public virtual Question Question { get; set; }
            //public virtual User User { get; set; }
            var responses = new List<Response>
            {
                new Response {
                    QuestionID = 1,
                    UserID = 1,
                    Data = "this is my data",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                }
                
            };

            responses.ForEach(r => context.Responses.Add(r));
            context.SaveChanges();


        }
    }
}