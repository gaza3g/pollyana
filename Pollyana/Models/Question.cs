using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pollyana.Models
{
    public enum QuestionType
    {
        OpenEnded
    }

    public class Question
    {
        public int QuestionID { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int PollID { get; set; }
        public QuestionType QuesType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


        public virtual Poll Poll { get; set;}
        public virtual ICollection<Response> Responses {get; set;}
    }
}