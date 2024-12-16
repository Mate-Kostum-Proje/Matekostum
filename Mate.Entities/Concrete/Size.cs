using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
	public class Size : BaseEntity
	{
		public int SizeNumber { get; set; }
		public List<Product> Products { get; set; }


	}
}
