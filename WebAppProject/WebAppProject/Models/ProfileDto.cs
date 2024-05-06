using System.ComponentModel.DataAnnotations;

namespace WebAppProject.Models
{
	public class ProfileDto
	{
		[Required(ErrorMessage = "Isim gerekli!!"), MaxLength(100)]
		public string FirstName { get; set; } = "";

		[Required(ErrorMessage = "Soyisim gerekli!!"), MaxLength(100)]
		public string LastName { get; set; } = "";

		[Required, EmailAddress, MaxLength(100)]
		public string Email { get; set; } = "";

		[Phone(ErrorMessage = "Format geçersiz!"), MaxLength(20)]
		public string? PhoneNumber { get; set; }

		[Required, MaxLength(200)]
		public string Address { get; set; } = "";
	}
}
