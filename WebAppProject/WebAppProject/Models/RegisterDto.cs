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

        [Required, Phone(ErrorMessage = "Telefon numarası 11 haneden fazla olamaz!!"), MaxLength(11)]
        [RegularExpression(@"^(05(\d{9}))$", ErrorMessage = "Girilen format yanlış!!.")]
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
