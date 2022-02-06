using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Core.Features.Devices.Queries;
using Data.DTOs;
using Data.Interfaces;
using Data.Mappings;
using Moq;
using Shouldly;
using Tests.Mocks;
using Xunit;

namespace Tests.Features.Devices.Queries
{
    public class DeviceQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;

        public DeviceQueryHandlerTests()
        {
            _mockUnitOfWork = MockUnitOfWork.GetUnitOfWork();
            var mapperConfig = new MapperConfiguration(c => c.AddProfile<MappingProfiles>());
            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task GetDevicesTest()
        {
            var handler = new GetDevices.Handler(_mockUnitOfWork.Object, _mapper);
            var results = await handler.Handle(new GetDevices.Query(), CancellationToken.None);

            results.ShouldBeOfType<List<DeviceDTO>>();
            results.Count().ShouldBe(5);
        }

        [Fact]
        public async Task GetDeviceByIdTest()
        {
            var handler = new GetDeviceById.Handler(_mockUnitOfWork.Object, _mapper);
            var result = await handler.Handle(new GetDeviceById.Query() { Id = 1 }, CancellationToken.None);

            result.ShouldNotBeNull();
            result.ShouldBeOfType<DeviceDetailsDTO>();

            result.Id.ShouldBe(1);
            result.Name.ShouldBe("Device 1");
            result.Type.ShouldBe("Monitor");
            result.Status.ShouldBe("Available");

            result.Temperature.ShouldBeOfType<decimal>();
            result.Temperature.ShouldBe(45);
        }
    }
}