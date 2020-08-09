using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BasicLogin.Models;

namespace BasicLogin.Dtos
{
    public class AddressDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string MainAddress { get; set; }
        [Required]
        public int StateId { get; set; }
        [Required]
        public int CityId { get; set; }
        public string Neighborhood { get; set; }
        public int PersonId { get; set; }
    }
}
