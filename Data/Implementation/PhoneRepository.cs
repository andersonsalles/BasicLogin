using System;
using System.Threading.Tasks;
using BasicLogin.Data.Interfaces;
using BasicLogin.Models;

namespace BasicLogin.Data.Implementation
{
    public class PhoneRepository :IPhoneRepository
    {
        private readonly DataContext _dataContext;

        public PhoneRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Phone> Create(Phone phoneNumberToSave)
        {
            await _dataContext.AddAsync(phoneNumberToSave);
            await _dataContext.SaveChangesAsync();
            return phoneNumberToSave;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
