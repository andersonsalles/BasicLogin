﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicLogin.Data.Interfaces
{
    public interface IAddressRepository
    {
        public void Create();
        public void Update();
        public void Delete();
    }
}
