using Core.Features.Devices.Queries;
using Data.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    public class DevicesController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeviceDTO>>> GetAll()
            => Ok(await Mediator.Send(new GetDevices.Query { }));

        [HttpGet("{id}")]
        public async Task<ActionResult<DeviceDetailsDTO>> GetDeviceById(int id)
            => await Mediator.Send(new GetDeviceById.Query { Id = id });
    }
}