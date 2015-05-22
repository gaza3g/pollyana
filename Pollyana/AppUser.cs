using Microsoft.AspNet.Identity.EntityFramework;

namespace Pollyana
{
    public class AppUser : IdentityUser
    {
        public string Country { get; set; }
    }
}