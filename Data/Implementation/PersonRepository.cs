using System;
using System.Threading.Tasks;
using BasicLogin.Data.Interfaces;
using BasicLogin.Models;

namespace BasicLogin.Data.Implementation
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IAddressRepository _addressRepository;
        private readonly ICorporationRepository _corporationRepository;
        private readonly IPersonalRepository _personalRepository;
        private readonly IEmailRepository _emailRepository;
        private readonly IPhoneRepository _phoneRepository;
        private readonly DataContext _context;

        public PersonRepository(IAddressRepository addressRepository, ICorporationRepository corporationRepository, 
            IPersonalRepository personalRepository, IEmailRepository emailRepository, IPhoneRepository phoneRepository,DataContext context)
        {
            _addressRepository = addressRepository;
            _corporationRepository = corporationRepository;
            _personalRepository = personalRepository;
            _emailRepository = emailRepository;
            _phoneRepository = phoneRepository;
            _context = context;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public async Task Create(Person personToSave, Address addressToSave, Email emailToSave, Phone phoneNumberToSave,
            Personal personalToSave)
        {
            await _context.Persons.AddAsync(personToSave);
            await _context.SaveChangesAsync();

            addressToSave.PersonId = personToSave.Id;
            await _addressRepository.Create(addressToSave);

            emailToSave.PersonId = personToSave.Id;
            await _emailRepository.Create(emailToSave);

            personalToSave.PersonId = personToSave.Id;
            await _personalRepository.Create(personalToSave);

            phoneNumberToSave.PersonId = personToSave.Id;
            await _phoneRepository.Create(phoneNumberToSave);
            


        }

        public async Task Create(Person personToSave, Address addressToSave, Email emailToSave, Phone phoneNumberToSave, Corporation corporationToSave)
        {
            await _context.Persons.AddAsync(personToSave);
            await _context.SaveChangesAsync();

            addressToSave.PersonId = personToSave.Id;
            await _addressRepository.Create(addressToSave);

            emailToSave.PersonId = personToSave.Id;
            await _emailRepository.Create(emailToSave);

            phoneNumberToSave.PersonId = personToSave.Id;
            await _phoneRepository.Create(phoneNumberToSave);

            corporationToSave.PersonId = personToSave.Id;
            await _corporationRepository.Create(corporationToSave);

        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
