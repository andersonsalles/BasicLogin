using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasicLogin.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TestAuthController : ControllerBase
    {
        [HttpGet("auth")]
        public IActionResult Auth()
        {
            return Ok("This is an access authorized");
        }

        [AllowAnonymous]
        [HttpGet("anonymousTest")]
        public IActionResult AnonymousTest()
        {
            return Ok("This is an access anonymous");
        }
    }
}
