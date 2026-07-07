using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyPracticeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        //We create a model class to represent the login request payload(incoming json data)
        public class LoginRequest
        {
            public string Username { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Validate the login credentials (this is just a placeholder, implement your own logic)
            if (request.Username == "admin" && request.Password == "password")
            {
                return Ok(new { Message = "Login successful" });
            }
            else
            {
                return Unauthorized(new { Message = "Invalid username or password" });
            }
        }
    }
}
