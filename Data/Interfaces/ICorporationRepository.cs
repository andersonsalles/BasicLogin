using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicLogin.Models;

namespace BasicLogin.Data.Interfaces
{
    public interface ICorporationRepository
    {
        public Task<Corporation> Create(Corporation corporationToSave);
        public void Update();
        public void Delete();
    }
}
