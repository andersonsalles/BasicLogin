using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicLogin.Models;

namespace BasicLogin.Data.Interfaces
{
    public interface IAddressRepository
    {
        public Task<Address> Create(Address addressToSave);
        public void Update();
        public void Delete();
    }
}
