using System.Threading.Tasks;
using BasicLogin.Data;
using BasicLogin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS;

namespace BasicLogin.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;

        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(string username, string password)
        {
            username = username.ToLower();
            if (await _repo.UserExists(username))
                return BadRequest("Username already exists");

            var userToCreate = new User
            {
                Username = username
            };

            var createdUser = _repo.Register(userToCreate, password);
            return StatusCode(201);
        }

    }
}
