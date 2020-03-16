using Microsoft.AspNetCore.Mvc;
using Riva.Api.Models.Requests;
using Riva.Api.Models.Responses;
using Riva.Api.Services;
using Riva.Models.HAYDEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riva.Api.Controllers
{
    [Route("api/auth")]
    public class AuthController : Controller
    {
        private readonly AuthService _service;
        public AuthController(AuthService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody]LoginRequest login)
        {
            var response = await _service.Login(login);

            switch (response.State)
            {
                case ResponseState.Exception:
                    return StatusCode(500, response.Exception.Message);
                case ResponseState.Error:
                    return BadRequest(response.MessageText);
                default:
                    return Ok(response);
            }
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody]LoginRequest login)
        {
            var response = await _service.CreateUser(login);

            switch (response.State)
            {
                case ResponseState.Exception:
                    return StatusCode(500, response.Exception.Message);
                case ResponseState.Error:
                    return BadRequest(response.MessageText);
                default:
                    return Ok(response);
            }
        }
    }
}
