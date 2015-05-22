using Microsoft.AspNet.Identity.EntityFramework;

namespace Pollyana
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext() : base("PollContext")
        { }
    }
}