using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicLogin.Data.Interfaces;
using BasicLogin.Models;

namespace BasicLogin.Data.Implementation
{
    public class PersonalRepository : IPersonalRepository
    {
        private readonly DataContext _dataContext;

        public PersonalRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Personal> Create(Personal personalToSave)
        {
            await _dataContext.AddAsync(personalToSave);
            await _dataContext.SaveChangesAsync();
            return personalToSave;
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
