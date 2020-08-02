using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace BasicLogin.Models
{
    public class Corporation
    {
        public int Id { get; set; }
        [Required]
        public string Cnpj { get; set; }
        public string Ie { get; set; }
        public string RazaoSocial { get; set; }
        
    }
}
