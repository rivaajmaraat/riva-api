using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Hayden.Services;
using Hayden.Models;
using Hayden.Services.RequestModel;
using Hayden.Services.ResponseModel;

namespace RivaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // POST: api/Login
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequest login)
        {
            var response = await LoginService.Login(login);

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

        [HttpGet("list")]
        public async Task<IActionResult> List()
        {
            var response = await LoginService.LoginList();

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

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]LoginRequest login)
        {
            var response = await LoginService.CreateUser(login);

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

        [HttpPut]
        public async Task<IActionResult> UpdateLoginDetails([FromBody]LoginRequest login)
        {
            var response = await LoginService.UpdateLoginDetails(login);

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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLogin(int id)
        {
            var response = await LoginService.DeleteLogin(id);

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
