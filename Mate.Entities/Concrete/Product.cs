using Mate.Entities.Abstract;

namespace Mate.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool? IsAdult { get; set; } //Not Sure
        public int Size { get; set; }

        //resim işi TODO
        public List<ProductCategory> ProductCategory { get; set; }
        public List<ProductRegion> ProductRegion { get; set; }
    }
}
