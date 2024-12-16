using System.ComponentModel.DataAnnotations;
using Mate.Entities.Concrete;

namespace Mate.MVC.Models.VMs
{
	public class SizeVM
	{
		[DataType(DataType.Text)]
		[MaxLength(14)]
		[MinLength(8)]
		public int SizeNumber { get; set; }
		public List<Product> Products { get; set; }

	}
}
