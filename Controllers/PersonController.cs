using System.Threading.Tasks;
using AutoMapper;
using BasicLogin.Data;
using BasicLogin.Data.Dtos;
using BasicLogin.Data.Interfaces;
using BasicLogin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonController(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post(PersonDto person)
        {
            var p = _mapper.Map<Person>(person);
            _personRepository.Create();
            return StatusCode(201);
        }
    }
}
