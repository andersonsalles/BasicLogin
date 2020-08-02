using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasicLogin.Models
{
    public class Email
    {
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
}
