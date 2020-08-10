using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicLogin.Models;

namespace BasicLogin.Data.Interfaces
{
    public interface IPhoneRepository
    {
        public Task<Phone> Create(Phone phoneNumberToSave);
        public void Update();
        public void Delete();
    }
}
