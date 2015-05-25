﻿using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Pollyana
{
    public class AppUserClaimsIdentityFactory : ClaimsIdentityFactory<AppUser, string>
    {
        public override async Task<ClaimsIdentity> CreateAsync(
            UserManager<AppUser, string> manager,
            AppUser user,
            string authenticationType)
        {
            var identity = await base.CreateAsync(manager, user, authenticationType);
            identity.AddClaim(new Claim(ClaimTypes.Country, user.Country));

            return identity;
        }
    }
}