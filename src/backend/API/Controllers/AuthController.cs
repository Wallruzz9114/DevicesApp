using Core.Features.Auth.Commands;
using Data.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [AllowAnonymous]
    public class AuthController : BaseController
    {
        [HttpPost("login")]
        public async Task<ActionResult<AuthResponse>> Login(Login.Query loginQuery) =>
            await Mediator.Send(loginQuery);
    }
}