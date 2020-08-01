using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace BasicLogin.Models
{
    public class Personal
    {
        [Required]
        public string Cpf { get; set; }
        public string Rg { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public int GenderId { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
}
