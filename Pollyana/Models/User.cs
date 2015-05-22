using System;
using System.Collections.Generic;

namespace Pollyana.Models
{

    public enum UserRole
    {
        Administrator, Teacher, Student
    }

    public class User
    {
        public int UserID { get; set; }
        public string Puid { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public UserRole UserRole { get; set; }
        public string LmsDomain { get; set; }
        public string DbInstance { get;set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<Poll> Polls { get; set; }
    }
}