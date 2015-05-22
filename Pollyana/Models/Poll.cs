using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pollyana.Models
{

    public class Poll
    {
        public int PollID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool isOpen { get; set; }
        public string AccessCode { get; set; }

        public virtual User User { get; set; }
    }
}