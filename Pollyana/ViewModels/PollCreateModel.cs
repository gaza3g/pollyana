using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Pollyana.ViewModels
{
    public class PollCreateModel
    {
        AppDbContext db = new AppDbContext();

        public PollCreateModel()
        {
            UserDropDown = from c in db.Users
                           select new SelectListItem()
                           {
                               Value = c.Id.ToString(),
                               Text = c.UserName.ToString(),
                               Selected = false
                           };

        }


        public int PollID { get; set; }
        public string UserID { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool isOpen { get; set; }
        public string AccessCode { get; set; }
        public IEnumerable<SelectListItem> UserDropDown { get; set; }

        public void Post()
        {

        }
    }
}