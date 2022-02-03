using Models.Entities;

namespace Core.Interfaces
{
    public interface IAuthService
    {
        Task<bool> UserExists(string username);
        bool CorrectPassword(string password, byte[] passwordHash, byte[] passwordSalt);
        string CreateToken(AppUser appUser);
    }
}