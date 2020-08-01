using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasicLogin.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string MainsAddress { get; set; }
        [Required]
        public int StateId { get; set; }
        [Required]
        public int CityId { get; set; }
        public string Neighborhood { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
}
