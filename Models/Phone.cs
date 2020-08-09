using System.ComponentModel.DataAnnotations;

namespace BasicLogin.Models
{
    public class Phone
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression("^[(]{1}\\d{2}[)]{1}\\d{5}[-]{1}\\d{4}$", ErrorMessage = "The phone format must be (99) 99999-9999")]
        public string PhoneNumber { get; set; }

        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
}