namespace Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IAppUserRepository AppUsers { get; }
        public IDeviceRepository Devices { get; }
    }
}