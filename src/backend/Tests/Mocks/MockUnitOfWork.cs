using System.Collections.Generic;
using System.Linq;
using Data.Interfaces;
using Models.Entities;
using Moq;

namespace Tests.Mocks
{
    public static class MockUnitOfWork
    {
        public static Mock<IUnitOfWork> GetUnitOfWork()
        {
            var devices = new List<Device>
            {
                new Device
                {
                    Id = 1,
                    Name = "Device 1",
                    TypeId = 3,
                    Temperature = 45,
                    Status = "Available"
                },
                new Device
                {
                    Id = 2,
                    Name = "Device 2",
                    TypeId = 1,
                    Temperature = 9,
                    Status = "Available"
                },
                new Device
                {
                    Id = 3,
                    Name = "Device 3",
                    TypeId = 2,
                    Temperature = 78,
                    Status = "Offline"
                },
                new Device
                {
                    Id = 4,
                    Name = "Device 4",
                    TypeId = 3,
                    Temperature = 32,
                    Status = "Offline"
                },
                new Device
                {
                    Id = 5,
                    Name = "Device 5",
                    TypeId = 2,
                    Temperature = 12,
                    Status = "Available"
                }
            };

            var mockUnitOfWork = new Mock<IUnitOfWork>();

            mockUnitOfWork
                .Setup(x => x.Devices.GetAll())
                .ReturnsAsync(devices);

            mockUnitOfWork
                .Setup(x => x.Devices.GetByIdAsync(1))
                .ReturnsAsync(devices.FirstOrDefault(x => x.Id == 1)!);

            return mockUnitOfWork;
        }
    }
}