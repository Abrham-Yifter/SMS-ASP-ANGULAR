using Microsoft.AspNetCore.Identity;
using Studmgt.Domain.Model.Identity;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RestAPICompleted.Extentions
{
    public static class UserManagerExtensions
    {
        public static async Task<AppUser> FindByEmailFromClaimsPrinciple(this UserManager<AppUser> input, ClaimsPrincipal user)
        {
            var email = user.FindFirstValue(ClaimTypes.Email);

            return await input.Users.SingleOrDefaultAsync(x => x.Email == email);
        }

    }
}
