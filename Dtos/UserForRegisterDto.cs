﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasicLogin.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 30 characters")]
        public string Password { get; set; }
    }
}
