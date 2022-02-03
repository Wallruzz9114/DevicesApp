using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Data.Interfaces
{
    public interface IAppDbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Device> Devices { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}