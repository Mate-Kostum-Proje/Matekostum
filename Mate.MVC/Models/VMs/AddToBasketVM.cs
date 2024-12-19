using Mate.Entities.Concrete;

namespace Mate.MVC.Models.VMs
{
	public class AddToBasketVM
	{

		public int SizeNumber { get; set; }
		public List<Size> SizeOptions { get; set; }
		public int Amount { get; set; }
		public string ProductId { get; set; }

	}
}
