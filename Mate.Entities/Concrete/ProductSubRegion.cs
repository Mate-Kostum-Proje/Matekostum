using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class ProductSubRegion : BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
