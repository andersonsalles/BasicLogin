using System.ComponentModel.DataAnnotations;

namespace BasicLogin.Data.Dtos
{
    public class PersonDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}