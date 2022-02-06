using System.Collections.Generic;
using System.Linq;
using Data.Interfaces;
using Models.Entities;
using Models.Enums;
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
                    Type = DeviceType.Monitor,
                    Temperature = 45,
                    Status = "Available"
                },
                new Device
                {
                    Id = 2,
                    Name = "Device 2",
                    Type = DeviceType.Phone,
                    Temperature = 9,
                    Status = "Available"
                },
                new Device
                {
                    Id = 3,
                    Name = "Device 3",
                    Type = DeviceType.Tablet,
                    Temperature = 78,
                    Status = "Offline"
                },
                new Device
                {
                    Id = 4,
                    Name = "Device 4",
                    Type = DeviceType.Monitor,
                    Temperature = 32,
                    Status = "Offline"
                },
                new Device
                {
                    Id = 5,
                    Name = "Device 5",
                    Type = DeviceType.Phone,
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