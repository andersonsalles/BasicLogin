using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicLogin.Models;

namespace BasicLogin.Data.Interfaces
{
    public interface IEmailRepository
    {
        public Task<Email> Create(Email emailToSave);
        public void Update();
        public void Delete();
    }
}
