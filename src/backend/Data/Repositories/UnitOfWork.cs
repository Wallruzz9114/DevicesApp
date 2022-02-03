using Data.Contexts;
using Data.Interfaces;

namespace Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public IAppUserRepository AppUsers { get; }
        public IDeviceRepository Devices { get; }

        public UnitOfWork(AppDbContext dbContext, IAppUserRepository appUsers, IDeviceRepository devices)
        {
            _dbContext = dbContext;
            AppUsers = appUsers;
            Devices = devices;
        }

        public void Dispose() => _dbContext.Dispose();
    }
}