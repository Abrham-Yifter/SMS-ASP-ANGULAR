using Studmgt.Domain.Model.Identity;

namespace Studmgt.Application.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
