using Models.Entities;

namespace Data.Interfaces
{
    public interface IAppUserRepository : IRepository<AppUser>
    {
        Task<AppUser> GetByEmailAsync(string email, CancellationToken cancellationToken);
    }
}