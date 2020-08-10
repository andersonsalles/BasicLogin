using System;
using AutoMapper;
using BasicLogin.Data.Interfaces;
using BasicLogin.Dtos;
using BasicLogin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Post(PersonToSaveDto person)
        {
            try
            {
                var personToSave = _mapper.Map<Person>(person.PersonDto);
                var addressToSave = _mapper.Map<Address>(person.AddressDto);
                var emailToSave = _mapper.Map<Email>(person.EmailDto);
                var phoneNumberToSave = _mapper.Map<Phone>(person.PhoneDto);
                if (person.PersonalDto != null)
                {
                    var personalToSave = _mapper.Map<Personal>(person.PersonalDto);
                    _personRepository.Create(personToSave, addressToSave, emailToSave, personalToSave);
                }
                else
                {
                    var corporationToSave = _mapper.Map<Corporation>(person.CorporationDto);
                    _personRepository.Create(personToSave, addressToSave, emailToSave, corporationToSave);
                }

                
                

               
                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest($"One or more erros on Save Person. {e.Message}");
            }
            
        }
    }
}