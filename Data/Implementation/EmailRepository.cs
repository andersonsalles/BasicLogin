using System;
using System.Threading.Tasks;
using BasicLogin.Data.Interfaces;
using BasicLogin.Models;

namespace BasicLogin.Data.Implementation
{
    public class EmailRepository : IEmailRepository
    {
        private readonly DataContext _dataContext;

        public EmailRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Email> Create(Email emailToSave)
        {
            await _dataContext.AddAsync(emailToSave);
            await _dataContext.SaveChangesAsync();
            return emailToSave;
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
