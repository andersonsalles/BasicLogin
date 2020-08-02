using System;
using BasicLogin.Data.Interfaces;

namespace BasicLogin.Data.Implementation
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IAddress _address;
        private readonly ICorporation _corporation;
        private readonly DataContext _context;

        public PersonRepository(IAddress address, ICorporation corporation, DataContext context)
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
