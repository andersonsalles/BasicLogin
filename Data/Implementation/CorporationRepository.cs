using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicLogin.Data.Interfaces;
using BasicLogin.Models;

namespace BasicLogin.Data.Implementation
{
    public class CorporationRepository : ICorporationRepository
    {
        private readonly DataContext _dataContext;

        public CorporationRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Corporation> Create(Corporation corporationToSave)
        {
            await _dataContext.AddAsync(corporationToSave);
            await _dataContext.SaveChangesAsync();
            return corporationToSave;
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
