using System.ComponentModel.DataAnnotations;

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