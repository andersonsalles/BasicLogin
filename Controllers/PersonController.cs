using System.Threading.Tasks;
using BasicLogin.Data;
using BasicLogin.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BasicLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            _personRepository.Create();
            return StatusCode(201);
        }
    }
}
