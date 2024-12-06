using JwtBasics.Services;
using Microsoft.AspNetCore.Mvc;

namespace JwtBasics.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request.Username == "admin" && request.Password == "password")
            {
                var token = TokenService.GenerateToken(request.Username);
                return Ok(new { Token = token });
            }

            return Unauthorized("Invalid credentials");
        }

        [HttpGet("login")]
        public IActionResult Test()
        {
            return Ok("AuthController is working!");
        }
    }

    public class LoginRequest
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
