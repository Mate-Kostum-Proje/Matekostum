using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class Size : BaseEntity
    {
        public int SizeNumber { get; set; }
        public int PerSizeAmount { get; set; }
        public List<ProductSize> ProductSizes { get; set; }


    }
}
