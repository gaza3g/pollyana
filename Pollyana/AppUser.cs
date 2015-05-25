using Microsoft.AspNet.Identity.EntityFramework;
using Pollyana.Models;
using System;
using System.Collections.Generic;

namespace Pollyana
{
    public enum UserRole
    {
        Administrator, Teacher, Student
    }
    public class AppUser : IdentityUser
    {
        public string Country { get; set; }
        public string Age { get; set; }
        public string Puid { get; set; }
        public string Fullname { get; set; }
        public UserRole UserRole { get; set; }
        public string LmsDomain { get; set; }
        public string DbInstance { get;set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual ICollection<Poll> Polls { get; set; }
    }
}