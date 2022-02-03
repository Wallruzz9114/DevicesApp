using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoFixture;
using Core.Features.Devices.Queries;
using Data.DTOs;
using Moq;
using Xunit;

namespace Tests
{
    public class DeviceTests : IClassFixture<SetupFixture>
    {
        protected readonly SetupFixture _setupFixture;

        public DeviceTests(SetupFixture setupFixture)
        {
            _setupFixture = setupFixture;
        }

        [Fact]
        public async Task Should_Get_All_Devices()
        {
            var fixture = new Fixture();
            var query = fixture.Create<GetDevices.Query>();

            _setupFixture.UnitOfWork
                .Setup(x => x.Devices.GetDevices())
                .ReturnsAsync(new List<DeviceDTO>());

            var result = await _setupFixture.Mediator.Send(query);

            Assert.NotNull(result);
            Assert.Equal(10, result.Count());
        }

        [Fact]
        public async Task Should_Get_Device_By_Id()
        {
            var fixture = new Fixture();
            var query = fixture.Create<GetDeviceById.Query>();

            _setupFixture.UnitOfWork
                .Setup(x => x.Devices.GetDeviceById(1))
                .ReturnsAsync(new DeviceDetailsDTO());

            var result = await _setupFixture.Mediator.Send(query);

            Assert.NotNull(result);
            Assert.Equal("Device 1", result.Name);
            Assert.Equal(10, result.Temperature);
        }
    }
}