using System.ComponentModel.DataAnnotations;

namespace WebAppProject.Models
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Isim girin!!"), MaxLength(100)]
        public string FirstName { get; set; } = "";

        [Required(ErrorMessage = "Soyisim girin!!"), MaxLength(100)]
        public string LastName { get; set; } = "";

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; } = "";

        [Phone(ErrorMessage = "Yanlış format!"), MaxLength(20)]
        public string? PhoneNumber { get; set; }

        [Required, MaxLength(200)]
        public string Address { get; set; } = "";

        [Required, MaxLength(100)]
        public string Password { get; set; } = "";

        [Required(ErrorMessage = "Şifrenizi tekrar girin")]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor!")]
        public string ConfirmPassword { get; set; } = "";
    }
}
