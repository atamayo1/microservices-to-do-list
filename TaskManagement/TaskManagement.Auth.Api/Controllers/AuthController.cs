// TaskManagement.Auth.Api/Controllers/AuthController.cs
using Microsoft.AspNetCore.Mvc;
using TaskManagement.Auth.Business.Services;
using TaskManagement.Auth.Domain.Entities;

namespace TaskManagement.Auth.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] UserRegistrationDto dto)
        {
            _authService.Register(dto.Username, dto.Password, dto.Email);
            return Ok();
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLoginDto dto)
        {
            var isAuthenticated = _authService.Authenticate(dto.Username, dto.Password);
            if (!isAuthenticated)
            {
                return Unauthorized();
            }
            return Ok();
        }
    }

    public class UserRegistrationDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }

    public class UserLoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
