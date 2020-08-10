using System;
using System.Threading.Tasks;
using BasicLogin.Data.Interfaces;
using BasicLogin.Models;

namespace BasicLogin.Data.Implementation
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IAddressRepository _addressRepository;
        private readonly ICorporationRepository _corporation;
        private readonly IPersonalRepository _personalRepository;
        private readonly IEmailRepository _emailRepository;
        private readonly IPhoneRepository _phoneRepository;
        private readonly DataContext _context;

        public PersonRepository(IAddressRepository addressRepository, ICorporationRepository corporation, 
            IPersonalRepository personalRepository, IEmailRepository emailRepository, IPhoneRepository phoneRepository,DataContext context)
        {
            _addressRepository = addressRepository;
            _corporation = corporation;
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

        public void Create(Person personToSave, Address addressToSave, Email emailToSave, Phone phoneNumberToSave, Corporation corporationToSave)
        {
            _context.Persons.AddAsync(personToSave);
            _context.SaveChanges();

            addressToSave.PersonId = personToSave.Id;
            emailToSave.PersonId = personToSave.Id;
            phoneNumberToSave.PersonId = personToSave.Id;
            corporationToSave.PersonId = personToSave.Id;

            _context.Addresses.AddAsync(addressToSave);
            _context.Emails.AddAsync(emailToSave);
            _context.Phones.AddAsync(phoneNumberToSave);
            _context.Corporations.AddAsync(corporationToSave);

            _context.SaveChanges();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
