using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pollyana.Models
{
    /*
     *  Response
        Id [PK]
        DateCreated
        DateModified
        PollId [FK]
        UserId [FK]
    */
    public class Response
    {
        public int ResponseID { get; set; }
        public int QuestionID { get; set; }
        public int UserID { get; set; }
        public string Data { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual Question Question { get; set; }
    }
}