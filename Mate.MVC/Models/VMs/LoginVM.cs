using System.ComponentModel.DataAnnotations;

namespace Mate.MVC.Models.VMs
{
	public class LoginVM
	{
		[DataType(DataType.Text)]
		[Required(ErrorMessage = "Email girmek zorundadir")]
		public string Email { get; set; }

		[DataType(DataType.Password)]
		[Required(ErrorMessage = "Şifre girilmesi zorunludur")]
		public string Password { get; set; }

		public bool RememberMe { get; set; } = false;
	}
}