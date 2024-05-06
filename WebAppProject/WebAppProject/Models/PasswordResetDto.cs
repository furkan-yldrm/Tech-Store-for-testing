using System.ComponentModel.DataAnnotations;

namespace WebAppProject.Models
{
    public class PasswordResetDto
    {
        [Required, EmailAddress]
        public string Email { get; set; } = "";

        [Required, MaxLength(100)]
        public string Password { get; set; } = "";

        [Required(ErrorMessage = "Şifreyi onayla")]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor!!")]
        public string ConfirmPassword { get; set; } = "";
    }
}
