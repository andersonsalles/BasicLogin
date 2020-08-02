using System;
using BasicLogin.Data.Interfaces;

namespace BasicLogin.Data.Implementation
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IAddressRepository _address;
        private readonly ICorporationRepository _corporation;
        private readonly IPersonalRepository _personalRepository;
        private readonly IEmailRepository _emailRepository;
        private readonly IPhoneRepository _phoneRepository;
        private readonly DataContext _context;

        public PersonRepository(IAddressRepository address, ICorporationRepository corporation, 
            IPersonalRepository personalRepository, IEmailRepository emailRepository, IPhoneRepository phoneRepository,DataContext context)
        {
            _address = address;
            _corporation = corporation;
            _personalRepository = personalRepository;
            _emailRepository = emailRepository;
            _phoneRepository = phoneRepository;
            _context = context;
        }
        public void Create()
        {
            _address.Create();
            _emailRepository.Create();

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
