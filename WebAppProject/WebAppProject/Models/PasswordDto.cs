using System.ComponentModel.DataAnnotations;

namespace WebAppProject.Models
{
	public class PasswordDto
	{
		[Required(ErrorMessage = "Mevcut şifreyi girin."), MaxLength(100)]
		public string CurrentPassword { get; set; } = "";

		[Required(ErrorMessage = "Yeni şifreyi girin"), MaxLength(100)]
		public string NewPassword { get; set; } = "";

		[Required(ErrorMessage = "Şifreyi onayla")]
		[Compare("NewPassword", ErrorMessage = "Şifreler eşleşmiyor!!")]
		public string ConfirmPassword { get; set; } = "";
	}
}
