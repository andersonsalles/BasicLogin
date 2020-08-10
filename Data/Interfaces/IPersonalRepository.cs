using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicLogin.Models;

namespace BasicLogin.Data.Interfaces
{
    public interface IPersonalRepository
    {
        public Task<Personal> Create(Personal personalToSave);
        public void Update();
        public void Delete();
    }
}
