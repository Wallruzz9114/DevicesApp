using Data.DTOs;
using Models.Entities;

namespace Data.Interfaces
{
    public interface IDeviceRepository : IRepository<Device>
    {
        Task<IEnumerable<DeviceDTO>> GetDevices();
        Task<DeviceDetailsDTO> GetDeviceById(int id);
    }
}