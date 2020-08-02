using System;
using BasicLogin.Data.Interfaces;

namespace BasicLogin.Data.Implementation
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IAddressRepository _address;
        private readonly ICorporationRepository _corporation;
        private readonly DataContext _context;

        public PersonRepository(IAddressRepository address, ICorporationRepository corporation, DataContext context)
        {
            _address = address;
            _corporation = corporation;
            _context = context;
        }
        public void Create()
        {
            _address.Create();
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
