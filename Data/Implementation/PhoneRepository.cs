using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicLogin.Data.Interfaces;
using BasicLogin.Models;

namespace BasicLogin.Data.Implementation
{
    public class PhoneRepository :IPhoneRepository
    {
        public Task<Phone> Create(Phone phoneNumberToSave)
        {
            throw new NotImplementedException();
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
