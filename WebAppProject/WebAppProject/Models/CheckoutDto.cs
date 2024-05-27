using System.ComponentModel.DataAnnotations;

namespace WebAppProject.Models
{
    public class CheckoutDto
    {
        [Required(ErrorMessage = "Teslimat adresi giriniz.")]
        [MaxLength(200)]
        public string DeliveryAddress { get; set; } = "";
        public string PaymentMethod { get; set; } = "";
    }
}
