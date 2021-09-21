using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Studmgt.Domain.Model.Identity;

namespace Studmgt.Infrastructure.Persistance
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Abrham"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}