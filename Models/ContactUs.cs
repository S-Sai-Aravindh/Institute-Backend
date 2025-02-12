using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Institute_Management.Models
{
    [Table("Contactus")]
    public class ContactUs
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(3)]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(10, MinimumLength = 10)]
        public string Contact { get; set; }

        [Required, MinLength(4), MaxLength(200)]
        public string Message { get; set; }
    }
}
