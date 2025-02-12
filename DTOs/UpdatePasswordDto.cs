using System.ComponentModel.DataAnnotations;

namespace Institute_Management.DTOs
{
    public class UpdatePasswordDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string NewPassword { get; set; }
    }
}
