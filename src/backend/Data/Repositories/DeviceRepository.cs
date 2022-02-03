using AutoMapper;
using Data.Contexts;
using Data.DTOs;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Data.Repositories
{
    public class DeviceRepository : Repository<Device>, IDeviceRepository
    {
        protected new IQueryable<Device> BaseQuery => _dbContext.Devices;

        public DeviceRepository(AppDbContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

        public async Task<IEnumerable<DeviceDTO>> GetDevices()
        {
            var devicesFromDb = await BaseQuery.ToListAsync();
            var devicesToReturn = _mapper.Map<List<DeviceDTO>>(devicesFromDb);

            return devicesToReturn;
        }

        public async Task<DeviceDetailsDTO> GetDeviceById(int id)
        {
            var deviceFromDb = await _dbContext.Devices.FirstOrDefaultAsync(x => x.Id == id);

            if (deviceFromDb is null) return null;

            var deviceToReturn = _mapper.Map<DeviceDetailsDTO>(deviceFromDb);
            return deviceToReturn;
        }
    }
}