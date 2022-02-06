using Models.Entities;

namespace Core.Interfaces
{
    public interface IAuthService
    {
        bool CorrectPassword(string password, byte[] passwordHash, byte[] passwordSalt);
        string CreateToken(AppUser appUser);
    }
}